using System;
using System.Collections.Generic;
using System.Text;

namespace IATray
{
    public class Favorite
    {
        public String name = null;
        public String folder = null;
        public bool recursive = false;
    }

    public class FavoritesList : List<Favorite>
    {
    }

}
