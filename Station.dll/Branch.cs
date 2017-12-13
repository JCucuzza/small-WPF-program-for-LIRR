//******************************************************
// File: Branch.cs
//
// Purpose: Contains the main definition for Branch.
//          Branch will hold member variables for the
//          LIRR (Long Island RailRoad) characteristics,
//          Accessors/Mutators/Constructors as well as
//          a ToString method. This Class has been built
//          to be serialized/deserialized. ( A branch is
//          is one set of stations that make up a line on
//          the LIRR).
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
    public class Branch
    {
        #region Member Variables
        private int m_id;
        private string m_name;
        private List<int> m_stationId;
        #endregion

        #region Properties
        [DataMember(Name = "id")]
        public int ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        [DataMember(Name = "stationid")]
        public List<int> StationID
        {
            get
            {
                return m_stationId;
            }
            set
            {
                m_stationId = value;
            }
        }
        #endregion

        #region Methods
        //****************************************************
        // Method: Branch
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        public Branch()
        {
            m_id = 2;
            m_name = "Port Jefferson";
            m_stationId = new List<int> { 10, 11, 12, 13, 14 };
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables          
        //****************************************************
        public override string ToString()
        {
            string s = "m_id: " + m_id;
            s += "m_name: " + m_name;
            s += " , ";
            s += "m_stationId" + m_stationId;
            s += "\n [";
            foreach (int x in m_stationId)
            {
                s += "m_stations: " + m_stationId;
                s += "\n";
            }
            s += "] \n";
            return s;
        }
        //****************************************************
        // Method: IsBranchStation
        //
        // Purpose: Returns true if matching stationID is found
        //          else it returns false.        
        //****************************************************
        public bool IsBranchStation(int stationId)
        {
            foreach(int m_stationId in m_stationId)
            {
                if(m_stationId == stationId)
                return true;
            }

            return false;
        }

        #endregion
    }
}
