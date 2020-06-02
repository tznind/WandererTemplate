# WandererTemplate
Template for the [Wanderer engine](https://github.com/tznind/Wanderer)

This was produced by following the 'Getting Started' instructions

## Using this template

Download or fork the template.  Download the [dotnet SDK](https://dotnet.microsoft.com/download).  Run the following code in a console:

```
cd ./Game
dotnet build
dotnet run
```

Modify the YAML files in [./Game/Resources/](./Game/Resources) to build your game.

## Autocomplete

To get autocomplete (intellisense) working with the YAML files (highly recommended) you will need [Visual Studio Code](https://code.visualstudio.com/) (Cross platform development environment) and the [Red Hat YAML Plugin](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-yaml).  Once these are installed you can open [Wanderer.code-workspace](./Wanderer.code-workspace) and your Resource files should autocomplete.

The schemas for the YAML are located in [./Game/Resources/Schemas](./Game/Resources/Schemas)
