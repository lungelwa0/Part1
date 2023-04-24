using System;
using System.Collections;

class Program
{
     class Recipe
    {
        double scale;
        int Select, option, count = 0, ingredientNum, numberOfSteps, opt, temp;
        string[] recipe_Name = new string[9];
        string[,] ingredient_Name = new string[9,9];
        double[,] ingredient_Quantity = new double[9,9];
        int[,] ingredient_UnitOfMeasurement = new int[9,9];
        string[,] ingredient_Steps = new string[9,9];
        int[,] recipeSteps = new int[9,9];  



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
            string name = Console.ReadLine();
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
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\n******" + recipe_Name[i]+"******\n");
                Console.WriteLine("Ingredient List: ");
                for (int j = 0; j < ingredientNum; j++)
                {
                    Console.WriteLine((j+1)+"."+" (" + ingredient_Quantity[i,j] +") " + ingredient_UnitOfMeasurement[i,j] +"ml/g "+ingredient_Name[i,j]);
                    }
                Console.WriteLine("\nSTEPS:");
                for (int j = 0; j < recipeSteps[i,i]; j++)
                {
                    Console.WriteLine("Step " + (j + 1) + ": " + ingredient_Steps[i, j]);
                }
            }   
        }
        void scaleUpRecipe()
        {
            Console.WriteLine("\nSelect Recipe: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("(" + (i+1) + ") " + recipe_Name[i]);
            }
            opt = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("\n(1) By Half\n(2) Double Servings\n(3) Triple Servings");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                scale = 0.5;
                ingredient_Quantity[opt, opt] = temp;
                ingredient_Quantity[opt, opt] *= scale;
            }else if (choice == 2)
            {
                scale = 2;
                ingredient_Quantity[opt, opt] = temp;
                ingredient_Quantity[opt, opt] *= scale;
            }
            else if (choice == 3) {
                scale = 3;
                ingredient_Quantity[opt, opt] = temp;
                ingredient_Quantity[opt, opt] *= scale;
            }
            else
            {
                scale = 1;
            }
            
        }
        void reset()
        {

        }
        void deleteRecipe()
        {

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

                }
                if (Select.Equals(5))
                {

                }
            }
        }
    }
    static void Main(string[] args)
    {
        Recipe run = new Recipe();
        run.app();
    }   
}
 