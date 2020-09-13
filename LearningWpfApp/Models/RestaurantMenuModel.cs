using System;
using System.Collections.Generic;
using System.Text;

namespace LearningWpfApp.Models
{
    public class RestaurantMenuModel
    {
        private List<DishModel> _restaurantMenu = new List<DishModel>
        {
            new DishModel
            {
                Name = "Pierś z kaczki",
                Price = 37.90M
            },
            new DishModel
            {
                Name = "Mortadella ze śliwą pod okiem",
                Price = 17.90M
            },
            new DishModel
            {
                Name = "Straganow na targowisku",
                Price = 23.90M
            },
            new DishModel
            {
                Name = "Pieczone żeberka",
                Price = 34.90M
            },
            new DishModel
            {
                Name = "Łosoś",
                Price = 32.30M
            },
            new DishModel
            {
                Name = "Zupa pomidorowa",
                Price = 8.60M
            },
            new DishModel
            {
                Name = "Szarlotka",
                Price = 12.80M
            },
            new DishModel
            {
                Name = "Kawa",
                Price = 7.70M
            },
            new DishModel
            {
                Name = "Zielona herbata",
                Price = 4.50M
            },
            new DishModel
            {
                Name = "Wódzia",
                Price = 11.50M
            },
            new DishModel
            {
                Name = "Napój gazowany",
                Price = 8.90M
            }
        };

        public List<DishModel> RestaurantMenu
        {
            get { return _restaurantMenu; }
            set
            {
                if (value != null)
                    _restaurantMenu = value;
            }
        }
    }
}
