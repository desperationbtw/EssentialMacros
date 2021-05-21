using EssentialMacros;
using EssentialMacros.Pages;
using Microsoft.Win32;
using System.Collections.Generic;

static class Constants
{
    public static BindingPage BP;
    public static SettingsPage SP;
    public static List<SettingsElement> settingsSetup = new List<SettingsElement>();
    public static List<WeaponElement> weaponArray = new List<WeaponElement>();
    public static WeaponElement currentWeapon = null;
    public static bool isBind = false;
    public static RegistryKey localMachineKey;
    public static OffsetWorker offsetWorker = new OffsetWorker();
}


