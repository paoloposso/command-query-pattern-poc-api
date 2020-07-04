**Framework**

The libs were written in .net standard 2.1, while the API is in .net Core 3.1


**About the architecture**

The present project was written using the practice of CQS (Command-Query separation). In this case we only have a query but will be possible to add the commands if/when needed.
The App layers has the responsibility of receiving the queries, validating the entries and after that calling the domain layer, which contains the use cases.
The Domain layer consists on the entities and services needed to implement our business use cases.
Besides the application and domainn layers we have the API, which receives the requests and calls the application layer and the tests, that in this case calls the domain layer directly.


**Tests**

To run the tests simply run dotnet test.

**Run Project**
Inside filder Multiples.Api, which contains the API project, execute dotnet run.
The url http://localhost:5000/swagger contains the path to the swagger, where is the API documentation and where you're able to execute requests.