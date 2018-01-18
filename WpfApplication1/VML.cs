using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class VML
    {
        private static MVM _mainViewModel;
        public static MVM MainViewModel
        {
            get
            {
                if (_mainViewModel == null)
                {
                    _mainViewModel = new MVM();
                }
                return _mainViewModel;
            }
        }
    }
}
