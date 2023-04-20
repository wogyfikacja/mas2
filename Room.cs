using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas2
{
    public class Room
    {
        public static Dictionary<int,Room> rooms = new Dictionary<int,Room>();
        private List<RoomAndGroup> roomAndGroups = new List<RoomAndGroup>();
        private int id;
        private int seats;
        private bool hasProjector;
        public int Id { get => id; set => id = value; }
        public Room(int id, int seats, bool hasProjector)
        {
            this.id = id;
            this.seats = seats;
            this.hasProjector = hasProjector;
        }
        public void AddRoomAndGroup(RoomAndGroup roomAndGroup)
        {
            roomAndGroups.Add(roomAndGroup);
        }
        public void RemoveRoomAndGroup(RoomAndGroup roomAndGroup)
        {
            roomAndGroups.Remove(roomAndGroup);
        }
        public override string ToString()
        {
            return $"{id} {seats} {hasProjector}";
        }
    }
}