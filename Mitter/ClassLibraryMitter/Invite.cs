using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMitter
{
    public class Invite
    {
        private int id;
        private int mitterID;
        private int userID;

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

        public int MitterID
        {
            get
            {
                return mitterID;
            }

            set
            {
                mitterID = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public Invite()
        {

        }
    }
}
