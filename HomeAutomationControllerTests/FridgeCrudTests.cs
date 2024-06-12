using DataAccessLayer;
using DataAccessLayer.CRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using DataAccessLayer.Models;
using DataAccessLayer.BuilderModels;
using NUnit.Framework;
using System.Diagnostics.Contracts;

namespace HomeAutomationControllerTests
{
    internal class FridgeCrudTests
    {
        private HomeAutomationDbContext _context;
        private FridgeContext _fridgeContext;
        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HomeAutomationDbContext>()
                .UseInMemoryDatabase(databaseName: "nhjaien")
                .Options;
            _context = new HomeAutomationDbContext(options);
            _fridgeContext = new FridgeContext(_context);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _context.Dispose();
            _fridgeContext = null;
        }
        [SetUp]
        public void SeedDb()
        {
            Fridge fr0 = new Fridge()
            {
                IsOn = true,
                Name = "fr0",
                Temperature = 20,
                EnergyEffectiveness = true,
                SmartCooling = false,
                RoomId = 1
            };
            Fridge fr1 = new Fridge()
            {
                IsOn = false,
                Name = "fr1",
                Temperature = 15,
                EnergyEffectiveness = false,
                SmartCooling = true,
                RoomId = 1
            };

            _fridgeContext.Add(fr0);
            _fridgeContext.Add(fr1);
        }
        [TearDown]
        public void UnseedDb()
        {
            _fridgeContext.Remove(1);
            _fridgeContext.Remove(2);
        }
        [Test]
        public void TestAdd()
        {
            //Arrange *done in setup*

            //Act
            Fridge fr0 = _fridgeContext.Get(1,true,false);
            Fridge fr1 = _fridgeContext.Get(2,true,false);

            bool does0Exist =
                (fr0.Id == 1) &&
                (fr0.IsOn == true)&&
                (fr0.Name == "fr0")&&
                (fr0.Temperature == 20)&&
                (fr0.EnergyEffectiveness == true)&&
                (fr0.SmartCooling == false)&&
                (fr0.RoomId == 1);

            bool does1Exist =
                (fr1.Id == 2) &&
                (fr1.IsOn == false) &&
                (fr1.Name == "fr1") &&
                (fr1.Temperature == 15) &&
                (fr1.EnergyEffectiveness == false) &&
                (fr1.SmartCooling == true) &&
                (fr1.RoomId == 1);


            //Assert
            Assert.That((does0Exist&&does1Exist), "Fridge Create() doesn't work like expected");
        }
        [Test]
        public void TestGet()
        {
            //Arrange *done in setup*
            List<Fridge> fridges; 

            //Act
            fridges = _fridgeContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(fridges.Count == 2, "Fridge GetAll() doesn't work like expected");
        }
        [Test]
        public void TestUpdate()
        {
            //Arrange *done in setup*
            Fridge fr0 = _fridgeContext.Get(1, true, false);

            //Act

            fr0.IsOn = false;
            fr0.Name = "fr1";
            fr0.Temperature = 15;
            fr0.EnergyEffectiveness = false;
            fr0.SmartCooling = true;

            _fridgeContext.Update(fr0,true);

            fr0 = _fridgeContext.Get(1,true,false);

            bool is0Updated =
                (fr0.IsOn == false) &&
                (fr0.Name == "fr1") &&
                (fr0.Temperature == 15) &&
                (fr0.EnergyEffectiveness == false) &&
                (fr0.SmartCooling == true);

            //Assert
            Assert.That(is0Updated, "Fridge Update() doesn't work like expected");
        }
        [Test]
        public void testDelete()
        {
            //Arrange *done in setup*
            List<Fridge> remaining;

            //Act
            _fridgeContext.Remove(1);
            _fridgeContext.Remove(2);
            remaining = _fridgeContext.GetAll(true, false).ToList();

            //Assert
            Assert.That(remaining.Count == 0, "Fridge Delete() doesn't work like expected");



        }
    }
}
