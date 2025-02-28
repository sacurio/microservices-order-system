using MassTransit;
using Contracts;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

public class OrderCreatedConsumer : IConsumer<OrderCreated>
{
    public async Task Consume(ConsumeContext<OrderCreated> context)
    {
        var orderId = context.Message.OrderId;
        Console.WriteLine($"[PaymentsService] Processing payment for order {orderId}");
    }
}