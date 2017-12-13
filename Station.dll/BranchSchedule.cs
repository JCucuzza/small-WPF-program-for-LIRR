//******************************************************
// File: BranchSchedule.cs
//
// Purpose: Stores all train ids for a branch. Only stores
//          train ids. To get more information about the 
//          individual train you would need to look up
//          info about the train in the train collection.
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
    public class BranchSchedule
    {
        #region Member Variables
        private int m_branchId;
        private List<int> m_trainId;
        #endregion

        #region Properties

        [DataMember(Name = "train_ID")]
        public List<int> TrainID
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

        [DataMember(Name = "branch_ID")]
        public int BranchID
        {
            get
            {
                return m_branchId;
            }
            set
            {
                m_branchId = value;
            }
        }

        #endregion

        #region Methods
        //****************************************************
        // Method: Station
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        public BranchSchedule()
        {
            m_branchId = 2;
            m_trainId = new List<int>();
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables          
        //****************************************************
        public override string ToString()
        {
            string s = "";
            s += "m_branchId: " + m_branchId;
            s += " , ";
            foreach (int x in m_trainId)
            {
                s += "m_trainId: " + x.ToString();
                s += "\n";
            }
            return s;
        }

        #endregion
    }
}