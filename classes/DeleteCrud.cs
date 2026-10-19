namespace quiz;

public class DeleteCRUD<T>
{
  public bool Delete()
  {
    if (GenericsList<T>.Items.Count == 0)
      return false;

    GenericsList<T>.Items.RemoveAt(0);
    return true;
  }
}