/*
 
** VPC = VIRUTAL PRIVATE CLOUD

É UMA SERVIÇO AWS PARA CRIAR UM HAMBIENTE VIRTUAL NA NUVEM.
QUANDO CRIAMOS UMA APLICAÇÃO WEB, ELA FICA ALOCADA POR MEIO DE IP NA SUBNET.
A SUBNET NÃO TEM CONEXÃO DIRETA COM INTERNET, POR ISSO A AS ULTILIZA INTERNEY GATEWAY PARA CONECTAR AS DUAS INSTANCIAS.

O VPC GERENCIA SE SUA APLICAÇÃO TERA OU NÃO CONEÇÃO COM O INTERNT GATEWAY, PODENDO SE TIVER PUBLICO NA INTERNET. OU NÃO TIVER PRIVADO MA SUBNET.



*/


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
