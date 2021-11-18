namespace PreviewFeatures;

public class TypeAttribute : Attribute
{
    public TypeAttribute(Type t) => ParamType = t;

    public Type ParamType { get; }
}

public class GenericAttribute<T> : Attribute where T : class
{ }