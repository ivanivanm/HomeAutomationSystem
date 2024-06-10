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
    public class TVContext : IDb<TV, int>
    {
        private HomeAutomationDbContext _context;
        public TVContext(HomeAutomationDbContext db)
        {
            _context = db;
        }

        public void Add(TV entity)
        {
            if (_context.TVs.Contains(entity))
            {
                return;
            }
            _context.TVs.Add(entity);
            _context.SaveChanges();
        }

        public TV Get(int key, bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<TV> TVs = _context.TVs;
            if (isReadOnly)
            {
                TVs.AsNoTrackingWithIdentityResolution();
            }
            return TVs.FirstOrDefault(r => r.Id == key);
        }

        public ICollection<TV> GetAll(bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<TV> TVs = _context.TVs;
            if (isReadOnly)
            {
                TVs.AsNoTrackingWithIdentityResolution();
            }
            return TVs.ToList();
        }

        public void Remove(int key)
        {
            TV entity = _context.TVs.FirstOrDefault(o => o.Id == key);
            if (entity is null)
            {
                return;
            }
            _context.TVs.Remove(entity);
            _context.SaveChanges();

        }

        public void Update(TV entity, bool useNavigationalProperties)
        {
            TV old = _context.TVs.FirstOrDefault(o => o.Id == entity.Id);
            if (entity is null)
            {
                return;
            }
            _context.TVs.Entry(old).CurrentValues.SetValues(entity);
        }
    }
}
