using System;
using System.Collections.Generic;
using PUBGApi.Models;

namespace PUBGApi.Models
{
    [Serializable]
    public class Telemetry
    {
        public TelemetryBases.MatchDefinition Definition = null;
        public TelemetryBases.MatchStart Start = null;
        public TelemetryBases.MatchEnd End = null;
        public List<TelemetryBases.PlayerLogin> PlayerLogins = new List<TelemetryBases.PlayerLogin>();
        public List<TelemetryBases.ItemEquip> ItemsEquiped = new List<TelemetryBases.ItemEquip>();
        public List<TelemetryBases.PlayerCreate> PlayersCreated = new List<TelemetryBases.PlayerCreate>();
        public List<TelemetryBases.PlayerPosittion> PlayersPossitions = new List<TelemetryBases.PlayerPosittion>();
        public List<TelemetryBases.VaultStart> VaultsStart = new List<TelemetryBases.VaultStart>();
        public List<TelemetryBases.PlayerAttack> PlayersAttacks = new List<TelemetryBases.PlayerAttack>();
        public List<TelemetryBases.ItemUnequip> ItemsUnequiped = new List<TelemetryBases.ItemUnequip>();
        public List<TelemetryBases.PlayerLogout> PlayersLogouts = new List<TelemetryBases.PlayerLogout>();
        public List<TelemetryBases.WeaponFireCount> WeaponFireCounts = new List<TelemetryBases.WeaponFireCount>();
        public List<TelemetryBases.VehicleRide> VehicleRides = new List<TelemetryBases.VehicleRide>();
        public List<TelemetryBases.ItemPickup> ItemsPickups = new List<TelemetryBases.ItemPickup>();
        public List<TelemetryBases.GameStatePeriod> GamestatePeriodic = new List<TelemetryBases.GameStatePeriod>();
        public List<TelemetryBases.VehicleLeave> VehicleLeaves = new List<TelemetryBases.VehicleLeave>();
        public List<TelemetryBases.ParachuteLanding> ParachuteLandings = new List<TelemetryBases.ParachuteLanding>();
        public List<TelemetryBases.ItemAttach> ItemsAttach = new List<TelemetryBases.ItemAttach>();
        public List<TelemetryBases.ItemDrop> ItemsDrop = new List<TelemetryBases.ItemDrop>();
        public List<TelemetryBases.ObjectDestroy> ObjectsDestroy = new List<TelemetryBases.ObjectDestroy>();
        public List<TelemetryBases.ItemDetach> ItemsDetach = new List<TelemetryBases.ItemDetach>();
        public List<TelemetryBases.PlayerTakeDamage> PlayersTakeDamage = new List<TelemetryBases.PlayerTakeDamage>();
        public List<TelemetryBases.PlayerMakeGroggy> PlayersMakeGroggy = new List<TelemetryBases.PlayerMakeGroggy>();
        public List<TelemetryBases.PlayerKill> PlayersKill = new List<TelemetryBases.PlayerKill>();
        public List<TelemetryBases.ItemPickupFromLootBox> ItemPickupFromLootbox = new List<TelemetryBases.ItemPickupFromLootBox>();
        public List<TelemetryBases.ItemUse> ItemsUse = new List<TelemetryBases.ItemUse>();
        public List<TelemetryBases.Heal> Heals = new List<TelemetryBases.Heal>();
        public List<TelemetryBases.ArmorDestroy> ArmorsDestoy = new List<TelemetryBases.ArmorDestroy>();
        public List<TelemetryBases.PlayerRevive> PlayersRevives = new List<TelemetryBases.PlayerRevive>();
        public List<TelemetryBases.CarePackageSpawn> CarePackageSpawns = new List<TelemetryBases.CarePackageSpawn>();
        public List<TelemetryBases.SwimStart> SwimStarts = new List<TelemetryBases.SwimStart>();
        public List<TelemetryBases.SwimEnd> SwimEnds = new List<TelemetryBases.SwimEnd>();
        public List<TelemetryBases.CarePackageLand> CarePackageLands = new List<TelemetryBases.CarePackageLand>();
        public List<TelemetryBases.RedZoneEnded> redZoneEndeds = new List<TelemetryBases.RedZoneEnded>();
        public List<TelemetryBases.WheelDestroy> WheelsDestoy = new List<TelemetryBases.WheelDestroy>();

    }
   
}
