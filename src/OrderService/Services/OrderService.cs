using MassTransit;
using Contracts;

public class OrderService
{
    private readonly IPublishEndpoint _publishEndpoint;

    public OrderService(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    public async Task CreateOrderAsync(Order order)
    {
        await _publishEndpoint.Publish(new OrderCreated { OrderId = order.Id });
    }
}