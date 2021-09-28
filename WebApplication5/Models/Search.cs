using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;



namespace SearchAPI.Models

{
    public class TopicModel

    {
        private string productmodel;

         public string ProductModel

        {
            get { return productmodel; }
            set { productmodel = value; }
          }

        private int serialnum;
        public int SerialNumber
        {
            get { return serialnum; }
            set { serialnum = value; }
           }

    }

}

