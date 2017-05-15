using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    interface IGuide
    {
        List<Room> paiwWay(CastleObject startObject, CastleObject targetObject);
    }
}
