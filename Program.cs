using System;

namespace SEF {
  public static class Testing {
    public static void Main(string[] args) {
      string prebyteCode = """
      #!\$SEF
      0x64=Hello World
      #ax=0x9
      #bx=0x0
      #cx=0x64
      *0x0
      """;
    }
  }
}