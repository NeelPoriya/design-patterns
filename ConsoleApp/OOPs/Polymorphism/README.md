| **Keyword**   | **Meaning**                                                            | **Example / Notes**                                       |
| ------------- | ---------------------------------------------------------------------- | --------------------------------------------------------- |
| `abstract`    | Defines a class/method that **must be implemented** in derived classes | `abstract class Animal { public abstract void Speak(); }` |
| `virtual`     | Marks method as **optional to override** in derived classes            | `public virtual void Drive() { }`                         |
| `override`    | Replaces a `virtual` or `abstract` method in child class               | `public override void Drive() { }`                        |
| `sealed`      | Prevents class inheritance or method overriding                        | `sealed class Final { }`                                  |
| `new`         | Hides base class method (compile-time)                                 | `public new void Show() { }`                              |
| `static`      | Belongs to class, not instance                                         | `Math.Sqrt(4)`                                            |
| `readonly`    | Value can only be set once (runtime)                                   | `readonly Guid Id = Guid.NewGuid();`                      |
| `const`       | Compile-time constant                                                  | `const double Pi = 3.14;`                                 |
| `partial`     | Split a class across multiple files                                    | `partial class Person { }`                                |
| `internal`    | Visible only within the same assembly                                  | `internal class Helper { }`                               |
| `protected`   | Accessible in class + derived classes                                  | `protected void Show() { }`                               |
| `interface`   | Defines a contract; must be implemented                                | `interface ILogger { void Log(); }`                       |
| `base`        | Access parent class members                                            | `base.Speak();`                                           |
| `this`        | Refers to current instance                                             | `this.name = name;`                                       |
| `async/await` | For asynchronous programming (non-blocking)                            | `await Task.Delay(1000);`                                 |
| `typeof`      | Gets type info                                                         | `typeof(string)`                                          |
| `is`          | Type check                                                             | `if(obj is string)`                                       |
| `as`          | Safe casting (returns null if fail)                                    | `obj as string`                                           |
| `record`      | Immutable data type with value equality                                | `record Person(string Name);`                             |
| `params`      | Variable number of arguments                                           | `PrintAll(params string[] items)`                         |
| `out`         | Return extra values from method                                        | `TryParse("123", out int n)`                              |
| `ref`         | Pass by reference (modifies original)                                  | `Increment(ref num)`                                      |
