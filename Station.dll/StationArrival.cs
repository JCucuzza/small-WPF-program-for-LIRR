//******************************************************
// File: StationArrival.cs
//
// Purpose: Contains the main definition for StationArrival.
//          StationArrival will hold member variables for the
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
    public class StationArrival
    {
        #region Member Variables

        private int m_stationId;
        private DateTime m_time;
        //private bool m_transferRequired;
        #endregion

        #region Properties

        [DataMember(Name = "station_id")]
        public int StationId
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

        [DataMember(Name = "time")]
        public DateTime Time
        {
            get
            {
                return m_time;
            }
            set
            {
                m_time = value;
            }
        }
        /*
                [DataMember(Name ="transfer_required")]
                public bool TransferRequired
                {
                    get
                    {
                        return m_transferRequired;
                    }
                    set
                    {
                        m_transferRequired = value;
                    }
                }
        */
        #endregion

        #region Methods

        //****************************************************
        // Method: StationArrival
        //
        // Purpose: Allocates space in RAM for member variables
        //          when StationArrival is called.
        //****************************************************
        public StationArrival()
        {
            m_stationId = 2;
            m_time = default(DateTime);
            //m_transferRequired = true;
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables     
        //****************************************************
        public override string ToString()
        {
            string s = "m_stationId:" + m_stationId;
                s += " , ";
                s += "m_time: " + m_time;
                s += "\n";
            return s;
        }
        #endregion
    }
}