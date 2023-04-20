using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas2
{
    public class RoomAndGroup
    {
        public static List<RoomAndGroup> RoomsAndGroups = new List<RoomAndGroup>();
        private Room room;
        private Group group;
        private DateTime date;
        public RoomAndGroup(Room room, Group group, DateTime date)
        {
            this.room = room;
            this.group = group;
            this.date = date;
            RoomsAndGroups.Add(this);
            room.AddRoomAndGroup(this);
            group.AddRoomAndGroup(this);
        }
        //trochę ciężko będzie mi to pokazać bo idk czy da się manualnie usunąć obiekt, ale generalnie jakby został wyczyszczony to zostanie pousuwany w innych miejscach również
        ~RoomAndGroup()
        {
            RoomsAndGroups.Remove(this);
            room.RemoveRoomAndGroup(this);
            group.RemoveRoomAndGroup(this);
        }
        public override string ToString()
        {
            return $"{room} : {group} : {date}";
        }
    }
    
}