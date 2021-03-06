﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using CommandLine;

namespace Dotnet.FBit.CommandOptions
{
    /// <summary>
    /// Options for the 'generate' command
    /// </summary>
    [Verb(name: "generate", HelpText = "Generate feature bit enum file(s)")]
    public class GenerateOptions : CommonOptions
    {
        /// <summary>
        /// Given namespace for the resulting enum file
        /// </summary>
        [Option('n', "namespace", HelpText = "Namespace for geneated enum")]
        public string Namespace { get; set; }

        /// <summary>
        /// Filename for the resulting enum
        /// </summary>
        [Option('o', "outputfile", HelpText = "Filename for the resulting enum")]
        public string OutputFileName { get; set; } = "Features.cs";

        /// <summary>
        /// Force overwriting old file with new file if one already exists
        /// </summary>
        [Option('f', "force", HelpText = "Force overwriting old file with new file if one already exists")]
        public bool Force { get; set; }
    }
}
