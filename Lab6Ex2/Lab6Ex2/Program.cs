// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
//Scrieti un program care va modela un autoturism. Un autoturism va avea o
//marca(string), un numar de inmatriculare (string), precum si capacitate cilindrica(int). 
//Autoturismul va avea:
//Campurile corespunzatoare caracteristicilor autoturismului.
//Un constructor care va initializa campurile acestuia
//O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
//numarDeInmatriculare, capacitateCilindrica”.

//in primul rand facem clasa
autoturism a1 = new autoturism();
a1.marca = "Nissan";
a1.numarDeInmatriculare = "SV14ZAX";
a1.capacitateCilindrica = 2000;

autoturism a2 = new autoturism();
a2.marca = "Subaru";
a2.numarDeInmatriculare = "SV86RRA";
a2.capacitateCilindrica = 2000;
Console.WriteLine(a1.Tipareste);
Console.WriteLine(a2.Tipareste);

//aici voi scrie functia care va afisa aceste informatii

class autoturism
{
    //apoi intializam campurile
    public string marca;
    public string numarDeInmatriculare;
    //am decis sa folosesc "private" atunci cand am definit capacitatea cilindrica
    //deoarece este o informatie specifica, nu foarte importanta
    private int capacitateCilindrica;
    //in continuare vom defini constructorul 
    public autoturism()
    {
        marca = string.Empty;
        numarDeInmatriculare = string.Empty;
        capacitateCilidrica = 2000;
    }
    //acum vom defini metoda
    public void Tipareste()
    {
        Console.WriteLine($"{marca} {numarDeInmatriculare} {capacitateCilindrica}");
    }

}
