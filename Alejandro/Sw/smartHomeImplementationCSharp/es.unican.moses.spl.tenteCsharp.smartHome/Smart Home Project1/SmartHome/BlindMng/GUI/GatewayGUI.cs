﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class GatewayGUI
    {

        /// <summary>
        /// Method to control scroll trackbar event
        /// </summary>
        /// <param name="sender">Autogenerated</param>
        /// <param name="e">Autogenerated</param>
        private void trackbar_Scroll_apertureBlind(object sender, EventArgs e)
        {
            gateway.blindMng_allAdjustBlinds(trackBar_apertureBlind.Value);

        }// trackbar_Scroll_apertureBlind

        /// <summary>
        /// Method to control textBox enter key event
        /// </summary>
        /// <param name="sender">Autogenerated</param>
        /// <param name="e">Autogenerated</param>
        private void textApertureBlind_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //Enter Key
            { 
                try
                {
                    int aperture = Convert.ToInt32(text_apertureBlind.Text);
                    gateway.blindMng_allAdjustBlinds(aperture);

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct aperture value(integer between 0 and 100 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }// if            
        }// textApertureBlind_KeyDown

        /// <summary>
        ///  Method to control textBox by room enter key event
        /// </summary>
        /// <param name="sender">Autogenerated</param>
        /// <param name="e">Autogenerated</param>
        private void textApertureBlindByRoom_KeyDown(Object sender, KeyEventArgs e)
        {
            int id_blind = inverseDictionaryTextApertureBlind[(TextBox)sender];
            if (e.KeyValue == 13) //Enter Key
            {
                try
                {
                    int aperture = Convert.ToInt32(dictionaryTextApertureBlindByRoom[id_blind].Text);
                    gateway.blindMng_adjustBlind(id_blind, aperture);
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct aperture value(integer between 0 and 100 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }// if            
        }// textApertureBlindByRoom_KeyDown

        /// <summary>
        /// Method to control scroll trackbar by room event
        /// </summary>
        /// <param name="sender">Autogenerated</param>
        /// <param name="e">Autogenerated</param>
        private void trackbarApertureBlindByRoom_Scroll(object sender, EventArgs e)
        {
            int id_blind = inverseDictionaryTrackBarApertureBlind[(TrackBar)sender];
            gateway.blindMng_adjustBlind(id_blind, dictionaryTrackBarApertureBlindByRoom[id_blind].Value);
        }// trackbarApertureBlindByRoom_Scroll

    }// GatewayGUI
}// SmartHome
