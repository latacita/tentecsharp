﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SmartHome;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room("Comedor",0);
            Room r2 = new Room("Dormitorio",1);
            Room r3 = new Room("Bano",2);
            Room r4 = new Room("Cocina", 3);
            Floor f1 = new Floor("Sotano",0);
            Floor f2 = new Floor("Planta baja",1);
            Floor f3 = new Floor("Planta alta", 2);
            HeaterCtrl h1 = new HeaterCtrl(0, 0);
            Thermometer t1 = new Thermometer(1, 0);
            HeaterCtrl h2 = new HeaterCtrl(1, 3);
            Thermometer t2 = new Thermometer(2, 1);
            WindowCtrl w1 = new WindowCtrl(2, 0);
            WindowCtrl w2 = new WindowCtrl(3, 2);
            WindowSensor ws1 = new WindowSensor(3, 2);
            WindowSensor ws2 = new WindowSensor(4, 3);
            f1.addRoom(r1);
            f1.addRoom(r2);
            f2.addRoom(r3);
            f3.addRoom(r4);
            Gateway g = new Gateway();
            g.initBaseSystem();
            g.initHeaterMng();
            g.initWindowMng();
            g.addFloor(f1);
            g.addFloor(f2);
            g.addFloor(f3);
            g.addHeaterCtrl(h1);
            g.addThermometer(t1);
            g.addHeaterCtrl(h2);
            g.addThermometer(t2);
            g.addWindowCtrl(w1);
            g.addWindowCtrl(w2);
            g.addWindowSensor(ws1);
            g.addWindowSensor(ws2);
            SimulatorGUI sim = new SimulatorGUI(g);
            GatewayGUI gatewayGUI = new GatewayGUI(g,sim);
            g.initSmartEnergyMng(gatewayGUI);
            gatewayGUI.addBaseSystem();
            gatewayGUI.addHeaterMng();
            gatewayGUI.addWindowMng();
            gatewayGUI.addSmartEnergy();
            sim.addHeaterMng();
            sim.addWindowMng();
            sim.Show();
            gatewayGUI.Show();            
            Application.Run(gatewayGUI);
            Application.Run(sim); 
        }
    }
}