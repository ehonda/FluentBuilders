namespace TwoProps;

public class EmployeeBuilderDirector : EmployeePositionBuilder<EmployeeBuilderDirector>
// public class EmployeeBuilderDirector : EmployeeInfoBuilder<EmployeeBuilderDirector>
{
    public static EmployeeBuilderDirector NewEmployee => new EmployeeBuilderDirector();
}
