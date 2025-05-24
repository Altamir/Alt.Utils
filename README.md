# Alt.Utils

General purpose classes and extensions for .NET.

This library provides a collection of utility classes and extension methods to simplify common development tasks.

## Features

Currently, the library includes:

*   **`Maybe<T>`:** A struct to represent optional values that might be missing or associated with errors. It helps to avoid null reference exceptions and clearly express the possibility of absence of a value.

## Author

Altamir Benkenstein

## Target Frameworks

*   Xamarin.iOS (xamarinios10)
*   MonoAndroid (monoandroid81)
*   .NET Framework 4.5 (net45)

## Usage Example

Here's a basic example of how to use the `Maybe<T>` struct:

```csharp
using Alt.Util.Classes;
using Alt.Util.Interfaces; // For IMaybe<T>

public class Example
{
    public void ProcessValue(string input)
    {
        IMaybe<int> maybeInt = ParseInt(input);

        if (maybeInt.HasValue)
        {
            Console.WriteLine($"Successfully parsed: {maybeInt.Value}");
        }
        else
        {
            Console.WriteLine($"Failed to parse. Error: {maybeInt.Error}");
        }
    }

    public IMaybe<int> ParseInt(string s)
    {
        if (int.TryParse(s, out int result))
        {
            return Maybe<int>.Some(result);
        }
        return Maybe<int>.WithError($"Could not parse '{s}' to an integer.");
    }
}
```

## Contributing

Contributions are welcome! If you have improvements or new utilities to add, please:

1.  Fork the repository.
2.  Create a new branch for your feature or bug fix.
3.  Make your changes, including tests if applicable.
4.  Submit a pull request.