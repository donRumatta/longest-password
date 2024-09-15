using System.Text.RegularExpressions;

namespace LongestPassword;

public static class PasswordValidator
{
    public static int GetLongestValidLength(string passwordsString)
    {
        var passwords = passwordsString.Split(' ');
        var validPasswords = passwords.Where(IsValid);

        return validPasswords.Any() ? validPasswords.Select(x => x.Length).Max() : -1;
    }

    private static bool IsValid(string password)
    {
        var regex = new Regex("^[a-zA-Z0-9]*$");
        if (!regex.IsMatch(password))
        {
            return false;
        }

        if (password.Count(char.IsAsciiDigit) % 2 == 0)
        {
            return false;
        }

        if (password.Count(char.IsAsciiLetter) % 2 == 1)
        {
            return false;
        }

        return true;
    }
}