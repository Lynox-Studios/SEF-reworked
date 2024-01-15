// NOTE: THIS IS A STANDALONE FILE AND CAN BE USED IN ANY OTHER PROJECT WITH TINY MODIFICATIONS BUT IS PROTECTED UNDER GPL-v3.0 LICENSE, THIS IS HENCE NOT STRICTLY TIED INTO LYNOX. YOU ARE WELCOME :)

namespace SEF {
  public static class ErrorHandling {
    public static void ShowError(string error) {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("SEF has halted with error: " + error);
      Console.ForegroundColor = ConsoleColor.White;
      Environment.Exit(0);
    }
  }

  public static class SEF {
    public static Dictionary<string, string> storedHexValues = new();

    public static void prebyteToBinary(string prebyteCode) {
      if (prebyteCode.Split('\n')[0] != "#!$SEF") {
        ErrorHandling.ShowError("Invalid prebyte code header. [Error Code: 0x00]");
      }
    }
  }
}