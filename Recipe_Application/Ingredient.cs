using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    public class Ingredient
    {
        private string name = "";
        private double quantity = 0;
        private string unitOfMeasure = "";
        private int calories = 0;
        private string foodGroup = "";

        public string Name
        {
            get => name;
            set => name = value;
        }
        public double Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        public string UnitOfMeasure
        {
            get => unitOfMeasure;
            set => unitOfMeasure = value;
        }
        public int Calories
        { 
            get => calories;
            set => calories = value;
        }
        public string FoodGroup 
        { 
            get => foodGroup;
            set => foodGroup = value;
        }
    }
}
