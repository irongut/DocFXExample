namespace DocFXExample
{
    public static class Example
    {
        public static (int quotient, int remainder) Divide(int dividend, int divisor)
        {
            return (dividend / divisor, dividend % divisor);
        }
    }
}
