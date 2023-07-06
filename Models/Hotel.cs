using System.ComponentModel.DataAnnotations;

namespace Hotels.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int rooms { get; set;}

        public string location { get; set; }

        public string phone { get; set; }

        public int rating { get; set; }

        public string imgUrl { get; set; }
    }
}
