using static System.Console;
public class MathMethods
{ 
    public static void Main()
    {
        WriteLine("Module 1 Competency Exercise: Math Methods by James Sales");
        Write("\nEnter an integer: ");
        int firstInt = int.Parse(ReadLine());
        Write("Enter another integer: ");
        int secondInt = int.Parse(ReadLine());
        doMath(firstInt, secondInt);
        Write("\nEnter a double: ");
        double firstDouble = double.Parse(ReadLine());
        Write("Enter another double: ");
        double secondDouble = double.Parse(ReadLine());
        doMath(firstDouble, secondDouble);

        WriteLine("\nPress a key to continue . . .");
        ReadKey();
    }
    //method for doing math with ints
    static void doMath(int firstNum, int secondNum)
    {
        int average(int firstNum, int secondNum) => (firstNum + secondNum) / 2;
        int perimeter(int firstNum, int secondNum) => (firstNum * 2) + (secondNum * 2);
        void total(int firstNum, int secondNum)
        {
            WriteLine($"Integer total: {firstNum + secondNum}");
        }
        void area(int firstNum, int secondNum)
        {
            WriteLine($"Integer area: {firstNum * secondNum}");
        }
        //call total void method
        total(firstNum, secondNum);
        //call average expression-bodied method
        WriteLine($"Integer average: {average(firstNum, secondNum)}");
        //call perimeter expression-bodied method
        WriteLine($"Integer perimeter: {perimeter(firstNum, secondNum)}");
        //call area void method
        area(firstNum, secondNum);
    }
    //Method for doing math with doubles
    static void doMath(double firstNum, double secondNum)
    {
        double average(double firstNum, double secondNum) => (firstNum + secondNum) / 2;
        double perimeter(double firstNum, double secondNum) => (firstNum * 2) + (secondNum * 2);
        void total(double firstNum, double secondNum)
        {
            WriteLine($"Double total: {firstNum + secondNum}");
        }
        void area(double firstNum, double secondNum)
        {
            WriteLine($"Double area: {firstNum * secondNum}");
        }
        //call total void method
        total(firstNum, secondNum);
        //call average expression-bodied method
        WriteLine($"Double average: {average(firstNum, secondNum)}");
        //call perimeter expression-bodied method
        WriteLine($"Double perimeter: {perimeter(firstNum, secondNum)}");
        //call area void method
        area(firstNum, secondNum);
    }   
}