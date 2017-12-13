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
    public class BranchCollection
    { 
        #region Member Variables

       List<Branch> m_branches;

        #endregion

        #region Properties
        [DataMember(Name = "branches")]
        public List<Branch> Branches
        {
            get
            {
                return m_branches;
            }
            set
            {
                m_branches = value;
            }
        }
        #endregion

        #region Methods
        //****************************************************
        // Method: Station
        //
        // Purpose: Allocates space in RAM for member variables
        //****************************************************
        BranchCollection()
        {
            Branches = new List<Branch>();
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Prints the value inside the member variables          
        //****************************************************
        public override string ToString()
        {
            string s = "";

            foreach (Branch x in Branches)
            {
                s += "m_branches: " + x.ToString();
                s += "\n";
            }

            return s;
        }

        //****************************************************
        // Method: FindBranch(Int stationId)
        //
        // Purpose: Returns the Station object with the given 
        //          station id. If it is not found return null         
        //****************************************************

        public Branch FindBranch(int branchId)
        {
            foreach (Branch n in Branches)
            {
                if (branchId == n.ID)
                    return n;
            }
            return null;
        }

        //****************************************************
        // Method: FindBranch(String name)
        //
        // Purpose: Returns the Station object with the given 
        //          name. If it is not found return null         
        //****************************************************

        public Branch FindBranch(string name)
        {
            foreach (Branch n in Branches)
            {
                if (name == n.Name)
                    return n;
            }
            return null;
        }
        #endregion
    } 
}
