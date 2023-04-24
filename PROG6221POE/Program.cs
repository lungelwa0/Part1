using System;
using System.Collections;

class Program
{
     class Recipe
    {
        int Select, option, count = 0, ingredientNum, numberOfSteps;
        string[] recipe_Name = new string[9];
        string[,] ingredient_Name = new string[9,9];
        double[,] ingredient_Quantity = new double[9,9];
        int[,] ingredient_UnitOfMeasurement = new int[9,9];
        string[,] ingredient_Steps = new string[9,9];
        int[,] recipeSteps = new int[9,9];
        int[,] temp_Quantity = new int[9, 9];


        int menu()
        {
            System.Console.WriteLine("(1) Enter details of a single recipe\n" +
                "(2) Display recipes\n" +
                "(3) Increase serving of a recipe\n" +
                "(4) Reset serving of a recipe\n" +
                "(5) Delete a recipe\n" +
                "(6) Exit Application");
            System.Console.Write("Select Option: ");
            Select = Convert.ToInt32(Console.ReadLine());
            return Select;
        }
        void addRecipe()
        {
            Console.Write("\nEnter Recipe Name: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            recipe_Name[count] = name;
            Console.WriteLine("Enter Number of Ingredients Recipe Has: ");
            ingredientNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ingredientNum; i++)
            {
                System.Console.Write("Enter Ingredient Name:");
                string ingredientName = Console.ReadLine();
                ingredient_Name[count,i] = ingredientName;
                Console.Write("Enter Ingerdient Quantity: ");
                int ingredientQuantity = Convert.ToInt32(Console.ReadLine());
                ingredient_Quantity[count, i] = ingredientQuantity;
                temp_Quantity[count,i] = ingredientQuantity;
                System.Console.Write("Enter Unit of Measurement for Ingredient: ");
                int ingredientUnitOfMeasurement = Convert.ToInt32(Console.ReadLine());
                ingredient_UnitOfMeasurement[count, i] = ingredientUnitOfMeasurement;
            }
            Console.WriteLine("\n******Ingredient Detail Successfully Saved!******\n" +
                        "Enter number of Steps for Recipe: ");
            numberOfSteps = Convert.ToInt32(Console.ReadLine());
            recipeSteps[count, count] = numberOfSteps;
            Console.WriteLine("Enter Description of Each Step.");
            for (int j = 0; j < numberOfSteps; j++)
            {
                Console.Write("Step " + (j+1) + ": ");
                string ingredientSteps = Console.ReadLine();
                ingredient_Steps[count, j] = ingredientSteps;

            }
            Console.WriteLine("\n******Recipe Steps Successfully Saved!******\n");
            count++;
        }
        void showRecipe()
        {
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\n******" + recipe_Name[i] + "******\n");
                    Console.WriteLine("Ingredient List: ");
                    for (int j = 0; j < ingredientNum; j++)
                    {
                        Console.WriteLine((j + 1) + "." + " (" + ingredient_Quantity[i, j] + ") " + ingredient_UnitOfMeasurement[i, j] + "ml/g " + ingredient_Name[i, j]);
                    }
                    Console.WriteLine("\nSTEPS:");
                    for (int j = 0; j < recipeSteps[i, i]; j++)
                    {
                        Console.WriteLine("Step " + (j + 1) + ": " + ingredient_Steps[i, j]);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n******NO RECIPE SAVES******\n");
            }
        }
        void scaleUpRecipe()
        {
            Console.WriteLine("\nSelect Option:");
            Console.WriteLine("\n(1) By Half\n(2) Double Servings\n(3) Triple Servings");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < ingredient_Quantity.GetLength(0); i++)
                {
                    for( int j = 0; j < ingredient_Quantity.GetLength(1); j++)
                    {
                        ingredient_Quantity[i, j] *= 0.5;
                    } 
                }
            }
            else if (choice == 2)
            {
                for (int i = 0; i < ingredient_Quantity.GetLength(0); i++)
                {
                    for (int j = 0; j < ingredient_Quantity.GetLength(1); j++)
                    {
                        ingredient_Quantity[i, j] *= 2;
                    }
                }
            }
            else if (choice == 3) {
                for (int i = 0; i < ingredient_Quantity.GetLength(0); i++)
                {
                    for (int j = 0; j < ingredient_Quantity.GetLength(1); j++)
                    {
                        ingredient_Quantity[i, j] *= 3;
                    }
                }
            }
        }
        void reset()
        {
            for (int i = 0; i < ingredient_Quantity.GetLength(0); i++)
            {
                for (int j = 0; j < ingredient_Quantity.GetLength(1); j++)
                {
                    ingredient_Quantity[i, j] = temp_Quantity[i, j];
                }
            }
            Console.WriteLine("\n*****Reset was Successful!*****\n");
        }
        void deleteRecipe()
        {
            for (int i = 0; i < recipe_Name.GetLength(0); i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    ingredient_Name[i, j] = "";
                    ingredient_Quantity[i, j] = 0;
                    ingredient_Steps[i, j] = "";
                    ingredient_UnitOfMeasurement[i,j] = 0;
                }
                recipe_Name[i] = "";
            }
            count = 0;
            Console.WriteLine("\n******Recipe Succesfully Deleted!******\n");
        }
        void exit()
        {
            Console.WriteLine("\n********************************************************************\n"
                + "Thank you for using our services.\n"
                + "********************************************************************");
        }
        int welcome()
        {
            Console.WriteLine("RECIPE LOGBOOK APPLICATION\n"
                        + "********************************************************************\n"
                        + "Enter (1) to launch menu or any other key to exit");

            option = Convert.ToInt32(Console.ReadLine()); 
            return option;
        }
        public void app()
        {
            welcome();
            if (option != 1)
            {
                exit();
            }
            else { 
                menu();
                while (Select.Equals(1) || Select.Equals(2) || Select.Equals(3) || Select.Equals(4) || Select.Equals(5))
                {
                    if (Select.Equals(1))
                    {
                        addRecipe();
                        menu();
                    }
                    if (Select.Equals(2))
                    {
                        showRecipe();
                        menu();
                    }
                    if (Select.Equals(3))
                    {
                        scaleUpRecipe();
                        menu();
                    }
                    if (Select.Equals(4))
                    {
                        reset();
                        menu();
                    }
                    if (Select.Equals(5))
                    {
                        deleteRecipe();
                        menu();
                    }
                }
                exit();
            }
        }
    }
    static void Main(string[] args)
    {
        Recipe run = new Recipe();
        run.app();
    }   
}
 
