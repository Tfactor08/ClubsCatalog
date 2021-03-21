using System.Data.Entity;
using System.Collections.Generic;

namespace ClubsCatalog
{
    class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Player> Players { get; set; }

        public Club()
        {
            Players = new List<Player>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
