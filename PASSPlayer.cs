using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;

namespace ProjectAtlantis
{
    public class PASSPlayer : ModPlayer
    {

      public bool NautlisMinion;

			public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            if ( player.ZoneBeach && liquidType == 0 &&  Main.rand.Next(2) == 0)
            {
                caughtType = mod.ItemType("BettaBubbler");
            } else if ( player.ZoneUnderworldHeight && liquidType == 2 &&  Main.rand.Next(2) == 0 && NPC.downedBoss3 == true)
            {
               caughtType = mod.ItemType("GoatDevilFish");
            }
        }
		}

}
