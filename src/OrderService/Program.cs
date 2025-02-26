var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://+:8040");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.MapGet("/api/orders/health", () => Results.Json(new { status = "Healthy" }))
    .WithName("HealthCheck")
    .WithTags("System");

app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.Run();