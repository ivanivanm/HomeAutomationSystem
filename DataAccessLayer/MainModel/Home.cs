using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;

namespace DataAccessLayer.MainModel
{
    public class Home
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Room> Rooms { get; set; } = new List<Room>();

        public Home(string name, List<Room> rooms)
        {
            Name = name;
            Rooms = rooms;
        }

        public Home(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }
    }
}
