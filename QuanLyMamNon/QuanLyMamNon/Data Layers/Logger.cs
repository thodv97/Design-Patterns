using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMamNon.Data_Layers
{
    public sealed class Logger
    {
        private static volatile Logger INSTANCE;

        private static readonly object syncLock = new object();

        private Logger()
        {
        }

        public static Logger GetLogger
        {
            get 
            {
                lock (syncLock)
                {
                    if (INSTANCE == null)
                    {
                        INSTANCE = new Logger();
                    }
                }

                return INSTANCE;
            }
        }
    }
}
