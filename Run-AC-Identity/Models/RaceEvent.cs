using System.ComponentModel.DataAnnotations;

namespace Run_AC_Identity.Models
{
    public class RaceEvent
    {
        [Key]
        public Guid Id { get; set; }
        public string RaceName { get; set; }
        public DateTime RaceDate { get; set; }

        public int Distance { get; set; }

        public string HostingClub { get; set; }

    }
}