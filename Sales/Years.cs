using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Years
    {
        private short _item;
        public short Item
        {
            get
            {
                return _item;
            }
            set
            {
                if (_item == value) return;
                if (!Items.Contains(value)) throw new Exception("値が不正です");
                _item = value;
            }
        }

        private short[] _items;
        public short[] Items
        {
            get
            {
                if (_items == null) _items = CreateItems();
                return _items;
            }
        }

        private short[] CreateItems()
        {
            int minYear = 2010;
            int maxYear = DateTime.Now.Year;
            int length = maxYear - minYear + 1;
            short[] r = new short[length];
            for (int i = 0; i < length; i++)
            {
                int year = minYear + i;
                r[i] = (short)year;
            }
            return r;
        }
    }
}
