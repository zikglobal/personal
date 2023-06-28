namespace Hotel.Models
{
    public class Property
    {
        public Property(string location, string propname, string price, string pic, string group, string popularity)
        {
            Location = location;
            Propname = propname;
            Price = price;
            Pic = pic;
            Group = group;
            this.popularity = popularity;
        }

        public string  Location { get; set; }
        public string  Propname { get; set; }
        public string Price { get; set; }
        public string Pic { get; set; }
        public string Group { get; set; }
        public string popularity { get; set; }
    }
}
