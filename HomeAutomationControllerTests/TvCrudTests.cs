using DataAccessLayer.BuilderModels;
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
    internal class TvCrudTests
    {
        private HomeAutomationDbContext _context;
        private TVContext _tvContext;
        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HomeAutomationDbContext>()
                .UseInMemoryDatabase(databaseName: "nhjaien")
                .Options;
            _context = new HomeAutomationDbContext(options);
            _tvContext = new TVContext(_context);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _context.Dispose();
            _tvContext = null;
        }
        [SetUp]
        public void SeedDb()
        {
            TV tv0 = new TV()
           { 
                IsOn = true,
                LightnessFactor = 5,
                Volume = 50,
                Name = "tv0",
                NightMode = true,
                RoomId = 1
           };

            TV tv1 = new TV()
            {
                IsOn = false,
                LightnessFactor = 1,
                Volume = 100,
                Name = "tv1",
                NightMode = false,
                RoomId = 1
            };


            _tvContext.Add(tv0);
            _tvContext.Add(tv1);
        }
        [TearDown]
        public void UnseedDb()
        {
            _tvContext.Remove(1);
            _tvContext.Remove(2);
        }
        [Test]
        public void TestAdd()
        {
            //Arrange *done in setup*
            TV tv0;
            TV tv1;
            bool does0Exist;
            bool does1Exist;

            //Act
            tv0 = _tvContext.Get(1, true, false);
            tv1 = _tvContext.Get(2, true, false);

            does0Exist =
                (tv0.Id == 1) &&
                (tv0.IsOn == true) &&
                (tv0.LightnessFactor == 5) &&
                (tv0.Volume == 50) &&
                (tv0.Name == "tv0") &&
                (tv0.NightMode == true) &&
                (tv0.RoomId == 1);

            does1Exist =
               (tv1.Id == 2) &&
                (tv1.IsOn == false) &&
                (tv1.LightnessFactor == 1) &&
                (tv1.Volume == 100) &&
                (tv1.Name == "tv1") &&
                (tv1.NightMode == false) &&
                (tv1.RoomId == 1);

            //Assert
            Assert.That((does0Exist && does1Exist), "TV Create() doesn't work like expected");
        }
        [Test]
        public void TestGet()
        {
            //Arrange *done in setup*
            List<TV> tvs;

            //Act
            tvs = _tvContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(tvs.Count == 2, "Room GetAll() doesn't work like expected");
        }
        [Test]
        public void TestUpdate()
        {
            //Arrange *done in setup*
            TV tv0 = _tvContext.Get(1, true, false);

            //Act

            tv0.IsOn = false;
            tv0.LightnessFactor = 1;
            tv0.Volume = 100;
            tv0.Name = "tv1";
            tv0.NightMode = false;

            _tvContext.Update(tv0, true);

            tv0 = _tvContext.Get(1, true, false);

            bool is0Updated =
                (tv0.IsOn == false) &&
                (tv0.LightnessFactor == 1) &&
                (tv0.Volume == 100) &&
                (tv0.Name == "tv1") &&
                (tv0.NightMode == false);

            //Assert
            Assert.That(is0Updated, "TV Update() doesn't work like expected");
        }
        [Test]
        public void testDelete()
        {
            //Arrange *done in setup*
            List<TV> remaining;

            //Act
            _tvContext.Remove(1);
            _tvContext.Remove(2);
            remaining = _tvContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(remaining.Count == 0, "TV Delete() doesn't work like expected");
        }
    }
}
