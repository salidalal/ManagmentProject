﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThisAbility.Models
{
    public class WantedAd : Ad
    {
        public bool Intellectual { get; set; }
        public bool Physical { get; set; }
        public bool MentalIllness { get; set; }
        public bool Sensory { get; set; }

        public string Description { get; set; }


        public WantedAd(String name, string mail, string phone, string desc,
            bool interl, bool phys, bool mental, bool sens)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = mail;
            this.Description = desc;
            this.Intellectual = interl;
            this.MentalIllness = mental;
            this.Sensory = sens;
            this.Physical = phys;
            //TODO : uncomment this 
            //AllWantedAds.Ads.Add(this);
        }


    }
}