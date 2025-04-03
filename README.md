# Fullstack E-Commerce App (API, MongoDB & Blazor)

## Project Overview

This is a fullstack e-commerce application built using .NET 8, MongoDB, and Blazor.
The backend consists of a REST API that handles Products, Customers, and Orders, while the frontend is a Blazor app that interacts with the API.

Backend: .NET 8 REST API using "Code First" to create and connect to a MongoDB database (ECommerceDb) locally. Supports full CRUD operations.

Frontend: Blazor application that allows users to register, update personal details, and place orders through the connected API.

---
## Getting Started
Follow these steps to set up and run the project locally:

**1. Set Up the API**
- Clone the API repository: https://github.com/Jeppzore/Labb2Webbutveckling.git

*Set up a local MongoDB database:*

- Ensure MongoDB is installed and running.
- You can start a local MongoDB instance using: mongosh
- The API connects to a database named ECommerceDb.

*Run the API:*
- Open the project in VS Code.
- Start the API in the terminal with: dotnet run (view -> terminal)
- Ensure the API is running at: **http://localhost:5139**

**2. Set Up the Blazor Frontend**
- Clone the Blazor repository: https://github.com/Jeppzore/ECommerceLabb.git
- Open the project in Visual Studio.
- Run the Blazor app from Visual Studio.

**3. Testing the Application**
- Once both the API and Blazor frontend are running, you can interact with the API directly via the Blazor interface.

- Navigate through the navbar to access different features such as Product Management, Customer Registration, and Order Placement.

---
## API Specification
For details on available API endpoints and how to interact with them, please refer to:
📄 ==API-Specification.md==
