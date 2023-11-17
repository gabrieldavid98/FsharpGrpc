# FsharpGrpc
This repo shows how to use F# with Grpc.AspNetCore, since Grpc.AspNetCore only works with C# a workaround must be done in order to use Grpc with F#.
1. Create a C# classlib referencing Grpc.AspNetCore and adding all .proto files to .csproj, this classlib will contain all .proto files and when compiled all auto-generated (Server/Client) Grpc code
2. Create a F# classlib referencing the classlib created in the previous step, this classlib will contain the implementations of the services defined in .proto files. Here client implementation can be done as well.
3. Create a C# grpc project referencing previous F# classlib, this grpc project will register grpc services implementations into AspNet and thus be able to expose them to outside world.

### FsharpGrpc.Lib (project from step 1)
### FsharpGrpc.Defs (project from step 2)
### FsharpGrpc.Web (project from step 3)
