// NOTE: THIS IS A STANDALONE FILE AND CAN BE USED IN ANY OTHER PROJECT WITH TINY MODIFICATIONS BUT IS PROTECTED UNDER GPL-v3.0 LICENSE, THIS IS HENCE NOT STRICTLY TIED INTO LYNOX. YOU ARE WELCOME :)

namespace SEF
{
    public static class ErrorHandling
    {
        public static void ShowError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SEF has halted with error: " + error);
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(-1);
        }
    }

    public static class SEF
    {
        public static Dictionary<string, string> storedHexValues = new();
        public static string[] availableRegisters = { "ax" };

        public static void prebyteToBinary(string prebyteCode)
        {
            if (prebyteCode.Split('\n')[0] != "#!$SEF")
            {
                ErrorHandling.ShowError("Invalid prebyte code header. [Error Code: 0x00]");
            }
            string[] prebyteCodeLines = prebyteCode.Split('\n');
            foreach (var line in prebyteCodeLines)
            {
                if (line.StartsWith("0x"))
                {
                    try
                    {
                        var num = Convert.ToInt32(line.Split('=')[0].Replace("0x", ""));
                        if (num < 64)
                        {
                            ErrorHandling.ShowError("Invalid memory value, already reserved by system. [Error Code: 0x01]");
                        }
                        storedHexValues.Add(line.Split('=')[0], line.Split('=')[1]);
                    }
                    catch (Exception)
                    {
                        ErrorHandling.ShowError("Invalid Memory Value/Referencing of Memory. [Error Code: 0x02]");
                    }
                } else if (line.StartsWith("#")) {
                  if (IsProperRegister(line.Split('=')[0])) {
                      
                  }
                }
            }
        }
        
        public static void IsProperRegister(string register) {
            if (register.)
        }
    }
}