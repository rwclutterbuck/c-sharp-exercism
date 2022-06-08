using System;

static class LogLine
{
    public static string Message(string logLine) =>
        logLine.Split(null, 2)[1].Trim();

    public static string LogLevel(string logLine) =>
        logLine[1..logLine.IndexOf(']')].ToLower();

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
