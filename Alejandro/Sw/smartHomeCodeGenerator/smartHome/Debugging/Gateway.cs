﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartHome;

namespace MyFirstHome
{
    partial class MyFirstHome_Gateway:Gateway
    {
        public MyFirstHome_Gateway()
            : base() { }
        // Class methods
        public override void heaterAdjustTemperature(int id, double temperature)
        {
			this.heaterMng_HeaterAdjustTemperature(id, temperature);
        }
    }
}