﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.User
{
    [ServiceContract]
    public interface IContact
    {
        [OperationContract]
        bool Contact(contact c);
    }

    [DataContract]
    public class contact
    {
        public int id { get; set; }
        string firstname = "abc";
        string lastname = "xyz";
        string email = "user1@gmail.com";
        string label = "mobile";
        string contactType = "work";
        int mobileno = 1234567890;

        public contact() { }
        public contact(string fname, string lname, string email, string label, string contactType, int mobile)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.email = email;
            this.label = label;
            this.contactType = contactType;
            this.mobileno = mobile;
        }

        [DataMember]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        [DataMember]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        [DataMember]
        public string ContactType
        {
            get { return contactType; }
            set { contactType = value; }
        }
        [DataMember]
        public int Mobileno
        {
            get { return mobileno; }
            set { mobileno = value; }
        }
    }
}