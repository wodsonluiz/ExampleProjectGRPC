using System;
using Grpc.Net.Client;
using Microsoft.Extensions.DependencyInjection;

public static class RequestGRPC
{
    public static void ClientGrpc()
    {
        var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new Greeter.GreeterClient(channel);

        var response = client.SayHello(new HelloRequest{ Name = "Wod"});

        Console.WriteLine(response.Message);
    }
}