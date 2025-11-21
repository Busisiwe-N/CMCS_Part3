CMCS Part 3 - Contract Monthly Claim System
Student: Busisiwe Nyembe (ST10443103)
Framework: .NET 8.0

Setup:
1. Ensure .NET 8 SDK and Visual Studio 2022/VS Code are installed.
2. Update 'appsettings.json' if you want a different DB.
3. Open Package Manager Console:
   - Add-Migration InitialCreate
   - Update-Database
4. Run the app.

Seeded accounts:
- lect1 / Password123! (Lecturer)
- coord1 / Password123! (Coordinator)
- manager1 / Password123! (AcademicManager)
- hr1 / Password123! (HR)

Key files:
- Program.cs - startup and DI
- Data/ApplicationDbContext.cs - EF Core DbContext
- Models/ - domain models
- Services/ - business logic
- Controllers/ - MVC controllers
- Views/ - Razor views
