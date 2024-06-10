using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccessLayer.CRUD
{
    public class RoomContext : IDb<Room, int>
    {
        private HomeAutomationDbContext _context;
        public RoomContext(HomeAutomationDbContext db)
        {
            _context = db;
        }

        public void Add(Room entity)
        {
            if (_context.Rooms.Contains(entity))
            {
                return;
            }
            _context.Rooms.Add(entity);
            _context.SaveChanges();
        }

        public Room Get(int key, bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<Room> rooms = _context.Rooms;
            if (isReadOnly)
            {
                rooms.AsNoTrackingWithIdentityResolution();
            }
            return rooms.SingleOrDefault(r => r.Id == key);
        }

        public ICollection<Room> GetAll(bool useNavigationalProperties, bool isReadOnly)
        {
            IQueryable<Room> rooms = _context.Rooms;
            if (isReadOnly)
            {
                rooms.AsNoTrackingWithIdentityResolution();
            }
            return rooms.ToList();
        }

        public void Remove(int key)
        {
            Room entity = _context.Rooms.FirstOrDefault(o => o.Id == key);
            if (entity is null)
            {
                return;
            }
            _context.Rooms.Remove(entity);
            _context.SaveChanges();

        }

        public void Update(Room entity, bool useNavigationalProperties)
        {
            Room old = _context.Rooms.FirstOrDefault(o => o.Id == entity.Id);
            if (entity is null)
            {
                return;
            }

            _context.Rooms.Entry(old).CurrentValues.SetValues(entity);

            _context.SaveChanges();
            //old.On = entity.On;
            //if (useNavigationalProperties)
            //{
            //    //TV currentTv;
            //    //TV tvFromDb;

            //    //TVContext tvIdb = new TVContext(_context);
            //    //for (int i = 0; i < old.TVs.Count; i++)
            //    //{
            //    //    tvIdb.Remove(old.TVs[i].Id);
            //    //}

            //    //for (int i = 0; i < entity.TVs.Count; i++)
            //    //{
            //    //    currentTv = entity.TVs[i];
            //    //    tvFromDb = _context.TVs.FirstOrDefault(tv => tv.Id == currentTv.Id );

            //    //    if (tvFromDb is null)
            //    //    {
            //    //        tvIdb.Add(currentTv);
            //    //    }
            //    //    else
            //    //    {
            //    //        entity.TVs[i] = tvFromDb;
            //    //    }
            //    //}

            //    //Fridge currentFridge;
            //    //Fridge fridgeFromDb;

            //    //FridgeContext fridgeIdb = new FridgeContext(_context);
            //    //for (int i = 0; i < old.Fridges.Count; i++)
            //    //{
            //    //    tvIdb.Remove(old.Fridges[i].Id);
            //    //}

            //    //for (int i = 0; i < entity.Fridges.Count; i++)
            //    //{
            //    //    currentFridge = entity.Fridges[i];
            //    //    fridgeFromDb = _context.Fridges.FirstOrDefault(frighe => frighe.Id == currentFridge.Id);

            //    //    if (fridgeFromDb is null)
            //    //    {
            //    //        fridgeIdb.Add(currentFridge);
            //    //    }
            //    //    else
            //    //    {
            //    //        entity.Fridges[i] = fridgeFromDb;
            //    //    }
            //    //}
            //    //old.TVs = entity.TVs;
            //    //old.AirConditioners = entity.AirConditioners;
            //    //old.Fridges = entity.Fridges;
            //    //old.Lamps = entity.Lamps;
            //}
        }
    }
}
