namespace MOD003263_SoftwareEngineering.Meta {
    public interface IMetaSerializer<T> {
        T Load();
        bool Save(T TIn); 
    }
}