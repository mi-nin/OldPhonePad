# OldPhonePad – C# Coding Challenge

This is a small C# coding challenge from Iron Software.

Simulate typing on a classic phone keypad — and decode the message!

## How it works

- Pressing the same number multiple times gives different letters.  
  Example: `2` → A, `22` → B, `222` → C
- Add a space to separate letters that use the same key.  
  Example: `222 2 22` → CAB
- Use `*` to delete the last letter.
- Use `#` to end the input.

## Example

```csharp
OldPhonePad(“33#”) => output: E
OldPhonePad(“227\*#”) => output: B
OldPhonePad(“4433555 555666#”) => output: HELLO
```

## Key Mapping Table

This table shows the mapping of keypad numbers to characters:

| Key | Characters |
| --- | ---------- |
| 1   | &'(        |
| 2   | ABC        |
| 3   | DEF        |
| 4   | GHI        |
| 5   | JKL        |
| 6   | MNO        |
| 7   | PQRS       |
| 8   | TUV        |
| 9   | WXYZ       |
| 0   | space      |
| \*  | remove     |
| #   | input end  |

## Prerequisites

Before running the application, ensure you have:

- **.NET 8.0 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)

## How to Run

### Option 1: Visual Studio

1. Open the `.sln` file in Visual Studio
2. Press `F5` to run the console app

### Option 2: Command Line

```bash
# Navigate to the solution directory
cd OldPhonePad

# Run the application
dotnet run --project OldPhonePad

# Or build and run
dotnet build
dotnet run --project OldPhonePad
```

## Testing

This project includes unit tests using xUnit framework.

### Running Tests

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal

# Run tests in specific project
dotnet test OldPhonePad.Tests
```
