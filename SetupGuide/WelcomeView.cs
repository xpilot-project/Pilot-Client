﻿/*
 * xPilot: X-Plane pilot client for VATSIM
 * Copyright (C) 2019-2020 Justin Shannon
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see http://www.gnu.org/licenses/.
*/
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Vatsim.Xpilot.Config;

namespace Vatsim.Xpilot
{
    public partial class WelcomeView : SetupScreen, ISetupScreen
    {
        public WelcomeView(ISetup host, IAppConfig config) : base(host, config)
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("X-Plane").Any())
            {
                MessageBox.Show("You must close X-Plane before continuing with the setup.");
                return;
            }

            int instancesFound = 0;
            string usablePath = "";
            var installFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "x-plane_install_11.txt");
            if (File.Exists(installFile))
            {
                using (StreamReader sr = File.OpenText(installFile))
                {
                    string xpPath = string.Empty;
                    while ((xpPath = sr.ReadLine()) != null)
                    {
                        string p = Path.Combine(xpPath, "Resources");
                        if (Directory.Exists(p))
                        {
                            DirectoryInfo di = new DirectoryInfo(p);
                            if (di.EnumerateDirectories().AsParallel().SelectMany(a => a.EnumerateFiles("*.*", SearchOption.AllDirectories)).Count() > 0)
                            {
                                usablePath = xpPath;
                                ++instancesFound;
                            }
                        }
                    }
                }
            }
            if (instancesFound == 1)
            {
                // check for conflicting plugins (XSwiftBus, XSB)
                string pluginPath = Path.Combine(usablePath, @"Resources\plugins");
                string[] dirs = Directory.GetDirectories(pluginPath);
                foreach (var dir in dirs)
                {
                    if (Path.GetFileName(dir).ToLower() == "xsquawkbox")
                    {
                        Host.XSquawkBox = true;
                    }
                    if (Path.GetFileName(dir).ToLower() == "xswiftbus")
                    {
                        Host.XSwiftBus = true;
                    }
                }

                Host.XplanePath = usablePath;

                if (Host.XSquawkBox || Host.XSwiftBus)
                {
                    Host.SwitchScreen("ConflictingPlugins");
                }
                else
                {
                    Host.SwitchScreen("CslConfiguration");
                }
            }
            else
            {
                Host.SwitchScreen("XplanePath");
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Host.ManualSetup();
        }
    }
}
