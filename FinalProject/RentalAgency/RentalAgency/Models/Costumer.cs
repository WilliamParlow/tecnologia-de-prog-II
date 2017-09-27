﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
    public class Costumer {

        public int Id { get; set; }
        public int PurchasedMovies { get; set; }
        public int PurchasedGames { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserID { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}