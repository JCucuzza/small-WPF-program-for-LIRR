//******************************************************
// File: TrainCollection.cs
//
// Purpose: The main use of this class will be to store
//          all stations on the LIRR. Other Classes will
//          refer to objects in this collection using the
//          train id.
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
    public class TrainCollection<T>
    {
        #region Member Variables

        private List<Train> m_trains;

        #endregion

        #region Properties
        [DataMember(Name = "trains")]
        public List<Train> Trains
        {
            get
            {
                return m_trains;
            }
            set
            {
                m_trains = value;
            }
        }


        #endregion

        #region Methods
        //****************************************************
        // Method: Train
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        TrainCollection()
        {
            m_trains = new List<Train>();
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables          
        //****************************************************
        public override string ToString()
        {
            string s = "";

            foreach (Train x in m_trains)
            {
                s += "m_trains: " + x.ToString();
                s += "\n";
            }

            return s;
        }

        //****************************************************
        // Method: FindTrain(Int stationId)
        //
        // Purpose: Returns the Train object with the given 
        //          station id. If it is not found return null         
        //****************************************************

        public Train FindTrain(int trainId)
        {
            foreach (Train n in m_trains)
            {
                if (trainId == n.ID)
                    return n;
            }
            return null;
        }
        #endregion
    }
}