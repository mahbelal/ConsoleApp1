using System;

namespace ConsoleApp1
{
    public class Quine
    {
        public static string Esc(string code)
        {
            return code.Replace("\n","\\n\" + \"");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(code + Esc(code) + ";\n   }\n}");
        }

        public static string code = "using System;\n" + "\n" + "namespace ConsoleApp1\n" + "{\n" + "   public class Quine\n" +
                                    "   {\n" + "      public static string Esc(string code)\n" + "      {\n" +
                                    "         return code.Replace(\"\\n\",\"\\\\n\\\" + \\\"\");\n" + "      }\n" + "\n" +
                                    "      public static void Main(string[] args)\n" + "      {\n" +
                                    "         Console.WriteLine(code + Esc(code) + \";\\n   }\\n}\");\n" + "      }\n" +
                                    "\n" + "      public static string code = \"";
    }
}
