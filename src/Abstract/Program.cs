var thing = RootC1
    .New()
    // Here we have this:
    //      C1_Method :: Director
    //      B1_Method :: Director
    //      A1_Method :: Director
    // Therefore, we always have all methods because Director is at the bottom of the hierarchy
    .A1_Method()
    .C1_Method()
    .B1_Method()
    .C1_Method()
    .A1_Method()
    // gives an error
    // .C1_Method()
    .B1_Method()
    .C1_Method()
    .Build();

var otherThing = RootB2
    .New()
    .A1_Method()
    .B2_Method()
    .A1_Method();

public class Thing;

public abstract class Builder
{
    public Thing Build() => new();
}

public class A1<T> : Builder
    where T : A1<T>
{
    public T A1_Method() => (T)this;
}

public class B1<T> : A1<T>
    where T : B1<T>
{
    public T B1_Method() => (T)this;
}

public class B2<T> : A1<T>
    where T : B2<T>
{
    public T B2_Method() => (T)this;
}

public class C1<T> : B1<T>
    where T : C1<T>
{
    public T C1_Method() => (T)this;
}

public class RootC1 : C1<RootC1>
{
    public static RootC1 New() => new RootC1();
}

public class RootB2 : B2<RootB2>
{
    public static RootB2 New() => new RootB2();
}
