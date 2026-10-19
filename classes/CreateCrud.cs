using System.Collections.Generic;

namespace quiz;

public class CreateCRUD<T>
{
  public void Create(T item)
  {
    GenericsList<T>.Items.Add(item);
  }

}