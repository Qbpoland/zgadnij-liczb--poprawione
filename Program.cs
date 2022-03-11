{
    int a, b, r, g;
    a = 1;
    b = 10;
    Random rand = new Random();
    r = rand.Next(a, b + 1);
    Console.WriteLine("Zgadnij liczbę od 1 do 10");
    do
    {
        g = Convert.ToInt32(Console.ReadLine());
     if (r != g)
         Console.WriteLine(((r < g) ? "Liczba jest za duża" : "liczba jest za mała"));
    } while (r != g);
    Console.WriteLine("To ta liczba");
    Console.ReadKey();
}
