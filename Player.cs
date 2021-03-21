namespace ClubsCatalog
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
