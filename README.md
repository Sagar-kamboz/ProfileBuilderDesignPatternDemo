# Builder Pattern in .NET — User Profile Builder (Practical Example)

> Clean, practical implementation of the **Builder design pattern** in .NET.  
> Create `User` objects with required + optional fields using a fluent, testable and maintainable approach.

---

## 🔎 Overview

This repository demonstrates the **Builder design pattern** with a real-world example: building `User` objects (required fields: `FirstName`, `LastName`; optional fields: `Email`, `Phone`, `Address`, `Age`, `Gender`). The project follows a clean folder structure (`Core`, `Infrastructure`, `Services`) and includes a Director for common build recipes.

**Why this repo?**
- Shows how to avoid monstrous constructors and telescoping overloads.
- Demonstrates required-vs-optional fields handling.
- Provides code you can copy directly into real projects.

---

## 🔖 Features
- Fluent builder API for readable object creation.
- Director class that encapsulates common construction recipes.
- Separation of concerns (Core / Infrastructure / Services).
- Ready-for-extension — follow OCP and SRP principles.

---

📄 Documentation & Downloads

Full guide (docx): https://drive.google.com/file/d/10sUVzjbPJxLHeU8ayJ8DXkQvtv81wzNr/view?usp=sharing


