using ClayFinder.Entities;
using ClayFinder.Items;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace ClayFinder
{
    public class ClayFinderModSystem : ModSystem
    {

        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + api.Side);
            api.RegisterItemClass(Mod.Info.ModID + ".doll", typeof(ItemDoll));
            api.RegisterEntity(Mod.Info.ModID + ".entitydoll", typeof(EntityDoll));
            base.Start(api);
        }
        public override void StartServerSide(ICoreServerAPI api)
        {
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
        }

    }
}
