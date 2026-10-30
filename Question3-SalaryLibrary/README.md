# Question 3: Salary Library Versioning

## Objective
Create two versions of a salary calculation class library and demonstrate how different client applications can use different library versions.

## Folder Structure

- `Version1/SalaryCalculator.cs` — Calculates basic salary.
- `Version1/AssemblyInfo.cs` — Defines assembly version 1.0.0.0.
- `Version2/SalaryCalculator.cs` — Calculates basic salary, allowances, and total salary.
- `Version2/AssemblyInfo.cs` — Defines assembly version 2.0.0.0.
- `ClientApp1/Program.cs` — Client application for Version 1.0.
- `ClientApp2/Program.cs` — Client application for Version 2.0.

## Requirements

- Windows
- .NET Framework C# compiler (`csc.exe`)
- Command Prompt or Developer Command Prompt for Visual Studio

## Build Version 1.0

Run these commands from the repository's root directory:

```bat
csc /target:library /out:Question3-SalaryLibrary\Version1\SalaryLibrary.dll Question3-SalaryLibrary\Version1\SalaryCalculator.cs Question3-SalaryLibrary\Version1\AssemblyInfo.cs
```

This generates `SalaryLibrary.dll` with assembly version 1.0.0.0.

## Build Version 2.0

```bat
csc /target:library /out:Question3-SalaryLibrary\Version2\SalaryLibrary.dll Question3-SalaryLibrary\Version2\SalaryCalculator.cs Question3-SalaryLibrary\Version2\AssemblyInfo.cs
```

This generates a separate `SalaryLibrary.dll` with assembly version 2.0.0.0.

## Build Client Application 1

```bat
csc /out:Question3-SalaryLibrary\ClientApp1\SalaryClientApp1.exe /reference:Question3-SalaryLibrary\Version1\SalaryLibrary.dll Question3-SalaryLibrary\ClientApp1\Program.cs
```

Copy the Version 1.0 DLL into the ClientApp1 directory:

```bat
copy Question3-SalaryLibrary\Version1\SalaryLibrary.dll Question3-SalaryLibrary\ClientApp1\
```

Run the application:

```bat
Question3-SalaryLibrary\ClientApp1\SalaryClientApp1.exe
```

## Build Client Application 2

```bat
csc /out:Question3-SalaryLibrary\ClientApp2\SalaryClientApp2.exe /reference:Question3-SalaryLibrary\Version2\SalaryLibrary.dll Question3-SalaryLibrary\ClientApp2\Program.cs
```

Copy the Version 2.0 DLL into the ClientApp2 directory:

```bat
copy Question3-SalaryLibrary\Version2\SalaryLibrary.dll Question3-SalaryLibrary\ClientApp2\
```

Run the application:

```bat
Question3-SalaryLibrary\ClientApp2\SalaryClientApp2.exe
```

## Expected Results

### Version 1.0
Calculates and displays the employee's basic salary.

### Version 2.0
Calculates and displays the employee's basic salary, HRA, DA, total allowances, and total salary.

## Advantages of Assembly Versioning

1. Helps identify different versions of a library.
2. Supports controlled updates to shared components.
3. Helps developers manage dependencies between applications and libraries.
4. Makes it easier to maintain and distribute updated library versions.

**Note:** These commands target the .NET Framework compiler. Run them from a suitable Windows developer command prompt. Assembly version numbers identify versions, but they do not alone guarantee that multiple versions can be loaded together in one application.
