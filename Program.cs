// 1. Definimos los datos del empleado
int employeeLevel = 200;
string employeeName = "John Smith";
string title = "";

// 2. Evaluamos el nivel usando switch-case
switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

// 3. Mostramos el resultado final en la terminal
Console.WriteLine($"{employeeName}, {title}");
