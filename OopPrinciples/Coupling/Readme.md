# Coupling (Powiązanie / Zależność)

**Coupling** określa stopień zależności (powiązania) między różnymi klasami w systemie. 
Naszym celem w programowaniu obiektowym jest dążenie do **Loose Coupling (Słabego powiązania)**, co oznacza, że klasy powinny wiedzieć o sobie jak najmniej i opierać się na abstrakcjach (np. Interfejsach), a nie na konkretnych implementacjach.

Przeciwieństwem jest **Tight Coupling (Mocne powiązanie)**, gdzie jedna klasa jest na stałe "przyspawana" do innej klasy, co sprawia, że każda zmiana w systemie jest bolesna i wymaga modyfikacji wielu plików.

### Dlaczego dążymy do Loose Coupling?

| Cecha | Tight Coupling (Mocne powiązanie - Źle) | Loose Coupling (Słabe powiązanie - Dobrze) |
| :--- | :--- | :--- |
| **Elastyczność** | Klasa `Order` na stałe tworzy w sobie `EmailSender`. Aby wysłać SMS, musisz zmodyfikować kod klasy `Order`. | Klasa `Order` przyjmuje z zewnątrz dowolny obiekt zgodny z interfejsem. Nic nie trzeba zmieniać. |
| **Testowanie** | Bardzo trudne. Testując zamówienie, program zawsze będzie próbował wysłać prawdziwego maila. | Bardzo proste. W testach wstrzykujesz "Fałszywego" wysyłacza (tzw. Mock), który nic nie wysyła, ale test przechodzi. |
| **Zależności** | Klasa zależy od konkretnej, "sztywnej" implementacji innej klasy. (Operator `new` to klej). | Klasa zależy tylko od kontraktu (Interfejsu). |

### Przykład w C# (Dependency Injection)

**1. Definicja Kontraktu (Interfejs)**
Każdy, kto chce być "Wysyłaczem powiadomień", musi posiadać tę metodę.
```csharp
public interface INotificationService
{
    void SendNotification(string message);
}
```
**2. Implementacje (Konkretne narzędzia)**
```csharp
public class EmailSender : INotificationService
{
    public void SendNotification(string message) { Console.WriteLine("Email: " + message); }
}

public class SmsSender : INotificationService
{
    public void SendNotification(string message) { Console.WriteLine("SMS: " + message); }
}
```

**3. Klasa używająca - Słabe Powiązanie (Dobre podejście)**
Klasa Order nie używa słówka new do tworzenia wysyłacza. Przyjmuje go w konstruktorze! To zjawisko nazywamy Wstrzykiwaniem Zależności (Dependency Injection).

```csharp
public class Order
{
    // Typ to Interfejs, a nie konkretna klasa!
    private readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void PlaceOrder()
    {
        // ... logika zamówienia ...
        _notificationService.SendNotification("Your Order placed successfully");
    }
}
```

**4. Wywołanie**
Możemy decydować o tym, co zostanie użyte do wysłania powiadomienia na poziomie tworzenia obiektu, całkowicie bez zmiany kodu samej klasy Order.

```csharp
// Zamówienie z powiadomieniem Email
var orderFirst = new Order(new EmailSender());
orderFirst.PlaceOrder();

// Zamówienie z powiadomieniem SMS
var orderOther = new Order(new SmsSender());
orderOther.PlaceOrder();
```