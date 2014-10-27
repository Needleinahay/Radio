using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data_layer
{
    public class Repository
    {
        private RadioContext db;
        public Repository(RadioContext dbContext)
        {
            db = dbContext;
        }

        public MainPageVM GetMainPage()
        {
            MainPageVM toReturn = new MainPageVM();
            toReturn.Countries = db.Countries.ToList();
            toReturn.Genres = db.Genres.ToList();
            return toReturn;
        }
    }
}
