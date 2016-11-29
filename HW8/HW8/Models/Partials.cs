﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HW8.Models
{
    public partial class Pirate
    {
        [Display(Name = "Pirate Name")]
        public string FullName { get { return $"{FirstName} \"{NickName}\" {LastName}"; } }
    }
}