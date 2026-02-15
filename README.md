# SecondAssignment-WebAPI-CRUD

 Descripción
Este proyecto es una **Web API en C# (.NET 7)** que implementa un **CRUD completo** para gestionar estudiantes.  
La API está conectada a **Oracle Database** usando **Entity Framework Core**.

Se incluyen las siguientes características:

- Modelo `Student` y DTO `StudentDTO`
- Controlador `StudentsController` con endpoints:
  - GET `/api/students` → Listar todos los estudiantes
  - GET `/api/students/{id}` → Obtener estudiante por ID
  - POST `/api/students` → Crear estudiante
  - PUT `/api/students/{id}` → Actualizar estudiante
  - DELETE `/api/students/{id}` → Eliminar estudiante
- Conexión a Oracle con `DbContext` y `appsettings.json`
- Documentación y prueba de endpoints con **Swagger UI**

---

 Tecnologías utilizadas

- C# (.NET 7)
- ASP.NET Core Web API
- Entity Framework Core
- Oracle Database (SQL Developer)
- Swagger (para documentación y pruebas de endpoints)
- Visual Studio 2022 / 2022 Insider




