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

        private Mitter newMeet;
        private User toSendFriends;

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
        public User ToSendFriends
        {
            get
            {
                return toSendFriends;
            }

            set
            {
                toSendFriends = value;
            }
        }
        public Mitter NewMeet
        {
            get
            {
                return newMeet;
            }

            set
            {
                newMeet = value;
            }
        }


        /*ctor*/
        public Invite()
        {
            toSendFriends = new User();
        }

        public Invite(User _toSendFriends, Mitter _newMeet)
        {
            ToSendFriends = _toSendFriends;
            NewMeet = _newMeet;
            
        }

        /*kreiraj novi invite*/
        public Invite createInvite(User _toSend, Mitter _newMeet)
        {
            try
            {
                Invite newInvite = new Invite( _toSend, _newMeet);
                _toSend.Invites.Add(newInvite);
                return newInvite;
            }
            catch (Exception)
            {     
                throw;
            }
        }

    }
}
