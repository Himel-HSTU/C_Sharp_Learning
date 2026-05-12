// Today we will just use libraries of different .NET versions just to see if they work as same (mostly)

//using dotnetFrameworkLibrary;
using dotnetStandardLibrary;


Generators generator = new Generators();
string welcomeMessage = generator.WelcomeMessage("Dr.", "Jane", "Smith");
string farewellMessage = generator.FarewellMessage("Dr.", "Jane", "Smith");
Console.WriteLine(welcomeMessage);
Console.WriteLine(farewellMessage);

PersonModel person = new PersonModel
{
    Prefix = "ENG.",
    Fname = "Himel",
    Lname = "Rahman"
};
Console.WriteLine(generator.WelcomeMessage(person.Prefix, person.Fname, person.Lname));
Console.WriteLine(generator.FarewellMessage(person.Prefix, person.Fname, person.Lname));



Console.ReadLine();

// ╔══════════════════════════════════════════════════════════════════╗
// ║           .NET FRAMEWORK vs .NET CORE vs .NET (5+)             ║
// ╚══════════════════════════════════════════════════════════════════╝

// ══════════════════════════════════════════════════════════════════
// THE SIMPLE STORY
// ══════════════════════════════════════════════════════════════════
// Microsoft built .NET Framework in 2002 — Windows only
// Developers wanted cross-platform (Linux, Mac) → .NET Core born 2016
// Microsoft unified everything → .NET 5 in 2020, just called ".NET"
// Now: .NET 6, 7, 8, 9, 10 — this is what you use

// ══════════════════════════════════════════════════════════════════
// THE THREE VERSIONS — QUICK IDENTITY
// ══════════════════════════════════════════════════════════════════

// .NET FRAMEWORK (1.0 → 4.8)
// ─────────────────────────────
// Released  : 2002
// Platform  : Windows ONLY
// Status    : Still alive but NO new features — maintenance mode
// You'll see : Startup.cs, verbose using statements, old NuGet packages
// Where      : Legacy enterprise apps, old BD company codebases
// Example    : Bank software built in 2010 still running on .NET Framework

// .NET CORE (1.0 → 3.1)
// ─────────────────────────────
// Released  : 2016
// Platform  : Windows, Linux, Mac — cross platform
// Status    : Dead — replaced by .NET 5+
// You'll see : Startup.cs still exists here
// Where      : Nowhere new — just old projects from 2016-2020
// Note       : .NET Core 4 was SKIPPED to avoid confusion with Framework 4

// .NET (5, 6, 7, 8, 9, 10)
// ─────────────────────────────
// Released  : 2020 (v5) → current (v10)
// Platform  : Windows, Linux, Mac, Mobile, Cloud
// Status    : ACTIVE — this is the present and future
// You'll see : No Startup.cs, minimal Program.cs, implicit usings
// Where      : All modern projects — what YOU are learning
// Note       : .NET 5+ is just "unified .NET Core" with better name

// .NET STANDARD (1.0 → 2.1)
// ─────────────────────────────
// Not a platform — a COMPATIBILITY SPECIFICATION
// A bridge so one library works on both Framework AND Core
// Status    : No longer needed for new projects
// Where     : NuGet packages that need to support old + new .NET

// ══════════════════════════════════════════════════════════════════
// WHERE THEY ARE THE SAME ✅
// ══════════════════════════════════════════════════════════════════
// C# language itself          → identical across all versions
// OOP — classes, interfaces   → identical
// Inheritance, generics       → identical
// LINQ                        → identical
// Collections, List<T>        → identical
// Basic NuGet packages        → mostly identical
// SQL Server connection        → identical concept
// Entity Framework Core       → works on modern .NET only
//                               (EF6 was Framework, EF Core is new)

// ══════════════════════════════════════════════════════════════════
// WHERE THEY DIFFER ❌
// ══════════════════════════════════════════════════════════════════

// 1. STARTUP / PROGRAM STRUCTURE
// .NET Framework / Core 3:
//   → Startup.cs exists separately
//   → ConfigureServices() for DI setup
//   → Configure() for middleware pipeline
//
// .NET 6+ (what you use):
//   → No Startup.cs
//   → Everything in Program.cs
//   → builder.Services.Add...() for DI
//   → app.Use...() for middleware

// 2. USING STATEMENTS
// Old (.NET Framework / Core):
//   → must manually write every using at top of file
//   → using System;
//   → using System.Collections.Generic;
//   → using System.Linq; etc.
//
// New (.NET 6+):
//   → Implicit global usings — auto imported
//   → You write nothing at top for common namespaces
//   → System, Collections, Linq all available automatically

// 3. PLATFORM SUPPORT
// .NET Framework  → Windows ONLY
// .NET Core+      → Windows, Linux, Mac, Cloud, Docker

// 4. PERFORMANCE
// .NET Framework  → slower, older architecture
// .NET 6+         → massively faster
//                   ASP.NET Core one of fastest web frameworks globally

// 5. OPEN SOURCE
// .NET Framework  → closed source (Microsoft only)
// .NET Core / 5+  → fully open source on GitHub

// ══════════════════════════════════════════════════════════════════
// WHAT YOU'LL SEE IN BD COMPANIES
// ══════════════════════════════════════════════════════════════════
// Old/legacy companies  → .NET Framework 4.x
//                          Startup.cs, Windows Server, IIS hosting
//                          verbose code, old patterns
//
// Modern companies      → .NET 6, 8, or 10
// (KAZ, Brain Station,     Program.cs only, Docker, Cloud
//  Enosis, BJIT)           clean minimal setup
//
// PRO TIP: When interviewing, ask "which .NET version do you use?"
//          If they say 4.x — you'll encounter Startup.cs
//          If they say 6+ — familiar territory, same as your learning

// ══════════════════════════════════════════════════════════════════
// THE ONE LINE SUMMARY
// ══════════════════════════════════════════════════════════════════
// .NET Framework = old Windows-only grandfather (still alive, no growth)
// .NET Core      = the crossplatform revolution (now retired name)
// .NET 5+        = the unified present and future (what YOU are learning)
// .NET Standard  = the compatibility bridge (not needed for new projects)
// C# language    = same across all of them, your skills transfer everywhere