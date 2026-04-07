namespace App
{
    public class Calculator
    {
        public int Result {get; private set;}
        
        public void Sum(int first, int second)
        {
            Result = first + second;
        }
    }
}