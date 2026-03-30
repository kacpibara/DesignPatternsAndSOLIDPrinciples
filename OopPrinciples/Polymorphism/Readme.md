# Polymorphism (Polimorfizm)

Słowo polimorfizm pochodzi z greki: *poly* (wiele) i *morph* (formy). W programowaniu obiektowym oznacza to zdolność obiektu (lub zmiennej) do przyjmowania wielu różnych form.

W praktyce polimorfizm pozwala nam traktować obiekty klas pochodnych (np. `Car`, `Plane`) tak, jakby były obiektami klasy bazowej (`Vehicle`), ale podczas wywoływania metod, program i tak wykona odpowiednią akcję dla konkretnego typu.

### Słowa kluczowe w C#
* `virtual` (w klasie bazowej) – "Pozwalam, aby ta metoda została nadpisana przez moje dzieci".
* `override` (w klasie pochodnej) – "Nadpisuję zachowanie mojego rodzica i robię to po swojemu".

### Dlaczego to jest potężne?

| Cecha | Bez Polimorfizmu (Rozpoznawanie typów) | Z Polimorfizmem |
| :--- | :--- | :--- |
| **Wywoływanie akcji** | Musisz sprawdzać typ obiektu (`if (vehicle is Car) ... else if (vehicle is Plane) ...`). | Wywołujesz po prostu `vehicle.Start()`. Kompilator sam wie, co robić. |
| **Rozbudowa programu** | Dodanie statku (`Ship`) wymaga znalezienia wszystkich `ifów` w programie i dopisania nowego warunku. | Dodajesz nową klasę `Ship : Vehicle`, dodajesz `override Start()`. Reszta kodu programu pozostaje nietknięta! |
| **Zasada OCP** | Łamie Open/Closed Principle (musisz modyfikować istniejący kod). | Wspiera Open/Closed Principle (dodajesz nowe klasy bez ruszania starych). |

### Przykład w C#

**1. Klasa bazowa i klasy pochodne**
```csharp
public class Vehicle
{
    // Słówko "virtual" otwiera drogę do polimorfizmu
    public virtual void Start() { Console.WriteLine("Vehicle is starting"); }
}

public class Car : Vehicle
{
    // Słówko "override" nadpisuje zachowanie
    public override void Start() { Console.WriteLine("Car is starting (Wrrrum!)"); }
}

public class Plane : Vehicle
{
    public override void Start() { Console.WriteLine("Plane is starting (Swoosh!)"); }
}
```

2. Wykorzystanie (Magia Polimorfizmu)

```csharp
// Tworzymy listę typu bazowego, ale wrzucamy do niej różne formy (dzieci)
List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car());
vehicles.Add(new Plane());

// Wywołujemy jedną metodę, ale każda klasa reaguje na nią inaczej!
foreach(var vehicle in vehicles)
{
    vehicle.Start(); // W konsoli zobaczymy najpierw "Wrrrum!", a potem "Swoosh!"
}
```