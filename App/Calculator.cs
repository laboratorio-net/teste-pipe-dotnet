namespace App
{
    public class Calculator
    {
        public int Result {get; private set;}
        
        public void Sum(int first, int second)
        {
            Result = first + second;
        }

        public void Sum(params int[] numbers)
        {
            Result = numbers.Sum();
        }

        public void Subtract(int first, int second)
        {
            Result = first - second;            
        }
    }
}