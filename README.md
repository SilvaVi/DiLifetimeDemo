# DI Lifetime Demo – ASP.NET Core

This project is a **hands-on demonstration of Dependency Injection lifetimes** in ASP.NET Core, focusing on:

- `Singleton`
- `Scoped`
- `Transient`

It also reproduces **one of the most common DI errors in real-world applications** and explains the correct and incorrect ways to fix it.

---

## 🎯 Purpose

The goal of this project is to **deeply understand how DI lifetimes behave at runtime**, not just conceptually.

This repository is especially useful for:
- Developers learning ASP.NET Core DI
- Preparing for technical interviews
- Understanding common production pitfalls
- Studying microservices architecture patterns

---

## 🧩 What This Project Demonstrates

### ✅ Correct behavior of lifetimes
- **Singleton**: One instance for the entire application lifetime
- **Scoped**: One instance per HTTP request
- **Transient**: A new instance every time it is requested

### ❌ Classic DI error
- A `Singleton` depending on a `Scoped` service
- Why this causes a runtime exception
- Why the container blocks this scenario

### ⚠️ Common incorrect fix
- Changing `Scoped` to `Transient`
- Why this *seems* to work
- Why it is dangerous in real applications

### ✅ Best practice solution
- Refactoring the service lifetime to match its responsibility
- Keeping the architecture consistent and safe

---

## 🧠 Key Concepts Covered

- Dependency Injection container behavior
- Service lifetime validation
- Object lifetime vs dependency lifetime
- Why **stateless services** are critical in microservices
- How ASP.NET Core protects you from invalid lifetimes

---

## 🚀 How to Run the Project

### Prerequisites
- .NET 7 or .NET 8 SDK
- Visual Studio Code or Visual Studio

### Run
```bash
dotnet run
