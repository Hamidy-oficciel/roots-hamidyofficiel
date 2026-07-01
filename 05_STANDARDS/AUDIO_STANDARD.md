# ROOTS_DIRECTOR/05_STANDARDS/AUDIO_STANDARD.md

# ROOTS — AUDIO STANDARD

Version: 1.0

---

## Purpose

Define the audio quality, style and implementation standards for ROOTS.

Every audio asset must follow these rules.

---

## Audio Philosophy

- Audio supports the story.
- Silence is intentional.
- Realism over cinematic effects.
- Every sound must have a believable source.
- Less is better.

---

## Audio Priority

1. Environmental Ambience
2. Interactive Sound Effects
3. Character Voices
4. UI Sounds
5. Music

---

## Audio Categories

- AMB_ → Environment
- SFX_ → Sound Effects
- VO_ → Voices
- MUS_ → Music
- UI_ → Interface Sounds

---

## Ambience

Every location must have its own ambient identity.

Examples:

- Old House
  - Wind
  - Wooden floor creaks
  - Clock ticking
  - Refrigerator hum
  - Distant traffic
- Hospital
  - Air conditioning
  - Elevator
  - Medical equipment
  - Footsteps
  - Distant conversations
- Cemetery
  - Wind
  - Birds
  - Leaves
  - Distant city ambience

---

## Sound Effects

Every interactive object should have appropriate sounds.

Examples:

- Doors
- Keys
- Paper
- Drawers
- Cabinets
- Glass
- Switches
- Footsteps
- Furniture
- Locks
- Water

---

## Footsteps

Different surfaces require different sounds.

Examples:

- Wood
- Concrete
- Tile
- Grass
- Gravel
- Metal
- Carpet

---

## Voice

Voice acting should be:

- Natural.
- Subtle.
- Emotional.
- Believable.
- No exaggerated acting.
- No radio-announcer style.

---

## Music

- Use only when it strengthens emotional moments.
- Music must never replace environmental storytelling.
- Silence is preferred over unnecessary music.

---

## Loudness

- Maintain consistent volume.
- Avoid clipping.
- Avoid sudden volume spikes.
- Dialogue must remain intelligible.

---

## Looping

Ambient tracks must:

- Loop seamlessly.
- Avoid noticeable repetition.
- Avoid abrupt starts or endings.

---

## File Format

- Working Files: WAV
- Final Build: OGG
- Use Mono when stereo is unnecessary.
- Compress appropriately.

---

## Sample Rate

- 44.1 kHz minimum.
- 48 kHz preferred for production.

---

## Optimization

- Keep memory usage low.
- Reuse sounds when appropriate.
- Avoid duplicate files.
- Stream long music tracks.
- Compress voice recordings.

---

## Unity Implementation

- Use Audio Mixer Groups.
- Apply spatial audio where appropriate.
- Use realistic attenuation distances.
- Avoid excessive simultaneous Audio Sources.

---

## Forbidden

- No horror stingers.
- No monster sounds.
- No supernatural effects.
- No copyrighted audio.
- No low-quality recordings.
- No clipping.
- No distorted audio unless intentionally justified.

---

## Quality Check

Every audio asset must be:

- Clean.
- Balanced.
- Optimized.
- Realistic.
- Consistent.
- Production-ready.

---

## Master Rule

If a sound does not improve immersion, provide useful feedback, or support the story, remove it.
