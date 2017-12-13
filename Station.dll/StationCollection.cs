//******************************************************
// File: StationCollection.cs
//
// Purpose: The main use of this class will be to store
//          all stations on the LIRR. Other Classes will
//          refer to objects in this collection using the
//          station id.
//
// Written By: Jonathan Cucuzza
//
// Compiler: Visual Studio 2015
//
//******************************************************

using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TrainStation
{
    [DataContract]
    public class StationCollection
    {
        #region Member Variables

        List<Station> m_stations;

        #endregion

        #region Properties
        [DataMember(Name = "stations")]
        public List<Station> Stations
        {
            get
            {
                return m_stations;
            }
            set
            {
                m_stations = value;
            }
        }


        #endregion

        #region Methods
        //****************************************************
        // Method: Station
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        public StationCollection()
        {
            m_stations = new List<Station>();
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables          
        //****************************************************
        public override string ToString()
        {
            string s ="";

            foreach (Station x in Stations)
            {
                s += "m_stations: " + x.ToString();
                s += "\n";
            }

            return s;
        }

        //****************************************************
        // Method: FindStation(Int stationId)
        //
        // Purpose: Returns the Station object with the given 
        //          station id. If it is not found return null         
        //****************************************************

        public Station FindStation(int stationId)
        {
            foreach (Station n in Stations)
            {
                if (stationId == n.ID)
                    return n;
            }
            return null;
        }

        //****************************************************
        // Method: FindStation(String name)
        //
        // Purpose: Returns the Station object with the given 
        //          name. If it is not found return null         
        //****************************************************

        public Station FindStation(string name)
        {
            foreach (Station n in Stations)
            {
                if (name == n.Name)
                    return n;
            }
            return null;
        }
        #endregion
    }
}
