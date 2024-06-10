using DataAccessLayer.MainModel;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DataAccessLayer.BuilderModels
{
    public class Room
    {
        public Room(int homeId, string type, string name)
        {
            HomeId = homeId;

            AirConditioners = new List<AirConditioner>();
            Fridges = new List<Fridge>();
            Lamps = new List<Lamp>();
            TVs = new List<TV>();
            Type = type;
            Name = name;
        }
        public Room(bool on, int homeId, string type, string name)
        {
            On = on;
            HomeId = homeId;

            AirConditioners = new List<AirConditioner>();
            Fridges = new List<Fridge>();
            Lamps = new List<Lamp>();
            TVs = new List<TV>();
            Type = type;
            Name = name;
        }

        public Room(List<AirConditioner> airConditioners, List<Fridge> fridges, List<Lamp> lamps, List<TV> tVs, bool on, int homeId, string type, string name)
        {
            AirConditioners = airConditioners;
            Fridges = fridges;
            Lamps = lamps;
            TVs = tVs;
            On = on;
            HomeId = homeId;
            Type = type;
            Name = name;
        }

        [Key]
        public int Id { get; set; }
        public virtual List<AirConditioner> AirConditioners { get; set; }
        public virtual List<Fridge> Fridges { get; set; }
        public virtual List<Lamp> Lamps { get; set; }
        public virtual List<TV> TVs { get; set; }
        [ForeignKey(nameof(Home))]
        public int HomeId { get; set; }
        public virtual Home Home { get; set; }

        public bool On { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
