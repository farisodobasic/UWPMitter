using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMitter
{
    public class Mitter
    {
        private int id;
        private User mitterCreator;
        private Location chosenLocation;
        private DateTime chosenTime;
        private List<Time> times;
        private List<Location> locations;
        private List<Invite> invites;
        private bool accepted;
 
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

        public User MitterCreator
        {
            get
            {
                return mitterCreator;
            }

            set
            {
                mitterCreator = value;
            }
        }

        public Location ChosenLocation
        {
            get
            {
                return chosenLocation;
            }

            set
            {
                chosenLocation = value;
            }
        }

        public DateTime ChosenTime
        {
            get
            {
                return chosenTime;
            }

            set
            {
                chosenTime = value;
            }
        }

        public List<Location> Locations
        {
            get
            {
                return locations;
            }

            set
            {
                locations = value;
            }
        }

        public List<Invite> Invites
        {
            get
            {
                return invites;
            }

            set
            {
                invites = value;
            }
        }

        public bool Accepted
        {
            get
            {
                return accepted;
            }

            set
            {
                accepted = value;
            }
        }

        public List<Time> Times
        {
            get
            {
                return times;
            }

            set
            {
                times = value;
            }
        }

        //ctor         
        public Mitter()
        {
            locations = new List<Location>();
            invites = new List<Invite>();
            times = new List<Time>();
        }

        public Mitter()
        {

        }
    }
}
