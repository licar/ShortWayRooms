using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Guide : IGuide
    {
        List<CastleObject> castleObjects = new List<CastleObject>();
        public Guide(List<CastleObject> castleObjects)
        {
            this.castleObjects = castleObjects;
        }
        private void setToBig()
        {
            foreach (CastleObject castleObject in castleObjects)
            {
                castleObject.setBig();
            }
        }
        public List<Room> paiwWay(CastleObject startObject, CastleObject targetObject)
        {
            setToBig();
            List<CastleObject> startObjectList = new List<CastleObject>();
            startObjectList.Add(startObject);
            startObject.setStep(0);
            List<CastleObject> visitedObjects = findMinimalWay(startObjectList, targetObject, 0);
            List<CastleObject> restoredWay = restoreWay(visitedObjects, startObject, targetObject);

            List<Room> restoredWayRooms = new List<Room>();
       
            foreach(CastleObject castleObject in restoredWay)
            {
                if (castleObject is Room) restoredWayRooms.Add(castleObject as Room);
            }

            restoredWayRooms.Reverse();
            return restoredWayRooms;
        }
        private List<CastleObject> findMinimalWay(List<CastleObject> currentObjects, CastleObject target, int step)
        {
            List<CastleObject> visitedObjects = new List<CastleObject>();
            
            foreach (CastleObject currentObject in currentObjects)
            {
                foreach (CastleObject connectedObject in currentObject.getConnectedObjects())
                {
                    if (connectedObject.getStep() > step)
                    {
                        connectedObject.setStep(step + 1);
                        visitedObjects.Add(connectedObject);
                    }
                    if (connectedObject == target)
                    {
                        return visitedObjects;
                    }
                }
            }
            visitedObjects.AddRange(findMinimalWay(visitedObjects, target, ++step));
            return visitedObjects;
        }
        private List<CastleObject> restoreWay(List<CastleObject> visitedObjects, CastleObject startObject, CastleObject targetObject)
        {
            List<CastleObject> way = new List<CastleObject>();
            way.Add(targetObject);
            if (targetObject != startObject)
            {
                CastleObject previousObject = getPreviousObject(targetObject);
                way.AddRange(restoreWay(visitedObjects, startObject, previousObject));
            }
            return way;
        }
        private CastleObject getPreviousObject(CastleObject targetObject)
        {
            CastleObject previous = null;
            foreach (CastleObject connectedObject in targetObject.getConnectedObjects())
            {
                if (connectedObject.getConnectedObjects().Contains(targetObject) &&
                    (connectedObject.getStep() == targetObject.getStep() - 1))
                {
                    previous = connectedObject;
                    break;
                }
            }
            Debug.Assert(previous != null, "Previous object for room is not defined");
            return previous;
        }
    }
}
