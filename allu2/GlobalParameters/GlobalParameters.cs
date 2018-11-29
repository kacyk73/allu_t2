﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu2
{

    //terrain type
    public enum TerrainKind
    {
        grass = 1,
        water = 2,
        city = 3,
        road = 4
    }

    public class GlobalParameters
    {
        public int boardBoxDim = 20;
        public int boardDimX = 60;
        public int boardDimY = 40;
        
    }
}
