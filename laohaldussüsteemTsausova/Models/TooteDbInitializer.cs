using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace laohaldussüsteemTsausova.Models
{
    public class TooteDbInitializer
        : DropCreateDatabaseAlways<TooteContext>
    {
        protected override void Seed(TooteContext db)
        {
            // создаем товар
            var toote1 = new Product
            {
                Toode = "Банан",               
                Tellija = "Егор Олейник",
                Koostaja = "Анастасия Чаусова",
                Aeg = DateTime.Now
        };
            var toote2 = new Product
            {
                Toode = "Криштиану Роналду",
                Tellija = "Егор Олейник",
                Koostaja = "Анастасия Чаусова",
                Aeg = DateTime.Now
            };
            var toote3 = new Product
            {
                Toode = "Неймар",
                Tellija = "Егор Олейник",
                Koostaja = "Анастасия Чаусова",
                Aeg = DateTime.Now
            };
            var toote4 = new Product
            {
                Toode = "Луис Суарес",
                Tellija = "Егор Олейник",
                Koostaja = "Анастасия Чаусова",
                Aeg = DateTime.Now
            };
            var toote5 = new Product
            {
                Toode = "Серхио Агуэро",
                Tellija = "Егор Олейник",
                Koostaja = "Анастасия Чаусова",
                Aeg = DateTime.Now
            };
            db.Products.Add(toote1);
            db.Products.Add(toote2);
            db.Products.Add(toote3);
            db.Products.Add(toote4);
            db.Products.Add(toote5);            
            base.Seed(db);
        }
    }
}

    
