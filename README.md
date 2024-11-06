This is a sample code

This application functions as a REST API and it is created by using .NET 8 version with ASP.NET Core Web API.
The application will store all the products in the cache and provides the below functionality. 

Following information can be obtain using the GET method.
function 
api/products // returns all the products. 
api/products/{id} // where id is the GUID of the product.

Below data needs to specified in the body of the HTTP POST method. This will store the data in the applications cache memory.
{
    "id": "b3604e84-13a6-4bcc-88aa-68d8255fc946", // id is not necessary as it will create new GUID
    "name": "Apple", 
    "description": "Macbook Pro",
    "price": 1399,
    "stockQuantity": 1000
}
function
api/products // Stores the data and returns the data in the response

You can use the above data model to pass the data throug HTTP PUT method to update a product by
api/products/{id} // where id is the GUID of the product.

You can also delete/remove a specific product by specifying the id in the parameter when using the HTTP DELETE method.
api/products/{id}  // where id is the GUID of the product.
