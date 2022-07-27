using BankEntityFrameWork.Repositories;
using ConsoleApp2.database;
using CoursEntityFrameWorkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using netflixAspNetCore.Services;
using netflixTestConsole.database.classes;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddCors(options =>
{
    options.AddPolicy("react", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters()
    {
        //todo: changer l'endroit de la chaine
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto")),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidIssuer = "m2i",
        ValidAudience = "m2i"
    };
});

builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy("admin", options =>
    {
        options.RequireClaim("statut", "admin");
    });
    builder.AddPolicy("user", options =>
    {
        options.RequireClaim("statut", "user");
    });
});

builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<BaseRepository<User>, UserRepo>(); //utile ?
builder.Services.AddScoped<UserRepo>();
builder.Services.AddScoped<BaseRepository<Faq>, FaqRepo>();
builder.Services.AddScoped<TokenService>();

builder.Services.AddMvc(); //utile ?

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); //utilisation de jwt
app.UseAuthorization();
app.UseCors();
//todo: need to remove nugget session : app.UseSession();

app.MapControllers();

app.Run();