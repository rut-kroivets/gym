using gym_rutiKroivets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepositories>();

builder.Services.AddScoped<IGuideService, GuideService>();
builder.Services.AddScoped<IGuideRepository, GuideRepositories>();

builder.Services.AddScoped<ITrainingService, TrainingService>();
builder.Services.AddScoped<ITrainingRepository, TrainingRepositories>();

builder.Services.AddSingleton<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
