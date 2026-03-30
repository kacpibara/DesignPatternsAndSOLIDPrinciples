# Enkapsulacja (hermetyzacja)

Enkapsulacja (hermetyzacja) to mechanizm ukrywania stanu wewnętrznego obiektu i wymuszania, aby każda interakcja z tym stanem odbywała się wyłącznie przez ściśle zdefiniowany publiczny interfejs (metody/właściwości).

W przykładzie Bank Account nie chodzi tylko o to, że pole _balance jest prywatne. Chodzi o to, że obiekt BankAccount pilnuje swoich zasad (niezmienników):
- Saldo nigdy nie spadnie poniżej zera.
- Nie można wpłacić ujemnej kwoty.
- Nikt z zewnątrz nie "zhakuje" konta, wpisując tam dowolną liczbę.

### Porównanie podejść

| Cecha | BadBankAccount (Brak enkapsulacji) | BankAccount (Poprawna enkapsulacja) |
| :--- | :--- | :--- |
| Dostęp | Bezpośredni (Public field) | Kontrolowany (Private field + Methods) |
| Walidacja | Brak. Możesz ustawić saldo na -999999. | Ścisła. Metody Deposit i Withdraw sprawdzają poprawność danych. |
| Odpowiedzialność | Programista korzystający z klasy musi wiedzieć, co wolno, a czego nie. | Klasa sama dba o swoją logikę. Jest "czarną skrzynką". |
| Bezpieczeństwo | Stan obiektu może zostać uszkodzony w dowolnym momencie. | Stan obiektu jest zawsze spójny i bezpieczny. |


### Właściwości (Properties) w C# zamiast Getterów z Javy

W Javie dostęp do prywatnych pól realizujemy tradycyjnymi metodami (getterami):

```java
public class BankAccount {
    private double balance;

    public BankAccount(double initialBalance) {
        this.balance = initialBalance;
    }

    public double getBalance() {
        return this.balance;
    }

    // brak settera
}
```
W C# rzadko używamy metod typu `GetBalance()`. Zamiast tego stosujemy **Właściwości (Properties)**, które dają elegantszą enkapsulację. 

Z punktu widzenia użytkownika klasy wygląda to jak zwykłe pole (`account.Balance`), ale z punktu widzenia klasy jest to metoda, która chroni dane.

**Opcja 1: Pełna właściwość z prywatnym polem (tzw. Backing Field)**
Używana, gdy np. musimy dodać jakąś logikę podczas pobierania wartości (choć tu tylko zwracamy).

```csharp
public class BankAccount
{
    private decimal _balance; // Ukryte pole (Backing field)

    public decimal Balance 
    { 
        get { return _balance; } 
    }
}
```
**Opcja 2: Auto-Implemented Properties (Skrót)**
Gdy nie mamy żadnej dodatkowej logiki przy pobieraniu lub ustawianiu zmiennej, C# pozwala na zapis skrócony. Kompilator sam pod spodem wygeneruje sobie prywatne pole (takie jak _balance).

```csharp
public class BankAccount
{
    // Publiczny odczyt (get), ale zapis (set) dozwolony tylko wewnątrz tej klasy.
    public decimal Balance { get; private set; }
}
```