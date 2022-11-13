using System.Text.RegularExpressions;

namespace BlazorApp.Models
{
    internal static class FormHelper
    {
        public static IEnumerable<string> CheckPasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                yield return "Password is required!";
                yield break;
            }

            if (password.Length < 8)
                yield return "Password must be at least of length 8";
            if (!Regex.IsMatch(password, @"[A-Z]"))
                yield return "Password must contain at least one capital letter";
            if (!Regex.IsMatch(password, @"[a-z]"))
                yield return "Password must contain at least one lowercase letter";
            if (!Regex.IsMatch(password, @"[0-9]"))
                yield return "Password must contain at least one digit";
        }

        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
    }
}