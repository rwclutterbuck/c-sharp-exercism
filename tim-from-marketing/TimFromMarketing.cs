using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idFormat = (id == null) ? "" : $"[{id}] - ";
        string departmentFormat = department?.ToUpper() ?? "OWNER"; 
        
        return  $"{idFormat}{name} - {departmentFormat}";
    }
}
