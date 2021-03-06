﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.IO;

namespace Microsoft.Coyote.SystematicTesting
{
    /// <summary>
    /// Monitors the program being tested for code coverage.
    /// </summary>
    internal static class CodeCoverageMonitor
    {
        /// <summary>
        /// Configuration.
        /// </summary>
        private static Configuration Configuration;

        /// <summary>
        /// Monitoring process is running.
        /// </summary>
        internal static bool IsRunning;

        /// <summary>
        /// Starts the code coverage monitor.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        internal static void Start(Configuration configuration)
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Process has already started.");
            }

            Configuration = configuration;
            RunMonitorProcess(true);
            IsRunning = true;
        }

        /// <summary>
        /// Stops the code coverage monitor.
        /// </summary>
        internal static void Stop()
        {
            if (Configuration is null)
            {
                throw new InvalidOperationException("Process has not been configured.");
            }

            if (!IsRunning)
            {
                throw new InvalidOperationException("Process is not running.");
            }

            RunMonitorProcess(false);
            IsRunning = false;
        }

        private static void RunMonitorProcess(bool isStarting)
        {
            var error = string.Empty;
            var exitCode = 0;
            var outputFile = GetOutputName();
            var arguments = isStarting ? $"/start:coverage /output:{outputFile}" : "/shutdown";
            var timedOut = false;
            using (var monitorProc = new Process())
            {
                monitorProc.StartInfo.FileName = CodeCoverageInstrumentation.GetToolPath("VSPerfCmdToolPath", "VSPerfCmd");
                monitorProc.StartInfo.Arguments = arguments;
                monitorProc.StartInfo.UseShellExecute = false;
                monitorProc.StartInfo.RedirectStandardOutput = true;
                monitorProc.StartInfo.RedirectStandardError = true;
                monitorProc.Start();

                Console.WriteLine($"... {(isStarting ? "Starting" : "Shutting down")} code coverage monitor");

                int retries = 0;
                // timedOut can only become true on shutdown (non-infinite timeout value)
                do
                {
                    timedOut = !monitorProc.WaitForExit(5000);
                    if (!timedOut)
                    {
                        exitCode = monitorProc.ExitCode;
                        if (exitCode != 0)
                        {
                            error = monitorProc.StandardError.ReadToEnd();
                        }

                        break;
                    }
                    else
                    {
                        // we've been asked to stop, but it is not stopping...
                        retries++;
                        if (isStarting)
                        {
                            Console.WriteLine($"Waiting for VSPerfCmd to start. Retry {retries} of 5 ...");
                        }
                        else
                        {
                            Console.WriteLine($"Waiting for VSPerfCmd /shutdown to complete. Retry {retries} of 5 ...");
                        }
                    }
                }
                while (retries < 5);

                if (timedOut && retries == 5)
                {
                    monitorProc.Kill();
                }
            }

            if (exitCode != 0 || error.Length > 0)
            {
                if (error.Length is 0)
                {
                    error = "<no error message returned>";
                }

                Console.WriteLine($"Warning: 'VSPerfCmd {arguments}' exit code {exitCode}: {error}");
            }

            if (!isStarting)
            {
                if (timedOut)
                {
                    Console.WriteLine($"Warning: VsPerfCmd timed out on shutdown");
                }

                if (File.Exists(outputFile))
                {
                    var fileInfo = new FileInfo(outputFile);
                    Console.WriteLine($"..... Created {outputFile}");
                }
                else
                {
                    Console.WriteLine($"Warning: Code coverage output file {outputFile} was not created");
                }
            }
        }

        /// <summary>
        /// Returns the output name.
        /// </summary>
        private static string GetOutputName()
        {
            string file = Path.GetFileNameWithoutExtension(Configuration.AssemblyToBeAnalyzed);
            string directory = CodeCoverageInstrumentation.OutputDirectory;
            return $"{directory}{file}.coverage";
        }
    }
}
