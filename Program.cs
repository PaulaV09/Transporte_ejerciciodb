using Transporte.src.shared.helpers;

try
{
    await using var context = await Task.FromResult(DbContextFactory.Create());
    if (await context.Database.CanConnectAsync())
    {
        Console.WriteLine("Conexión exitosa a la base de datos transportedb (MySQL).");
        Console.WriteLine("Este proyecto define solo el modelo EF para migraciones.");
    }
    else
    {
        Console.WriteLine("No se pudo conectar con la base de datos.");
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Error: {ex.Message}");
    if (ex.InnerException != null)
    {
        Console.Error.WriteLine($"Detalle: {ex.InnerException.Message}");
    }
}
