using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using System.Data;

namespace NewProject
{
    public class MyClass
    {
        public MyClass()
        {

        }

        // Fields...
        private DateTime _Date;
        private float _Sales;
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }

        // Fields...
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }


        public float Sales
        {
            get { return _Sales; }
            set
            {
                _Sales = value;
            }
        }


        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
    }
}
