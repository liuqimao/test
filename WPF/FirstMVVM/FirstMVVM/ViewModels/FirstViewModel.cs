using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.ViewModels
{
    
    public class FirstViewModel:Screen
    {
        private string _FirstName="北极";
        
        public string  FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string _SecondName ="企鹅";

        public string SecondName
        {
            get { return _SecondName; }
            set {
                _SecondName = value;
                NotifyOfPropertyChange(() => SecondName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string _FullName;
        public string FullName
        {
            get { return FirstName + SecondName; }

        }



    }
}
