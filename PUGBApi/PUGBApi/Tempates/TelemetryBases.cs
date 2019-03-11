using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGApi.Tempates
{

     [Serializable] 
 public class TelemetryBases
    {

         [Serializable] 
 public class MatchDefinition
        {
            public string MatchId = string.Empty;
            public string PingQuality = string.Empty;
            public string SeasonState = string.Empty;
            public DateStamp TimeStamp;
        }
         [Serializable] 
 public class PlayerLogin
        {
            public string accountId = string.Empty;
            public Common common = null;
            public DateStamp TimeStamp;
        }
         [Serializable] 
 public class ItemEquip
        {
            public Character character;
            public Item item;
            public Common common;
            public DateStamp TimeStamp;
        }
         [Serializable] 
 public class PlayerCreate
        {
            public Character character = null;
            public Common common = null;
            public DateStamp TimeStamp;
        }
         [Serializable] 
 public class PlayerPosittion
        {
            public Character character = null;
            public Vehicle vehicle = null;
            public int elapsedTime = 0;
            public int numAlivePlayers = 0;
            public Common common;
            public DateStamp TimeStamp;
        }
         [Serializable] 
 public class VaultStart
        {
            public Character character = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class PlayerAttack
        {
            public int attackId = 0;
            public int fireWeaponStackCount = 0;
            public Character attacker = null;
            public string attackType = string.Empty;
            public Item weapon = null;
            public Vehicle vehicle = null;
            public Common common = null;
            public DateStamp TimeStack = null;
        }
         [Serializable] 
 public class ItemUnequip
        {
            public Character character = null;
            public Item item = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class PlayerLogout
        {
            public string accountId = string.Empty;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class WeaponFireCount
        {
            public Character character = null;
            public string weaponId = string.Empty;
            public int fireCount = 0;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class VehicleRide
        {
            public Character character = null;
            public Vehicle vehicle = null;
            public int seatIndex = 0;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ItemPickup
        {
            public Character character = null;
            public Item item = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class MatchStart
        {
            public string mapName = string.Empty;
            public string weatherId = string.Empty;
            public List<Character> characters = new List<Character>();
            public string cameraViewBehaviour = string.Empty;
            public int teamSize = 0;
            public bool isCustomGame = false;
            public bool isEventMode = false;
            public string blueZoneCustomOptions = string.Empty;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class GameStatePeriod
        {
            public Gamestate gameState = null;
            public Common common = null;
            public DateStamp TimeStamp = null;

        }
         [Serializable] 
 public class VehicleLeave
        {
            public Character character = null;
            public Vehicle vehicle = null;
            public float rideDistance = 0f;
            public int seatIndex = 0;
            public float maxSpeed = 0f;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ParachuteLanding
        {
            public Character character = null;
            public float distance = 0f;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ItemAttach
        {
            public Character character = null;
            public Item parrentItem = null;
            public Item childItem = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ItemDrop
        {
            public Character character = null;
            public Item item = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ObjectDestroy
        {
            public Character character = null;
            public string objectType = string.Empty;
            public Location objectLocation = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ItemDetach
        {
            public Character character = null;
            public Item parrentItem = null;
            public Item childItem = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class PlayerTakeDamage
        {
            public int attackId = 0;
            public Character attacker = null;
            public Character victim = null;
            public string damageTypeCategory = string.Empty;
            public string damageReason = string.Empty;
            public float damage = 0f;
            public string damageCauserName = string.Empty;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class PlayerMakeGroggy
        {
            public int attackId = 0;
            public Character attacker = null;
            public Character victim = null;
            public string damageReason = string.Empty;
            public string damageTypeCategory = string.Empty;
            public string damageCauserName = string.Empty;
            public List<string> damageCauserAdditionalInfo = new List<string>();
            public float distance = 0f;
            public bool isAttackerInVehicle = false;
            public int dBNOId = 0;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class PlayerKill
        {
            public int attackId = 0;
            public Character killer = null;
            public Character victim = null;
            public Character assistant = null;
            public int dBNOId = 0;
            public string damageTypeCategory = string.Empty;
            public string damageCauserName = string.Empty;
            public List<string> damageCauserAdditionalInfo = new List<string>();
            public string damageReason = string.Empty;
            public float distance = 0f;
            public VictimGameResult victimGameResult;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ItemPickupFromLootBox
        {
            public Character character = null;
            public Item item = null;
            public int ownerTeamId = 0;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ItemUse
        {
            public Character character = null;
            public Item item = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class Heal
        {
            public Character character = null;
            public Item item = null;
            public float healAmount = 0f;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class ArmorDestroy
        {
            public int attackId = 0;
            public Character attacker = null;
            public Character victim = null;
            public string damageTypeCategory = string.Empty;
            public string damageReason = string.Empty;
            public Item item = null;
            public float distance = 0f;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class PlayerRevive
        {
            public Character reviver = null;
            public Character victim = null;
            public int dBNOId = 0;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class CarePackageSpawn
        {
            public ItemPackage itemPackage = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class SwimStart
        {
            public Character character = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class SwimEnd
        {
            public Character character = null;
            public float swimDistance = 0f;
            public float maxSwimDepthOfWater = 0f;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class CarePackageLand
        {
            public ItemPackage itemPackage = null;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class RedZoneEnded
        {
            public List<Character> drivers = new List<Character>();
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class WheelDestroy
        {
            public int attackId = 0;
            public Character attacker = null;
            public Vehicle vehicle = null;
            public string damageTypeCategory = string.Empty;
            public string damageCauserName = string.Empty;
            public Common common = null;
            public DateStamp TimeStamp = null;
        }
         [Serializable] 
 public class MatchEnd
        {
            public List<Character> characters = new List<Character>();
            public Common common = null;
            public DateStamp TimeStamp = null;
        }





         [Serializable] 
 public class ItemPackage
        {
            public string itemPackageId = string.Empty;
            public Location location = null;
            public List<Item> items = new List<Item>();
        }

         [Serializable] 
 public class VictimGameResult
        {
            public int rank = 0;
            public string gameResult = string.Empty;
            public int teamId = 0;
            public Stat stats = null;
            public string accountId = string.Empty;
        }
         [Serializable] 
 public class Stat
        {
            public int killCount = 0;
            public float distanceOnFoot = 0f;
            public float distanceOnSwim = 0f;
            public float distanceOnVehicle = 0f;
            public float distanceOnParachute = 0f;
            public float distanceOnFreefall = 0f;
        }
         [Serializable] 
 public class Vehicle
        {
            public string vehicleType = string.Empty;
            public string vehicleId = string.Empty;
            public int healthPercent = 0;
            public int feulPercent = 0;
        }
         [Serializable] 
 public class Character
        {
            public string name = string.Empty;
            public int teamId = 0;
            public int health = 0;
            public Location location;
            public int ranking = 0;
            public string accountId = string.Empty;
            public bool isInBlueZone = false;
            public bool isInRedZone = false;
            public Zone zone;
        }
         [Serializable] 
 public class Item
        {
            public string ItemId = string.Empty;
            public int stackCount = 0;
            public string category = string.Empty;
            public string subCategory = string.Empty;
            public List<string> attachedItems = new List<string>();
        }
         [Serializable] 
 public class Gamestate
        {
            public int elapsedTime = 0;
            public int numAliveTeams = 0;
            public int numJoinPlayers = 0;
            public int numStartPlayers = 0;
            public int numAlivePlayers = 0;
            public Location safetyZonePosition = null;
            public float safetyZoneRadius = 0f;
            public Location poisonGasWarningPosition = null;
            public float poisonGasWarningRadius = 0f;
            public Location redZonePosition = null;
            public float redZoneRadius = 0f;
        }
         [Serializable] 
 public class Zone
        {

        }
         [Serializable] 
 public class Location
        {
            public float x = 0f;
            public float y = 0f;
            public float z = 0f;
        }
         [Serializable] 
 public class Common
        {
            public int isGame = 0;
        }
    }
}
