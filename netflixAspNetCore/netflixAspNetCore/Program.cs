using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using netflixAspNetCore.Services;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json;

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
        //changer l'endroit de la chaine
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine crypto")),
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

builder.Services.AddScoped<TokenService>();

builder.Services.AddMvc();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(30);
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); //utilisation de jwt
app.UseAuthorization();
app.UseCors();
app.UseSession();

/*
 * 
 * int	{id:int}	123456789, -123456789	Correspond à n’importe quel entier
bool	{active:bool}	true, FALSE	Correspond true ou false. Non-respect de la casse
datetime	{dob:datetime}	2016-12-31, 2016-12-31 7:32pm	Correspond à une valeur valide DateTime dans la culture invariante. Consultez l’avertissement précédent.
decimal	{price:decimal}	49.99, -1,000.01	Correspond à une valeur valide decimal dans la culture invariante. Consultez l’avertissement précédent.
double	{weight:double}	1.234, -1,001.01e8	Correspond à une valeur valide double dans la culture invariante. Consultez l’avertissement précédent.
float	{weight:float}	1.234, -1,001.01e8	Correspond à une valeur valide float dans la culture invariante. Consultez l’avertissement précédent.
guid	{id:guid}	CD2C1638-1638-72D5-1638-DEADBEEF1638	Correspond à une valeur Guid valide
long	{ticks:long}	123456789, -123456789	Correspond à une valeur long valide
minlength(value)	{username:minlength(4)}	Rick	La chaîne doit comporter au moins 4 caractères
maxlength(value)	{filename:maxlength(8)}	MyFile	La chaîne ne doit pas comporter plus de 8 caractères
length(length)	{filename:length(12)}	somefile.txt	La chaîne doit comporter exactement 12 caractères
length(min,max)	{filename:length(8,16)}	somefile.txt	La chaîne doit comporter au moins 8 caractères et pas plus de 16 caractères
min(value)	{age:min(18)}	19	La valeur entière doit être au moins égale à 18
max(value)	{age:max(120)}	91	La valeur entière ne doit pas être supérieure à 120
range(min,max)	{age:range(18,120)}	91	La valeur entière doit être au moins égale à 18 mais ne doit pas être supérieure à 120
alpha	{name:alpha}	Rick	La chaîne doit se composer d’un ou plusieurs caractères a-z alphabétiques et sans respect de la casse.
regex(expression)	{ssn:regex(^\\d{{3}}-\\d{{2}}-\\d{{4}}$)}	123-45-6789	La chaîne doit correspondre à l’expression régulière. Consultez des conseils sur la définition d’une expression régulière.
required	{name:required}	Rick	Utilisé pour garantir qu’une valeur autre qu’un paramètre est présente pendant la génération de l’URL
 * 
 * */

app.MapGet("/", () =>{ return "Bienvenue sur le serveur"; });
//user
app.MapGet("/user/{id:int}", (int id) => { return Netflix.UserRepo.FindById(id); });
app.MapGet("/users", () =>{ return Netflix.UserRepo.FindAll(); });
//remove this
app.MapGet("/createUser", () => {

    Netflix.UserRepo.Create(new User()
    {
        FirstName = "test",
        LastName = "test",
        Avatar = "",
        Mail = "123@gmail.com",
        Password = "123"
    });
    int userID = Netflix.UserRepo.FindLastUserId();
    Statut statut = new()
    {
        StatutId = 0,
        UserId = userID,
        Name = "User",
        Description = ".............."
    };
    Netflix.StatutRepo.Create(statut);
    return "ok";

});
app.MapGet("/getUserStatut", (int id) => {
    return Netflix.StatutRepo.FindByUserId(id);
});
//ressource
//app.MapGet("/ressource/{id:int}", (int id) => { return Netflix.RessourceRepo.FindById(id); });
app.MapGet("/ressources", () => { return Netflix.RessourceRepo.FindAll(); });
//faq
//app.MapGet("/faq/{id:int}", (int id) => { return Netflix.FaqRepo.FindById(id); });
app.MapGet("/faqs", () => { return Netflix.FaqRepo.FindAll(); });
//save user avatar
/*app.MapGet("/user/setavatar", (int id, string avatar) => {
    User user = Netflix.UserRepo.FindById(id);
    if (user != null)
    {
        user.Avatar = avatar;
        Netflix.Save();
        return user;
    }
    return null;
});*/

Netflix.StartApp();

app.MapControllers();

/*
app.MapControllerRoute("avatar", "avatar", new { controller = "Avatar", action = "Index" });
app.MapControllerRoute("isLogin", "isLogin", new { controller = "IsLogin", action = "Index" });
app.MapControllerRoute("login", "login", new { controller = "Login", action = "Index" });
*/

app.Run();