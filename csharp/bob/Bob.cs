using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.ToUpperInvariant() == statement && statement.EndsWith('?') && statement.Any(char.IsLetter))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement.Any(char.IsLetter) && statement.ToUpperInvariant() == statement)
        {
            return "Whoa, chill out!";
        }
        else if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        else if (statement.Trim().EndsWith('?'))
        {
            return "Sure.";
        }
        else
            return "Whatever.";

    }
       
}