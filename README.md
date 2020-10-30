# 096CheeseFix
A SCP:SL Plugin that fixes the cheesing of 096's flaw by staring at your feet to avoid getting him enraged.

Requires [EXILED](https://github.com/galaxy119/EXILED/).

Credits: RogerFK for his readme template.

# Latest release
[Get the latest release here!](https://github.com/RinTheWeeb/096CheeseFix/releases/latest)

## Features

- **Make 096 Enrage when players stand near him**
- **Notifies players when they get targetted when they stand near 096** 

## Configs

| Config Option | Value Type | Default Value | Description |
|:------------------------:|:----------:|:-------------:|:------------------------------------------:|
| `is_enabled` | bool | `true` | Enables/disables the plugin |
| `ignore_tutorial` | bool | `true` | If set to true, tutorial role will be ignored and does not enrage 096 when tutorial is near him. |
| `distance` | float | 0.5 | The minimum distance 096 needs to be from the player to be triggered. (Vector3.Distance) |
| `hint_display_time` | float | 3 | Amount of time in seconds the hint will be displayed to the player. |
| `hint_text` | string | `You enraged 096 by standing beside him. You better run.` | The text the player will see when they enrage 096 by standing near him. |
| `windup_time` | float | 1 | Amount of time in seconds 096 his enrage will be delayed for. |

