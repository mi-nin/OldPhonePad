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
|------|------------|
| 1    | &'(        |
| 2    | ABC        |
| 3    | DEF        |
| 4    | GHI        |
| 5    | JKL        |
| 6    | MNO        |
| 7    | PQRS       |
| 8    | TUV        |
| 9    | WXYZ       |
| 0    | space      |
| *    | remove     |
| #    | input end  |

## Prerequisites

Before running the application, ensure you have:

- **.NET 8.0 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)

## How to Run

Open the `.sln` file in Visual Studio and press F5 to run the console app.

## or
```bash
dotnet run