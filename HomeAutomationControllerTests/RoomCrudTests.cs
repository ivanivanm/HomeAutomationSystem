using DataAccessLayer.CRUD;
using DataAccessLayer.Models;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;

namespace HomeAutomationControllerTests
{
    internal class RoomCrudTests
    {
        private HomeAutomationDbContext _context;
        private RoomContext _roomContext;
        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HomeAutomationDbContext>()
                .UseInMemoryDatabase(databaseName: "nhjaien")
                .Options;
            _context = new HomeAutomationDbContext(options);
            _roomContext = new RoomContext(_context);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _context.Dispose();
            _roomContext = null;
        }
        [SetUp]
        public void SeedDb()
        {
            Room r0 = new Room()
            {
                HomeId = 1,
                On = true,
                Type = "living room",
                Name = "r0"
            };

            Room r1 = new Room()
            {
                HomeId = 1,
                On = false,
                Type = "kitchen",
                Name = "r1"
            };

            _roomContext.Add(r0);
            _roomContext.Add(r1);
        }
        [TearDown]
        public void UnseedDb()
        {
            _roomContext.Remove(1);
            _roomContext.Remove(2);
        }
        [Test]
        public void TestAdd()
        {
            //Arrange *done in setup*
            Room r0;
            Room r1;
            bool does0Exist;
            bool does1Exist;

            //Act
            r0 = _roomContext.Get(1, true, false);
            r1 = _roomContext.Get(2, true, false);

            does0Exist =
                (r0.Id == 1) &&
                (r0.HomeId == 1) &&
                (r0.On == true) &&
                (r0.Type == "living room") &&
                (r0.Name == "r0");

            does1Exist =
              (r1.Id == 2) &&
              (r1.HomeId == 1) &&
              (r1.On == false) &&
              (r1.Type == "kitchen") &&
              (r1.Name == "r1");

            //Assert
            Assert.That((does0Exist && does1Exist), "Room Create() doesn't work like expected");
        }
        [Test]
        public void TestGet()
        {
            //Arrange *done in setup*
            List<Room> rooms;

            //Act
            rooms = _roomContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(rooms.Count == 2, "Room GetAll() doesn't work like expected");
        }
        [Test]
        public void TestUpdate()
        {
            //Arrange *done in setup*
            Room r0 = _roomContext.Get(1, true, false);

            //Act

            r0.HomeId = 2;
            r0.On = false;
            r0.Type = "bedroom";
            r0.Name = "r1";

            _roomContext.Update(r0, true);

            r0 = _roomContext.Get(1, true, false);

            bool is0Updated =
                (r0.HomeId == 2) &&
                (r0.On == false) &&
                (r0.Type == "bedroom") &&
                (r0.Name == "r1");

            //Assert
            Assert.That(is0Updated, "Room Update() doesn't work like expected");
        }
        [Test]
        public void testDelete()
        {
            //Arrange *done in setup*
            List<Room> remaining;

            //Act
            _roomContext.Remove(1);
            _roomContext.Remove(2);
            remaining = _roomContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(remaining.Count == 0, "Room Delete() doesn't work like expected");
        }
    }
}
