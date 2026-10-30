# Question 2: University Library and Strong-Named Assemblies

## Objective

Create a reusable University Library, sign it with a strong name, install it in the Global Assembly Cache (GAC), and use it from two console applications.

## Files

- `Student.cs` — Contains the Student class and its methods.
- `StudentApp1.cs` — First client application.
- `StudentApp2.cs` — Second client application.

## Requirements

- Windows
- .NET Framework
- Developer Command Prompt for Visual Studio
- Administrator privileges for installing an assembly into the GAC

## Step 1: Generate a Strong-Name Key

Run:

```bat
sn -k UniversityLibrary.snk
```

This generates a key file used to sign the assembly.

Keep the private key secure. Do not commit the generated `.snk` file to a public repository.

## Step 2: Build the Strong-Named Library

From the directory containing `Student.cs`, run:

```bat
csc /target:library /keyfile:UniversityLibrary.snk /out:UniversityLibrary.dll Student.cs
```

This creates a strong-named `UniversityLibrary.dll`.

## Step 3: Install the Library in the GAC

Open an elevated Developer Command Prompt and run:

```bat
gacutil -i UniversityLibrary.dll
```

The GAC stores shared .NET Framework assemblies.

## Step 4: Verify the Installation

Run:

```bat
gacutil -l UniversityLibrary
```

This lists matching assemblies installed in the GAC.

## Step 5: Build Client Application 1

From the directory containing `StudentApp1.cs`, run:

```bat
csc /reference:UniversityLibrary.dll /out:StudentApp1.exe StudentApp1.cs
```

Run:

```bat
StudentApp1.exe
```

## Step 6: Build Client Application 2

From the directory containing `StudentApp2.cs`, run:

```bat
csc /reference:UniversityLibrary.dll /out:StudentApp2.exe StudentApp2.cs
```

Run:

```bat
StudentApp2.exe
```

## Advantages of Strong-Named Assemblies

1. A strong name identifies an assembly using its name, version, culture, and public key information.
2. Strong-named assemblies can be installed in the .NET Framework GAC.
3. The strong name helps distinguish assemblies with different identities.
4. The GAC supports sharing suitable assemblies between applications.

## Important Notes

- These commands target the .NET Framework and should be run in a suitable Windows developer command prompt.
- The library must be built before compiling either client application.
- For the client commands above, make `UniversityLibrary.dll` available in the current directory.
- Installing an assembly into the GAC requires an appropriate .NET Framework environment and administrative permissions.
- A strong name identifies an assembly; it does not guarantee that the code is safe or trustworthy.
