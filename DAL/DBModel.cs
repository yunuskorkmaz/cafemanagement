namespace DAL
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBModel : DbContext
    {
        // Your context has been configured to use a 'DBModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.DBModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBModel' 
        // connection string in the application configuration file.
        public DBModel()
            : base("name=DBModel")
        {
            Database.SetInitializer(new Myconfig());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Masa> Masa { get; set; }
    }

    public class Myconfig : CreateDatabaseIfNotExists<DBModel>
    {
        protected override void Seed(DBModel context)
        {
            context.Masa.AddRange(new Masa[]
            {

                new Masa(){Adi= "BÜLENT FIRAT",AdditionCount=123},
                new Masa(){ Adi = "Masa 2",AdditionCount=45},
                new Masa(){Adi= "Masa 1",AdditionCount=55},
                new Masa(){ Adi = "Masa 2",AdditionCount=45645678},

            });
            context.SaveChanges();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}