var thing = Director
    .New()
    .C1_Method()
    .A1_Method()
    // gives an error
    // .C1_Method()
    .B1_Method()
    .C1_Method()
    .Build();

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

public class B1<T> : A1<B1<T>>
    where T : B1<T>
{
    public T B1_Method() => (T)this;
}

public class C1<T> : B1<C1<T>>
    where T : C1<T>
// public class C1<T> : A1<B1<C1<T>>>
//     where T : B1<C1<T>>
{
    public T C1_Method() => (T)this;
}

public class Director : C1<Director>
{
    public static Director New() => new Director();
}
