using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    interface CastleObject
    {
        List<CastleObject> getConnectedObjects();
        void addConnectedObject(CastleObject castleObject);
        void addConnectedObjects(List<CastleObject> castleObjects);
        void setBig();
        void setStep(int step);
        int getStep();
    }
}
