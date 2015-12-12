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
        private string title;
        private User mitterCreator;
        private Location chosenLocation;
        private DateTime chosenTime;

        private List<Time> times;
        private List<Location> locations;
        private List<Invite> invites;

        private bool active;
 
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
        public DateTime DeadLine { get; set; }

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

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        //ctor         
        public Mitter()
        {
            locations = new List<Location>();
            invites = new List<Invite>();
            times = new List<Time>();
        }

        public Mitter(User _mitterCreator, List<Location> _locations, List<Time> _times, List<Invite> _invites, string _title)
        {
            MitterCreator = _mitterCreator;
            Locations = _locations;
            Times = _times;
            Invites = _invites;
            Title = _title;
        }

        /*methodes*/

            /*VRIJEME*/
        public Time addTime(int _day, int _month, int _hour, int _minutes)
        {
            Time newTime = new Time(_day, _month, _hour, _minutes);
            this.Times.Add(newTime);
            return newTime;
        }

        public List<Time> getTimes()
        {
            return this.Times;
        }

        /*MJESTO*/

        public Location addLocation(string _locationName)
        {
            Location newLocation = new Location(_locationName);
            this.Locations.Add(newLocation);
            return newLocation;
        }

        public List<Location> getLocations()
        {
            return this.Locations;
        }

        /*dodavanje etc.*/

        public Mitter submitMitter(User _mitterCreator, List<Location> _locations, List<Time> _times, List<Invite> _invites, string _title)
        {
            try
            {
                Mitter newMitt = new Mitter(_mitterCreator, _locations, _times, _invites, _title);
                _mitterCreator.MyMeets.Add(newMitt);
                return newMitt;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public bool isMeetActive()
        {
            bool a = false;
            this.Active = true ? a = true : a = false;
            if (DeadLine == DateTime.Now) a = false;
            return a;
        }
    }
}
