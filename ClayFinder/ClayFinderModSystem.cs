using ClayFinder.Entities;
using ClayFinder.Items;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace ClayFinder
{
    public class ClayFinderModSystem : ModSystem
    {

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.World.Logger.Event("Started Clayfinder mod!");
            api.RegisterItemClass(Mod.Info.ModID + ".doll", typeof(ItemDoll));
            api.RegisterEntity(Mod.Info.ModID + ".entitydoll", typeof(EntityDoll));
            
        }
        public override void StartServerSide(ICoreServerAPI api)
        {
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
        }

    }
}
