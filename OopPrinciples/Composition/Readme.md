

// When there is a clear "is-a" relationship between classes, and subclass objects can be treated
as instances of their superclass.
// When you want to promote code reuse by inheriting properties and behaviors from existing
classes.
// When you want to leverage polymorphism to allow objects of different subclasses to be treated
uniformly through their common superclass interface.

# Composition (Kompozycja)

Kompozycja to zasada projektowania polegająca na budowaniu złożonych obiektów poprzez łączenie ze sobą mniejszych, prostszych komponentów. Zamiast dziedziczyć zachowania, obiekt "posiada" inne obiekty i deleguje im zadania.

Kompozycję opisujemy relacją **"HAS-A" (Ma coś)** – np. Samochód *ma* Silnik, *ma* Koła i *ma* Podwozie.

### Dziedziczenie (Inheritance) vs Kompozycja (Composition)

W nowoczesnym programowaniu istnieje bardzo popularna zasada: **"Favour Composition over Inheritance"** (Preferuj kompozycję nad dziedziczeniem), ponieważ kompozycja daje często większą elastyczność i chroni przed problemem zbyt głębokich i sztywnych drzew dziedziczenia.

| Kiedy używać Dziedziczenia? | Kiedy używać Kompozycji? |
| :--- | :--- |
| Kiedy istnieje wyraźna relacja **"IS-A"** (Samochód jest Pojazdem). | Kiedy istnieje relacja **"HAS-A"** (Samochód ma Silnik). |
| Kiedy chcesz współdzielić bazowe właściwości i korzystać z **Polimorfizmu**. | Kiedy potrzebujesz elastyczności w budowaniu obiektów z małych, reużywalnych klocków. |
| Kiedy klasy podrzędne są po prostu uszczegółowieniem klasy nadrzędnej. | Kiedy chcesz uniknąć problemów z dziedziczeniem, takich jak mocne powiązanie z klasą bazową (Tight Coupling). |

### Przykład w C#

**1. Proste komponenty (Klocki)**
Każdy komponent ma swoją własną, małą odpowiedzialność.

```csharp
public class Engine
{
    public void Start() { Console.WriteLine("Engine started"); }
}

public class Wheels
{
    public void Rotate() { Console.WriteLine("Wheels rotating"); }
}

public class Chassis
{
    public void Support() { Console.WriteLine("Chassis supporting the car"); }
}

public class Seats
{
    public void Sit() { Console.WriteLine("Sitting on seats"); }
}
```

**2. Kompozycja (Budowanie całości)**
Klasa Car nie dziedziczy po żadnym z powyższych komponentów. Zamiast tego tworzy ich instancje jako swoje pola i deleguje im zadania w odpowiednim momencie.

```csharp
public class Car
{
    // Obiekt "Car" posada (HAS-A) poniższe komponenty
    private Engine engine = new Engine();
    private Wheels wheels = new Wheels();
    private Chassis chassis = new Chassis();
    private Seats seats = new Seats();

    public void Start()
    {
        // Delegowanie zadań do odpowiednich komponentów
        engine.Start();
        wheels.Rotate();
        chassis.Support();
        seats.Sit();
        
        Console.WriteLine("Car started successfully!");
    }
}
```