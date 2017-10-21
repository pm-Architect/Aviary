﻿using AForge.Imaging.Filters;
using Macaw.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macaw.Compositing
{
    public class mDifferenceThreshold
    {

        ThresholdedDifference Effect = new ThresholdedDifference();

        public Bitmap BitmapOver = null;
        public Bitmap BitmapUnder = null;
        public Bitmap ModifiedBitmap = null;

        int Threshold = 50;

        public mDifferenceThreshold(Bitmap UnderlayBitmap, Bitmap OverlayBitmap, int ThresholdValue)
        {

            Threshold = ThresholdValue;

            BitmapUnder = new mSetFormat(UnderlayBitmap, 2).ModifiedBitmap;
            BitmapOver = new mSetFormat(OverlayBitmap,2).ModifiedBitmap;

            ModifiedBitmap = UnderlayBitmap;

            Effect = new ThresholdedDifference(Threshold);
            
            Effect.OverlayImage = BitmapOver;

            ModifiedBitmap = Effect.Apply(BitmapUnder);
        }

    }
}