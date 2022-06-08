using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string pattern) =>
        log.Substring(log.IndexOf(pattern) + pattern.Length);

    public static string SubstringBetween(
        this string log, 
        string firstPattern, 
        string secondPattern
        )
    {
        int firstIndex = log.IndexOf(firstPattern) + firstPattern.Length;
        int secondIndex = log.IndexOf(secondPattern);
        return log.Substring(firstIndex, secondIndex - firstIndex);
    }
    
    public static string Message(this string log) => 
        log.SubstringAfter(":").Trim();
        
    public static string LogLevel(this string log) =>
        log.SubstringBetween("[", "]");
}