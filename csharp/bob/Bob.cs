using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement[statement.Length - 1] == '?' && !statement.Any(c => Char.IsLetter(c)))
        {
            return "Sure.";
        }
        else if (statement[statement.Length - 1] == '?' && statement.ToUpperInvariant() == statement)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement[statement.Length - 1] == '!' && statement.Any(i => char.IsDigit(i)))
        {
            return "Whoa, chill out!";
        }
        else if (statement[statement.Length - 1] == '?')
        {
            return "Sure.";
        }
        else if (statement.Any(c => Char.IsDigit(c) && statement.Any(i => !Char.IsLetter(i))))
        {
            return "Whatever.";
        }
        else if (statement.ToUpperInvariant() == statement && Regex.IsMatch(statement, @"[a-zA-Z]"))
        {
            return "Whoa, chill out!";
        }
        else if (statement[statement.Length - 1] == '?')
        {
            return "Sure.";
        }
        else if (statement.Any(i => char.IsDigit(i)))
        {
            return "Sure.";
        }
        else if (Regex.IsMatch(statement, @"[%^*@#$]"))
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever."; 
        }

    }
       
}