# Copilot Instructions for Hunterphage Xenotype (Continued)

## Mod Overview and Purpose

Hunterphage Xenotype (Continued) is a comprehensive mod for RimWorld, originally crafted by BlackMarket420 and updated to utilize the improved asset bundle support introduced in RimWorld 1.6. This mod introduces a new xenotype known as "The Hunterphage" along with a variety of new gameplay elements including weapons, apparel, buildings, items, drugs, and an interactive faction. The Hunterphage Xenotype draws inspiration from the rogue discipline "Shadow Stalker" from the game "Dungeon Blitz." The mod is designed to enhance your gameplay by allowing you to dominate other factions with powerful new abilities and stylish gear.

## Key Features and Systems

- **The Hunterphage Xenotype:** A new faction with unique abilities reminiscent of the Shadow Stalker. 
- **New Weapons and Apparel:** A selection of gear inspired by various beloved games, enhancing combat and providing new strategies.
- **Researchable Buildings:** Introduce new buildings that expand your colony's technology and production capabilities.
- **Unique Items and Drugs:** Experiment with new resources that provide diverse benefits and effects.
- **Interactive Faction:** Engage with or conquer the Hunterphage faction, adding depth to inter-factional interactions.

## Coding Patterns and Conventions

- **C# Usage:** The mod's core logic is written in C#, divided into functional components. Each file typically contains one primary class, and methods within these classes adhere to consistent naming conventions for clarity and maintainability.
- **XML Definitions:** The mod defines new objects, items, and behaviors using XML. Each file encapsulates related definitions to promote modularity.
- **File Organization:** C# source files and XML definition files are organized into directories named according to their content type, e.g., `DarkEssence` for core capabilities, `Defs` for game definitions.

## XML Integration

- **Ability and Item Definitions:** Use XML to define new abilities and items, with each object having its file for cleaner separation.
- **Building and Item Defs:** XML files contain `ThingDef`, `StatDef`, and other definitions required to introduce new game entities.
- **Balancing and Testing:** Iteratively adjust XML stats for balance; test changes within a controlled RimWorld environment for validation.

## Harmony Patching

- **Patching Use:** Use Harmony to modify existing game mechanics without altering the base game code, ensuring compatibility.
- **Patch Locations:** Place Harmony patches before or after base method calls depending on the desired behavior change.
- **Implementation Best Practices:** Keep Harmony patches exceedingly specific to limit potential conflicts, and document all patches thoroughly for future reference.

## Suggestions for Copilot

- **Code Generation:** Use Copilot to quickly scaffold C# methods for new abilities or items based on existing patterns within the mod.
- **XML Suggestions:** Leverage Copilot to autocomplete XML tags and attributes based on similar existing definitions, particularly useful for large repetitive structures like item definitions.
- **Error Identification:** Instruct Copilot to help identify potential logic errors in Harmony patches by analyzing method signatures and typical usage patterns.

Please ensure all contributions to the project follow these guidelines to maintain consistency and quality throughout the mod. For support or additional guidance, consider joining our dedicated Discord server.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).

