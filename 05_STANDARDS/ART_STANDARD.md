# ROOTS_DIRECTOR/05_STANDARDS/ART_STANDARD.md

# ROOTS — ART STANDARD

Version: 1.0

---

## Purpose

Define a single visual standard for every asset in ROOTS.

Every artist and AI Agent must follow these rules.

---

## Art Style

Primary Style:

- 3D Low Poly
- Pixel Art Textures
- Semi-Realistic Proportions
- Minimal Detail
- Readable Shapes
- Performance First

---

## Visual Goals

- Readable
- Consistent
- Emotional
- Timeless
- Optimized
- Immersive

---

## Modeling

- Use Low Poly geometry.
- Avoid unnecessary edge loops.
- Avoid sculpted details.
- Prefer clean silhouettes.
- Every model must be reusable.

---

## Polygon Budget

- Small Props: 100–800 tris
- Medium Props: 800–3,000 tris
- Large Props: 3,000–10,000 tris
- Buildings: 5,000–25,000 tris
- Hero Objects: Up to 30,000 tris (only if approved)

---

## Scale

- 1 Unity Unit = 1 Meter
- Use realistic dimensions.
- All assets must match the same world scale.

---

## Grid

- Use modular sizes.
- Recommended:
  - 0.25m
  - 0.5m
  - 1m
  - 2m
  - 4m
- Walls, floors and furniture should align to the grid.

---

## Topology

- Clean topology.
- No non-manifold geometry.
- No duplicated faces.
- No isolated vertices.
- Correct normals.
- No unnecessary subdivisions.

---

## UV Mapping

- No stretched UVs.
- Consistent texel density.
- Reuse UV space when appropriate.
- Minimize wasted UV space.

---

## Textures

- Pixel Art only.
- Limited color palette.
- No photo textures.
- No AI artifacts.
- Keep texture style consistent.

---

## Texture Size

- Small Props: 256×256
- Medium Props: 512×512
- Large Objects: 1024×1024
- Hero Assets: 2048×2048 only if justified
- Always use power-of-two resolutions.

---

## Materials

- Reuse materials.
- Avoid unique materials unless necessary.
- Keep shader count low.
- Use simple shaders.

---

## Colors

- Natural colors.
- Muted tones.
- Avoid oversaturation.
- Maintain visual harmony.
- Support the emotional atmosphere.

---

## Lighting

- Baked Lighting preferred.
- Realistic light sources.
- Soft shadows.
- Minimal post-processing.
- No excessive bloom.

---

## Environment Design

Every environment must:

- Support the story.
- Guide exploration naturally.
- Contain meaningful objects.
- Avoid visual clutter.
- Remain easy to read.

---

## Props

Every prop must have:

- Purpose.
- Owner.
- Logical placement.
- Correct scale.
- Story value or gameplay value.

---

## Characters

- Low Poly.
- Simple facial features.
- Readable silhouettes.
- Realistic proportions.
- Consistent clothing style.
- No exaggerated cartoon proportions.

---

## Animations

- Natural.
- Subtle.
- Readable.
- No exaggerated movements.
- Smooth transitions.

---

## Optimization

- Reuse meshes.
- Reuse textures.
- Reuse materials.
- Use LOD when appropriate.
- Support Occlusion Culling.
- Avoid unnecessary mesh complexity.

---

## File Requirements

Every asset must include:

- Model.
- UVs.
- Pivot correctly placed.
- Scale verified.
- Material assigned.
- Naming follows NAMING_STANDARD.

---

## Forbidden

- High Poly assets.
- Photorealism.
- Inconsistent pixel density.
- Oversized textures.
- Broken topology.
- Floating geometry.
- Copyrighted assets.
- Placeholder assets in production builds.

---

## Quality Check

Every asset must be:

- Readable.
- Optimized.
- Consistent.
- Reusable.
- Production-ready.
- Unity-ready.

---

## Master Rule

If an asset does not improve the player's immersion or cannot meet the project's performance targets, it does not belong in ROOTS.
