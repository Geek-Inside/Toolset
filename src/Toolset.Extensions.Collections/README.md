# Toolset.Extensions.Collections

This nuget provides useful extension methods for collections.

## Available extensions
<details>
<summary>Shuffle collection</summary>

#### How to use

```csharp
var list = new List<string>() { "Car", "Banana", "Weed" };
list.Shuffle();
Console.WriteLine(string.Join(", ", list)); // Banana, Car, Weed

var array = new string[] { "Car", "Banana", "Weed" };
array.Shuffle();
Console.WriteLine(string.Join(", ", array)); // Weed, Car, Banana
```

#### Note

Shuffle method shuffles list using Fisher-Yates shuffle algorithm.

> Keep in mind that Fisher-Yates shuffle algorithm do not guarantees that no element will stay in its original position.

</details>
