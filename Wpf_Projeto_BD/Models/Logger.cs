using System;
using System.IO;

public static class Logger
{
    public static void LogError(Exception ex)
    {
        File.AppendAllText("erros.log", $"{DateTime.Now}: {ex}\n");
    }
}