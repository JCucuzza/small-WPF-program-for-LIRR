//******************************************************
// File: TrainScheduleUnitTesting.cs
//
// Purpose: Contains the main definition for 
//          TrainScheduleUnitTesting.TrainScheduleUnitTesting
//          will hold member variables for the
//          LIRR (Long Island RailRoad) code to unit test
//          class Station and Station Arrivals Property 
//          methods.
//          
//
// Written By: Jonathan Cucuzza
//
// Compiler: Visual Studio 2015
//
//******************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TrainStation
{
    public class TrainScheduleUnitTesting
    {
        #region Variables

        private int pass = 0;
        private int fail = 0;

        #endregion

        #region Methods
        //****************************************************
        // Method: UnitTestStation
        //
        // Purpose: Test Station.cs Properties and print the 
        //          outcome.
        //****************************************************
        public void UnitTestStation()
        {
            Station testStation = new Station();

            Console.WriteLine("\nWriting Unit Test: Station Properties\n");

            int testId = 100;
            testStation.ID = testId;

            if (testStation.ID == testId)
            {
                Console.WriteLine("Station ID Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("Station ID Property: FAIL");
                fail++;
            }

            string testName = "Hicksville";
            testStation.Name = testName;

            if (testStation.Name == testName)
            {
                Console.WriteLine("Station Name Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("Station Name Property: FAIL");
                fail++;
            }

            string testLocation = "New York Avenue";
            testStation.Location = testLocation;

            if (testStation.Location == testLocation)
            {
                Console.WriteLine("Station Location Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("Station Location Property: FAIL");
                fail++;
            }

            int testFareZone = 10;
            testStation.FareZone = testFareZone;

            if (testStation.FareZone == testFareZone)
            {
                Console.WriteLine("Station FareZone Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("Station FareZone Property: FAIL");
                fail++;
            }

            double testMileageToPenn = 35.5;
            testStation.MileageToPenn = testMileageToPenn;

            if (testStation.MileageToPenn == testMileageToPenn)
            {
                Console.WriteLine("Station MileageToPenn Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("Station MileageToPenn Property: FAIL");
                fail++;
            }

            string testPicFilename = "hicksville.jpg";
            testStation.PicFilename = testPicFilename;

            if (testStation.PicFilename == testPicFilename)
            {
                Console.WriteLine("Station PicFilename Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("Station PicFilename Property: FAIL");
                fail++;
            }

            Console.WriteLine("\nUnit Test Finished: Station Properties");
            Console.WriteLine("-----------------------------------------");
        }

        //****************************************************
        // Method: UnitTestStationArrival
        //
        // Purpose: Test StationArrive.cs Properties and print 
        //          the outcome.
        //****************************************************
        public void UnitTestStationArrival()
        {
            StationArrival testStationArrival = new StationArrival();

            Console.WriteLine("\nWriting Unit Test: Station Properties\n");

            int testStationId = 3;
            testStationArrival.StationId = testStationId;

            if (testStationArrival.StationId == testStationId)
            {
                Console.WriteLine("StationArrival StationId Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("StationArrival StationId Property: FAIL");
                fail++;
            }

            DateTime testTime = new DateTime(1503926700000 - 0400);
            testStationArrival.Time = testTime;

            if (testStationArrival.Time == testTime)
            {
                Console.WriteLine("StationArrival Time Property: PASS");
                pass++;
            }
            else
            {
                Console.WriteLine("StationArrival Time Property: FAIL");
                fail++;
            }

            //     bool testTransferRequired = false;
            //     testStationArrival.TransferRequired = testTransferRequired;

            //     if (testStationArrival.TransferRequired == testTransferRequired)
            //     {
            //         Console.WriteLine("StationArrival TransferRequired Property: PASS");
            //         pass++;
            //     }
            //     else
            //     {
            //         Console.WriteLine("StationArrival TransferRequired Property: FAIL");
            //         fail++;
            //     }
            //     Console.WriteLine("\nUnit Test Finished: StationArrival Properties");
            //    Console.WriteLine(fail + " / " + pass + " FAILED\n");
            //     Console.WriteLine("-----------------------------------------\n");
            // }
        }

        #endregion
    }
}