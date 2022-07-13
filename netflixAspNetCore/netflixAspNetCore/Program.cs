using NetflixServer.Classes;
using netflixTestConsole.database.classes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseCors("MyPolicy");
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

//contraintes de routes

app.MapGet("/", () =>{ return "Bienvenue sur le serveur"; });
//user
app.MapGet("/user/{id:int}", (int id) => { return Netflix.UserRepo.FindById(id); });
app.MapGet("/users", () =>{ return Netflix.UserRepo.FindAll(); });
app.MapGet("/login", (string mail, string password) => { 
    return Netflix.UserRepo.Login(mail,password); 
});
//ressource
//app.MapGet("/ressource/{id:int}", (int id) => { return Netflix.RessourceRepo.FindById(id); });
app.MapGet("/ressources", () => { return Netflix.RessourceRepo.FindAll(); });
//faq
//app.MapGet("/faq/{id:int}", (int id) => { return Netflix.FaqRepo.FindById(id); });
app.MapGet("/faqs", () => { return Netflix.FaqRepo.FindAll(); });
//save user avatar
app.MapGet("/user/avatar", (int id, string avatar) => {
    User user = Netflix.UserRepo.FindById(id);
    if(user != null)
    {
        Console.WriteLine(avatar);  
    }
});

Netflix.StartApp();

app.Run();