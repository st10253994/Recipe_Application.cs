using System;
using System.Runtime.CompilerServices;
using Recipe_Application;

namespace Recipe_ApplicationTests
{
    public class RecipeTest
    {

        Recipe recipe = new Recipe();
        [Fact]
        public void totalCalorieCount_OK()
        {
            //Arrange
            recipe.Name = "Test";
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient());
            ingredients[0].Calories = 300;

            recipe.Ingredients = ingredients;

            //Act
            int calories = recipe.totalCalorieCount();
            
            //Assert
            Assert.Equal(300,calories);
        }

        [Fact]
        public void totalCalorieCount_HandleNegativeCalorie()
        {
            //Arrange
            recipe.Name = "Test";
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient());
            ingredients[0].Calories = 300;
            ingredients.Add(new Ingredient());
            ingredients[1].Calories = -200;

            recipe.Ingredients = ingredients;

            //Act
            int calories = recipe.totalCalorieCount();

            //Assert
            Assert.Equal(500, calories);
        }
    }
}