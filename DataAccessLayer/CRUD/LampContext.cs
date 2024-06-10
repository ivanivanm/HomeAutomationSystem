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
    public class LampContext : IDb<Lamp, int>
    {
        private HomeAutomationDbContext _context;
        public LampContext(HomeAutomationDbContext db)
        {
            _context = db;
        }

        public void Add(Lamp entity)
        {
            if (_context.Lamps.Contains(entity))
            {
                return;
            }
            _context.Lamps.Add(entity);
            _context.SaveChanges();
        }

        public Lamp Get(int key, bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<Lamp> lamps = _context.Lamps;
            if (isReadOnly)
            {
                lamps.AsNoTrackingWithIdentityResolution();
            }
            return lamps.SingleOrDefault(r => r.Id == key);
        }

        public ICollection<Lamp> GetAll(bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<Lamp> lamps = _context.Lamps;
            if (isReadOnly)
            {
                lamps.AsNoTrackingWithIdentityResolution();
            }
            return lamps.ToList();
        }

        public void Remove(int key)
        {
            Lamp entity = _context.Lamps.FirstOrDefault(o => o.Id == key);
            if (entity is null)
            {
                return;
            }
            _context.Lamps.Remove(entity);
            _context.SaveChanges();

        }

        public void Update(Lamp entity, bool useNavigationalProperties)
        {
            Lamp old = _context.Lamps.FirstOrDefault(o => o.Id == entity.Id);
            if (entity is null)
            {
                return;
            }
            _context.Lamps.Entry(old).CurrentValues.SetValues(entity);
        }
    }
}
