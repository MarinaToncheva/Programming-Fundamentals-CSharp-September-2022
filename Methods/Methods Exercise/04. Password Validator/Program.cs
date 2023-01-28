namespace _04._Password_Validator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword =Console.ReadLine();
            bool isLengthValid = IsPasswordLengthValid(inputPassword);
            bool isPasswordAlphaNumeric = IsPasswordAlphaNumeric(inputPassword);
            bool hasTwoDigits = IsPasswordContainingAtLeastTwoDigits(inputPassword);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid&&isPasswordAlphaNumeric&&hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
       
        }
        static bool IsPasswordLengthValid(string password)//Връща да или не
        {
            bool isValid=password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
                
            }
            return true;
        }
        static bool IsPasswordContainingAtLeastTwoDigits(string password)
        {
            int digitsCnt = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCnt++;
                }
            }
            return digitsCnt >= 2;
        }
    }
}
