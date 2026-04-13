# Transporte_ejerciciodb

Proyecto de **modelo de datos con Entity Framework Core** para un dominio de **transporte y logística**. Define entidades, configuraciones Fluent API y **migraciones** contra **MySQL 8+**. La aplicación de consola comprueba la conexión a la base; el valor principal del repositorio es el esquema persistido mediante EF.

## Requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download) (el proyecto usa `net10.0`)
- **MySQL 8.0 o superior** (la versión del servidor se detecta en tiempo de ejecución; versiones anteriores no están soportadas)
- Herramientas de EF Core para la CLI (una sola vez en la máquina):

  ```bash
  dotnet tool install --global dotnet-ef
  ```

## Configuración

### Cadena de conexión

1. Copia o edita `appsettings.json` en la raíz del proyecto (se copia al directorio de salida al compilar).
2. Ajusta `ConnectionStrings:MySqlDB` con tu servidor, base de datos, usuario y contraseña.

Ejemplo de formato Pomelo/MySQL:

```json
{
  "ConnectionStrings": {
    "MySqlDB": "server=localhost;database=transporte_ejerciciodb;user=TU_USUARIO;password=TU_PASSWORD;SslMode=None;"
  }
}
```

**Variable de entorno (prioritaria):** si defines `MYSQL_CONNECTION`, sustituye a la cadena de `appsettings.json`. Útil en CI o para no guardar secretos en archivos versionados.

**Seguridad:** no subas credenciales reales al repositorio. Para desarrollo local, preferible usar `MYSQL_CONNECTION` o secretos de usuario (`dotnet user-secrets`) y mantener `appsettings.json` solo con valores de ejemplo.

## Cómo ejecutar

Desde la carpeta del proyecto:

```bash
dotnet run --project Transporte_ejerciciodb.csproj
```

Si la conexión es correcta, verás un mensaje de éxito en consola. Si falla, se mostrará el error (y el detalle de la excepción interna si existe).

## Migraciones

Ejecuta los comandos **desde el directorio raíz del repositorio** (donde está `appsettings.json` y el `.csproj`), para que la fábrica en tiempo de diseño encuentre la configuración.

| Acción | Comando |
|--------|---------|
| Aplicar esquema a la BD | `dotnet ef database update --project Transporte_ejerciciodb.csproj` |
| Nueva migración | `dotnet ef migrations add NombreDescriptivo --project Transporte_ejerciciodb.csproj` |
| Listar migraciones | `dotnet ef migrations list --project Transporte_ejerciciodb.csproj` |

Las migraciones generadas están en la carpeta `Migrations/`. El contexto usa **Pomelo.EntityFrameworkCore.MySql** con **NetTopologySuite** para tipos espaciales compatibles con MySQL.

## Estructura del código

| Ruta | Contenido |
|------|-----------|
| `src/shared/context/` | `AppDbContext`, registro de configuraciones por ensamblado y fábrica en tiempo de diseño |
| `src/shared/helpers/` | Fábrica del contexto en ejecución, resolución de versión de MySQL |
| `src/modules/*/` | Módulos por dominio; cada uno incluye entidades y `*EntityConfiguration` (Fluent API) |
| `Migrations/` | Historial de migraciones de EF Core |

El dominio modelado incluye, entre otros: empresas de transporte, vehículos y conductores, viajes y asignaciones, cargas y estados, clientes, documentos, precios y reglas por ciudad, pagos, suscripciones, notificaciones, chat y tablas de apoyo (países, ciudades, tipos de carga, etc.).

## Solución y compilación

```bash
dotnet build Transporte_ejerciciodb.sln
```

## Dependencias principales

- `Microsoft.EntityFrameworkCore` (9.x)
- `Pomelo.EntityFrameworkCore.MySql` y `Pomelo.EntityFrameworkCore.MySql.NetTopologySuite` (9.x)
- `Microsoft.Extensions.Configuration.*` para leer `appsettings.json` y variables de entorno
- `NetTopologySuite` para geometrías en el modelo

## Licencia

Indica aquí la licencia del proyecto si aplica (por ejemplo MIT, uso académico, etc.).
