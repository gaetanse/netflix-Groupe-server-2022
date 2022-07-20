using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using Newtonsoft.Json.Linq;
using System.Text.Json;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,policy =>
                          {
                              policy.WithOrigins("http://localhost:3000", "http://localhost:7119");
                              policy.AllowAnyHeader();
                              policy.AllowAnyMethod();
                              policy.AllowCredentials();
                          });
});

builder.Services.AddMvc();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(30);
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

app.UseSession();
app.UseCors(MyAllowSpecificOrigins);
app.UseStaticFiles();
app.UseRouting();

/*
 * 
 * int	{id:int}	123456789, -123456789	Correspond � n�importe quel entier
bool	{active:bool}	true, FALSE	Correspond true ou false. Non-respect de la casse
datetime	{dob:datetime}	2016-12-31, 2016-12-31 7:32pm	Correspond � une valeur valide DateTime dans la culture invariante. Consultez l�avertissement pr�c�dent.
decimal	{price:decimal}	49.99, -1,000.01	Correspond � une valeur valide decimal dans la culture invariante. Consultez l�avertissement pr�c�dent.
double	{weight:double}	1.234, -1,001.01e8	Correspond � une valeur valide double dans la culture invariante. Consultez l�avertissement pr�c�dent.
float	{weight:float}	1.234, -1,001.01e8	Correspond � une valeur valide float dans la culture invariante. Consultez l�avertissement pr�c�dent.
guid	{id:guid}	CD2C1638-1638-72D5-1638-DEADBEEF1638	Correspond � une valeur Guid valide
long	{ticks:long}	123456789, -123456789	Correspond � une valeur long valide
minlength(value)	{username:minlength(4)}	Rick	La cha�ne doit comporter au moins 4 caract�res
maxlength(value)	{filename:maxlength(8)}	MyFile	La cha�ne ne doit pas comporter plus de 8 caract�res
length(length)	{filename:length(12)}	somefile.txt	La cha�ne doit comporter exactement 12 caract�res
length(min,max)	{filename:length(8,16)}	somefile.txt	La cha�ne doit comporter au moins 8 caract�res et pas plus de 16 caract�res
min(value)	{age:min(18)}	19	La valeur enti�re doit �tre au moins �gale � 18
max(value)	{age:max(120)}	91	La valeur enti�re ne doit pas �tre sup�rieure � 120
range(min,max)	{age:range(18,120)}	91	La valeur enti�re doit �tre au moins �gale � 18 mais ne doit pas �tre sup�rieure � 120
alpha	{name:alpha}	Rick	La cha�ne doit se composer d�un ou plusieurs caract�res a-z alphab�tiques et sans respect de la casse.
regex(expression)	{ssn:regex(^\\d{{3}}-\\d{{2}}-\\d{{4}}$)}	123-45-6789	La cha�ne doit correspondre � l�expression r�guli�re. Consultez des conseils sur la d�finition d�une expression r�guli�re.
required	{name:required}	Rick	Utilis� pour garantir qu�une valeur autre qu�un param�tre est pr�sente pendant la g�n�ration de l�URL
 * 
 * */

app.MapGet("/", () =>{ return "Bienvenue sur le serveur"; });
//user
app.MapGet("/user/{id:int}", (int id) => { return Netflix.UserRepo.FindById(id); });
app.MapGet("/users", () =>{ return Netflix.UserRepo.FindAll(); });
/*app.MapGet("/login", (string mail, string password) => {
    User user = Netflix.UserRepo.Login(mail, password);
    if(user != null)
    {
        HttpContext.Session.SetString("isLogin", "true");
    }
    return user;
});*/
//remove this
app.MapGet("/createUser", () => {

    Statut statut = Netflix.StatutRepo.FindById(1);
    Netflix.UserRepo.Create(new User()
    {
        FirstName = "test",
        LastName = "test",
        StatutId = 1,
        Avatar = "",
        Statut = statut,
        Mail = "123@gmail.com",
        Password = "123"
    });

});
//ressource
//app.MapGet("/ressource/{id:int}", (int id) => { return Netflix.RessourceRepo.FindById(id); });
app.MapGet("/ressources", () => { return Netflix.RessourceRepo.FindAll(); });
//faq
//app.MapGet("/faq/{id:int}", (int id) => { return Netflix.FaqRepo.FindById(id); });
app.MapGet("/faqs", () => { return Netflix.FaqRepo.FindAll(); });
//save user avatar
app.MapGet("/user/setavatar", (int id, string avatar) => {
    User user = Netflix.UserRepo.FindById(id);
    Console.WriteLine(avatar);
    //statut vide ???
    if (user != null)
    {
        user.Avatar = avatar;
        Console.WriteLine(avatar);
        Netflix.Save();
        return user;
    }
    return null;
});

Netflix.StartApp();

app.MapControllerRoute("avatar", "avatar", new { controller = "Avatar", action = "Index" });
app.MapControllerRoute("isLogin", "isLogin", new { controller = "IsLogin", action = "Index" });
app.MapControllerRoute("login", "login", new { controller = "Login", action = "Index" });

app.Run();