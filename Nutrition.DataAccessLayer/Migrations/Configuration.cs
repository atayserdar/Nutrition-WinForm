namespace Nutrition.DataAccessLayer.Migrations
{
    using Nutrition.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nutrition.DataAccessLayer.DbContexts.NutritionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Nutrition.DataAccessLayer.DbContexts.NutritionContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Foods.Any())
            {
                List<Food> foodList = new List<Food>()
            {
                new Food
                {
                    Name = "Ekmek",
                    Quantity = 1,
                    Kcal = 90,
                    Description = "1 dilim Ekmek 25 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\01-ekmek.png"
                },

                new Food
                {
                    Name = "Mısır Ekmeği",
                    Quantity = 1,
                    Kcal = 92,
                    Description = "1 dilim Mısır Ekmeği 25 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\02-misirekmegi.png"
                },

                new Food
                {
                    Name = "Çavdar Ekmeği",
                    Quantity = 1,
                    Kcal = 60,
                    Description = "1 dilim Çavdar Ekmeği 25 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\03-cavdarekmegi.png"
                },

                new Food
                {
                    Name = "Kavun",
                    Quantity = 1,
                    Kcal = 33,
                    Description = "1 porsiyon Kavun 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\04-kavun.png"
                },

                new Food
                {
                    Name = "Portakal",
                    Quantity = 1,
                    Kcal = 79,
                    Description = "1 porsiyon Portakal 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\05-portakal.png"
                },

                new Food
                {
                    Name = "Muz",
                    Quantity = 1,
                    Kcal = 89,
                    Description = "1 porsiyon Muz 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\06-muz.png"
                },

                new Food
                {
                    Name = "Kereviz",
                    Quantity = 1,
                    Kcal = 40,
                    Description = "1 porsiyon Kereviz 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\07-kereviz.png"
                },

                new Food
                {
                    Name = "Karnabahar",
                    Quantity = 1,
                    Kcal = 27,
                    Description = "1 porsiyon Karnabahar 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\08-karnabahar.png"
                },

                new Food
                {
                    Name = "Brüksel Lahana",
                    Quantity = 1,
                    Kcal = 35,
                    Description = "1 porsiyon Brüksel Lahana 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\09-brukselLahana.png"
                },

                new Food
                {
                    Name = "Biftek",
                    Quantity = 1,
                    Kcal = 156,
                    Description = "1 porsiyon Biftek 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\10-biftek.png"
                },

                new Food
                {
                    Name = "Kuzu Pirzola",
                    Quantity = 1,
                    Kcal = 263,
                    Description = "1 porsiyon Kuzu Pirzola 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\11-kuzu_pirzola.png"
                },

                new Food
                {
                    Name = "Tavuk But",
                    Quantity = 1,
                    Kcal = 232,
                    Description = "1 porsiyon Tavuk But 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\12-tabukbut.png"
                },

                new Food
                {
                    Name = "Kuru Fasulye",
                    Quantity = 1,
                    Kcal = 340,
                    Description = "1 porsiyon Kuru Fasulye 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\13-kurufasulye.png"
                },

                new Food
                {
                    Name = "Mercimek Yemeği",
                    Quantity = 1,
                    Kcal = 340,
                    Description = "1 porsiyon Mercimek Yemeği 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\14-mercimek.png"
                },

                new Food
                {
                    Name = "Nohut Yemeği",
                    Quantity = 1,
                    Kcal = 360,
                    Description = "1 porsiyon Nohut Yemeği 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\15-nohut.png"
                },

                new Food
                {
                    Name = "Pirinç Pilavı",
                    Quantity = 1,
                    Kcal = 363,
                    Description = "1 porsiyon Pirinç Pilavı 100 gr dır.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\16-pilav.png"
                },

                new Food
                {
                    Name = "Kola",
                    Quantity = 1,
                    Kcal = 59,
                    Description = "1 porsiyon Kola 100 ml dir.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\17-cola.png"
                },

                new Food
                {
                    Name = "Portakal Suyu",
                    Quantity = 1,
                    Kcal = 45,
                    Description = "1 porsiyon Portakal Suyu 100 ml dir.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\18-portakalsuyu.png"
                },

                new Food
                {
                    Name = "Ayran",
                    Quantity = 1,
                    Kcal = 38,
                    Description = "1 porsiyon Ayran 100 ml dir.",
                    PhotoPath = @"C:\Users\User\Desktop\Serdar Nutrition Proje\Nutrition\Nutrition.UI\images\19-ayran.png"
                },

            };

                context.Foods.AddRange(foodList);
                context.SaveChanges();

                List<Meal> mealList = new List<Meal>()
            {
                new Meal
                {
                    Name = "Kahvaltı",
                    Sequence = 1
                },

                new Meal
                {
                    Name = "Öğle Yemeği",
                    Sequence = 2
                },

                new Meal
                {
                    Name = "Akşam Yemeği",
                    Sequence = 3
                },

                new Meal
                {
                    Name = "Ara Öğün",
                    Sequence = 4
                },
            };

                context.Meals.AddRange(mealList);
                context.SaveChanges();
            }
        }
    }
}
