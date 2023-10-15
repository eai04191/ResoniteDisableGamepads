# ResoniteDisableGamepads

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that completely disables all gamepad inputs (for example from an Xbox controller).

## Installation

1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
1. Place [ResoniteDisableGamepads.dll](https://github.com/eai04191/ResoniteDisableGamepads/releases/latest/download/ResoniteDisableGamepads.dll) into your `rml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\Resonite\rml_mods` for a default install. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Resonite logs.

## Building

1. If you installed Resonite to a non-default location, you will need to edit `Directory.Build.targets` to point to your Resonite install directory. Create `Directory.Build.targets` in the root of the repository with the following contents:

    ```xml
    <Project>
        <PropertyGroup>
            <ResonitePath>G:\SteamLibrary\steamapps\common\Resonite\</ResonitePath>
        </PropertyGroup>
    </Project>
    ```

    Change the path to your Resonite install directory.

2. `dotnet build`
