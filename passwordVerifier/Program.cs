namespace passwordVerifier;

public static class PasswordChecker
{
    static int MinPasswordLength = 9;
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the Password");
        string password = Console.ReadLine();
        VerifyPassword(password);
    }
    public static string VerifyPassword(string password)
    {
        try
        {
            if (password.Length < MinPasswordLength)
            {
                throw new Exception("The password is less than 8 digits");
            }

            else if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("The password cannot be null");
            }

            else if (!password.Any(char.IsDigit))
            {
                throw new Exception("The password should have atleast one digit");
            }
            else if (!password.Any(char.IsUpper))
            {
                throw new Exception("The password should contain uppercase");
            }
            else if (!password.Any(char.IsLower))
            {
                throw new Exception("The password should contain lower case");

            }
            //Console.WriteLine("The password is valid");
            return "The password is valid";
        }

        catch (Exception e)
        {
            //Console.WriteLine(e.Message);
            return e.Message;
        }
    }
}