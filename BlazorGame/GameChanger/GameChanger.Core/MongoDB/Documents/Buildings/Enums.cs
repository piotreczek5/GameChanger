using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Buildings
{
    public enum BuildingStatuses
    {
        BUILDING,
        BROKEN,
        FIXING,
        BUILT,
        NOT_BUILT,
        DESTROYING,
        IDLE
    }

    public enum BuildActions
    {
        BUILD,
        FIX,
        DESTROY,
        UPGRADE
    }
}
