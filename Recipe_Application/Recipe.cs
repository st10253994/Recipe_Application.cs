using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    public class Recipe : IComparable<Recipe>
    {
        private string name = "";
        private double quantityFactorValue = 1;
        public List<Ingredient> ingredients = [];
        private List<Step> steps = [];


        public string Name 
        { 
            get => name;
            set => name = value;
        }

        public List<Ingredient> Ingredients 
        { 
            get => ingredients;
            set => ingredients = value;
        }

        //gets quantity
        public double QuantityFactorValue
        {
            get
            {
                if (quantityFactorValue < 0)
                {
                    resetFactorValue();
                }
                return quantityFactorValue;
            }
            set => quantityFactorValue = value;
        }

        //gets steps
        internal List<Step> Steps 
        { 
            get => steps;
            set => steps = value;
        }

        //Displays a recipe
        public void displayRecipe()
        {
            try
            {
                RecipeDisplayTemplates.createRecipeDetails(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(RecipeConstants.ERROR_MESSAGE + ex.Message);
            }
        }

        public void resetFactorValue()
        {
            quantityFactorValue = 1;
        }

        //overrides default sort method
        public int CompareTo(Recipe recipe)
        {
            return this.name.CompareTo(recipe.name);
        }

        //get a total calorie count for a recipe
        public int totalCalorieCount()
        {
            int totalCalories = 0;
            for (int i = 0; i < ingredients.Count; i++)
            {
               totalCalories += Convert.ToInt32(Math.Abs(ingredients[i].Calories) * QuantityFactorValue);
            }
            return totalCalories;
        }

    }
}
