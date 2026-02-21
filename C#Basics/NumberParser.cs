namespace C_Basics
{
    public class NumberParser
    {
        public string phoneNumber { get; set; }

        public NumberParser(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        private bool CheckValidPhoneNumber(string phoneNumber)
        {
            bool isNumber = int.TryParse(phoneNumber, out int result);
            bool isValid = isNumber &&  phoneNumber.Length == 10;

            //if (phoneNumber != "" || phoneNumber != null || phoneNumber.Replace(" ", "").Length == 10)
            //{
            //    return true;
            //}
            return isValid;
        }

        //read the description of the task!! this needs to split the string
        public void Parse( string number)
        {

            //if (CheckValidPhoneNumber(phoneNumber))
            //{
            //    return phoneNumber.Insert(0, "(").Insert(4, ")").Insert(8, "-");
            //}
            //else
            //{
            //    return "Invalid Number";
            //}
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
