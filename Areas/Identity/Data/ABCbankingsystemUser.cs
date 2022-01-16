using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ABCbankingsystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ABCbankingsystemUser class
    public class ABCbankingsystemUser : IdentityUser
    {

        // personal info

        [PersonalData]
        [Column(TypeName ="nvarchar(50)")]
        public string FirstName { get; set; }


        [PersonalData]
        [Column (TypeName ="nvarchar(50)")]
        public string LastName { get; set; }

        /*
        [PersonalData]
        [Column("Gender")]
        public string Gender { get; set; }


        [PersonalData]
        [Column("MaritalStatus")]
        public string MaritalStatus { get; set; }

        [PersonalData]
        [Column("DateOfBirth")]
        public DateTime DOB { get; set; }


        //residential info

        [PersonalData]
        [Column("Address")]
        public string Address { get; set; }

        [PersonalData]
        [Column("City")]
        public string City { get; set; }

        [PersonalData]
        [Column("PostCode")]
        public string PostCode { get; set; }

        [PersonalData]
        [Column("Country")]
        public string Country { get; set; }


        //Identification
        
        [Column("CountryofBirth")]
        public string CountryofBirth { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string IDNumber { get; set; } */

    }
}
