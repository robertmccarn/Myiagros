# Myiagros Development Conventions

## Git Branches

- `main` — stable/release-ready code
- `develop` — active integration
- `feature/<name>` — new functionality
- `fix/<name>` — bug fixes
- `refactor/<name>` — structural/code improvements
- `docs/<name>` — documentation
- `chore/<name>` — tooling/configuration/maintenance

Substantial changes should use a branch and merge through a pull request.

Small early-development changes may be committed directly to `develop`
when a branch would add unnecessary overhead.

## Commit Messages

Use conventional prefixes:

- `feat:` — new functionality
- `fix:` — bug fix
- `refactor:` — restructuring without behavior change
- `docs:` — documentation
- `test:` — tests
- `chore:` — maintenance/tooling
- `perf:` — performance improvements

Examples:

- `feat: add player movement component`
- `fix: prevent swarm particles escaping bounds`
- `refactor: separate swarm simulation from rendering`
- `docs: document swarm architecture`

Commit messages should describe the change clearly and concisely.

## C# Naming

- Types: `PascalCase`
- Methods: `PascalCase`
- Private fields: `_camelCase`
- Parameters: `camelCase`
- Local variables: `camelCase`
- Constants: `PascalCase`
- Namespaces: `Myiagros.<Domain>`

## File Organization

By default, one primary production type should occupy one file.

File names should match their primary type.

Examples:

- `SwarmSimulation.cs`
- `SwarmPopulation.cs`
- `ArmorPlate.cs`

## Godot Nodes

Use Godot `Node` types when Godot scene-tree integration or lifecycle
behavior is required.

Use ordinary C# classes when Godot functionality is not required.

Do not represent large simulation populations with individual Godot Nodes.

## Architecture

Prefer composition and clear domain boundaries.

Do not introduce abstractions without a concrete reason.

Avoid premature:

- ECS architecture
- dependency injection frameworks
- service locators
- generic managers
- event buses
- factories
- interfaces without a demonstrated need

Abstractions should solve an identified architectural or testing problem.

## Documentation

Significant architectural decisions should be documented under:

`docs/decisions/`

Documentation should explain decisions that future development would
otherwise have to rediscover.
