﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Microsoft.Coyote.Specifications;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Coyote.SystematicTesting.Tests.Tasks
{
    public class TaskRunConfigureAwaitTrueTests : BaseSystematicTest
    {
        public TaskRunConfigureAwaitTrueTests(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelTask()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(() =>
                {
                    entry.Value = 5;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelTaskFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(() =>
                {
                    entry.Value = 3;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelSynchronousTask()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.CompletedTask;
                    entry.Value = 5;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelSynchronousTaskFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.CompletedTask;
                    entry.Value = 3;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelAsynchronousTask()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.Delay(1).ConfigureAwait(true);
                    entry.Value = 5;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelAsynchronousTaskFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.Delay(1).ConfigureAwait(true);
                    entry.Value = 3;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunNestedParallelSynchronousTask()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.Run(async () =>
                    {
                        await Task.CompletedTask;
                        entry.Value = 3;
                    }).ConfigureAwait(true);

                    entry.Value = 5;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestAwaitNestedParallelSynchronousTaskFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.Run(async () =>
                    {
                        await Task.CompletedTask;
                        entry.Value = 5;
                    }).ConfigureAwait(true);

                    entry.Value = 3;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestAwaitNestedParallelAsynchronousTask()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.Run(async () =>
                    {
                        await Task.Delay(1).ConfigureAwait(true);
                        entry.Value = 3;
                    }).ConfigureAwait(true);

                    entry.Value = 5;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestAwaitNestedParallelAsynchronousTaskFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                await Task.Run(async () =>
                {
                    await Task.Run(async () =>
                    {
                        await Task.Delay(1).ConfigureAwait(true);
                        entry.Value = 5;
                    }).ConfigureAwait(true);

                    entry.Value = 3;
                }).ConfigureAwait(true);

                AssertSharedEntryValue(entry, 5);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelTaskWithResult()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(() =>
                {
                    entry.Value = 5;
                    return entry.Value;
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelTaskWithResultFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(() =>
                {
                    entry.Value = 3;
                    return entry.Value;
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelSynchronousTaskWithResult()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    await Task.CompletedTask;
                    entry.Value = 5;
                    return entry.Value;
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelSynchronousTaskWithResultFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    await Task.CompletedTask;
                    entry.Value = 3;
                    return entry.Value;
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelAsynchronousTaskWithResult()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    await Task.Delay(1).ConfigureAwait(true);
                    entry.Value = 5;
                    return entry.Value;
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunParallelAsynchronousTaskWithResultFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    await Task.Delay(1).ConfigureAwait(true);
                    entry.Value = 3;
                    return entry.Value;
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunNestedParallelSynchronousTaskWithResult()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    return await Task.Run(async () =>
                    {
                        await Task.CompletedTask;
                        entry.Value = 5;
                        return entry.Value;
                    }).ConfigureAwait(true);
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunNestedParallelSynchronousTaskWithResultFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    return await Task.Run(async () =>
                    {
                        await Task.CompletedTask;
                        entry.Value = 3;
                        return entry.Value;
                    }).ConfigureAwait(true);
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }

        [Fact(Timeout = 5000)]
        public void TestRunNestedParallelAsynchronousTaskWithResult()
        {
            this.Test(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    return await Task.Run(async () =>
                    {
                        await Task.Delay(1).ConfigureAwait(true);
                        entry.Value = 5;
                        return entry.Value;
                    }).ConfigureAwait(true);
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200));
        }

        [Fact(Timeout = 5000)]
        public void TestRunNestedParallelAsynchronousTaskWithResultFailure()
        {
            this.TestWithError(async () =>
            {
                SharedEntry entry = new SharedEntry();
                int value = await Task.Run(async () =>
                {
                    return await Task.Run(async () =>
                    {
                        await Task.Delay(1).ConfigureAwait(true);
                        entry.Value = 3;
                        return entry.Value;
                    }).ConfigureAwait(true);
                }).ConfigureAwait(true);

                Specification.Assert(value == 5, "Value is {0} instead of 5.", value);
            },
            configuration: GetConfiguration().WithTestingIterations(200),
            expectedError: "Value is 3 instead of 5.",
            replay: true);
        }
    }
}
