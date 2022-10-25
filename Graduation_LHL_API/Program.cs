
using Graduation_LHL_API.IServices;
using Graduation_LHL_API.Services;
using SqlSugar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//加载配置文件
var conBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");
var config = conBuilder.Build();

//添加接口
builder.Services.AddTransient<IUserService,UserService>();

builder.Services.AddGrpc();//添加grpc
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGrpcService<HookProviderService>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
