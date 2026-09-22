# LIFEGAME

Scripts de Unity para un juego de vida en móvil. El jugador tiene edad, dinero y varias estadísticas, se mueve en horizontal y entra en edificios.

Este repositorio **no es un proyecto Unity completo**: no hay `ProjectSettings` ni escenas. Son los `.cs` sueltos para copiarlos a un proyecto que ya tenga el resto de la escena.

## Qué hacen los scripts

| Script | Papel |
| --- | --- |
| `PlayerStats` | Edad (empieza en 18), dinero y stats: salud, hambre, frío, salud mental y salud corporal |
| `CharacterStat` / `StatModifier` | Stat con valor base y modificadores (usa `Kryz.CharacterStats`) |
| `PlayerController` | Movimiento horizontal. En Android activa el camino táctil (`USING_MOBILE`) |
| `EnterBuldings` | Entrada a edificios |
| `DisplayText` / `TextButton` / `ResumeButton` | Texto de UI y reanudar |

## Stack

- Unity
- C#
- Pensado para móvil (`UNITY_ANDROID`)
- Depende del asset **Kryz.CharacterStats** (el `using` de `PlayerStats`)

## Cómo usarlo

1. Crea o abre un proyecto Unity 2D/3D.
2. Copia estos `.cs` a `Assets`.
3. Importa el paquete de Character Stats que espera `PlayerStats`.
4. Coloca `PlayerController` y `PlayerStats` en el jugador y enlaza la UI en el Inspector.

`EnterBuldings` conserva ese nombre en el archivo: al referenciar el componente en el Inspector, Unity usa el nombre de la clase tal cual.
