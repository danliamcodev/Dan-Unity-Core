# Version Control Standards
The purpose of this document is to establish standards when using version control for projects.

## Table of Contents
- [Branching Standards](#branching-standards)
- [Commit Messages](#commit-messages)
  - [Additions](#additions)
  - [Updates](#updates)
  - [Fixes](#fixes)
  - [Improvements](#improvements)
  - [Optimizations](#optimizations)
  - [Bug Reports](#bug-reports)
  - [Documentation](#documentation)
  - [Dependencies](#dependencies)
  - [Testing](#testing)
  - [Refactoring](#refactoring)
  - [Branch Management](#branch-management)
  - [Reverts](#reverts)

## Commit Messages

### Additions
For adding new features, assets, or functionality to the project. For example, adding new character models, animations, or new game features.

#### Examples
- Add new character model and animations
- Integrate particle effects for enemy spawn
- Implement a settings menu for audio control

---

### Updates
For making updates or improvements to existing features or assets. This can include UI improvements, code enhancements, or level design updates.

#### Examples
- Update UI layout for better mobile compatibility
- Update character movement script for smoother animation transitions
- Update level design based on feedback

---

### Fixes
For addressing and fixing bugs or issues in the project. This can encompass fixing gameplay-related issues, UI problems, or technical glitches.

#### Examples
- Fix character collider bug causing player to fall through the ground
- Fix enemy AI pathfinding issue
- Fix UI button not responding to clicks

---

### Improvements
For enhancing the overall quality or user experience of the project. This can involve graphical improvements, gameplay enhancements, or code optimizations.

#### Examples
- Improve lighting and shadows in level 3
- Improve player jump mechanics for better gameplay experience
- Improve code readability by refactoring enemy spawning logic

---

### Optimizations
For optimizing the project for better performance, such as improving rendering, reducing load times, or enhancing memory management.

#### Examples
- Optimize rendering pipeline for better performance
- Optimize resource loading to reduce load times
- Optimize memory usage in audio manager

---

### Bug Reports
For addressing issues reported by users or team members. Mention the specific issue numbers or descriptions you're resolving.

#### Examples
- Address issue #432: Resolve crashing bug on startup
- Fix issue #567: Handle null reference error in player script
- Close issue #789: Improve network synchronization

---

### Documentation
For making changes or additions to project documentation. This can include updating README files, documenting APIs, or adding code comments for clarity.

#### Examples
- Update README with instructions for setting up the project
- Document public API for custom scripts
- Add inline code comments for clarity

---

### Dependencies
For managing or updating project dependencies, such as Unity version updates or package changes.

#### Examples
- Update Unity version to 2020.3.2f1
- Update TextMeshPro package to version 3.0.0
- Add PostProcessing v2.0.1 package for improved visual effects

---

### Testing
For conducting testing activities, including adding tests, confirming compatibility on different platforms, or assessing performance.

#### Examples
- Add unit tests for the player health system
- Test game functionality on macOS and confirm compatibility
- Performance testing for level loading times

---

### Refactoring
For restructuring or improving the codebase for better readability and maintainability. This can involve renaming variables, methods, or splitting large scripts into smaller components.

#### Examples
- Refactor character movement script for readability and modularity
- Rename variables and methods for consistency
- Split a monolithic script into smaller reusable components

---

### Branch Management
For handling version control tasks, like merging branches, resolving conflicts, or creating new branches for features.

#### Examples
- Merge feature/character-customization into develop
- Resolve conflicts in feature/enemy-ai branch
- Create feature/level-selection branch

---

### Reverts
For reverting changes made in previous commits due to unintended issues or problems that need to be addressed.

#### Examples
- Revert commit abc123: Reverting changes due to unintended issues
- Revert feature/enhancement-X: Not ready for production
