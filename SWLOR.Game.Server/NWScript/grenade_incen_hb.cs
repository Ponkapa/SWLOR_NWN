﻿using NWN;
using System;
using static NWN._;
using SWLOR.Game.Server.GameObject;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    internal class grenade_incen_hb
#pragma warning restore IDE1006 // Naming Styles
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {            
            NWObject oTarget;            
            oTarget = GetFirstInPersistentObject(_.OBJECT_SELF);
            while (GetIsObjectValid(oTarget) == TRUE)
            {         
                SWLOR.Game.Server.Item.Grenade.grenadeAoe(oTarget, "INCENDIARY");
                //Get the next target in the AOE
                oTarget = GetNextInPersistentObject(_.OBJECT_SELF);
            }
        }
    }
}