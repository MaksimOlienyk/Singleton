# Singleton - Патерн Проєктування

Патерн **Singleton** гарантує, що **клас матиме лише один екземпляр**, і надає **глобальну точку доступу** до нього.

Це корисно, коли один спільний об’єкт потрібен у всій програмі, наприклад:
- логер,
- конфігурація,
- пул підключень.

---

## Ідея патерна

> Забезпечити існування **єдиного екземпляра** класу та надати до нього **універсальний доступ**.

---

## Структура

| Роль | Опис |
|------|------|
| `Singleton` | Клас, який контролює створення свого єдиного екземпляра |

---

## Код:

```csharp
class Singleton {
    private static Singleton _instance;
    public static Singleton Instance => _instance ??= new Singleton();
    private Singleton() { }
    public void Show() => Console.WriteLine("Singleton works");
}

class Program {
    static void Main() => Singleton.Instance.Show();
}
## Поле _instance зберігає єдиний екземпляр класу || Властивість Instance перевіряє, чи був уже створений об’єкт || Конструктор private обмежує створення об’єктів у коді (new Singleton() заборонено).
