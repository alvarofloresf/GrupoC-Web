namespace Logic
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        // Object Sponsor (name, description, phoneNumber), by default is NULL
        public Sponsor Sponsor { get; set; }
        public bool Active { get; set; }

    }
}