using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Lockers
{
    public static class ResourceLocker
    {
        public static object Lock = new object();
    }
}
