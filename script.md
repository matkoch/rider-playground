# Introduction
- Architecture (front/backend)
- Included: DataGrip, WebStorm, IDEA (all JetBrains IDEs)
- Plugins (PowerShell, Bash, Grazie, Structured Logging)

# First Look & Editing
- General shortcuts (shift-shift) (my productivity)
- Settings
    - Block caret
    - Auto: Insert EOF / Remove trailing spaces (only modified lines)
    - Widescreen setting
    - Soft-wrap per file-type
- Themes
- Terminal
- Solution explorer / file system / assembly explorer
- Zen mode
- Disable tabs?

# Basics
- Alt-Enter
- Code simplification
- Code completion (unimported types + extension methods, inside interpolated strings)
- Code navigation (base/derived types, recent files/edits, last edit location, find in files, find usages/symbols)

# Code Analysis
- Solution-wide analysis
- Switching to new language features (bulk fixes)
- Changing severities (LINQ OrderBy vs. ThenBy could be error instead of warning)
- Run Inspection X (finds all issues of a specific type in solution)
- Heap allocation viewer
- Cognitive complexity
- InspectCode CLI (run inspections on CI)

# Editing / Refactorings
- Postfix templates
- Live/file templates (create from usage)
- Expand/shrink selection + select occurrence (poor man rename, very powerful)
- Complete statement (Ctrl-Shift-Enter)
- Reformat code (Ctrl-Alt-Enter)

# Debugging
- Run Configurations (compound, sharable)
- Floating Icons (forget about shortcuts)
- Decompiled Sources (seemingly debug into nuget packages)
- Conditional breakpoints (code completion + removal confirmation)
- Immediate Window (code completion)
- Dependent Breakpoints (IDEA feature)

# Smaller features
- Docker (creating images, inspecting filesystem, download to scratch files)
- HttpClient (writing parameterized http request)
- Inspecting log files (Ideolog plugin)

# VCS
- Branch operations (change indicators, favorites, VCS operations quicklist)
- Multi-repo support
- Log (searching/filtering/shortcuts)
- Local history
- ... for selection
- Fixes in diff
- Changelists (pre-organizing commits, avoid commit secrets)
- GitToolBox

# Unit Testing
- Shortcuts
- Coverage
- Quicklist
- Auto-run tests until failure
