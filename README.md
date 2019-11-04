# blog-app-secrets
This sample is part of the [How to manage passwords in ASP.NET Core configuration files tutorial](https://hodo.ro/posts/ost-05-aspnetcore-app-secrets/). See the tutorial for details.

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
