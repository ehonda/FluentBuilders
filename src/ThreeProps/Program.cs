using Core;

// See: https://code-maze.com/fluent-builder-recursive-generics/

// var emp = EmployeeBuilderDirector
//     .NewEmployee
//     .WithSalary(3500)
//     .SetName("Maks")
//     .AtPosition("Software Developer")
//     .Build();

var emp = EmployeeBuilderDirector
    .NewEmployee
    .WithSalary(1)
    .SetName("");
    
Console.WriteLine(emp);
