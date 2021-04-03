using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Services.Map
{
    public class DistanceService : IDistanceService
    {
        public TimeSpan Calculate()
        {
            return TimeSpan.FromSeconds(5);
        }
    }
}
