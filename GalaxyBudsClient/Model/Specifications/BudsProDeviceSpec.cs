using System;
using System.Collections.Generic;
using GalaxyBudsClient.Interop.TrayIcon;
using GalaxyBudsClient.Model.Constants;
using GalaxyBudsClient.Model.Touchpad;

namespace GalaxyBudsClient.Model.Specifications
{
    public class BudsProDeviceSpec : IDeviceSpec
    {
        public Dictionary<IDeviceSpec.Feature, FeatureRule?> Rules =>
            new Dictionary<IDeviceSpec.Feature, FeatureRule?>()
            {
                { IDeviceSpec.Feature.SeamlessConnection, null },
                { IDeviceSpec.Feature.StereoPan, new FeatureRule(5, "R190XXU0AUA5") },
                { IDeviceSpec.Feature.DoubleTapVolume, new FeatureRule(7, "R190XXU0AUD1" /* TODO */) },
                { IDeviceSpec.Feature.FirmwareUpdates, null },
                { IDeviceSpec.Feature.DetectConversations, null },
                { IDeviceSpec.Feature.NoiseControl, null },
                { IDeviceSpec.Feature.GamingMode, null },
                { IDeviceSpec.Feature.CaseBattery, null },
                { IDeviceSpec.Feature.FragmentedMessages, null },
                { IDeviceSpec.Feature.SpatialSensor, null },
                { IDeviceSpec.Feature.BixbyWakeup, null },
            };
        
        public Models Device => Models.BudsPro;
        public string DeviceBaseName => "Galaxy Buds Pro (";
        public ITouchOption TouchMap => new BudsProTouchOption();
        public Guid ServiceUuid => Uuids.BudsPro;

        public IReadOnlyCollection<ItemType> TrayShortcuts => Array.AsReadOnly(
            new[] {
                ItemType.ToggleNoiseControl,
                ItemType.ToggleEqualizer,
                ItemType.LockTouchpad
            }
        );
    }
}