using System;
using static System.Console;

// README.md를 읽고 아래에 코드를 작성하세요.



SimpleQueue<int> intq1= new SimpleQueue<int>(3);
SimpleQueue<string> intq2 = new SimpleQueue<string>(2);

intq1.Enqueue(10);
intq1.Enqueue(20);
intq1.Enqueue(30);

WriteLine("=== int 큐 (용량: 3) ===");
WriteLine($"Enqueue: 10, 20, 30");
WriteLine($"Count: {intq1.Count}, IsFull: {intq1.IsFull}");
intq1.Enqueue(20);
WriteLine($"Peek: {intq1.Peek()}");
WriteLine($"Dequeue: {intq1.Dequeue()}");
WriteLine($"Dequeue: {intq1.Dequeue()}");
WriteLine($"Count: {intq1.Count}, IsFull: {intq1.IsFull}");
WriteLine();
WriteLine("=== string 큐 (용량: 2) ===");
WriteLine($"Enqueue: Hello, World");
intq2.Enqueue("Hello");
intq2.Enqueue("World");
WriteLine($"Dequeue: {intq2.Dequeue()}");
WriteLine($"Dequeue: {intq2.Dequeue()}");
intq2.Dequeue();
WriteLine($"Dequeue:");
WriteLine($"IsEmpty: {intq2.IsEmpty}");