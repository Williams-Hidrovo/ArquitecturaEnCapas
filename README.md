# API .NET 8 - Arquitectura en Capas

Este proyecto es una API construida con .NET 8 que implementa una arquitectura en capas para garantizar la escalabilidad, mantenibilidad y separaci�n de responsabilidades. La arquitectura utiliza los siguientes componentes principales:

- **Repositories**: Encargados de interactuar con la base de datos.
- **Services**: Contienen la l�gica de negocio.
- **Models**: Representan las entidades del dominio y los DTOs.
- **Mapping**: Configura la transformaci�n entre entidades y DTOs.

## Caracter�sticas

- .NET 8
- Arquitectura en capas
- Uso de Entity Framework Core
- Inyecci�n de dependencias
- Transformaci�n de entidades a DTOs usando AutoMapper

## Estructura del Proyecto

El proyecto sigue una estructura modular para separar responsabilidades:

```
ApiProject/
|
|-- Controllers/         # Controladores de la API
|-- Models/              # Entidades y DTOs
|-- Repositories/        # Capa de acceso a datos
|-- Services/            # Capa de l�gica de negocio
|-- Mapping/             # Configuraci�n de AutoMapper
|-- Program.cs           # Configuraci�n de la aplicaci�n
```

## Tecnolog�as y Librer�as

- **.NET 8**: Framework principal.
- **Entity Framework Core**: ORM para el acceso a datos.
- **AutoMapper**: Transformaci�n entre entidades y DTOs.

## Requisitos Previos

- .NET 8 SDK
- SQL Server o cualquier otra base de datos configurada
- Visual Studio 2022 o cualquier editor compatible