using Domain.IRepository;
using Infrastructure.Clients;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Sql Server
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShuruDb"));
}, ServiceLifetime.Scoped);

// Configuring Services
builder.Services.AddScoped<ISurveyRepository,SurveyRepository>();
builder.Services.AddScoped<IQuestionRepository,QuestionRepository>();
builder.Services.AddScoped<IAnswerRepository,AnswerRepository>();
builder.Services.AddScoped<ISurveyResponseRepository,SurveyResponseRepository>();
builder.Services.AddScoped<IRespondentRepository,RespondentRepository>();
builder.Services.AddScoped<IUserRepository,UserRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();
