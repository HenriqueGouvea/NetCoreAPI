# API with .NET Core 6

This is an example of an asynchronous .NET Core API that handles e-commerce products and the shopping carts of customers.

## Entities

### Customer
Considering there's no anonymous purchase, users should be logged in to buy. The Customer entity has the following properties:
- GUID
- UserName
- Password
- IsAdmin
- ShoppingCart
- Orders

### Product
Contains the following properties:
- ID
- Name
- Price
- PictureUrl
- StockQuantity
- SequenceNumber

The ProductsController has endpoints to read and modify products, but only admins should be able to modify them.

### ShoppingCart
Contains the following properties:
- GUID
- Products (ID, Quantity)
- Customer
- TotalPrice

The ShoppingCartController has endpoints to:
- AddProduct: should verify the stock and, if it's available, add it, decrease stock and update the TotalPrice. If there's no stock inform stock unavailability.
- RemoveProduct: update TotalPrice and restore stock.
- Order: clear the ShoppingCart and add it as an order of the customer

## Features
- [x] Swagger
- [x] Use ModelState for validations
- [x] Reading products with pagination
- [x] SQLite database
- [x] EntityFramework
- [x] Clean architecture
- [ ] Authentication via JWT token
- [ ] Register new user
- [ ] CRUD operations for Products
- [ ] CRUD operations for Order
- [ ] Add user role (only admins are able to modify products)
- [ ] Integration tests
- [ ] Unit tests
- [ ] Logging
- [ ] Centralized exceptions catching
- [ ] GitHub Actions