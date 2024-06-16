using DataAccessLayer.CRUD;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace HomeAutomationControllerTests
{
    internal class LampCrudTests
    {
        private HomeAutomationDbContext _context;
        private LampContext _lampContext;
        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HomeAutomationDbContext>()
                .UseInMemoryDatabase(databaseName: "nhjaien")
                .Options;
            _context = new HomeAutomationDbContext(options);
            _lampContext = new LampContext(_context);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _context.Dispose();
            _lampContext = null;
        }
        [SetUp]
        public void SeedDb()
        {
            Lamp l0 = new Lamp()
            {
                IsOn = true,
                LightnessFactor = 5,
                Name = "l0",
                RoomId = 1
            };

            Lamp l1 = new Lamp()
            {
                IsOn = false,
                LightnessFactor = 1,
                Name = "l1",
                RoomId = 1
            };

            _lampContext.Add(l0);
            _lampContext.Add(l1);
        }
        [TearDown]
        public void UnseedDb()
        {
            _lampContext.Remove(1);
            _lampContext.Remove(2);
        }
        [Test]
        public void TestAdd()
        {
            //Arrange *done in setup*
            Lamp l0;
            Lamp l1;
            bool does0Exist;
            bool does1Exist;

            //Act
            l0 = _lampContext.Get(1, true, false);
            l1 = _lampContext.Get(2,true,false);

            does0Exist =
                (l0.Id == 1) &&
                (l0.IsOn == true) &&
                (l0.LightnessFactor == 5) &&
                (l0.Name == "l0") &&
                (l0.RoomId == 1);

            does1Exist =
                 (l1.Id == 2) &&
                 (l1.IsOn == false) &&
                 (l1.LightnessFactor == 1) &&
                 (l1.Name == "l1") &&
                 (l1.RoomId == 1);

            //Assert
            Assert.That((does0Exist&&does1Exist),"Lamp Add() doesn't work like expected");
        }
        [Test]
        public void TestGet()
        {
            //Arrange *done in setup*
            List<Lamp> lamps;

            //Act
            lamps = _lampContext.GetAll(true,false).ToList();

            //Assert
            Assert.That(lamps.Count == 2, "Lamp GetAll() doesn't work like expected");
        }
        [Test]
        public void TestUpdate()
        {
            //Arrange *done in setup*
            Lamp l0;
            bool is0Updated;

            //Act
            l0 = _lampContext.Get(1,true,false);

            l0.IsOn = false;
            l0.LightnessFactor = 6;
            l0.Name = "l1";

            _lampContext.Update(l0, true);

            l0 = _lampContext.Get(1, true, false);

            is0Updated =
                (l0.IsOn == false) &&
                (l0.LightnessFactor == 6) &&
                (l0.Name == "l1");

            //Assert
            Assert.That(is0Updated, "Lamp Update() doesn't work like expected");
        }
        [Test]
        public void TestRemove()
        {
            //Arrange *done in setup*
            List<Lamp> remaining;

            //Act
            _lampContext.Remove(1);
            _lampContext.Remove(2);

            remaining = _lampContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(remaining.Count == 0, "Lamp Remove() doesn't work like expected");
        }
    }
}
