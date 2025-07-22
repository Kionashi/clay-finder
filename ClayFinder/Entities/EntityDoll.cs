using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace ClayFinder.Entities
{
    internal class EntityDoll: Entity
    {
        public override void Initialize(EntityProperties properties, ICoreAPI api, long InChunkIndex3d)
        {
           
            api.Logger.Error("Initializing EntityDoll!!");
            base.Initialize(properties, api, InChunkIndex3d);

        }

    }
}
