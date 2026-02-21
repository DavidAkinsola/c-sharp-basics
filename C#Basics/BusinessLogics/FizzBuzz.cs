namespace C_Basics.BusinessLogics
{
    public class FizzBuzz
    {
        public int Value { get; set; }
        public FizzBuzz(int value)
        {
            this.Value = value;
        }

        public string Solve()
        {
            string result = string.Empty;

            if (Value % 3 == 0)
            {
                result += "Fizz";
            }
            if (Value % 5 == 0)
            {
                result += "Buzz";
            }

            return result == string.Empty ? Value.ToString() : result;

        }
    }
}
