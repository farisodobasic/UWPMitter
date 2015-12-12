using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMitter
{
    public class Location
    {
        private int id;
        private string locatioName;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string LocatioName
        {
            get
            {
                return locatioName;
            }

            set
            {
                locatioName = value;
            }
        }

        public Location()
        {

        }

        public Location(string _locationName)
        {
            LocatioName = _locationName;
        }
    }
}
