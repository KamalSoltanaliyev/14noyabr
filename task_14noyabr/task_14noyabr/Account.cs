namespace task_14noyabr
{
    public class Account
    {
        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsNumber))
            {
                return false;
            }
            return true;
        }
    }
}

