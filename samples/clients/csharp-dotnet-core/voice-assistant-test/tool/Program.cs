﻿// <copyright file="Program.cs" company="Microsoft Corporation">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VoiceAssistantTest
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Encapsulates the application's entry point.
    /// </summary>
    internal class Program
    {
        private static int Main(string[] args)
        {
            return MainMethod(args.Length == 0 ? null : args[0]).GetAwaiter().GetResult();
        }

        private static async Task<int> MainMethod(string configFile)
        {
            try
            {
                await MainService.StartUp(configFile).ConfigureAwait(false);
                return 0;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.TraceError(e.ToString());
                return 1;
            }
        }
    }
}