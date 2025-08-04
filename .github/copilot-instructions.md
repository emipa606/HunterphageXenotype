# GitHub Copilot Instructions for Hunterphage Xenotype (Continued)

## Mod Overview and Purpose

The **Hunterphage Xenotype (Continued)** mod brings a new xenotype, "The Hunterphage," inspired by the rogue discipline "Shadow Stalker" from a favorite game, "Dungeon Blitz." It enhances the RimWorld experience by adding new weapons, apparel, buildings, items, drugs, and a unique faction, providing players with the opportunity to interact with or conquer them.

The mod is an exciting addition for those looking to experience a rogue-like playthrough in RimWorld, emphasizing stealth and combat prowess with shadow-inspired abilities. This is only the beginning, as the mod creator hints at future projects like new enemies and factions, offering continued expansion on this dark and exhilarating theme.

## Key Features and Systems

- **Hunterphage Xenotype**: A unique race inspired by rogue-like abilities, focusing on combat and stealth.
- **New Weapons and Apparel**: Inspired by various games, these items enhance the player's arsenal and style.
- **Innovative Buildings**: Research and construct new buildings, offering tactical advantages.
- **Unique Items and Drugs**: Experiment with new items that affect gameplay and strategy.
- **Faction Interaction**: Engage with or battle against the new faction, offering a diverse range of strategic gameplay options.

## Coding Patterns and Conventions

- **Naming Conventions**: Follow C# conventions, using PascalCase for classes and methods.
- **Code Structure**: Organize classes within files based on functionality (e.g., abilities, effects, genes).
- **Class Inheritance**: Utilize inheritance for shared behaviors, such as `HediffWithComps` and `CompAbilityEffect`.
- **Static Classes**: Use static classes for definitions, maintaining a centralized repository for constants like `DamageDefOf` and `ThingDefOf`.

## XML Integration

- Integrate XML files for defining game objects, like weapons and buildings. Ensure definitions align with the static classes `ThingDefOf`, `DamageDefOf`, etc., for seamless integration into the game world.

## Harmony Patching

- Implement Harmony for overriding or extending game behaviors without modifying the original code. Ensure patches are targeted to specific methods, avoiding broad, invasive changes.
- Use descriptive prefixes and postfixes in patching methods to maintain clarity and avoid code conflicts.

## Suggestions for Copilot

- Copilot can assist by automating repetitive coding tasks, such as generating properties from definitions or scaffolding new class structures.
- Use Copilot to suggest XML structure for new items and definitions based on existing patterns.
- Leverage Copilot for generating unit tests for core functional methods, ensuring reliable and maintainable code.
- Use Copilot for writing Harmony patches, providing suggestions to maintain proper method signatures and ensuring correct attribute usage.

## Developer Contact

- **Commissions and Contributions**: The mod developer is open to commissions. Contact is available via Discord mentioned in the mod's details.
- **Compatibility Notes**: The mod is not CE compatible at this time. Reach out to Combat Extended authors for patch inquiries.

---

This document provides essential guidance to developers contributing to the Hunterphage Xenotype (Continued) mod, aiding in maintaining code quality and expanding its functionality.
