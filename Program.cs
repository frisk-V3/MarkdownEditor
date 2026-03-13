var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles(); // ClientApp/dist の中身を配信
app.Run();
