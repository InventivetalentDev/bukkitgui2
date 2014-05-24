﻿// QuickButtons.cs in bukkitgui2/bukkitgui2
// Created 2014/01/17
// Last edited at 2014/05/24 12:16
// ©Bertware, visit http://bertware.net

using System;
using System.Windows.Forms;
using Net.Bertware.Bukkitgui2.AddOn;
using Net.Bertware.Bukkitgui2.AddOn.Starter;
using Net.Bertware.Bukkitgui2.Core;
using Net.Bertware.Bukkitgui2.MinecraftInterop.ProcessHandler;
using Net.Bertware.Bukkitgui2.UI;

namespace Net.Bertware.Bukkitgui2.Controls.QuickButtons
{
	public partial class QuickButtons : UserControl
	{
		public QuickButtons()
		{
			InitializeComponent();
			ProcessHandler.ServerStarting += HandleServerStarting;
			ProcessHandler.ServerStarted += HandleServerStarted;
			ProcessHandler.ServerStopped += HandleServerStopped;
			ProcessHandler.ServerStopping += HandleServerStopping;
		}

		private void HandleServerStarting()
		{
			//suport for calls from other threads
			if (InvokeRequired)
			{
				Invoke((MethodInvoker) (HandleServerStarting));
			}
			else
			{
				btnStartStop.Enabled = false;
				btnStartStop.Text = Locale.Tr("Starting...");
			}
		}

		private void HandleServerStarted()
		{
			//suport for calls from other threads
			if (InvokeRequired)
			{
				Invoke((MethodInvoker) (HandleServerStarted));
			}
			else
			{
				btnStartStop.Enabled = true;
				btnStartStop.Text = Locale.Tr("Stop");
			}
		}

		private void HandleServerStopping()
		{
			//suport for calls from other threads
			if (InvokeRequired)
			{
				Invoke((MethodInvoker) (HandleServerStopping));
			}
			else
			{
				btnStartStop.Enabled = false;
				btnStartStop.Text = Locale.Tr("Stopping...");
			}
		}

		private void HandleServerStopped()
		{
			//suport for calls from other threads
			if (InvokeRequired)
			{
				Invoke((MethodInvoker) (HandleServerStopped));
			}
			else
			{
				btnStartStop.Enabled = true;
				btnStartStop.Text = Locale.Tr("Start");
			}
		}

		private void BtnStartStopClick(object sender, EventArgs e)
		{
			//suport for calls from other threads
			if (InvokeRequired)
			{
				Invoke((MethodInvoker) (() => BtnStartStopClick(sender, e)));
			}
			else
			{
				if (ProcessHandler.IsRunning)
				{
					ProcessHandler.StopServer();
				}
				else
				{
					if (!(ParentForm is MainForm))
					{
						return; //check if the parent form is a mainform
					}
					Starter starter = (Starter) AddonManager.GetRequiredAddon(RequiredAddon.Starter);
					// Get the starter addon
					starter.LaunchServerFromTab(); // Launch with tab settings
				}
			}
		}
	}
}