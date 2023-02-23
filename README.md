# Project Name

This project has been developed using the Onion Architecture and Mediatr Pattern design patterns, which enables communication between the application layers without creating a tight dependency between them.

In addition, Entity Framework and AutoMapper technologies have been used in the project. Entity Framework is used for managing database operations, while AutoMapper allows for easy conversion between data objects.

The loosely coupled development of the project means that dependencies between application layers are kept to a minimum. This reduces the impact of changes made in one layer on the other layers.

## Project Structure

The project consists of the following layers, in accordance with the Onion Architecture design pattern:

- **Core**: The layer where basic objects and business logic are located.
- **Infrastructure**: The layer where database operations are performed and communication with external services is established.
- **Application**: The layer where the application's business logic is located. Mediatr Pattern is used to perform the necessary operations in this layer.
- **Web**: The layer where the user interface is located. This layer defines the APIs of the application.

## Installation

To run the project, follow these steps:

1. Clone the project: `git clone https://github.com/ahmetbabalii/ProductApp-OnionArch-MediatR.git`
2. Navigate to the project directory: `cd ProductApp-OnionArch-MediatR`
3. Install necessary dependencies: `dotnet restore`
4. Create the database: `dotnet ef database update`
5. Run the application: `dotnet run`




![Onion Architecture](https://www.gencayyildiz.com/blog/wp-content/uploads/2021/03/Nedir-Bu-Onion-Architecture-1.png)


