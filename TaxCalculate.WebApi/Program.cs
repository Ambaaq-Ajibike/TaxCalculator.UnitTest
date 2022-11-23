using TaxCalculatorProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(x => x.AddPolicy("TaxCalculatorPolicy", a =>{
    a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
}));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICalculateTaxService, CalculateTaxService>();
builder.Services.AddScoped<ITaxableIncomeService, TaxableIncomeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("TaxCalculatorPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
