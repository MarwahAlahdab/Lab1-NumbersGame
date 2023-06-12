internal class Program
{
    static void Main(string[] args)
    {


        try
        {

            StartSequence();
        }

        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong ! " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program completed.");
        }
    }


    private static void StartSequence()
    {

        try
        {

            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Enter a number greater than zero:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Populate(arr);
            int sum = GetSum(arr);
            int product = GetProduct(arr, sum);

            decimal quotient = GetQuotient(product);


            Console.WriteLine($"Your array size : {size}");
            Console.Write($"Numbers in the array are ");



            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i == arr.Length - 1)
                    break;
                Console.Write(",");

            }
            Console.WriteLine();

            Console.WriteLine($"The sum of the array is {sum}");



            Console.WriteLine(product);
            Console.WriteLine(quotient);
        }



        catch (FormatException ex)
        {
            Console.WriteLine("Input format is wrong, please try again ! " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Try a lower number !" + ex.Message);
        }

    }






    private static int[] Populate(int[] arr)
    {


        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Please enter number: {i + 1} of {arr.Length}");
            string input = Console.ReadLine();
            arr[i] = Convert.ToInt32(input);
        }


        return arr;

    }




    private static int GetSum(int[] arr)
    {


        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        if (sum < 20)
        {
            throw new Exception($"Value of {sum} is too low");

        }

        return sum;
    }









    private static int GetProduct(int[] arr, int sum)
    {

        Console.WriteLine($"Please select a random number between 1 and {arr.Length}");
        int randNum = Convert.ToInt32(Console.ReadLine());
        try
        {

            int product = sum * arr[randNum];
            return product;
        }
        catch (IndexOutOfRangeException ex)
        {
            throw new IndexOutOfRangeException("Invalid index. The array length is " + arr.Length + ".", ex);
        }


    }





    private static decimal GetQuotient(int product)
    {


        Console.WriteLine($"Please enter a number to devide your product {product} by");

        decimal num = Convert.ToDecimal(Console.ReadLine());

        try
        {

            decimal quotient = decimal.Divide(product, num);

            return quotient;
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return 0;
        }

    }








}
