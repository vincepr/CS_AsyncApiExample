# Asynchronous API
Minimal Api. Revolves around the Client posting a large number or Data to our Service.

This should take so long, as that we want to decouple the `your post received` and the `your post has completely ran trough` messages.

So in that sense being Asynchronous in it's response.

## used packets
```
dotnet add package Microsoft.EntitiyFrameworkCore.Design
dotnet add package Microsoft.EntitiyFrameworkCore.Sqlite
```