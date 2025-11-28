namespace BE
{
    public interface IABM<T>
    {
        bool Agregar(T obj);
        bool Borrar(int id);
        bool Modificar(T obj);
    }
}
