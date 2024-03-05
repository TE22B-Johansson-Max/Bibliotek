// Bokregister

Console.Clear();
Console.WriteLine("Välkommen till biblioteca!");
Console.WriteLine("Här kan du registrera dina libros: ");

// En lista för att lagra boknamn
List<string> boklista = new List<string>();

/*
1. Lägg till en bok
2. Visa alla böcker
3. Sök efter en bok
4. Ta bort en bok
5. Avsulta
*/

while (true) {
    /*Console.WriteLine("1. Lägg till en bok\n" +
    "2. Visa alla böcker\n" +
    "3. Sök efter en bok\n" +
    "4. Ta bort en bok\n" +
    "5. Avsulta"); */

    Console.WriteLine(
    @"
    1. Lägg till en bok
    2. Visa alla böcker
    3. Sök efter en bok
    4. Ta bort en bok
    5. Avsulta"
    );
    Console.Write("Ange ditt val (1-5): ");

    string val = Console.ReadLine();

    switch (val)
    {
        case "1": 
        LäggTillBok(boklista);
        break;

        case "2": 
        AllaBöcker();
        break;

        case "3": 
        BokSökning();
        break;

        case "4":
        RaderaBok();
        break;

        case "5":
        Console.WriteLine("Tack för idag!");
        return;


        default:
        Console.Write("Fel inmatning! Ange ditt val (1-5): ");
        val = Console.ReadLine();
        break;
    }
}

// -- Metoder -- \\

static void LäggTillBok(List <string> lista) {
    Console.Write("Ange namnet på en bok: ");
    string boknamn = Console.ReadLine();
    lista.Add(boknamn);
}



static void AllaBöcker() {
    wdasd
}



static void BokSökning() {
    wdasd
}



static void RaderaBok() {
    wdasd
}
