# WPF Preprocessor Demo

A minimal example demonstrating how to use C# preprocessor directives with WPF XAML UI variants.

## Overview

This project shows how to:

- Use C# preprocessor directives to control code behavior
- Toggle between different XAML UI variants at compile time
- Build the same project with different preprocessor constants

## Building

Build original version:

```batch
msbuild.exe PreprocessorDemo.csproj
```

Build with new feature enabled:

```batch
msbuild.exe PreprocessorDemo.csproj /p:DefineConstants="fix_issue_001"
```

## Requirements

- Visual Studio 2019
- .NET Framework
- WPF

## Notes

- Clean the solution between builds when switching preprocessor directives
- The example shows a simple counter increment (by 1 or 2) with different UI styles
- Uses data binding with BooleanToVisibilityConverter for UI toggling
