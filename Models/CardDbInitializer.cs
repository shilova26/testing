using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Coffeehouse1.Models
{
    public class CardDbInitializer : DropCreateDatabaseAlways<CardContext>
    {
        protected override void Seed(CardContext db)
        {
            db.Cards.Add(new Card { Name = "Война и мир", Description = "Л. Толстой", Price = 220 });
            db.Cards.Add(new Card { Name = "Отцы и дети", Description = "И. Тургенев", Price = 180 });
            db.Cards.Add(new Card { Name = "Чайка", Description = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}