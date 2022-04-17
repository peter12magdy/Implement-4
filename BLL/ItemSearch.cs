using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public interface ItemSearch<T>
    {
        List<T> SearchByTitle(String title);
        List<T> SearchByBarcode(int barcode);
        List<T> SearchBookByAuthorNationality(String nationality);
        List<T> SearchBookByAuthorBirth(DateTime birthDate);
    }
}
