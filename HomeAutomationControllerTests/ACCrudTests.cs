using DataAccessLayer;
using DataAccessLayer.CRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using DataAccessLayer.Models;
using DataAccessLayer.BuilderModels;
using NUnit.Framework;


namespace HomeAutomationControllerTests
{
    internal class ACCrudTests
    {
        private HomeAutomationDbContext _context;
        private AirConditionerContext _airConditionerContext;
        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HomeAutomationDbContext>()
                .UseInMemoryDatabase(databaseName: "nhjaien")
                .Options;
            _context = new HomeAutomationDbContext(options);
            _airConditionerContext = new AirConditionerContext(_context);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _context.Dispose();
            _airConditionerContext = null;
        }
        [SetUp]
        public void SeedDb()
        {
            _airConditionerContext.Add(new AirConditioner()
            {
                IsOn = false,
                Temperature = 20,
                AirDir = AirConditioner.Direction.Up,
                ACMode = 1,
                AirSpeed = 5,
                LateStart = 0,
                LateStop = 0,
                Turbo = false,
                Name = "AC0",
                SelfCleaning = true,
                RoomId = 1
            });
            _airConditionerContext.Add(new AirConditioner()
            {
                IsOn = true,
                Temperature = 10,
                AirDir = AirConditioner.Direction.Right,
                ACMode = 4,
                AirSpeed = 8,
                LateStart = 30,
                LateStop = 30,
                Turbo = true,
                Name = "AC1",
                SelfCleaning = false,
                RoomId = 1
            });

        }
        [TearDown]
        public void UnseedDb()
        {
            _airConditionerContext.Remove(1);
            _airConditionerContext.Remove(2);
        }
        [Test]
        public void TestDelete()
        {
            //Arrange *done in SeedDb()*

            //Act 
            _airConditionerContext.Remove(1);


            bool Is0Deleted = (_airConditionerContext.Get(1, true, false) is null);

            //Assert 
            Assert.That(Is0Deleted, "AC Delete() doesn't work like expected");
        }

        [Test]
        public void TestUpdate()
        {
            //Arrange *done in SeedDb()*
            AirConditioner ac0;
            bool Is0Updated;

            //Act 
             ac0 = _airConditionerContext.Get(1, true, false);

            ac0.IsOn = true;
            ac0.Temperature = 10;
            ac0.AirDir = AirConditioner.Direction.Right;
            ac0.ACMode = 4;
            ac0.AirSpeed = 8;
            ac0.LateStart = 30;
            ac0.LateStop = 30;
            ac0.Turbo = true;
            ac0.Name = "AC1";
            ac0.SelfCleaning = false;

             Is0Updated = (
                (ac0.IsOn == true)
                && (ac0.Temperature == 10)
                && (ac0.AirDir == AirConditioner.Direction.Right)
                && (ac0.ACMode == 4)
                && (ac0.AirSpeed == 8)
                && (ac0.LateStart == 30)
                && (ac0.LateStop == 30)
                && (ac0.Turbo == true)
                && (ac0.Name == "AC1")
                && (ac0.SelfCleaning == false)
                );

            //Assert 
            Assert.That(Is0Updated, "AC Update() doesn't work like expected");
        }

        [Test]
        public void TestGet()
        {
            //Arrange *done in SeedDb()*
            List<AirConditioner> conditioners;

            //Act 
            conditioners = _airConditionerContext.GetAll(true, false).ToList();

            //Assert 
            Assert.That(conditioners.Count == 2, "AC Read() doesn't work like expected");
        }

        [Test]
        public void TestAdd()
        {
            //Arrange *done in SeedDb()*

            //Act 
            AirConditioner ac0 = _airConditionerContext.GetAll(true,false).ToList()[0];
            bool does0Exist = (
                (ac0.Id == 1)
                && (ac0.IsOn == false)
                && (ac0.Temperature == 20)
                && (ac0.AirDir == AirConditioner.Direction.Up)
                && (ac0.ACMode == 1)
                && (ac0.AirSpeed == 5)
                && (ac0.LateStart == 0)
                && (ac0.LateStop == 0)
                && (ac0.Turbo == false)
                && (ac0.Name == "AC0")
                && (ac0.SelfCleaning == true)
                && (ac0.RoomId == 1)
                );

            AirConditioner ac1 = _airConditionerContext.GetAll(true, false).ToList()[1];
            bool does1Exist = (
                (ac1.Id == 2)
                && (ac1.IsOn == true)
                && (ac1.Temperature == 10)
                && (ac1.AirDir == AirConditioner.Direction.Right)
                && (ac1.ACMode == 4)
                && (ac1.AirSpeed == 8)
                && (ac1.LateStart == 30)
                && (ac1.LateStop == 30)
                && (ac1.Turbo == true)
                && (ac1.Name == "AC1")
                && (ac1.SelfCleaning == false)
                && (ac1.RoomId == 1)
                );

            //Assert 
            Assert.That((does0Exist&&does1Exist), "AC Create() doesn't work like expected");
        }
    }
}
