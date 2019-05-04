﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing.Processors.Filters
{
    /// <summary>
    /// Converts the colors of the image recreating Achromatomaly (Color desensitivity) color blindness.
    /// </summary>
    public class AchromatomalyProcessor : FilterProcessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AchromatomalyProcessor"/> class.
        /// </summary>
        public AchromatomalyProcessor()
            : base(KnownFilterMatrices.AchromatomalyFilter)
        {
        }
    }
}