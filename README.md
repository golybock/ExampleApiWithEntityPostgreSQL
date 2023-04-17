# Создание EntityFramework Context для PostgreSQL
### Подключение библиотек

Необходимые библиотеки:

- Npgsql.EntityFrameworkCore.PostgreSql
- Miсrosoft.EntityFrameworkCore
- Miсrosoft.EntityFrameworkCore.Design
- Miсrosoft.EntityFrameworkCore.Tools

### Подключение entity к проекту через консоль 

Переход в директорию проекта

```sh
cd solution_name\project_name\
```

Установка dotnet-ef

```sh
dotnet tool install --global dotnet-ef
```

Создание контекста и моделей данных

```sh
dotnet ef dbcontext scaffold "[connectionstring]" Npgsql.EntityFrameworkCore.PostgreSQL -o [OutputDir]
```

### Подключение контекста к api 

Для работы с entity в api необходимо добавить контекст базы данных в файл Program.cs

```sh
builder.Services.AddDbContext<[DbContextClass]>();
```

### Подключение entity к проекту через консоль nuget

```sh
Scaffold-Dbcontext "[connectionstring]" Npgsql.EntityFramewrokCore.PostgreSQL -o [OutputDir]
```

### Использование контекста базы данных в контроллерах

В конструкторах контроллеров необходимо указать раннее созданный класс контекста базы. Например:

```sh
public [ControllerName]([DatabaseContextClass] context)
{
    _context = context;
}
```

Переменная **_context** ялвяется приватным атрибутом класса и используется для обращения к бд
