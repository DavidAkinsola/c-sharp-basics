namespace C_Basics.BusinessLogics
{
    public class NumberParser
    {
        public string AreaCode { get; private set; }
        public string CentralOfficeCode { get; private set; }
        public string LineNumber { get; private set; }


        private bool CheckValidPhoneNumber(string phoneNumber)
        {
            bool isNumber = long.TryParse(phoneNumber, out long result);
             
            return isNumber && phoneNumber.Length == 10;
        }

        //read the description of the task!! this needs to split the string
        public void Parse(string number)
        {
            
            if (!CheckValidPhoneNumber(number))
                throw new ArgumentException("Invalid phone number");

            AreaCode = number.Substring(0, 3);
            CentralOfficeCode = number.Substring(3, 3);
            LineNumber = number.Substring(6, 4);            
        }

        public override string ToString()
        {
            return $"({AreaCode}){CentralOfficeCode}-{LineNumber}";            
        }
    }
}
