using System.Collections.Generic;

namespace Engine.Models
{
    public class World
    {
        private readonly List<Location> _locations = new List<Location>();

        internal void AddLocation(Location location)
        {
            _locations.Add(location);
        }

        public Location LocationAt(int xCoodinate, int yCoordinate)
        {
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == xCoodinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
