# Keep a Changelog (SingletonPattern Voting Program)

### Unreleased


## [2.0.0] – Initial Release - 20.01.2026

### Added
- Added Party-Votes
- Added string attribute for the voted party in VotingPeople.cs

### Fixed
- Fixed Party-Index (Always one (+1) ahead)

## [1.0.0] – Initial Release - 20.01.2026

<br>
<br>

### Added
- Initial implementation of the **Singleton Pattern** via `VoteMachine`
- Centralized vote handling using a single global `VoteMachine` instance
- Console-based voting system with interactive menu
- Ability to add voters with:
  - First name
  - Last name
  - Age validation (18+ required)
  - Auto-generated fingerprint
- Secure admin-only voter list display using password authentication
- Internal storage of all voters using `List<VotingPeople>`
- Custom `ToString()` implementation for clean voter output
- Basic input validation and error handling for invalid age input

### Technical Details
- Written in **C#**
- Console Application
- Uses:
  - Singleton Pattern
  - Encapsulation
  - Basic exception handling
  - Collections (`List<T>`)

### Notes
- This version represents the **first functional prototype**
- Designed for learning and demonstration purposes
- No persistence layer (data is lost on program exit)

