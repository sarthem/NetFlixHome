using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootFlixHome.Models
{
    public class Viewer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get
            {
                return GetFullName();
            }
            set
            {

            }
        }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }



        //methods
        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }


    }
}