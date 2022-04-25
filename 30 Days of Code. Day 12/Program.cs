using Day12;

Student s = new("Sancho", "Panza", 4847677, new int[] { 41, 42, 43, 44, 45, 46, 48 });
s.printPerson();
Console.WriteLine($"Grade: {s.Calculate()}");
