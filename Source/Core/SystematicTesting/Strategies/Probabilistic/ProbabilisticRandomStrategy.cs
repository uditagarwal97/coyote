﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Coyote.SystematicTesting.Strategies
{
    /// <summary>
    /// A randomized scheduling strategy with increased probability
    /// to remain in the same scheduling choice.
    /// </summary>
    internal sealed class ProbabilisticRandomStrategy : RandomStrategy
    {
        /// <summary>
        /// Number of coin flips.
        /// </summary>
        private readonly int NumberOfCoinFlips;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProbabilisticRandomStrategy"/> class.
        /// </summary>
        internal ProbabilisticRandomStrategy(int maxSteps, int numberOfCoinFlips, IRandomValueGenerator random)
            : base(maxSteps, random)
        {
            this.NumberOfCoinFlips = numberOfCoinFlips;
        }

        /// <inheritdoc/>
        internal override bool GetNextOperation(IEnumerable<AsyncOperation> ops, AsyncOperation current,
            bool isYielding, out AsyncOperation next)
        {
            var enabledOps = ops.Where(op => op.Status is AsyncOperationStatus.Enabled).ToList();
            if (enabledOps.Count is 0)
            {
                next = null;
                return false;
            }

            this.ScheduledSteps++;

            if (enabledOps.Count > 1)
            {
                if (!this.ShouldCurrentMachineChange() && current.Status is AsyncOperationStatus.Enabled)
                {
                    next = current;
                    return true;
                }
            }

            int idx = this.RandomValueGenerator.Next(enabledOps.Count);
            next = enabledOps[idx];

            return true;
        }

        /// <inheritdoc/>
        internal override string GetDescription() =>
            $"probabilistic[seed '{this.RandomValueGenerator.Seed}', coin flips '{this.NumberOfCoinFlips}']";

        /// <summary>
        /// Flip the coin a specified number of times.
        /// </summary>
        private bool ShouldCurrentMachineChange()
        {
            for (int idx = 0; idx < this.NumberOfCoinFlips; idx++)
            {
                if (this.RandomValueGenerator.Next(2) is 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
