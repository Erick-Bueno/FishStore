using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPeixesService, PeixesService>();
builder.Services.AddScoped<IUsuariosService, usuariosService>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddDbContext<AppDbContext>(c=> c.UseMySql("server = localhost; database=fishstore; user=root; password=sirlei231;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));

builder.Services.AddCors();

//configuração jwt
var chave = Encoding.ASCII.GetBytes(settings.secret);

builder.Services.AddAuthentication(x =>
{	
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x => {
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters{
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(chave),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
//--

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c => {
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});


app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();

app.MapControllers();

app.Run();
