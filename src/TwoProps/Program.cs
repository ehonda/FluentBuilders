using TwoProps;

// EmployeeBuilderDirector : EmployeeInfoBuilder<EmployeeBuilderDirector>

// Breaks
// var employee = EmployeeBuilderDirector
//     .NewEmployee
//     .SetName("Nick")
//     .AtPosition("Developer")

// public class EmployeeBuilderDirector : EmployeePositionBuilder<EmployeeBuilderDirector>

var nick = EmployeeBuilderDirector
    .NewEmployee
    // SetName :: EmployeePositionBuilder<EmployeeBuilderDirector> 
    .SetName("Nick")
    // AtPosition :: EmployeeBuilderDirector
    .AtPosition("Developer");

var bob = EmployeeBuilderDirector
    // NewEmployee :: EmployeeBuilderDirector
    .NewEmployee
    // AtPosition :: EmployeeBuilderDirector
    //
    // We have
    //      EmployeeBuilderDirector
    //          : EmployeePositionBuilder<EmployeeBuilderDirector>
    //              : EmployeeInfoBuilder<EmployeePositionBuilder<EmployeeBuilderDirector>>
    //
    // Therefore we have and can chain `SetName` via `EmployeeInfoBuilder<T>`
    .AtPosition("Tester")
    // SetName :: EmployeePositionBuilder<EmployeeBuilderDirector> 
    .SetName("Bob");
