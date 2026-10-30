## Building and Running the Tax Library

### Requirements
- Windows
- .NET Framework C# compiler (`csc.exe`)
- Developer Command Prompt for Visual Studio

### Step 1: Build the Class Library

Run this command from the repository's root directory:

```bat
csc /target:library /out:Question1-TaxLibrary\TaxLibrary.dll Question1-TaxLibrary\TaxCalculator.cs
```

This generates `TaxLibrary.dll`, containing the reusable tax calculation methods.

### Step 2: Build the Console Application

Run:

```bat
csc /reference:Question1-TaxLibrary\TaxLibrary.dll /out:Question1-TaxLibrary\TaxConsoleApp.exe Question1-TaxLibrary\Program.cs
```

This compiles the console application and references the tax library.

### Step 3: Run the Application

Run:

```bat
Question1-TaxLibrary\TaxConsoleApp.exe
```

Enter an employee name and annual income to see the calculated tax under both regimes.

### Advantages of Class Libraries

1. **Code reusability:** The same tax calculation logic can be reused in payroll and salary applications.
2. **Maintainability:** Tax calculation logic can be updated separately from applications that use it.
3. **Modularity:** Applications can be divided into independent components.
4. **Reduced duplication:** Developers do not need to rewrite the same calculations in multiple applications.

### Important Note

The tax slabs in this educational example are illustrative. They are not a complete implementation of the official Indian income tax rules. These commands target the .NET Framework compiler and should be run in a suitable Windows developer command prompt.
