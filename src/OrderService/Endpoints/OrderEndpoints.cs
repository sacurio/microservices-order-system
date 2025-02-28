public static class OrderEndpoints
{
    public static IEndpointRouteBuilder MapOrderEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/api/orders", async (Contracts.Order order, OrderService orderService) =>
        {
            await orderService.CreateOrderAsync(order);
            return Results.Ok(new { message = "Order created successfully" });
        });

        return endpoints;
    }
}