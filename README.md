# CheraasjeEpp – Garage Management System

**Authors:** Jelte, Remco & Joachim

---

## Description
CheraasjeEpp is a comprehensive Windows Forms application for managing a car garage chain. The system allows employees and administrators to efficiently manage vehicle inventory, branches, and users. Instead of simple text files, the application uses a robust **SQLite database** to ensure secure and reliable data storage.

The application features a modern, consistent user interface and supports both daily operational tasks and administrative management.

---

## Features

### Authentication & Security
- Secure login using a unique user ID and password  
- Role-based access control (Employee vs. Administrator)

### Fleet Management
- View the complete vehicle inventory per branch  
- Advanced filtering and search options:
  - Brand & model  
  - Price range  
  - Color  
  - Number of doors  
- Detailed vehicle view including specifications and images

### Branch Management
- View branch details such as address, phone number, and owner  
- Access branch opening hours

### Administration (Admin Only)
- User management (add, edit, delete users)  
- Branch management (add, edit, delete branches)  
- Vehicle management (add new vehicles with images, remove sold vehicles)

---

## Technical Details
- **Framework:** .NET 8.0 (Windows Forms)  
- **Language:** C#  
- **Database:** SQLite (`database.db`)  
- **Architecture:**
  - Clear separation between Data, Models, and UI layers  
  - Custom UI components (e.g., `RoundedButton`, `RoundedTextBox`) for a modern look and feel

---

## Installation & Usage
1. Clone the repository.  
2. Open the solution (`.sln`) in Visual Studio.  
3. Ensure `database.db` is present in the `Data` folder (included by default in the build output).  
4. Run the application using `F5` or the **Start** button.

---

## Project Status
This project meets all assignment requirements and has been extended with database persistence and an enhanced user experience.
