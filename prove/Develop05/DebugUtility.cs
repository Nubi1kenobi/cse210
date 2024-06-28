using System;
using System.IO;

public class DebugUtility
    {
        private static readonly string logFilePath = "debug.log"; // Example log file path

        public static void Debug()
            {
                Console.WriteLine("Debug();");
                Log("Debug();");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        public static void Debug(bool parameter)
            {
                Console.WriteLine($"Debug(bool parameter); {parameter}");
                Log($"Debug(bool parameter); {parameter}");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        public static void Debug(string parameter)
            {
                Console.WriteLine($"Debug(string parameter); {parameter}");
                Log($"Debug(string parameter); {parameter}");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        public static void Debug(int parameter)
            {
                Console.WriteLine($"Debug(int parameter); {parameter}");
                Log($"Debug(int parameter); {parameter}");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        private static void Log(string message)
            {
                try
                    {
                        using (StreamWriter writer = new StreamWriter(logFilePath, true))
                            {
                                writer.WriteLine($"[{DateTime.Now}] {message}");
                            }
                    }
                catch (Exception ex)
                    {
                        Console.WriteLine($"Error while logging: {ex.Message}");
                    }
            }
    }
