using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft_Learn
{
    internal class StringInterpolationExcercise
    {
        string name = "Bob";
        int messages = 3;
        decimal temperature = 34.4m;

        Console.Write($"Hello, {name}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");
    }
}
