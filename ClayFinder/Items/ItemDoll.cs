using ClayFinder.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

namespace ClayFinder.Items
{
    internal class ItemDoll : Item
    {
        public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, bool firstEvent, ref EnumHandHandling handling)
        {
            byEntity.World.Logger.Error("Using the class!");
            AssetLocation dollAssetLocation = new AssetLocation("clayfinder", "doll");
            EntityProperties dollEntityType = byEntity.World.GetEntityType(dollAssetLocation);
            Entity entityDoll = byEntity.World.ClassRegistry.CreateEntity(dollAssetLocation);
            if (entityDoll == null)
            {
                byEntity.World.Logger.Error("FAILURE");
            }
            else {
                byEntity.World.Logger.Error("SUCCESSS!");
            }
                base.OnHeldInteractStart(slot, byEntity, blockSel, entitySel, firstEvent, ref handling);
        }
    }
}
