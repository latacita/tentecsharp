﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Thermometer : Sensor
    {
        protected double outsideTemp = 0;
        // Standard average temperature in earth surface
        protected const double DEFAULT_TEMP = 25.0;

        public Thermometer(int id, int id_heater)
            : base(id, id_heater)
        {
            this.outsideTemp = DEFAULT_TEMP;
            
        }// HeaterCtrl(int, int)
                
        //This method is called each time the temperature changes
        public void setOutsideTemp(double outsideTemp)
        {
            this.outsideTemp = outsideTemp;
        }//setOutsideTemp

        public double getOutsideTemp()
        {
            return outsideTemp;
        }//getOutsideTemp

        //This method is called each time the temperature changes
        public override void setValue(double temp)
        {
            this.deviceValue = temp;
        }// setValue

        public override double getValue()
        {
            return deviceValue;
        }// getValue        
    }// Thermometer
}// SmartHome