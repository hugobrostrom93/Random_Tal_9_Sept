// ReSharper disable All
Console.WriteLine("Random!");


// Seed hämtar en lista av tal, specifik tal ger samma lista varje gång
// Random slumpTal = new(15); -> Då blir varje gång du kallar på den samma svar
Console.WriteLine("Seed 15 = parametern blir samma varje gång efter första gången!");
Random slumpTal = new(15);
Console.WriteLine(slumpTal.Next());
Console.WriteLine(slumpTal.Next());
Console.WriteLine(slumpTal.Next());

// Om du vill få olika tal varje gång
Console.WriteLine("Parametern blir random blir varje gång!");
Random slump = new();
Console.WriteLine(slump.Next());


// Slumptal mellan 1-20
Console.WriteLine("Talet blir mellan 1-20!");
Console.WriteLine(slump.Next(1, 20));

// Slumptal mellan 0 och parameter -1 ( Alltså tal mellan 0 och 100 i fallet nedan )
Console.WriteLine("Slumptal mellan 0 och parameter -1");
Console.WriteLine(slump.Next(101));

// Slumptal mellan 0 och 1 ( Alltså ett decimal tal )
Console.WriteLine("Slumptal mellan 0 och 1 ( Alltså ett decimal tal )");
Console.WriteLine(slump.NextDouble());


Console.WriteLine(slump.Next(50, 101)); // Tal mellan 50 - 100
Console.WriteLine(slump.Next(101)); // Tal mellan 0 och 100
Console.WriteLine(slump.NextDouble()); // Tal mellan 0 och 1