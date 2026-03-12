using System;
using static System.Console;


// README.md를 읽고 아래에 코드를 작성하세요.


var conv1 = new Converter<string, int>( s => s.Length);
var conv2 = new Converter<int, string>(s => s.ToString());
var conv3 = new Converter<double, int>(s => (int)s);

string[] strings = new string[] {"Hello", "world", "C#"};
int[] numbers = new int[] { 1, 2, 3 };
double[] doubles = new double[] { 3.14, 1.2, 9.9 };

WriteLine("=== 문자열 -> 길이 변환 ===");
WriteLine($"Hello -> {conv1.Convert("Hello")}");
WriteLine($"전체 변환: {string.Join(", ",(conv1.ConvertAll(strings)))}"); 
WriteLine();
WriteLine("=== 정수 -> 문자열 변환 ===");
WriteLine($"1 -> {conv2.Convert(1)}번");
WriteLine($"전체 변환: {string.Join("번, ", (conv2.ConvertAll(numbers)))}번");
WriteLine();
WriteLine("=== 실수 -> 문자열 변환 ===");
WriteLine($"3.7 -> {conv3.Convert(3.7)}");
WriteLine($"전체 변환: {string.Join(", ", (conv3.ConvertAll(doubles)))}");
