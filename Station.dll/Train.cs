//******************************************************
// File: Train.cs
//
// Purpose: Contains the main definition for Train.
//          Train will hold member variables for the
//          LIRR (Long Island RailRoad) characteristics,
//          Accessors/Mutators/Constructors as well as
//          a ToString method. This Class has been built
//          to be serialized/deserialized.
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
    [DataContract]
    public class Train
    {
        #region Member Variables
        private int m_trainId;
        private List<StationArrival> m_stationArrivals;
        #endregion

        #region Properties

        [DataMember(Name = "trainID")]
        public int ID
        {
            get
            {
                return m_trainId;
            }
            set
            {
                m_trainId = value;
            }
        }

        [DataMember(Name = "station_arrivals")]
        public List<StationArrival> Station_Arrivals
        {
            get
            {
                return m_stationArrivals;
            }
            set
            {
                m_stationArrivals = value;
            }
        }

        #endregion

        #region Methods
        //****************************************************
        // Method: Station
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        public Train()
        {
            m_trainId = 2;
            m_stationArrivals = new List<StationArrival>();
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables          
        //****************************************************
        public override string ToString()
        {
            string s = "";
            s += "m_trainId: " + m_trainId;
            s += " , ";
            foreach (StationArrival x in m_stationArrivals) {
                s += "m_stationArrivals: " + x.ToString();
                s += "\n";
            }
            return s;
        }

        #endregion
    }
}
