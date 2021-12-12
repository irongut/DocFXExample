namespace DocFXExample
{
    /// <summary>A simple example class with one method which divides two numbers.</summary>
    public static class Example
    {
        /// <summary>Divides the specified dividend by the divisor, returning the quotient and the remainder as a Tuple.</summary>
        /// <param name="dividend">The dividend - the number which will be divided by the divisor.</param>
        /// <param name="divisor">The divisor - the number by which the dividend will be divided.</param>
        /// <returns>(quotient, remainder)</returns>
        public static (int quotient, int remainder) Divide(int dividend, int divisor)
        {
            return (dividend / divisor, dividend % divisor);
        }
    }
}
