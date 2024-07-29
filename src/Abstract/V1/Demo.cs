namespace Abstract.V1;

public static class Demo
{
     public static void F()
    {
        var thing = Director
            .New()
            // Here we have this:
            //      C1_Method :: Director
            //      B1_Method :: C1<Director>
            //      A1_Method :: B1<C1<Director>>
            // Therefore, if we call A1_Method, we can't call C1_Method, since we only have a B1 at that point, and it doesn't
            // have C1-Methods.
            .C1_Method()
            .A1_Method()
            // gives an error
            // .C1_Method()
            .B1_Method()
            .C1_Method()
            .Build();
    }
    
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
}
