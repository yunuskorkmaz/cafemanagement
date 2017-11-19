using DAL;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class MasaService
    {

        public static List<Masa> GetList()
        {
            using (var db = new DBModel())
            {
                return db.Masa.ToList();
            }


        }
    }
}
