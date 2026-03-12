using System;
using static System.Console;


// README.md를 읽고 아래에 코드를 작성하세요.


var conv = new Converter<string, int>( s => s.Length);
WriteLine(conv.Convert("Hello"));
