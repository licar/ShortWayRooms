using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Stairs : CastleObject
    {
        public List<CastleObject> connectedObjects = new List<CastleObject>();
        public int step = Consts.MAX;
        public int floor = 1;
        Stairs(int floor)
        {
            this.floor = floor;
        }
        public void addConnectedObject(CastleObject castleObject)
        {
            this.connectedObjects.Add(castleObject);
        }
        public void addConnectedObjects(List<CastleObject> castleObjects)
        {
            connectedObjects.AddRange(castleObjects);
        }
        public List<CastleObject> getConnectedObjects()
        {
            return connectedObjects;
        }
        public int getStep()
        {
            return step;
        }
        public void setBig()
        {
            this.step = Consts.MAX;
        }
        public void setStep(int step)
        {
            this.step = step;
        }
    }
}
