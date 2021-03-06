﻿// NotificationsSettings.cs in bukkitgui2/bukkitgui2
// Created 2014/06/21
// 
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file,
// you can obtain one at http://mozilla.org/MPL/2.0/.
// 
// ©Bertware, visit http://bertware.net

using System;
using MetroFramework.Controls;

namespace Net.Bertware.Bukkitgui2.AddOn.Notifications
{
	public partial class NotificationSettings : MetroUserControl
	{
		public NotificationSettings()
		{
			InitializeComponent();
			chkEnable.Link(Notifications.CfgIdent, "enabled", false);
			chkAlways.Link(Notifications.CfgIdent, "always", false);
			chkOnStatusChange.Link(Notifications.CfgIdent, "status", false);
			chkOnStatusChange.Link(Notifications.CfgIdent, "status", false);
			chkOnPlayerJoin.Link(Notifications.CfgIdent, "join", false);
			chkOnPlayerLeave.Link(Notifications.CfgIdent, "leave", false);
			chkOnPlayerKick.Link(Notifications.CfgIdent, "kick", false);
			chkOnPlayerBan.Link(Notifications.CfgIdent, "ban", false);

			chkSoundOnError.Link(Notifications.CfgIdent, "sound_error", false);
			chkSoundOnWarning.Link(Notifications.CfgIdent, "sound_warn", false);
			chkSoundOnJoin.Link(Notifications.CfgIdent, "sound_join", false);
			chkSoundOnLeave.Link(Notifications.CfgIdent, "sound_leave", false);
		}

		private void chkEnable_CheckedChanged(object sender, EventArgs e)
		{
			gbBalloons.Enabled = chkEnable.Checked;
			//gbSound.Enabled = chkEnable.Checked;
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			IAddon notifications = AddonManager.GetAddon("Notifications");
			notifications.Dispose();
			notifications.Initialize();
		}
	}
}