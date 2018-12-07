/*
Deklaracja klasy

Brak modyfikatroa dostępu przed słowek kluczowy 'class'
jest równoważne z deklaracją 'internal class'
Na daną chwile jest to bez znaczenia, na najbliższych zajęciach 
będziemy stosować konstrukcje 'public class' oraz wyjanimy znaczenie 
słówka kluczowego internal

*/

class Car
{
    //Deklaracja właciowci (properties)
    <access modifier> <returning type> Name;
    //eg.
     public string Brand;
    //Deklaracja właciwoci zaimplementowanej automatycznie(Auto-Implemented propert)
    public string Brand {get; set;}
    //Deklaracja właciwoci z regułami zapisu i odczytu
    //Deklarujemy prywatne pole właciowci o tej samej nazwie do którego będziemy się odwoływać
    private string _brand; //pola prywatne posiadają prefix '_'
    public string Brand
    {
        get
        {
            return _brand;
        }
        set
        {
            if(value != "BMW") //zmienna value przechowuje wartosc przekazaną do setter'a
                _brand = value;
            else System.Console.WriteLine("Nie produkujemy BMW!");
        }
    }

    //Statyczna właciowoć w nie statycznej klasie
    public static int CarsCount;

    //konstruktora podstawowy tworzony automatycznie
    public Car() {}

    //własny konstruktor jedno argumentowy
    //Stworzenie własnego konstrukotra zastępuje kontruktora podstawowy
    public Car(string brand)
    {
        Brand = brand;
    }

    //przeciążenie konstruktora na dwa argumenty
    public Car(string brand, int vMax)
    {
        Band = brand;
        VMax = vMax;
    }

    //Odwołanie do innego kostruktora
    public Car(string brand, int vMax) : this()
    {
        Band = brand;
        VMax = vMax;
    }

    //Dekontruktora 
    ~Car()
    {
        //
    }

    //Metoda klasy
    <access modifier> <returning typ> Name() {body}
    //eg.
    public void Accelerate(int targetSpeed)
    {
        while(Speed != targetSpeed)
            Speed++;
    }

    //Statyczna metoda w nie statycznej klasie
    public static bool CheckEngine(Car car)
    {
        if(car.GetEngineStatus())
            return true;
        else return false;
    }
}

//Klasa statyczna
//W klasie statycznej wszystkie właciwosci oraz metody są statyczne

static class CarDealer()
{
    static int CarsCount = 20;
    static void SellCar(int numberOfCarsSold)
    {
        CarsCount -= numberOfCarsSold;
    }
}

// Dodatek:
// Snippets
Klasa:
class + <tab> + <tab>

Konstuktor:
ctor + <tab> + <tab>

Właciowć:
prop + <tab> + <tab>

// Lista oficjalnych fragmentó
// https://docs.microsoft.com/pl-pl/visualstudio/ide/visual-csharp-code-snippets?view=vs-2017
// Dodatkowe snippety można pobrać lub tworzyć samemu :)