using System;
using System.Collections;

class Program
{
     class Recipe
    {
        int Select, option, count = 0, ingredientNum, numberOfSteps, temp;
        ArrayList ingredient_Steps = new ArrayList();
        ArrayList ingredient_Name = new ArrayList();
        int[,] temp_Quantity = new int[9, 9];
        ArrayList ingredient_Quantity = new ArrayList();
        ArrayList ingredient_UnitOfMeasurement = new ArrayList();
        int menu()
        {
            Console.WriteLine("\n--MENU--");
            Console.WriteLine("(1) Enter details of a single recipe\n" +
                "(2) Display recipes\n" +
                "(3) Increase serving of a recipe\n" +
                "(4) Reset serving of a recipe\n" +
                "(5) Delete a recipe\n" +
                "(6) Exit Application");
            Console.Write("\nSelect Option: ");
            Select = Convert.ToInt32(Console.ReadLine());
            return Select;
        }
        void addRecipe()
        {
            Console.WriteLine("Enter Number of Ingredients Recipe Has: ");
            ingredientNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ingredientNum; i++)
            {
                Console.Write("Enter Ingredient Name: ");
                string ingredientName = Console.ReadLine();
                ingredient_Name.Add(ingredientName);
                Console.Write("Enter Ingredient Quantity: ");
                int ingredientQuantity = Convert.ToInt32(Console.ReadLine());
                ingredient_Quantity.Add(ingredientQuantity);
                temp = ingredientQuantity;
                Console.Write("Enter Unit of Measurement for Ingredient: ");
                string ingredientUnitOfMeasurement = Console.ReadLine();
                ingredient_UnitOfMeasurement.Add(ingredientUnitOfMeasurement);
                Console.WriteLine();
            }
            Console.WriteLine("\n******Ingredient Detail Successfully Saved!******\n" +
                        "Enter number of Steps for Recipe: ");
            numberOfSteps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description of Each Step.");
            for (int j = 0; j < numberOfSteps; j++)
            {
                Console.Write("Step " + (j+1) + ": ");
                string ingredientSteps = Console.ReadLine();
                ingredient_Steps.Add(ingredientSteps);
            }
            Console.WriteLine("\n******Recipe Steps Successfully Saved!******\n");
            count++;
        }
        void showRecipe()
        {
            if (count != 0)
            {
                Console.WriteLine("\n****** Ingredient List ******\n");
                for (int i = 0; i < ingredientNum; i++)
                {
                    Console.WriteLine((i + 1) + "." + " (" + ingredient_Quantity[i] + ") " + ingredient_UnitOfMeasurement[i] + " of "+ ingredient_Name[i]);
                }
                Console.WriteLine("\nSTEPS:");
                for (int i = 0; i < ingredient_Steps.Count; i++)
                {
                    Console.WriteLine("Step " + (i + 1) + ": " + ingredient_Steps[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n******NO RECIPE SAVES******\n");
            }
        }
        void scaleUpRecipe()
        {
            Console.WriteLine("\nScale Up By:");
            Console.WriteLine("\n(1) Half\n(2) Double \n(3) Triple ");
            Console.Write("\nSelect Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < ingredient_Quantity.Count; i++)
                {
                    ingredient_Quantity[i] = temp * 0.5;
                }
            }
            else if (choice == 2)
            {
                for (int i = 0; i < ingredient_Quantity.Count; i++)
                {
                    ingredient_Quantity[i] = temp * 2;
                }
            }
            else if (choice == 3) {
                for (int i = 0; i < ingredient_Quantity.Count; i++)
                {
                    ingredient_Quantity[i] = temp * 3;
                }
            }
            Console.WriteLine("\n******Recipe Scale Successfully Updated!******\n");
        }
        void reset()
        {
            for (int i = 0; i < ingredient_Quantity.Count; i++)
            {
                ingredient_Quantity[i] = temp;
            }
            Console.WriteLine("\n*****Reset was Successful!*****\n");
        }
        void deleteRecipe()
        {
            for (int j = 0; j < 9; j++)
            {
                ingredient_Name.Clear();
                ingredient_Quantity.Clear();
                ingredient_Steps.Clear();
                ingredient_UnitOfMeasurement.Clear();
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
            Console.WriteLine("RECIPE CONSOLE APPLICATION\n"
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
 
