# Make WCF new

Most SOAP Services --> REST

Binary --> gRPC

Duplex --> SignalR

Stateful --> don't do this (or use Durable Azure Functions)

Authentication --> OAuth, OpenID Connect

Transactions --> Saga pattern

[More info Saga 1](https://microservices.io/patterns/data/saga.html)

[More info Saga 2](http://chrisrichardson.net/post/microservices/2019/07/09/developing-sagas-part-1.html)

[Distributed Transactions](https://github.com/dotnet/runtime/issues/715)

Reliability --> do it in the business layer

[More info reliability](https://www.infoq.com/articles/no-reliable-messaging/)