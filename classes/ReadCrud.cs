namespace quiz;

public class ReadCRUD<T>
{
  public T? Read()
  {
    if (GenericsList<T>.Items.Count == 0)
      return default;

    return GenericsList<T>.Items[0];
  }
}