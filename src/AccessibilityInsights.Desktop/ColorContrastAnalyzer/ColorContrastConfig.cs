﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AccessibilityInsights.Desktop.ColorContrastAnalyzer
{
    public static class ColorContrastConfig
    {
        /**
         * The number of Color transitions we expect to make us believe a "Row" of Pixels
         * contains Text.
         */
        public static readonly int MinNumberColorTransitions = 10;

        /**
         * We will inevitably find other color combinations in a row. To be highly confident
         * we have text, we expect the most likely color combination to be at least this dominant.
         * Type: Double between 0 and 1.
         */
        public static readonly double TextColorPairDominanceValue = .2;

        /**
         * We're going to binary search sample rows. Once two samples are this 
         * far apart we should not sample between them as finding text is highly unlikely.
         * A good value for this is the smallest reasonable font size for the DPI of the screen.
         * 
         * Note: Making this number too low will have dramatic performance impacts when a HIGH
         * confidence result is NOT found. EX: at 0, you would end up scanning the entire image.
         */
        public static readonly int MinSpaceBetweenSamples = 12;
    }
}
