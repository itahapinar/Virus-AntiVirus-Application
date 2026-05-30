# 🛡️ AntiVirus Application

A Windows Forms desktop application built with C# and .NET 8 that demonstrates how malware can persist in the Windows Registry and how antivirus tools detect and remove such threats.

## Overview

This educational project simulates a simple threat creation and detection cycle using the Windows Registry startup key (`HKCU\Software\Microsoft\Windows\CurrentVersion\Run`). It is intended to help users understand how trojans and malware establish persistence on a Windows system — and how security software identifies and eliminates them.

> ⚠️ **Disclaimer:** This application is strictly for **educational and demonstration purposes**. It only modifies the current user's registry (no system-level changes) and does not create or execute any actual malicious files.

## Features

- **Create a Simulated Threat** — Injects a fake trojan entry (`test_trojan`) into the Windows Registry startup key, mimicking how real malware achieves persistence.
- **Scan the System** — Scans all entries under the startup registry key and flags any entry whose name contains `"virus"` or `"test"`.
- **Auto-Clean** — Automatically deletes detected threats from the registry and reports the result in the UI.
- **Real-time Status Display** — Shows scan results and system status (safe/at risk) in a live log list and a color-coded label.

## Tech Stack

| Component | Details |
|-----------|---------|
| Language | C# |
| Framework | .NET 8 |
| UI | Windows Forms (WinForms) |
| Platform | Windows only (`net8.0-windows`) |
| IDE | Visual Studio 2022 |

## Project Structure

```
AntiVirus/
├── AntiVirus.sln            # Solution file
└── AntiVirus/
    ├── Program.cs           # Application entry point
    ├── Form1.cs             # Main form logic (threat creation & scanning)
    ├── Form1.Designer.cs    # Auto-generated UI layout
    ├── AntiVirus.csproj     # Project configuration
    ├── Properties/
    │   ├── Resources.resx
    │   └── Resources.Designer.cs
    └── Resources/
        └── ai analiz.png    # UI asset
```

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Windows OS (required for Windows Forms and Registry access)
- Visual Studio 2022 (recommended) or any .NET-compatible IDE

### Build & Run

1. Clone or extract the repository.
2. Open `AntiVirus.sln` in Visual Studio.
3. Build the solution (`Ctrl+Shift+B`).
4. Run the project (`F5` or `Ctrl+F5`).

Or via the .NET CLI:

```bash
cd AntiVirus
dotnet build
dotnet run
```

## How It Works

### 1. Create a Virus (Simulate Threat)
Clicking **"Create a Virus"** writes the following entry to the Windows Registry:

```
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
  test_trojan = "zararli_arka_plan_islemi.exe"
```

This is how real malware ensures it runs automatically on every Windows login.

### 2. Scan The System and Clear
Clicking **"Scan The System and Clear"** reads all values under the startup registry key and checks each entry name for suspicious keywords (`"virus"`, `"test"`). If a match is found:
- The threat is logged in the results list.
- The registry entry is permanently deleted.
- The status label updates to confirm the system is clean.
