﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact : IAmModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }

        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }

        public Contact()
        {
            this.Id = Guid.NewGuid();
        }
        public Contact(string firstName, string lastName, string company) : this()
        {
            SetBasicInfo(firstName, lastName, company);
        }
        public Contact(string firstName, string lastName) : this(firstName, lastName, null) { }

        public void SetBasicInfo(string firstName, string lastName, string company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
        }
        public void SetBasicInfo(string firstName, string lastName)
        {
            SetBasicInfo(firstName, lastName, null);
        }

        public void SetDetails(string phoneNumber, string emailAddress, string homeAddress)
        {
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.HomeAddress = homeAddress;
        }
        public void SetDetails(string phoneNumber, string emailAddress)
        {
            SetDetails(phoneNumber, emailAddress, null);
        }
        public void SetDetails(string phoneNumber)
        {
            SetDetails(phoneNumber, null, null);
        }
    }
}
