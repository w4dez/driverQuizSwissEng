using System.Collections.Generic;

namespace quiz;

public class GetAllCRUD<T>
{
  public IReadOnlyList<T> GetAll()
  {
    return GenericsList<T>.Items.AsReadOnly();
  }
}