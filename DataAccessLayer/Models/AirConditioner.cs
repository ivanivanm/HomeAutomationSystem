using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;

namespace DataAccessLayer.Models
{
    public class AirConditioner
    {
        public AirConditioner()
        {

        }
        public AirConditioner(bool isOn, string name, int roomId)
        {
            IsOn = isOn;
            Name = name;
            RoomId = roomId;
        }

        public AirConditioner(bool isOn, double temperature, Direction airDir, int aCMode, int airSpeed, int lateStartMinutes, int lateStopMinutes, bool turbo, bool selfCleaning, int roomId, string name)
        {
            IsOn = isOn;
            Temperature = temperature;
            ACMode = aCMode;
            AirSpeed = airSpeed;
            LateStart = lateStartMinutes;
            LateStop = lateStopMinutes;
            Turbo = turbo;
            SelfCleaning = selfCleaning;
            AirDir = airDir;
            RoomId = roomId;
            Name = name;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; } = false;
        [Range(0, 30)]
        public double Temperature { get; set; } = 20;
        public Direction AirDir { get; set; } = Direction.Up;
        [Range(1, 5)]
        public int ACMode { get; set; } = 3;
        [Range(1, 10)]
        public int AirSpeed { get; set; } = 5;
        public int LateStart { get; set; } = 0;
        public int LateStop { get; set; } = 0;
        public bool Turbo { get; set; } = false;
        [Required]
        public string Name { get; set; }
        public bool SelfCleaning { get; set; } = false;
        public virtual Room Room { get; set; }
        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
        public enum Direction
        {
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4,
        }
    }
}
