# blog-app-secrets

This project is part of the [How to manage passwords in ASP.NET Core configuration files](https://hodo.ro/posts/post-05-aspnetcore-app-secrets/) tutorial. See the tutorial for details.

## Build and run

To build and run the sample, execute the following command:

```console
# Clone the repositoty
git clone https://github.com/gabihodoroaga/blog-app-secrets.git
cd blog-app-secrets

# Restore the .NET Core packages
dotnet restore

# Run the web app
dotnet run

```

On a separate terminal

```console
curl -k https://localhost:5001/database/connectionstring
```
