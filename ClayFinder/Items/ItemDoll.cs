using ClayFinder.Entities;
using System;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.API.Util;

namespace ClayFinder.Items
{
    internal class ItemDoll : Item
    {
        public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, bool firstEvent, ref EnumHandHandling handling)
        {
            byEntity.World.Logger.Error("Using ItemDoll class!");

            // Define the entity type
            AssetLocation dollAssetLocation = new AssetLocation("clayfinder", "doll");
            EntityProperties dollEntityType = byEntity.World.GetEntityType(dollAssetLocation);

            byEntity.World.Logger.Error($"Entity type found: Code={dollEntityType.Code}, Class={dollEntityType.Class}");

            // Create the entity
            Entity entityDoll = byEntity.World.ClassRegistry.CreateEntity(dollEntityType) as EntityDoll;
            byEntity.World.Logger.Error($"Created entity type: {entityDoll.GetType().FullName}");

            // Set the entity's position
            entityDoll.ServerPos.SetFrom(byEntity.Pos);
            entityDoll.ServerPos.Yaw = byEntity.ServerPos.Yaw;
            entityDoll.ServerPos.X += (float)Math.Cos(byEntity.ServerPos.Yaw) * 2;
            entityDoll.ServerPos.Z += (float)Math.Sin(byEntity.ServerPos.Yaw) * 2;
            entityDoll.Pos.SetFrom(entityDoll.ServerPos);

            byEntity.World.Logger.Error($"Set entity position: X={entityDoll.ServerPos.X}, Y={entityDoll.ServerPos.Y}, Z={entityDoll.ServerPos.Z}");
            var world = byEntity.World;


            // Handle spawning
            world.SpawnEntity(entityDoll);


            byEntity.World.Logger.Error("Doing something after");
            
            base.OnHeldInteractStart(slot, byEntity, blockSel, entitySel, firstEvent, ref handling);

            handling = EnumHandHandling.PreventDefault;

        }
    }
}
