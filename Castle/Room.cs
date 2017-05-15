using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Room : CastleObject
    {
        private List<CastleObject> connectedObjects = new List<CastleObject>();
        public int step = Consts.MAX;
        public String name = "";
        public Room(String name)
        {
            this.name = name;
        }
        public void addConnectedObject(CastleObject castleObject)
        {
            this.connectedObjects.Add(castleObject);
        }
        public List<CastleObject> getConnectedObjects()
        {
            return connectedObjects;
        }
        void CastleObject.setBig()
        {
            this.step = Consts.MAX;
        }
        public void setStep(int step)
        {
            this.step = step;
        }
        public int getStep()
        {
            return step;
        }
        public void addConnectedObjects(List<CastleObject> castleObjects)
        {
            connectedObjects.AddRange(castleObjects);
        }
    }
}
