using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccessLayer.CRUD
{
    public class FridgeContext : IDb<Fridge, int>
    {
        private HomeAutomationDbContext _context;
        public FridgeContext(HomeAutomationDbContext db)
        {
            _context = db;
        }

        public void Add(Fridge entity)
        {
            if (_context.Fridges.Contains(entity))
            {
                return;
            }
            _context.Fridges.Add(entity);
            _context.SaveChanges();
        }

        public Fridge Get(int key, bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<Fridge> fridges = _context.Fridges;
            if (isReadOnly)
            {
                fridges.AsNoTrackingWithIdentityResolution();
            }
            return fridges.FirstOrDefault(r => r.Id == key);
        }

        public ICollection<Fridge> GetAll(bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<Fridge> fridges = _context.Fridges;
            if (isReadOnly)
            {
                fridges.AsNoTrackingWithIdentityResolution();
            }
            return fridges.ToList();
        }

        public void Remove(int key)
        {
            Fridge entity = _context.Fridges.FirstOrDefault(o => o.Id == key);
            if (entity is null)
            {
                return;
            }
            _context.Fridges.Remove(entity);
            _context.SaveChanges();

        }

        public void Update(Fridge entity, bool useNavigationalProperties)
        {
            Fridge old = _context.Fridges.FirstOrDefault(o => o.Id == entity.Id);
            if (entity is null)
            {
                return;
            }
            old.IsOn = entity.IsOn;
            old.Name = entity.Name;
            old.Temperature = entity.Temperature;
            old.EnergyEffectiveness = entity.EnergyEffectiveness;
            old.SmartCooling = entity.SmartCooling;

            _context.SaveChanges();
        }
    }
}
