using Microsoft.VisualStudio.Threading;
using Server.Context;
using Server.Events;
using Server.Log;
using Server.Settings.Structures;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Upnp
{
    public static class LmpPortMapper
    {
        private static readonly int LifetimeInSeconds = (int)TimeSpan.FromMinutes(5).TotalSeconds;

        /// <summary>
        /// Opens the port set in the settings using UPnP. With a lifetime of <see cref="LifetimeInSeconds"/> seconds
        /// </summary>
        [DebuggerHidden]
        public static async Task OpenLmpPort(bool verbose = true)
        {
            return;
            /*if (ConnectionSettings.SettingsStore.Upnp)
            {
                try
                {
                    var device = await Device.GetValueAsync();
                    await device.CreatePortMapAsync(LmpPortMapping);
                    if (verbose) LunaLog.Debug($"UPnP active. Port: {ConnectionSettings.SettingsStore.Port} {LmpPortMapping.Protocol} opened!");
                }
                catch (Exception)
                {
                    // ignored
                }
            }*/
        }

        /// <summary>
        /// Opens the website port set in the settings using UPnP. With a lifetime of <see cref="LifetimeInSeconds"/> seconds
        /// </summary>
        [DebuggerHidden]
        public static async Task OpenWebPort(bool verbose = true)
        {
            return;
            /*if (ConnectionSettings.SettingsStore.Upnp && WebsiteSettings.SettingsStore.EnableWebsite)
            {
                try
                {
                    var device = await Device.GetValueAsync();
                    await device.CreatePortMapAsync(LmpWebPortMapping);
                    if (verbose) LunaLog.Debug($"UPnP + Website active. Port: {WebsiteSettings.SettingsStore.Port} {LmpWebPortMapping.Protocol} opened!");
                }
                catch (Exception)
                {
                    // ignored
                }
            }*/
        }

        /// <summary>
        /// Refresh the UPnP port every 1 minute
        /// </summary>
        public static async void RefreshUpnpPort()
        {
            return;
            /*if (ConnectionSettings.SettingsStore.Upnp)
            {
                while (ServerContext.ServerRunning)
                {
                    await OpenLmpPort(false);
                    await OpenWebPort(false);
                    await Task.Delay((int)TimeSpan.FromSeconds(60).TotalMilliseconds);
                }
            }*/
        }
    }
}
