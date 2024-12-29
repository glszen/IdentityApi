# User Registration API (C# .NET)

This guide explains how to implement a **User Registration API** using **ASP.NET Core** and **Entity Framework**, covering the creation of a `User` table, model validation, and password encryption.

## Steps to Implement

### 1. Create a `User` Table
Define a `User` model class with `Email` and `Password` properties to represent user data in the database.

### 2. Set Up Entity Framework Code-First
- Create a `DbContext` to manage the `User` table.
- Use Entity Framework's **Code-First** approach to generate the database schema from the model.
- Run migrations to create the database tables.

### 3. Model Validation
- Use **Data Annotations** for input validation:
  - `[Required]` ensures that fields like `Email` and `Password` are provided.
  - `[EmailAddress]` validates the email format.
  - `[MinLength]` enforces password strength (e.g., minimum length of 6 characters).

### 4. Password Encryption
- Use **ASP.NET Core Identity**'s `UserManager` to securely hash passwords before storing them in the database.
- The `UserManager.CreateAsync` method automatically hashes passwords during registration.

## Key Concepts

- **Entity Framework Code-First**: Automatically creates the database schema based on your model classes.
- **Model Validation**: Ensures that user inputs meet the required criteria, such as valid email format and password strength.
- **Password Hashing**: Ensures that passwords are securely stored in the database by hashing them before storage.

## Conclusion

This API demonstrates how to:
- Build a secure **user registration system** using **Entity Framework** and **ASP.NET Core**.
- Ensure **data integrity** through **input validation** and **password encryption**.

This approach provides a reliable foundation for managing user accounts in your web application, with a focus on security and user data protection.
