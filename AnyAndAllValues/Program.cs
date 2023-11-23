List<int> lisInteri = new() { 1, 25, 11, 97, 53, 68 };

Console.WriteLine("I numeri della lista sono:\n");

lisInteri.Select(n => n % 2 == 0 ? $"{n}: Pari" :  $"{n}: Dispari").ToList().ForEach(n => Console.WriteLine(n));