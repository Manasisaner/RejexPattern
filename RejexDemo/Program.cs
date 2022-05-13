// See https://aka.ms/new-console-template for more information
namespace RejexDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            String pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$";
            string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string pincode = "^[0-9]{3}[]*[0-9]{3}$";
            string[] pinCodeArr = { "422010", "412109", "400820", "1452" };
            program p = new Program();
            p.ValidateConseqCharacter(inputs, pattern);
            Console.WriteLine();
            p.ValidPincode(pinCodeArr, pincode);
            Console.Read();
        }

    }

}
