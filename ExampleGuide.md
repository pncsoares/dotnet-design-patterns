# Example Guide

## Create the structure for the new design pattern

1. Open terminal
1. `cd` into this repository directory
1. Execute the following commands in order

✅ Create a directory that will contain the design pattern source code

```bash
  mkdir {DesignPatternName}Pattern

  # example
  # mkdir SingletonPattern
```

✅ Go to the new directory

```bash
  cd {DesignPatternName}Pattern

  # example
  # cd SingletonPattern
```

## Create the dotnet projects

In this step we will use Dotnet CLI 💪

If you don't know what it is, check the documentation [here](https://docs.microsoft.com/en-us/dotnet/core/tools/)
Check if you have it installed by executing the following command via terminal:

```bash
  dotnet --version
```

If you don't have it installed, check the documentation above 👆 and try again after installing it.

Now we will use `console` template (from Dotnet Core Console Application) to exemplify but you can use other templates such as `webapi`, `classlib`, `mvc` and others.

You can check all the available templates in Microsoft's documentation [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new#arguments)

✅ Create the project that will contain the source code without the design pattern

```bash
  dotnet new console -n "{DesignPatternName}Pattern.WithoutPattern"

  # example
  # dotnet new console -n "SingletonPattern.WithoutPattern"
```

✅ Create the project that will contain the source code using the design pattern

```bash
  dotnet new console -n "{DesignPatternName}Pattern.WithPattern"

  # example
  # dotnet new console -n "SingletonPattern.WithPattern"
```

✅ Go back to repository root directory (where the `DesignPatterns.sln` is)

```bash
  cd ..
```

✅ Add the two new projects to the solution

```bash
  dotnet sln .\DesignPatterns.sln add .\{DesignPatternName}Pattern\{DesignPatternName}Pattern.WithoutPattern\{DesignPatternName}Pattern.WithoutPattern.csproj

  # example
  # dotnet sln .\DesignPatterns.sln add .\SingletonPattern\SingletonPattern.WithoutPattern\SingletonPattern.WithoutPattern.csproj
```

```bash
  dotnet sln .\DesignPatterns.sln add .\{DesignPatternName}Pattern\{DesignPatternName}Pattern.WithPattern\{DesignPatternName}Pattern.WithPattern.csproj

  # example
  # dotnet sln .\DesignPatterns.sln add .\SingletonPattern\SingletonPattern.WithPattern\SingletonPattern.WithPattern.csproj
```

💡 We need this two projects, `*.WithoutPattern` and `.WithoutPattern` so we can exemplify the difference between with and without the design pattern.

## Add source code

Now that you have the structure and two projects, one that will contain the source code without the design pattern and another that will contain the source code using the design pattern, you can start coding 🧑‍💻

## Add documentation

Finish the good work by adding some documentation, scenarios, pros and cons or other things that you know about the design pattern.

## Add images

If you want to show something you can screenshot and then reference that in a markdown file. To do that just save the image or the screenshot in `./.github/images/{DesignPatternName}Pattern/image-name.extension`