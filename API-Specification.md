# API Specification

## Overview
This API manages products, customers, and orders for the e-commerce platform. Below is a detailed specification of the available endpoints.

---

## Products

### Get All Products
**GET** `/api/products`

**Description:**
Retrieves a list of all products in the system.

**Response:**
```json
[
    {
        "id": "60d5f9b5c2b4c705b8c6a7b5",
        "productNumber": "12345",
        "name": "T-shirt",
        "description": "A comfortable t-shirt",
        "price": 199.99,
        "category": "2",
        "status": "0"
    }
]
```

### Get a Specific Product
**GET** `/api/products/id/{id}`

**Description:**
Retrieves a specific product based on its ID.

**Response:**
```json
{
    "id": "60d5f9b5c2b4c705b8c6a7b5",
    "productNumber": "12345",
    "name": "T-shirt",
    "description": "A comfortable t-shirt",
    "price": 199.99,
    "category": "2",
    "status": "0"
}
```

### Get a Specific Product
**GET** `/api/products/name/{name}`

**Description:**
Retrieves a specific product based on its NAME.

**Response:**
```json
{
    "id": "60d5f9b5c2b4c705b8c6a7b5",
    "productNumber": "12345",
    "name": "T-shirt",
    "description": "A comfortable t-shirt",
    "price": 199.99,
    "category": "2",
    "status": "0"
}
```

### Create a New Product
**POST** `/api/products`

**Request Body:**
```json
{
    "productNumber": "12345",
    "name": "T-shirt",
    "description": "A comfortable t-shirt",
    "price": 199.99,
    "category": "2",
    "status": "0"
}
```

**Response:** `201 Created`

### Update a Product
**PUT** `/api/products/{id}`

**Request Body:**
```json
{
    "productNumber": "12345",
    "name": "T-shirt Updated",
    "description": "An even better t-shirt",
    "price": 249.99,
    "category": "2",
    "status": "0"
}
```

**Response:** `204 No Content`

### Delete a Product
**DELETE** `/api/products/{id}`

**Response:** `204 No Content`

---

## Customers

### Get All Customers
**GET** `/api/customers`

**Response:**
```json
[
    {
        "id": "67e3e64b9c49d4669142aa82",
        "firstname": "John",
        "lastname": "Doe",
        "email": "john.doe@example.com",
        "address": "123 Main St",
        "phoneNumber": "+46701234567"
    }
]
```

### Create a New Customer
**POST** `/api/customers`

**Request Body:**
```json
{
    "firstname": "John",
    "lastname": "Doe",
    "email": "john.doe@example.com",
    "address": "123 Main St",
    "phoneNumber": "+46701234567"
}
```

**Response:** `201 Created`

---

## Orders

### Create a New Order
**POST** `/api/orders`

**Request Body:**
```json
{
    "customerId": "67e3e64b9c49d4669142aa82",
    "items": [
        {
            "id": "60d5f9b5c2b4c705b8c6a7b5",
            "quantity": 2
        }
    ],
    "totalPrice": 399.98
}
```

**Response:** `201 Created`

### Get a Specific Order
**GET** `/api/orders/{id}`

**Response:**
```json
{
    "id": "67eb9baa8d59ab34838db529",
    "customerId": "67e3e64b9c49d4669142aa82",
    "items": [
        {
            "id": "60d5f9b5c2b4c705b8c6a7b5",
            "quantity": 2
        }
    ],
    "totalPrice": 399.98,
    "orderDate": "2025-04-01T07:54:18.811Z",
    "status": "Pending"
}
```

### Update Order Status
**PATCH** `/api/orders/{id}`

**Request Body:**
```json
{
    "status": "Shipped"
}
```

**Response:** `204 No Content`

### Delete an Order
**DELETE** `/api/orders/{id}`

**Response:** `204 No Content`

---

## Status Codes
| Status Code | Description |
|------------|-------------|
| 200 OK | The request was successful and data was returned |
| 201 Created | The resource was successfully created |
| 204 No Content | The request was successful but no content is returned |
| 400 Bad Request | Invalid request |
| 404 Not Found | The resource was not found |
| 500 Internal Server Error | An unexpected error occurred |

---

## Contact
For any inquiries regarding the API specification, please contact the IT department at Länsstyrelsen.



