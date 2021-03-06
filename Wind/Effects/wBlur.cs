﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace Wind.Effects
{
    public class wBlur : wEffect
    {
        public BlurEffect ShapeEffect = new BlurEffect();
        
        public double Radius = 1;

        public wBlur()
        {
            SetEffect();
        }

        public wBlur(double BlurRadius)
        {

            Active = true;

            Radius = BlurRadius;
            SetEffect();
        }
        
        public void SetEffect()
        {
            ShapeEffect.Radius = Radius;
        }

    }
}
