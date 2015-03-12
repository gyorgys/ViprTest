using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDrive
{
    public partial class oneDrive
    {
        public IdriveFetcher drive
        {
            get
            {
                var path = GetPath("drive");
                var fetcher = new driveFetcher();
                fetcher.Initialize(Context, path);

                return fetcher;
            }
        }
    }
}
