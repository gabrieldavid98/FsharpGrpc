namespace FsharpGrpc.Defs

open FsharpGrpc.Lib

type GreetService() =
    inherit Greeter.GreeterBase()

    override _.SayHello(req, ctx) =
        task {
            let r = new HelloReply()
            r.Message <- sprintf "Hello %s From F#" req.Name

            return r
        }
