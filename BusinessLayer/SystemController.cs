using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;
using DataAccessLayer.MainModel;
using DataAccessLayer.Models;
using PresentationLayer;
using PresentationLayer.Home;
using PresentationLayer.Rooms;
using PresentationLayer.Tools;
using DataAccessLayer;
using DataAccessLayer.CRUD;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq.Expressions;
using PresentationLayer.Tools;

namespace BusinessLayer
{
    internal class SystemController
    {
        private Home model;
        private HomeAutomationDbContext _db;

        public SystemController()
        {
            if (_db.Home.Count() == 0)
            {
                // nqmame ime
                string name = HomeClass.WelcomeHomeFirstTime();
                // dobavqme obekta
                _db.Home.Add(new Home(name));
            }
            else
            {
                HomeClass.WelcomeHome(_db.Home.ToList()[0].Name);
            }

            AirConditionerContext acContext = new AirConditionerContext(_db);
            FridgeContext fridgeContext = new FridgeContext(_db);
            LampContext lampContext = new LampContext(_db);
            TVContext tvContext = new TVContext(_db);
            RoomContext roomContext = new RoomContext(_db);

            int roomChoice;
            do
            {
                roomChoice = HomeClass.Choice();

                switch (roomChoice)
                {
                    case 1:
                        // choose a room
                        Console.WriteLine("Here is a list with all of your rooms : ");
                        foreach (Room item in roomContext.GetAll(true, false))
                        {
                            Console.WriteLine("{0} (ID) - {1} (type), {2} (name)", item.Id, item.Type, item.Name);
                        }

                        Console.WriteLine();

                        Console.Write("Please enter the Id of the room which you want to choose : ");
                        int chosenRoomId = int.Parse(Console.ReadLine());

                        Room chosenRoom = roomContext.Get(chosenRoomId, true, false);

                        LivingRoom.Welcome(chosenRoom.Name);

                        int toolChoice = 0;

                        do
                        {
                            toolChoice = LivingRoom.Choice();
                            switch (toolChoice)
                            {
                                case 1:
                                    //select tool
                                    Console.WriteLine("Air conditioners : ");
                                    foreach (AirConditioner ac in chosenRoom.AirConditioners)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", ac.Id, ac.Name);
                                    }
                                    Console.WriteLine("Fridges : ");
                                    foreach (Fridge f in chosenRoom.Fridges)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", f.Id, f.Name);
                                    }
                                    Console.WriteLine("Lamps : ");
                                    foreach (Lamp l in chosenRoom.Lamps)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", l.Id, l.Name);
                                    }
                                    Console.WriteLine("TVs : ");
                                    foreach (TV tv in chosenRoom.TVs)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", tv.Id, tv.Name);
                                    }

                                    Console.Write("Please enter the type of the tool that you want to select (ac,f,l or tv) : ");
                                    string chosenToolType = Console.ReadLine();
                                    Console.Write("Please enter the Id of the tool that you want to select : ");
                                    int chosenToolId = int.Parse(Console.ReadLine());

                                    int toolOptionsChoice = 0;
                                    if (chosenToolType.ToUpper() == "AC")
                                    {
                                        AirConditioner chosenAC = acContext.Get(chosenToolId, true, false);
                                        AirConditioningOptions.Welcome(chosenAC.Name);
                                        do
                                        {
                                            toolOptionsChoice = AirConditioningOptions.Functions();
                                            switch (toolOptionsChoice)
                                            {
                                                case 1:
                                                    Console.WriteLine("Current temperature : {0}", chosenAC.Temperature);
                                                    int? newTemperature = AirConditioningOptions.Temperature();
                                                    if (newTemperature is not null)
                                                    {
                                                        chosenAC.Temperature = (int)newTemperature;
                                                    }
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Current power : {0}", chosenAC.IsOn);
                                                    bool? newOnOff = AirConditioningOptions.On();
                                                    if (newOnOff is not null)
                                                    {
                                                        chosenAC.IsOn = (bool)newOnOff;
                                                    }
                                                    break;

                                                case 3:
                                                    string currentDirection = null;
                                                    switch ((int)chosenAC.AirDir)
                                                    {
                                                        case 1:
                                                            currentDirection = "up";
                                                            break;
                                                        case 2:
                                                            currentDirection = "down";
                                                            break;
                                                        case 3:
                                                            currentDirection = "left";
                                                            break;
                                                        case 4:
                                                            currentDirection = "right";
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                    Console.WriteLine("Current direction : {0}", currentDirection);
                                                    int? newAirDir = AirConditioningOptions.Direction();
                                                    if (newAirDir is not null)
                                                    {
                                                        chosenAC.AirDir = (AirConditioner.Direction)newAirDir;
                                                    }
                                                    break;

                                                case 4:
                                                    Console.Write("Current mode : {0}", chosenAC.ACMode);
                                                    int? newMode = AirConditioningOptions.Mode();
                                                    if (newMode is not null)
                                                    {
                                                        chosenAC.ACMode = (int)newMode;
                                                    }
                                                    break;

                                                case 5:
                                                    Console.WriteLine("Current speed : {0}", chosenAC.AirSpeed);
                                                    int? newSpeed = AirConditioningOptions.Speed();
                                                    if (newSpeed is not null)
                                                    {
                                                        chosenAC.AirSpeed = (int)newSpeed;
                                                    }
                                                    break;

                                                case 6:
                                                    Console.WriteLine("Late start : {0}", chosenAC.LateStart.Item1);
                                                    Console.WriteLine("Minutes : {0}", chosenAC.LateStart.Item2);
                                                    int? newLateStart = AirConditioningOptions.LateStart();
                                                    if (newLateStart is not null)
                                                    {
                                                        chosenAC.LateStart = (int)newLateStart;
                                                    }
                                                    break;

                                                case 7:
                                                    Console.WriteLine("Late stop : {0}", chosenAC.LateStop.Item1);
                                                    Console.WriteLine("Minutes : {0}", chosenAC.LateStop.Item2);
                                                    int? newLateStop = AirConditioningOptions.LateStop();
                                                    if (newLateStop is not null)
                                                    {
                                                        chosenAC.LateStop = (int)newLateStop;
                                                    }
                                                    break;

                                                case 8:
                                                    Console.WriteLine("Current turbo mode : {0}", chosenAC.Turbo);
                                                    bool? newTurbo = AirConditioningOptions.Turbo();
                                                    if (newTurbo is not null)
                                                    {
                                                        chosenAC.Turbo = (bool)newTurbo;
                                                    }
                                                    break;

                                                case 9:
                                                    Console.WriteLine("Current self-cleaning mode : {0}", chosenAC.SelfCleaning);
                                                    bool? newSelfCleaning = AirConditioningOptions.SelfCleaning();
                                                    if (newSelfCleaning is not null)
                                                    {
                                                        chosenAC.SelfCleaning = (bool)newSelfCleaning;
                                                    }
                                                    break;
                                                case 0:
                                                    break;
                                                default:
                                                    break;

                                            }
                                        }
                                        while (toolOptionsChoice != 0);

                                    }
                                    else if (chosenToolType.ToUpper() == "F")
                                    {
                                        Fridge chosenFridge = fridgeContext.Get(chosenToolId, true, false);
                                        FridgeOptions.Welcome(chosenFridge.Name);
                                        do
                                        {
                                            toolOptionsChoice = FridgeOptions.Functions();
                                            switch (toolOptionsChoice)
                                            {
                                                case 1:
                                                    Console.WriteLine("Current temperature : {0}", chosenFridge.Temperature);
                                                    int? newTemperature = FridgeOptions.Temperature();
                                                    if (newTemperature is not null)
                                                    {
                                                        chosenFridge.Temperature = (int)newTemperature;
                                                    }
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Current power : {0}", chosenFridge.IsOn);
                                                    bool? newOnOff = FridgeOptions.On();
                                                    if (newOnOff is not null)
                                                    {
                                                        chosenFridge.IsOn = (bool)newOnOff;
                                                    }
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Current energy effectiveness mode: {0}", chosenFridge.EnergyEffectiveness);
                                                    bool? newEnergyEffectiveness = FridgeOptions.EnergyEffectiveness();
                                                    if (newEnergyEffectiveness is not null)
                                                    {
                                                        chosenFridge.EnergyEffectiveness = (bool)newEnergyEffectiveness;
                                                    }
                                                    break;

                                                case 4:
                                                    Console.WriteLine("Smart cooling  : {0}", chosenFridge.SmartCooling);
                                                    bool? newSmartCooling = FridgeOptions.SmartCooling();
                                                    if (newSmartCooling is not null)
                                                    {
                                                        chosenFridge.SmartCooling = (bool)newSmartCooling;
                                                    }
                                                    break;

                                                case 0:
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        while (toolOptionsChoice != 0);
                                    }
                                    else if (chosenToolType.ToUpper() == "TV")
                                    {
                                        TV chosenTv = tvContext.Get(chosenToolId, true, false);
                                        TVOptions.Welcome(chosenTv.Name);
                                        do
                                        {
                                            toolOptionsChoice = TVOptions.Functions();
                                            switch (toolOptionsChoice)
                                            {
                                                case 1:
                                                    Console.WriteLine("Current power : {0}", chosenTv.IsOn);
                                                    bool? newOnOff = TVOptions.On();
                                                    if (newOnOff is not null)
                                                    {
                                                        chosenTv.IsOn = (bool)newOnOff;
                                                    }
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Current volume : {0}", chosenTv.Volume);
                                                    int? newVolume = TVOptions.Volume();
                                                    if (newVolume is not null)
                                                    {
                                                        chosenTv.Volume = (int)newVolume;
                                                    }
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Current lightness factor : {0}", chosenTv.LightnessFactor);
                                                    int? newLightnessFactor = TVOptions.LightnessFactor();
                                                    if (newLightnessFactor is not null)
                                                    {
                                                        chosenTv.LightnessFactor = (int)newLightnessFactor;
                                                    }
                                                    break;
                                                case 4:
                                                    Console.WriteLine("Night mode : {0}", chosenTv.NightMode);
                                                    bool? newNightMode = TVOptions.NightMode();
                                                    if (newNightMode is not null)
                                                    {
                                                        chosenTv.NightMode = (bool)newNightMode;
                                                    }
                                                    break;
                                                case 0:
                                                    break;
                                            }
                                        }
                                        while (toolOptionsChoice != 0);
                                    }
                                    else if (chosenToolType.ToUpper() == "L")
                                    {
                                        Lamp chosenLamp = lampContext.Get(chosenToolId, true, false);
                                        LampOptions.Welcome(chosenLamp.Name);
                                        do
                                        {
                                            toolOptionsChoice = LampOptions.Functions();
                                            switch (toolOptionsChoice)
                                            {
                                                case 1:
                                                    Console.WriteLine("Current power : {0}", chosenLamp.IsOn);
                                                    bool? newOnOff = TVOptions.On();
                                                    if (newOnOff is not null)
                                                    {
                                                        chosenLamp.IsOn = (bool)newOnOff;
                                                    }
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Current lightness factor : {0}", chosenLamp.LightnessFactor);
                                                    int? newLightnessFactor = TVOptions.LightnessFactor();
                                                    if (newLightnessFactor is not null)
                                                    {
                                                        chosenLamp.LightnessFactor = (int)newLightnessFactor;
                                                    }
                                                    break;
                                                case 0:
                                                    break;
                                                default:
                                                    break;

                                            }
                                        }
                                        while (toolOptionsChoice != 0);
                                    }

                                    break;

                                case 2:
                                    //add tool

                                    Console.Write("Please enter the type of the tool that you want to add (ac,f,l or tv) : ");
                                    chosenToolType = Console.ReadLine();
                                    switch (chosenToolType.ToUpper())
                                    {
                                        case "AC":
                                            string toolName = AirConditioningOptions.WelcomeFirstTime();
                                            acContext.Add(new AirConditioner(false, toolName, chosenRoom.Id));
                                            break;
                                        case "F":
                                            toolName = FridgeOptions.WelcomeFirstTime();
                                            fridgeContext.Add(new Fridge(chosenRoom.Id, toolName, false));
                                            break;
                                        case "L":
                                            toolName = LampOptions.WelcomeFirstTime();
                                            lampContext.Add(new Lamp(false, chosenRoom.Id, toolName));
                                            break;
                                        case "TV":
                                            toolName = TVOptions.WelcomeFirstTime();
                                            tvContext.Add(new TV(chosenRoom.Id, false, toolName));
                                            break;
                                        default:
                                            break;
                                    }

                                    break;

                                case 3:

                                    // delete tool
                                    Console.WriteLine("Air conditioners : ");
                                    foreach (AirConditioner ac in chosenRoom.AirConditioners)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", ac.Id, ac.Name);
                                    }
                                    Console.WriteLine("Fridges : ");
                                    foreach (Fridge f in chosenRoom.Fridges)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", f.Id, f.Name);
                                    }
                                    Console.WriteLine("Lamps : ");
                                    foreach (Lamp l in chosenRoom.Lamps)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", l.Id, l.Name);
                                    }
                                    Console.WriteLine("TVs : ");
                                    foreach (TV tv in chosenRoom.TVs)
                                    {
                                        Console.WriteLine("{0} (Id) - {1} (name)", tv.Id, tv.Name);
                                    }

                                    Console.Write("Please enter the type of the tool that you want to delete (ac,f,l or tv) : ");
                                    chosenToolType = Console.ReadLine();
                                    Console.Write("Please enter the Id of the tool that you want to delete : ");
                                    chosenToolId = int.Parse(Console.ReadLine());

                                    break;
                                case 0:
                                    break;
                                //quit tool options
                                default:
                                    break;
                            }

                        }
                        while (toolChoice != 0);
                        break;

