# ROOTS_DIRECTOR/05_STANDARDS/CODING_STANDARD.md

# ROOTS — CODING STANDARD

Version: 1.0

---

## Purpose

Define a single coding standard for the entire ROOTS project.

Every programmer and AI Agent must follow these rules.

---

## Language

- Primary Language: C#
- Framework: Unity

---

## Philosophy

- Readable code.
- Maintainable code.
- Modular architecture.
- Performance first.
- Simplicity over cleverness.
- Consistency over personal preference.

---

## SOLID

Follow SOLID principles whenever practical.

- Single Responsibility.
- Open/Closed.
- Liskov Substitution.
- Interface Segregation.
- Dependency Inversion.

---

## Class Rules

- One class = One responsibility.
- Maximum recommended length: 500 lines.
- Split large classes into smaller components.

---

## Method Rules

- Keep methods focused.
- Recommended maximum: 40 lines.
- Avoid deeply nested logic.
- Prefer early returns.

---

## File Rules

- One public class per file.
- File name must match class name.

---

## Naming

- Follow NAMING_STANDARD.md.
- Never invent new naming styles.

---

## Variables

- Initialize when appropriate.
- Keep scope as small as possible.
- Avoid global mutable state.
- Use meaningful names.

---

## Magic Values

Forbidden.

Use:

- Constants
- Enums
- ScriptableObjects
- Configuration files

---

## Comments

- Comment WHY.
- Not WHAT.
- Avoid obvious comments.
- Remove outdated comments.

---

## Error Handling

- Validate inputs.
- Handle expected failures gracefully.
- Log meaningful errors.
- Never silently ignore exceptions.

---

## Unity Rules

- Avoid unnecessary Update().
- Cache references.
- Prefer events over polling.
- Use Coroutines only when appropriate.
- Avoid FindObjectOfType during gameplay.
- Avoid GameObject.Find in production.
- Avoid excessive GetComponent calls.

---

## ScriptableObjects

Use for:

- Configuration.
- Game Data.
- Item Definitions.
- Audio Data.
- UI Data.

Avoid storing runtime state.

---

## Prefabs

- Keep reusable.
- Avoid duplicated logic.
- No scene-specific assumptions.

---

## Events

- Prefer events for communication.
- Unsubscribe correctly.
- Avoid memory leaks.
- Avoid unnecessary static events.

---

## Performance

- Profile before optimizing.
- Avoid unnecessary allocations.
- Reuse objects.
- Pool frequently spawned objects.
- Avoid LINQ in performance-critical code.
- Avoid expensive operations inside Update().

---

## Dependencies

- Minimize dependencies.
- Avoid circular references.
- Use interfaces when appropriate.
- Keep systems loosely coupled.

---

## Architecture

Separate:

- Gameplay
- UI
- Audio
- Data
- Save System
- Input
- Rendering
- Debug

Never mix responsibilities.

---

## Debug Code

- Allowed during development.
- Must be removed or disabled before release.

---

## Testing

Every new system should be:

- Manually tested.
- Regression-safe.
- Compatible with existing systems.

---

## Documentation

Every significant system must include:

- Purpose.
- Dependencies.
- Public API.
- Configuration Notes.
- Known Limitations.

---

## Forbidden

- Hardcoded paths.
- Hardcoded references.
- Duplicated logic.
- Dead code.
- Unused variables.
- Unused methods.
- Unused assets.
- Temporary hacks.
- Hidden side effects.

---

## Quality Check

Every code submission must be:

- Readable.
- Modular.
- Reusable.
- Optimized.
- Documented.
- Production-ready.

---

## Master Rule

If another developer cannot understand, modify and extend the code easily, the implementation is not ready for ROOTS.
