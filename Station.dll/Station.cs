//******************************************************
// File: Station.cs
//
// Purpose: Contains the main definition for Station.
//          Station will hold member variables for the
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
    public class Station
    {
        #region Member Variables

        private int m_id;
        private string m_name;
        private string m_location;
        private int m_fareZone;
        private double m_mileageToPenn;
        private string m_picFilename;
        #endregion

        #region Properties

        [DataMember(Name = "fare_zone")]
        public int FareZone
        {
            get
            {
                return m_fareZone;
            }
            set
            {
                m_fareZone = value;
            }
        }

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

        [DataMember(Name = "location")]
        public string Location
        {
            get
            {
                return m_location;
            }
            set
            {
                m_location = value;
            }
        }


        [DataMember(Name = "mileage_to_penn")]
        public double MileageToPenn
        {
            get
            {
                return m_mileageToPenn;
            }
            set
            {
                m_mileageToPenn = value;
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

        [DataMember(Name = "pic_filename")]
        public string PicFilename
        {
            get
            {
                return m_picFilename;
            }
            set
            {
                m_picFilename = value;
            }
        }
        #endregion

        #region Methods
        //****************************************************
        // Method: Station
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        public Station()
        {
            m_id = 111;
            m_name = "Huntington";
            m_location = "New York Avenue (Route 110) and Broadway, 2 miles North of Jericho Turnpike";
            m_fareZone = 9;
            m_mileageToPenn = 34.7;
            m_picFilename = "huntington.jpg";
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
                s += "m_location: " + m_location;
                s += " , ";
                s += "m_fareZone: " + m_fareZone;
                s += " , ";
                s += "m_mileageToPenn: " + m_mileageToPenn;
                s += " , ";
                s += "m_picFilename: " + m_picFilename;
                s += "\n";
            return s;
        }

        #endregion
    }
}