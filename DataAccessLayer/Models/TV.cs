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
    public class TV
    {
        public TV()
        {

        }
        public TV(int roomId, bool isOn, string name)
        {
            RoomId = roomId;
            IsOn = isOn;
            Name = name;
        }

        public TV(bool isOn, int lightnessFactor, int volume, bool nightMode, int roomId, string name)
        {
            IsOn = isOn;
            LightnessFactor = lightnessFactor;
            Volume = volume;
            NightMode = nightMode;
            RoomId = roomId;
            Name = name;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; }
        [Range(0, 100)]
        public int LightnessFactor { get; set; } = 50;
        [Range(0, 100)]
        public int Volume { get; set; } = 50;
        public string Name { get; set; }
        public bool NightMode { get; set; } = false;
        public virtual Room Room { get; set; }
        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
    }
}
