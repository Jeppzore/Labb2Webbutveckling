# API Specification

## Overview

This API manages products, customers, and orders for the e-commerce platform. Below is a detailed specification of the available endpoints.

---

## Products

### Get All Products

**GET** `/api/products`

**Description:**
Retrieves a list of all products in the system.

**Response:** `200 OK`

```json
[
    {
        "id": "60d5f9b5c2b4c705b8c6a7b5",
        "productNumber": "12345",
        "name": "T-shirt",
        "description": "A comfortable t-shirt",
        "price": 199.99,
        "category": 0,
        "status": 0
    }
]
```

### Get a Specific Product by Id

**GET** `/api/products/id/{id}`

**Description:**
Retrieves a specific product based on its Id.

**Response:** `200 OK`

```json
{
    "id": "60d5f9b5c2b4c705b8c6a7b5",
    "productNumber": "12345",
    "name": "T-shirt",
    "description": "A comfortable t-shirt",
    "price": 199.99,
    "category": 0,
    "status": 0
}
```

### Get a Specific Product by Name

**GET** `/api/products/name/{name}`

**Description:**
Retrieves a specific product based on its Name.

**Response:** `200 OK`

```json
{
    "id": "60d5f9b5c2b4c705b8c6a7b5",
    "productNumber": "12345",
    "name": "T-shirt",
    "description": "A comfortable t-shirt",
    "price": 199.99,
    "category": 0,
    "status": 0
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
    "category": 0,
    "status": 0
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
    "category": 0,
    "status": 0
}
```

**Response:** `204 No Content`

### Delete a Product

**DELETE** `/api/products/{id}`

**Response:** `204 No Content`


### Update Product Status To Unavailable

**PATCH** `/api/products/{id}/unavailable`

**Response:** `204 No Content`


### Update Product Status To Available

**PATCH** `/api/products/{id}/available`

**Response:** `204 No Content`

---

## Customers

### Get All Customers

**GET** `/api/customers`

**Response:** `200 OK`

```json
[
    {
        "id": "67e3e64b9c49d4669142aa82",
        "firstName": "John",
        "lastName": "Doe",
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
    "firstName": "John",
    "lastName": "Doe",
    "email": "john.doe@example.com",
    "address": "123 Main St",
    "phoneNumber": "+46701234567"
}
```

**Response:** `201 Created`


### Get a Specific Customer by Email

**GET** `/api/customers/{email}`

**Description:**
Retrieves a specific customer based on its Email.

**Response:** `200 OK`

```json
{
    "firstName": "John",
    "lastName": "Doe",
    "email": "john.doe@example.com",
    "address": "123 Main St",
    "phoneNumber": "+46701234567"
}
```

### Update a Customer

**PUT** `/api/customers/{email}`

**Request Body:**

```json
{
    "firstName": "Jane",
    "lastName": "Doe",
    "email": "john.doe@example.com",
    "address": "321 Second St",
    "phoneNumber": "+46701234567"
}
```

**Response:** `204 No Content`

---

## Orders

### Get All Orders

**GET** `/api/orders`

**Description:**
Retrieves a list of all orders in the system.

**Response:** `200 OK`

```json
[
    {
        "id": "67eb9f4be50fa8abc79764b3",
        "customerId": "67e3ff7d9c49d4669142aa86",
        "items": [
        {
            "productId": "67e3c5939c49d4669142aa81",
            "quantity": 3
        },
        {
            "productId": "67e9aaa9e729ca4b4b595cb5",
            "quantity": 2
        },
        {
            "productId": "67eb0037be18de701a8339b5",
            "quantity": 1
        }
        ],
        "totalPrice": 62.97,
        "orderDate": "2025-04-01T08:09:47Z",
        "status": "Pending"
    }
]
```

### Create a New Order

**POST** `/api/orders`

**Request Body:**

```json
{
    "customerId": "67e3ff7d9c49d4669142aa86",
    "items": [
    {
      "productId": "67e3c5939c49d4669142aa81",
      "quantity": 1
    }
  ],
    "totalPrice": 9.99,
    "orderDate": "2025-04-02T12:39:08.358Z",
    "status": "Pending"
}
```

**Response:** `201 Created`

### Get a Specific Order by Id

**GET** `/api/orders/{id}`

**Response:** `200 OK`

```json
{
    "id": "67eb9baa8d59ab34838db529",
    "customerId": "67e3e64b9c49d4669142aa82",
    "items": [
        {
            "productId": "60d5f9b5c2b4c705b8c6a7b5",
            "quantity": 2
        }
    ],
    "totalPrice": 399.98,
    "orderDate": "2025-04-01T07:54:18.811Z",
    "status": "Pending"
}
```

### Get ALL Orders by CustomerId

**GET** `/api/orders/customer/{customerId}`

**Response:** `200 OK`

```json
[
  {
    "id": "67eb9f4be50fa8abc79764b3",
    "customerId": "67e3ff7d9c49d4669142aa86",
    "items": [
      {
        "productId": "67e3c5939c49d4669142aa81",
        "quantity": 3
      },
      {
        "productId": "67e9aaa9e729ca4b4b595cb5",
        "quantity": 2
      },
      {
        "productId": "67eb0037be18de701a8339b5",
        "quantity": 1
      }
    ],
    "totalPrice": 62.97,
    "orderDate": "2025-04-01T08:09:47Z",
    "status": "Pending"
  },
  {
    "id": "67ed30343e2a9f29c6a1693d",
    "customerId": "67e3ff7d9c49d4669142aa86",
    "items": [
      {
        "productId": "67e3c5939c49d4669142aa81",
        "quantity": 1
      }
    ],
    "totalPrice": 9.99,
    "orderDate": "2025-04-02T12:39:08.358Z",
    "status": "Pending"
  }
]
```

### Update Order Status

**POST** `/api/orders/{id}/status`

**Request Body:**

```json
{
    "status": "Cancelled"
}
```

**Response:** `204 No Content`


### Delete an Order

**DELETE** `/api/orders/{id}`

**Response:** `204 No Content`

---

## Enum Values

### ProductCategory
| Value | Name        |
|-------|-------------|
| 0     | Clothes     |
| 1     | Electronics |
| 2     | Food        |
| 3     | Other       |

### ProductStatus
| Value | Name       |
|-------|------------|
| 0     | Available  |
| 1     | Unavailable|

---

## Status Codes

| Status Code               | Description                                           |
| ------------------------- | ----------------------------------------------------- |
| 200 OK                    | The request was successful and data was returned      |
| 201 Created               | The resource was successfully created                 |
| 204 No Content            | The request was successful but no content is returned |
| 400 Bad Request           | Invalid request                                       |
| 404 Not Found             | The resource was not found                            |
| 500 Internal Server Error | An unexpected error occurred                          |

---

## Contact

For any inquiries regarding the API specification, please contact me.





