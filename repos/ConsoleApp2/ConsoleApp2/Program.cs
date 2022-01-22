using System;

namespace ConsoleApp2
{

    namespace mps
    {
        class SampleProgram
        {
            static void Main(string[] args)
            {
                String s1 = "abcdefghoijklmnopqrstuvwxyz";
                Console.Write(s1.IndexOf('c') + " ");
                Console.Write(s1.Length);
            }
        }
    }
}