                    case 2:
                        // add a room
                        Tuple<string, int> result = HomeClass.AddRoom();
                        int type = result.Item2;
                        string name = result.Item1;
                        int homeId = _db.Home.ToList()[0].ID;
                        switch (type)
                        {
                            case 1:
                                roomContext.Add(new Room(homeId, "living room", name));
                                break;
                            case 2:
                                roomContext.Add(new Room(homeId, "kitchen", name));
                                break;
                            case 3:
                                roomContext.Add(new Room(homeId, "bathroom", name));
                                break;
                            case 4:
                                roomContext.Add(new Room(homeId, "bedroom", name));
                                break;
                            default:
                                break;
                        }
                        break;

                    case 3:
                        //delete a room
                        Console.WriteLine("Here is a list with all of your rooms : ");
                        foreach (Room item in roomContext.GetAll(true, false))
                        {
                            Console.WriteLine("{0} (ID) - {1} (type) {2} (name)", item.Id, item.Type, item.Name);
                        }

                        Console.WriteLine();

                        Console.Write("Please enter the Id of the room which you want to delete : ");
                        int deletedId = int.Parse(Console.ReadLine());
                        roomContext.Remove(deletedId);
                        break;

                    default:
                        break;
                }
            }
            while (roomChoice != 0);
        }
    }
}
