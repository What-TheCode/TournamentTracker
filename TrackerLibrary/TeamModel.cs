﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; }
        public String TeamName { get; set; }

        public TeamModel()
        {
            this.TeamMembers = new List<PersonModel>;
        }
    }
}
