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
    public class Lamp
    {
        public Lamp()
        {

        }
        public Lamp(bool isOn, int lightnessFactor, int roomId, string name)
        {
            IsOn = isOn;
            LightnessFactor = lightnessFactor;
            RoomId = roomId;
            Name = name;
        }
        public Lamp(bool isOn, int roomId, string name)
        {
            IsOn = isOn;
            RoomId = roomId;
            Name = name;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; } = false;
        [Range(1, 10)]
        public int LightnessFactor { get; set; } = 5;
        [Required]
        public string Name { get; set; }
        public virtual Room Room { get; set; }
        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

    }
}
