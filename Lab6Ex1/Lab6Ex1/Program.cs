// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
//metoda care va calcula volumul acestuia.
//Folositi o clasa care va modela un dulap.
// Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
//Cele trei campuri vor fi initializate cu ajutorul constructorului
//Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.

//in primul rand definim clasa
Console.WriteLine(Dulap.GetVolum);
class Dulap
{
    //aici avem campurile
    private int lungime;
    private int latime;
    private int inaltime;
    private int vol;
    //mai departe initializam contructorul
    private Dulap()
    {
        lungime = 23;
        latime= 12;
        inaltime = 10;
    }
    //mai departe scriem metoda prin care calculam volum
    public void GetVolum(int vol=0)
    {
        vol = lungime * inaltime * latime;
        
    }
}
