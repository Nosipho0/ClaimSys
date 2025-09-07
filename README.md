# ClaimSys
ClaimSys is a simple web-based claims management system built with **ASP.NET Core MVC**.  
It allows users to register, log in, submit claims, and view claim history. The system also includes a dashboard with quick navigation and an overview of its functionality.

---

## Features
- **User Authentication**
  - Register new accounts with username, password, and role.
  - Login with existing credentials.
- **Dashboard**
  - Displays a welcome message and system overview.
  - Provides quick links to submit claims, view history, and access reports.
- **Claims Management**
  - Submit new claims with a description and amount.
  - View claim history in a simple table format.
- **Navigation Bar**
  - Always visible for easy access to Home, Claims, Reports, and Logout.
- **Reports Page**
  - Placeholder page for future report functionality.

---
## How It Works
When the project is run, ClaimSys starts on the **Login page**.  
- New users can **register**, while existing users can **log in**.  
- After login, the user is redirected to the **Dashboard**, which shows a welcome message, overview, and quick links.  
- Users can then **submit a claim**, which is added to the in-memory claim list, and **view claim history**.  
- The **navigation bar** allows movement between Home, Claims, Reports, and Logout.  

---

## ▶ How to Run
1. Open the solution in **Visual Studio**.  
2. Build the project (`Ctrl+Shift+B`).  
3. Run the project (`F5` or the green play button).  
4. The system will start in the browser at the **Login page**.  

---

## Notes
- This version stores data **in memory only** (users and claims are lost when the app restarts).  
- You can extend it by adding a **database** (e.g., SQL Server with Entity Framework).  
- Reports are currently placeholders and can be expanded with real analytics.

---


## 🏗️ Project Structure
