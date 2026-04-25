using ToDoListWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// REGISTER SERVICES
builder.Services.AddControllers();
builder.Services.AddSingleton<ToDoService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// MIDDLEWARE PIPELINE
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();