using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class BigPhotoAlbum 
    {
        private int numOfPages;

        public BigPhotoAlbum()
        {
            this.numOfPages = 64;
        }

       public int getNumberOfPages() { return numOfPages; }
    }
}
