using Belajar_CRUD_WPF_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_CRUD_WPF_Dionisius.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Belajar_CRUD_WPF_Dionisius") { }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; }
    }
}