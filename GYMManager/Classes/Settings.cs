using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Settings
{
    public static string GYMTitle
    {
        get;
        set;
    }

    public static void Load()
    {
        GYMTitle = Definitions.GetConfigValue("GYM_TITLE");
    }
    public static void Save()
    {

    }

}

