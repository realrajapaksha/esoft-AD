using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class PhotoAlbum
    {
        private int numOfPages;

        public PhotoAlbum()
        {
            this.numOfPages = 16;
        }

        public PhotoAlbum(int numOfPages)
        {
            this.numOfPages = numOfPages;
        }

        public int getNumberOfPages() { return this.numOfPages;}


    }
}
