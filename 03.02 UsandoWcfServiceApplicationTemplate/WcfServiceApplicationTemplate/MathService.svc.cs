namespace WcfServiceApplicationTemplate
{
    public class MathService : IMathService
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Divide(int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Substract(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
