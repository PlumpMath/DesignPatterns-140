using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class MyfabClass
    {
        public static MyfabClass myclassinstance;
        public  string identifier ="";
        

        private MyfabClass()
        {
         
          }

        public static MyfabClass GiveMeInstance()
        {
            if (myclassinstance == null)
            {
                myclassinstance = new MyfabClass();
                myclassinstance.identifier = Guid.NewGuid().ToString();

            }

            return myclassinstance;
        }

        }
}
