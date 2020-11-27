using System;
using System.Collections.Generic;
using System.Text;
using XamarinEmailCreationApp.Models;

namespace XamarinEmailCreationApp.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption Bars { get; set; }
        public MenuOption FineDining { get; set; }
        public MenuOption JunkFood { get; set; }
        public MenuOption SeaFood { get; set; }
        public MenuOption LocalFood { get; set; }
        public MenuOption HealthyFood { get; set; }

        public HomeViewModel()
        {
            Bars = new MenuOption()
            {
                Image = "restaurantIcon.png",
                Title = "Bars and discotheques",
                Places = "35 Places"
            };

            FineDining = new MenuOption()
            {
                Image = "restaurantIcon.png",
                Title = "Fine Dining",
                Places = "21 Places"
            };

            JunkFood = new MenuOption()
            {
                Image = "restaurantIcon.png",
                Title = "Junk Food",
                Places = "14 Places"
            };

            SeaFood = new MenuOption()
            {
                Image = "restaurantIcon.png",
                Title = "Fish & More",
                Places = "7"
            };

            LocalFood = new MenuOption()
            {
                Image = "restaurantIcon.png",
                Title = "Local Food",
                Places = "26 Places"
            };

            HealthyFood = new MenuOption()
            {
                Image = "restaurantIcon.png",
                Title = "Healthy Foods",
                Places = "11 Places"
            };
        }
    }
}
