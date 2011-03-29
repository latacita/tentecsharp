﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    partial class GatewayGUI
    {
        private void buttonSwitch_Click_smartEnergy(object sender, EventArgs e)
        {
            if (buttonSmartEnergy.Text.Equals("OFF"))
            {
                buttonSmartEnergy.Text = "ON";
                buttonSmartEnergy.BackColor = System.Drawing.Color.Green;
                gateway.switchOnSmartEnergyMng();
                
            }// if
            else
            {
                buttonSmartEnergy.Text = "OFF";
                buttonSmartEnergy.BackColor = System.Drawing.Color.Red;
                gateway.switchOffSmartEnergyMng();

            }// else
            //SimulatorGUI
            refreshSimulator();

        }// buttonSwitch_Click
    }
}