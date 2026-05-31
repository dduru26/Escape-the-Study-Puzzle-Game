# Escape the Study

## What the game is

You wake up locked in a small study and have to get out. The room's dark and full of objects you can poke at, and a few of them actually do something. Solve the five puzzles hidden around the room and the door finally unlocks so you can leave. One room, one door, five things to figure out.

I kept it to a single room on purpose since it's only week 4 — most of my time went into getting the interaction and the puzzle tracking working rather than making it big.

## The five puzzle tasks

Instead of a plain "3 / 5" counter, there's a little checklist in the corner of the screen with a clue-ish name for each puzzle. As you solve one, its line gets crossed out and turns green. The names hint at what to do without spelling it out:

1. **Let there be light** — the room starts dark, with one lamp faintly glowing. Aim at it and press E to power the rest of the lights on.
2. **Set the record straight** — there are four objects on the desk (radio, laptop, plant, tissue box). Press them in the right order. A framed picture on the wall shows the order using the objects themselves. Get it wrong and a buzzer sounds and that puzzle resets.
3. **A turn for the better** — one object can be rotated. Press E to spin it a step at a time until it lines up the right way.
4. **Right where it belongs** — pick up a loose item with E (it floats in front of you), then drop it on the spot that lights up blue once you're carrying it.
5. **Pull yourself together** — the lever. It glows red until the other four are done, then turns green. Pull it and the door swings open.

The clues are all non-text — colours, symbols, lights, a buzzer. The only words on screen are the puzzle checklist and a small "Press E" prompt that pops up when you're looking at something you can interact with.

The first four can be done in any order — only the lever needs the rest finished first.

## Win & lose

- **Win:** solve all five, the lever goes green, and pulling it opens the door so you can walk out.
- **Lose / reset:** get the order in puzzle 2 wrong and it buzzes and resets that puzzle, so you have to work it out again.

## Assets I used

- **Furniture, lamp, desk props** — Kenney Furniture Kit (free): https://kenney.nl/assets/furniture-kit
- **First-person player controller** — Mini First Person Controller (free, Unity Asset Store): https://assetstore.unity.com/packages/tools/input-management/mini-first-person-controller-174710
- **Lever for the final puzzle** — low-poly lever off Sketchfab: https://sketchfab.com/3d-models/lever-power-switch-374608f75c114b8a9bf41dbc02c51c50
- The room shell (walls / floor / ceiling) is just stretched default Unity cubes with a Kenney material on them — I built that part by hand.

> Note to self: confirm the controller name above matches the one I actually imported before submitting.

## Controls

| Key / input | What it does |
|---|---|
| **W A S D** | Move around |
| **Shift** | Run while moving |
| **Mouse** | Look around |
| **E** | Interact with whatever the crosshair is on — power the lamp, press the desk objects, rotate, pick up / drop the item, pull the lever |

Walk up to something, put the crosshair on it (the "Press E" hint appears), and press E.