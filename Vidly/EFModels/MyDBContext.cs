﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.EFModels
{
    public class MyDBContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }

   
}