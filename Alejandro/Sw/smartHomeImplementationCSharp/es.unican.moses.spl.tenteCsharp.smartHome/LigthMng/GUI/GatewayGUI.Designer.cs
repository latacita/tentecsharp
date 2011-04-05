﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class GatewayGUI : IGatewayGUILigthObserver
    {
        //Atributes
        private TabPage tabPage_ligth;
        private TrackBar trackBar_ligthing;
        private Label lab_ligthing;
        private TextBox text_ligthing;
        private PictureBox pict_ligth;
        private Label label_predefinedValues = new Label();
        private ComboBox combo_predefinedValues = new ComboBox();
        private Dictionary<int, TrackBar> dictionaryTrackBarLigthingByRoom = new Dictionary<int, TrackBar>();
        private Dictionary<TrackBar, int> inverseDictionaryTrackBarLigthing = new Dictionary<TrackBar, int>();
        private Dictionary<int, Label> dictionaryLabelLigthingByRoom = new Dictionary<int, Label>();
        private Dictionary<int, TextBox> dictionaryTextLigthingByRoom = new Dictionary<int, TextBox>();
        private Dictionary<TextBox, int> inverseDictionaryTextLigthing = new Dictionary<TextBox, int>();
        private Dictionary<int, Label> dictionaryLabelPredefinedValues = new Dictionary<int, Label>();
        private Dictionary<int, ComboBox> dictionaryComboBoxPredefinedValues = new Dictionary<int, ComboBox>();
        private Dictionary<ComboBox, int> inverseDictComboBoxPredefinedValues = new Dictionary<ComboBox, int>();


        public void addLigthMng()
        {

            initLigthMng();
            addLigthByRoom(gateway.ligthwMng_getLigths());
            gateway.registerObserverLigth(this);
        }//addLigthMng

        public void initLigthMng()
        {
            //
            //TabPage
            //
            tabPage_ligth = new TabPage();
            tabPage_ligth.Text = "Ligths";
            tabPage_ligth.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_ligth);
            //
            //TrackBar
            //
            trackBar_ligthing = new TrackBar();
            trackBar_ligthing.Location = new System.Drawing.Point(width / 4, height / 2);
            trackBar_ligthing.Size = new System.Drawing.Size((width + 40) / 2, height / 16);
            trackBar_ligthing.Maximum = 100;
            trackBar_ligthing.Minimum = 0;
            tabPage_ligth.Controls.Add(trackBar_ligthing);
            trackBar_ligthing.Visible = true;
            trackBar_ligthing.Scroll += new System.EventHandler(this.trackbar_Scroll_ligthing);
            //
            //Label
            //
            lab_ligthing = new Label();
            lab_ligthing.Size = new System.Drawing.Size(180, 20);
            lab_ligthing.Text = "Select ligthing (0-100): ";
            lab_ligthing.Location = new System.Drawing.Point((width - 30) / 3, (height + 80) / 3);
            tabPage_ligth.Controls.Add(lab_ligthing);
            lab_ligthing.Visible = true;

            //
            //Label_predefinedValues
            //
            label_predefinedValues.Size = new System.Drawing.Size(180, 20);
            label_predefinedValues.Text = "Predefined values: ";
            label_predefinedValues.Location = new System.Drawing.Point((width+30) / 3, (height + 100) / 2);
            tabPage_ligth.Controls.Add(label_predefinedValues);

            //
            //ComboBox_predefinedValues
            //
            combo_predefinedValues.Location = new System.Drawing.Point((width) / 3, (height + 140) / 2);
            combo_predefinedValues.Items.Add("None"); //index 0
            combo_predefinedValues.Items.Add("TVWatching"); //index 1
            combo_predefinedValues.Items.Add("Reading"); //index 2
            combo_predefinedValues.Items.Add("Normal"); //index 3
            combo_predefinedValues.Items.Add("Ambient"); //index 4
            combo_predefinedValues.SelectedIndex = 0;
            tabPage_ligth.Controls.Add(combo_predefinedValues);
            combo_predefinedValues.SelectedIndexChanged += new EventHandler(combo_predefinedValues_SelectedIndexChanged);            
            //
            //TextTemp
            //
            text_ligthing = new TextBox();
            text_ligthing.Text = "0";
            text_ligthing.Size = new System.Drawing.Size(30, 20);
            text_ligthing.Location = new System.Drawing.Point(width / 6, height / 2);
            //textTemp.Enabled = false;
            text_ligthing.KeyDown += new KeyEventHandler(textLigthing_KeyDown);
            tabPage_ligth.Controls.Add(text_ligthing);
            text_ligthing.Visible = true;
            //
            //Image
            //
            pict_ligth = new PictureBox();
            pict_ligth.Image = System.Drawing.Image.FromFile("..\\..\\Images\\ligth.jpg"); //TEMPORAL
            pict_ligth.Location = new System.Drawing.Point((width + 45) / 3, height / 16);
            pict_ligth.Size = new System.Drawing.Size(100, 94);
            tabPage_ligth.Controls.Add(pict_ligth);
        }

        private void addLigthByRoom(List<LigthCtrl> ligths)
        {
            for (int i = 0; i < ligths.Count; i++)
            {
                int id_room = ligths[i].getIdRoom();
                int id_ligth = ligths[i].getId();
                DictionaryTabPageDevice.Add(id_ligth, new TabPage("Ligth " + id_ligth));
                DictionaryTabControlDevice[id_room].Controls.Add(DictionaryTabPageDevice[id_ligth]);
                initLigthMngByRoom(id_ligth);
            }//for

        }//addWindowByRoom

        private void initLigthMngByRoom(int id_ligth)
        {
            //
            //TrackBar
            //
            dictionaryTrackBarLigthingByRoom.Add(id_ligth, new TrackBar());
            inverseDictionaryTrackBarLigthing.Add(dictionaryTrackBarLigthingByRoom[id_ligth], id_ligth);
            dictionaryTrackBarLigthingByRoom[id_ligth].Location = new System.Drawing.Point(width / 4, (height + 50) / 3);
            dictionaryTrackBarLigthingByRoom[id_ligth].Size = new System.Drawing.Size(width / 2, height / 16);
            dictionaryTrackBarLigthingByRoom[id_ligth].Maximum = 100;
            dictionaryTrackBarLigthingByRoom[id_ligth].Minimum = 0;
            dictionaryTrackBarLigthingByRoom[id_ligth].Visible = true;
            DictionaryTabPageDevice[id_ligth].Controls.Add(dictionaryTrackBarLigthingByRoom[id_ligth]);
            dictionaryTrackBarLigthingByRoom[id_ligth].Scroll += new System.EventHandler(this.trackbarLigthingByRoom_Scroll);
            //
            //Label
            //
            dictionaryLabelLigthingByRoom.Add(id_ligth, new Label());
            dictionaryLabelLigthingByRoom[id_ligth].Size = new System.Drawing.Size(180, 20);
            dictionaryLabelLigthingByRoom[id_ligth].Text = "Select ligthing (0-100): ";
            dictionaryLabelLigthingByRoom[id_ligth].Location = new System.Drawing.Point((width - 30) / 3, (height) / 3);
            dictionaryLabelLigthingByRoom[id_ligth].Visible = true;
            DictionaryTabPageDevice[id_ligth].Controls.Add(dictionaryLabelLigthingByRoom[id_ligth]);

            //
            //Label_predefinedValues
            //
            dictionaryLabelPredefinedValues.Add(id_ligth, new Label());
            dictionaryLabelPredefinedValues[id_ligth].Size = new System.Drawing.Size(180, 20);
            dictionaryLabelPredefinedValues[id_ligth].Text = "Predefined values: ";
            dictionaryLabelPredefinedValues[id_ligth].Location = new System.Drawing.Point((width + 30) / 3, (height+20) / 2);
            DictionaryTabPageDevice[id_ligth].Controls.Add(dictionaryLabelPredefinedValues[id_ligth]);

            //
            //ComboBox_predefinedValues
            //
            dictionaryComboBoxPredefinedValues.Add(id_ligth, new ComboBox());
            inverseDictComboBoxPredefinedValues.Add(dictionaryComboBoxPredefinedValues[id_ligth], id_ligth);
            dictionaryComboBoxPredefinedValues[id_ligth].Location = new System.Drawing.Point((width) / 3, (height +70) / 2);
            dictionaryComboBoxPredefinedValues[id_ligth].Items.Add("None"); //index 0
            dictionaryComboBoxPredefinedValues[id_ligth].Items.Add("TVWatching"); //index 1
            dictionaryComboBoxPredefinedValues[id_ligth].Items.Add("Reading"); //index 2
            dictionaryComboBoxPredefinedValues[id_ligth].Items.Add("Normal"); //index 3
            dictionaryComboBoxPredefinedValues[id_ligth].Items.Add("Ambient"); //index 4
            dictionaryComboBoxPredefinedValues[id_ligth].SelectedIndex = 0;
            DictionaryTabPageDevice[id_ligth].Controls.Add(dictionaryComboBoxPredefinedValues[id_ligth]);
            dictionaryComboBoxPredefinedValues[id_ligth].SelectedIndexChanged += new EventHandler(combo_predefinedValues_SelectedIndexChangedByRoom);   
            //
            //TextAperture
            //
            dictionaryTextLigthingByRoom.Add(id_ligth, new TextBox());
            inverseDictionaryTextLigthing.Add(dictionaryTextLigthingByRoom[id_ligth], id_ligth);
            dictionaryTextLigthingByRoom[id_ligth].Text = "0";
            dictionaryTextLigthingByRoom[id_ligth].Size = new System.Drawing.Size(30, 20);
            dictionaryTextLigthingByRoom[id_ligth].Location = new System.Drawing.Point((width - 140) / 4, (height + 50) / 3);
            dictionaryTextLigthingByRoom[id_ligth].KeyDown += new KeyEventHandler(textLigthingByRoom_KeyDown);
            DictionaryTabPageDevice[id_ligth].Controls.Add(dictionaryTextLigthingByRoom[id_ligth]);
            dictionaryTextLigthingByRoom[id_ligth].Visible = true;
            //
            //Image
            //
            PictureBox pict_ligth = new PictureBox();
            pict_ligth.Image = System.Drawing.Image.FromFile("..\\..\\Images\\ligth.jpg"); //TEMPORAL
            pict_ligth.Location = new System.Drawing.Point((width + 45) / 3, height / 16);
            pict_ligth.Size = new System.Drawing.Size(100, 94);
            DictionaryTabPageDevice[id_ligth].Controls.Add(pict_ligth);
        }

       public void adjustLigthByRoom(int id_ligth, int ligthing)
        {
            dictionaryTrackBarLigthingByRoom[id_ligth].Value = ligthing;
            dictionaryTextLigthingByRoom[id_ligth].Text = ligthing.ToString();
            

        }//adjustLigthByRoom
        public void adjustAllLigth(int ligthing)
        {
            text_ligthing.Text = ligthing.ToString();
            trackBar_ligthing.Value = ligthing;
            List<LigthCtrl> l = gateway.ligthwMng_getLigths();
            for (int i = 0; i < l.Count; i++)
            {
              dictionaryComboBoxPredefinedValues[l[i].getId()].SelectedIndex = combo_predefinedValues.SelectedIndex;
            }//for           
            
        }//adjustAllLigth 
    }
}