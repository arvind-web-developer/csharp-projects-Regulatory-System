using eFarmingRegulatorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eFarmingRegulatorySystem.Services
{
    public class PersonService
    {
        private ApplicationDbContext db;

        public PersonService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreatePerson(string firstName, string lastName, string userId, string mobileNo, string joinDate, bool isActive)
        {
            //Note 123456 seed number should be avoided or stored in config file. If I delete any account then I might end up duplicating the account number.
            var accountNumber = (123456 + db.Persons.Count()).ToString().PadLeft(10, '0');
            var person = new Person
            {
                AccountNumber = accountNumber,
                //AccountNumber = "0000123456",
                FirstName = firstName,
                LastName = lastName,
                MobileNo = mobileNo,
                JoinDate = joinDate,
                IsActive = isActive,
                ApplicationUserId = userId
            };
            db.Persons.Add(person);
            db.SaveChanges();
        }
    }
}