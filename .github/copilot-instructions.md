# Hunterphage Xenotype (Continued) GitHub Copilot Instructions

## Mod Overview and Purpose
Hunterphage Xenotype (Continued) is an update of BlackMarket420's mod, which adds a new xenotype called "The Hunterphage" to RimWorld. This mod includes several bug fixes by SypherRed and is compatible with RimWorld 1.6, which supports Asset Bundles to reduce the mod size.

The Hunterphage xenotype features unique abilities inspired by the "Shadow Stalker" rogue discipline from the game "Dungeon Blitz." It also includes new weapons, apparels, buildings, items, and a faction that can be interacted with or conquered.

## Key Features and Systems
### Hunterphage Xenotype
- New xenotype with unique abilities and traits inspired by the Shadow Stalker rogue discipline.
- New weapons and apparels with references to various games.
- New buildings for research and construction.
- New items and drugs.
- A faction that can be interacted with or conquered.

### Planned Projects
- New enemies and enemy faction "The Army of Fetid Corpse."
- Chemfuelpunk and Chemfuelpunk Vehicles projects.

## Coding Patterns and Conventions
### C# Code
- Use meaningful and descriptive names for classes, methods, and variables.
- Follow the RimWorld coding standards and conventions.
- Implement proper error handling and logging.
- Use Harmony patches for modding RimWorld functionalities.

### XML Integration
- Use XML files to define new game elements such as xenotypes, weapons, apparels, buildings, items, and factions.
- Ensure XML files are properly formatted and validated.
- Use XML comments to provide documentation for complex definitions.

## Harmony Patching
Harmony is a popular framework for modding RimWorld. To use Harmony patches in this mod:
1. Add the Harmony library to the mod's dependencies.
2. Create patch classes and methods using the Harmony API.
3. Apply patches to RimWorld methods to modify or extend their behavior.
4. Ensure patches are properly tested and do not introduce performance issues.

## Suggestions for Copilot
- Use Copilot to quickly generate code snippets for new game elements (e.g., new abilities, weapons, buildings).
- Use Copilot to generate Harmony patches for modifying existing RimWorld functionalities.
- Use Copilot to assist with XML file creation and validation.
- Use Copilot to generate documentation and comments for complex definitions.

By following these guidelines, developers can efficiently contribute to the Hunterphage Xenotype (Continued) mod and ensure compatibility with the latest versions of RimWorld.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Temporary files

- Do not create temporary files, build output, test artifacts, or Copilot session
  folders inside the mod root.
- Store temporary artifacts under `%USERPROFILE%\CopilotTemp\[modname]`.
- Direct build and test output there as well, without changing project settings.
- Clean up task-specific temporary artifacts when finished.

## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

