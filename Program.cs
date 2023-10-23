using DOANDATVEMAYBAY2023.Models;
using DOANDATVEMAYBAY2023.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddControllers();
var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies()
.UseSqlServer(connectionString));
builder.Services.AddScoped<ThongTinChuyenBayService, ThongTinChuyenBayServiceImpl>();
builder.Services.AddScoped<SanBayService, SanBayServiceImpl>();
var app = builder.Build();
app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );

//app.UseMiddleware<BasicAuthMiddleware>();

app.UseStaticFiles();

app.MapControllers();
app.Run();

