﻿using ASCOM.Standard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConformU
{
    public class FilterWheelFacade : FacadeBaseClass, IFilterWheelV2
    {
        // Create the test device in the facade base class
        public FilterWheelFacade(Settings conformSettings, ConformLogger logger) : base(conformSettings, logger) { }

        #region Interface implementation

        public int[] FocusOffsets => driver.FocusOffsets;

        public string[] Names => driver.driver.Names;

        public short Position { get => driver.Position; set => driver.Position = value; }

        #endregion

    }
}
