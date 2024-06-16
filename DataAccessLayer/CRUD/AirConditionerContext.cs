using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CRUD
{
    public class AirConditionerContext : IDb<AirConditioner, int>
    {
        private HomeAutomationDbContext _context;
        public AirConditionerContext(HomeAutomationDbContext db)
        {
            _context = db;
        }

        public void Add(AirConditioner entity)
        {
            if (_context.Conditioners.Contains(entity))
            {
                return;
            }
            _context.Conditioners.Add(entity);
            _context.SaveChanges();
        }

        public AirConditioner Get(int key, bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<AirConditioner> conditioners = _context.Conditioners;
            if (isReadOnly)
            {
                conditioners.AsNoTrackingWithIdentityResolution();
            }
            return conditioners.SingleOrDefault(r => r.Id == key);
        }

        public ICollection<AirConditioner> GetAll(bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<AirConditioner> conditioners = _context.Conditioners;
            if (isReadOnly)
            {
                conditioners.AsNoTrackingWithIdentityResolution();
            }
            return conditioners.ToList();
        }

        public void Remove(int key)
        {
            AirConditioner entity = _context.Conditioners.FirstOrDefault(o => o.Id == key);
            if (entity is null)
            {
                return;
            }
            _context.Conditioners.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(AirConditioner entity, bool useNavigationalProperties)
        {
            AirConditioner old = _context.Conditioners.FirstOrDefault(o => o.Id == entity.Id);
            if (entity is null)
            {
                return;
            }
            
            old.IsOn = entity.IsOn;
            old.Temperature = entity.Temperature;
            old.AirDir = entity.AirDir;
            old.ACMode = entity.ACMode;
            old.AirSpeed = entity.AirSpeed;
            old.LateStart = entity.LateStart;
            old.LateStop = entity.LateStop;
            old.Turbo = entity.Turbo;
            old.Name = entity.Name;
            old.SelfCleaning = entity.SelfCleaning;

            _context.SaveChanges();
        }
    }
}
