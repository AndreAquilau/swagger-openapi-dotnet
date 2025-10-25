# 📡 Consulta Cliente API

Welcome to the **Consulta Cliente API**, a simple ASP.NET Core Web API project that demonstrates how to configure Swagger/OpenAPI documentation, enable CORS, and set up controller-based endpoints.

## 🧰 Technologies Used

- [.NET 6+](https://dotnet.microsoft.com/)
- [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/web-api/)
- [Swashbuckle (Swagger)](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

## 🚀 Features

- 📘 Swagger/OpenAPI documentation with XML comments
- 🌐 CORS enabled for all origins
- 🧩 Modular controller support
- 🧪 Development-only Swagger UI

## 📦 Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/AndreAquilau/swagger-openapi-dotnet
cd consulta-cliente-api
```

### 2. Install Dependencies

Ensure the following NuGet packages are installed:

```bash
dotnet add package Swashbuckle.AspNetCore
```

### 3. Build and Run

```bash
dotnet build
dotnet run
```

### 4. Access the API

- Swagger UI: `http://localhost:<port>/swagger`
- API Endpoints: `http://localhost:<port>/api/...`

## 🛠 Configuration Highlights

### Swagger Setup

```csharp
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Consulta Cliente API",
        Version = "v1",
        Description = "An ASP.NET Core Web API consulta Cliente",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "License",
            Url = new Uri("https://example.com/license")
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFilename);
    options.IncludeXmlComments(xmlPath);
});
```

### CORS Policy

```csharp
app.UseCors(op => op.AllowAnyOrigin());
```

## 📁 Project Structure

```
/Controllers         # API controllers
/Program.cs          # Main application setup
/Properties          # Launch settings
consulta-cliente.csproj
```
---

Let me know if you'd like to add Docker support, CI/CD setup, or deployment instructions!
