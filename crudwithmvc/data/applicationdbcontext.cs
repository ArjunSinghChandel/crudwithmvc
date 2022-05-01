using crudwithmvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crudwithmvc.data
{
    public class applicationdbcontext: DbContext
    {
        public applicationdbcontext():base("conStr")
        {

        }
        public DbSet<student>students { get; set; }
    }
}