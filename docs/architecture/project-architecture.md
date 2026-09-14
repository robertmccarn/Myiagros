# Myiagros Project Architecture

## 1. Overview

Myiagros is a dark sci-fi/body-horror action RPG built with Godot 4.x and C#/.NET.

The project uses Godot as the game engine while maintaining a modular game architecture owned by the Myiagros project.

Core architectural goals:

- Keep gameplay independent from presentation where practical.
- Keep swarm simulation independent from swarm rendering.
- Keep logical population separate from simulated particle count.
- Prefer modular/component-oriented design.
- Avoid premature ECS adoption.
- Use Godot's built-in systems where appropriate rather than replacing the engine.
- Optimize based on profiling and measured performance.
- Prototype code should evolve toward production code rather than being discarded.

---

## 2. Technology Stack

- Engine: Godot 4.x
- Language: C#
- Runtime/SDK: .NET
- World: 3D
- Gameplay: Primarily planar 2D/2.5D
- Physics: Godot 3D physics
- Default physics engine: Jolt Physics
- Renderer: Forward+
- Windows rendering driver: D3D12
- Version control: Git
- Repository: GitHub
- Primary editor: Zed

---

## 3. Project Structure

```text
Myiagros/
├── game/
│   ├── scenes/
│   │   ├── bootstrap/
│   │   ├── world/
│   │   ├── player/
│   │   ├── enemies/
│   │   ├── armor/
│   │   └── ui/
│   │
│   ├── scripts/
│   │   ├── Core/
│   │   ├── Gameplay/
│   │   ├── Player/
│   │   ├── Swarm/
│   │   ├── Combat/
│   │   ├── Armor/
│   │   ├── Enemies/
│   │   ├── AI/
│   │   ├── World/
│   │   ├── Abilities/
│   │   ├── Items/
│   │   ├── Progression/
│   │   ├── Save/
│   │   ├── UI/
│   │   ├── Audio/
│   │   └── Debug/
│   │
│   ├── resources/
│   ├── shaders/
│   └── assets/
│
├── tests/
├── tools/
└── docs/
    ├── architecture/
    ├── design/
    └── decisions/
