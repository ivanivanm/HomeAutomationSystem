using DataAccessLayer.BuilderModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Fridge
    {
        public Fridge()
        {

        }
        public Fridge(int roomId, string name, bool isOn)
        {
            RoomId = roomId;
            Name = name;
            IsOn = isOn;
        }

        public Fridge(bool isOn, int temperature, bool energyEffectiveness, bool smartCooling, int roomId, string name)
        {
            IsOn = isOn;
            Temperature = temperature;
            EnergyEffectiveness = energyEffectiveness;
            SmartCooling = smartCooling;
            RoomId = roomId;
            Name = name;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; } = false;
        [Required]
        public string Name { get; set; }
        [Range(0, 10)]
        public int Temperature { get; set; } = 5;
        public virtual Room Room { get; set; }
        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
        public bool EnergyEffectiveness { get; set; } = true;

        public bool SmartCooling { get; set; } = true;
    }
}
