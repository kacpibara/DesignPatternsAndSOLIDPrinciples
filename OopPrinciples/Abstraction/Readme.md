# Abstraction (Abstrakcja)

Abstrakcja to zasada programowania obiektowego polegająca na **ukrywaniu skomplikowanych szczegółów implementacyjnych** przed użytkownikiem klasy i udostępnianiu mu tylko tego, co jest absolutnie niezbędne do korzystania z obiektu (prostego i bezpiecznego interfejsu).

Najlepszą analogią jest ekspres do kawy: naciskasz przycisk "Zrób Latte" (to publiczny interfejs), a ekspres sam zajmuje się mieleniem ziaren, podgrzewaniem wody pod ciśnieniem i spienianiem mleka (to są ukryte, prywatne detale, którymi jako użytkownik, nie musisz i nie powinieneś się martwić).

### Porównanie podejść

| Cecha | BadEmailService (Brak abstrakcji) | EmailService (Poprawna abstrakcja) |
| :--- | :--- | :--- |
| **Złożoność** | Duża. Użytkownik musi znać dokładną kolejność kroków (najpierw Connect, potem Auth...). | Mała. Użytkownik wywołuje po prostu jedną metodę `SendEmail()`. |
| **Ryzyko błędu** | Ogromne. Pominięcie jakiegoś kroku (np. `Authenticate()`) z zewnątrz spowoduje awarię (tzw. crash). | Zerowe. Klasa sama wywołuje swoje wewnętrzne metody w odpowiedniej kolejności. |
| **Utrzymanie** | Trudne. Dodanie nowego kroku do wysyłania wymaga zmiany kodu w każdym miejscu, gdzie użyto tej klasy. | Łatwe. Jeśli logika się zmieni, modyfikujemy tylko wnętrze klasy `EmailService`. |

### Przykład w C# (Podejście tożsame z Javą)

**Złe podejście (Brak abstrakcji):**
Wszystkie metody są publiczne. Programista korzystający z klasy musi sam zarządzać całym procesem.

```csharp
public class BadEmailService
{
    public void Connect() { Console.WriteLine("Connecting..."); }
    public void Authenticate() { Console.WriteLine("Authenticating..."); }
    public void SendEmail() { Console.WriteLine("Sending..."); }
    public void Disconnect() { Console.WriteLine("Disconnecting..."); }
}