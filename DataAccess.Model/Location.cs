﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class Location : IEntityBase
    {
        public long Id { get; set; }
        public string LocationId { get; set; }
        public string DisplayName { get; set; }

        public Team Team { get; set; }
    }
}
