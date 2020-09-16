﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Model
{
    public class Team : IEntityBase
    {
        public Team()
        {
            Users = new HashSet<User>();
        }
        public long Id { get; set; }
        public string TeamId { get; set; }
        public string SecretToken { get; set; }
        public string Location { get; set; }

        public Location LocationNav { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public ICollection<User> Users { get; set; }
    }
}