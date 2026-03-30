# Inheritance (Dziedziczenie)

Dziedziczenie to zasada programowania obiektowego, która pozwala tworzyć nowe klasy na bazie już istniejących. 
Pozwala to na przejęcie (odziedziczenie) właściwości i metod z klasy bazowej (rodzica) do klasy pochodnej (dziecka).

Głównym celem dziedziczenia jest unikanie powtarzania kodu (Zasada **DRY** - *Don't Repeat Yourself*) oraz budowanie logicznej hierarchii obiektów opartej na relacji **"IS-A" (Jest czymś)** - np. Samochód *jest* Pojazdem.

### Dlaczego warto używać dziedziczenia?

| Cecha | Podejście bez dziedziczenia (Bad) | Podejście z dziedziczeniem (Good) |
| :--- | :--- | :--- |
| **Powtarzalność kodu** | Duża. W każdej klasie (Samochód, Rower, Motocykl) musisz od nowa pisać właściwości takie jak `Brand`, `Year` czy metody `Start()`. | Zerowa. Wspólne cechy piszesz tylko raz w klasie bazowej. |
| **Utrzymanie (Maintenance)** | Trudne. Jeśli chcesz dodać do każdego pojazdu nr VIN, musisz modyfikować dziesiątki niezależnych klas. | Łatwe. Dodajesz pole `VIN` do klasy `Vehicle`, a wszystkie inne klasy automatycznie to dziedziczą. |
| **Czytelność** | Niska. Trudno zauważyć, co łączy różne klasy w systemie. | Wysoka. Jasno widać, że i Samochód, i Rower należą do rodziny Pojazdów. |

### Przykład w C#

**1. Klasa Bazowa (Superclass / Base Class)**
Zawiera to, co jest wspólne dla wszystkich pojazdów (atrybuty oraz metody).

```csharp
// Wspólne właściwości
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }

    // Wspólne zachowania (metody)
    public void Start() 
    { 
        Console.WriteLine("Vehicle is starting"); 
    }
    
    public void Stop() 
    { 
        Console.WriteLine("Vehicle is stopping");
    }
```

**2. Klasy Pochodne (Subclass / Derived Class)**
Dziedziczą wszystko po Vehicle i dodają to, co jest dla nich unikalne.

```csharp
// Samochód posiada drzwi, ale dziedziczy markę, model i koła
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; } 
}

// Rower posiada stopkę, ale dziedziczy markę, model i koła
public class Bike : Vehicle
{
    public bool HasKickstand { get; set; }
}
```
Obiekty klas pochodnych mają dostęp do swoich unikalnych cech oraz do wszystkiego, co odziedziczyły z klasy bazowej.

```csharp
var car = new Car();

// Użycie odziedziczonych właściwości i metod
car.Brand = "Toyota";
car.NumberOfWheels = 4;
car.Start(); 

// Użycie unikalnej właściwości klasy Car
car.NumberOfDoors = 5; 


var bike = new Bike();

// Użycie odziedziczonych właściwości i metod
bike.Brand = "Honda";
bike.NumberOfWheels = 2;
bike.Stop();

// Użycie unikalnej właściwości klasy Bike
bike.HasKickstand = true;
```