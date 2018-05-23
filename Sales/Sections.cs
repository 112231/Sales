using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Sections
    {
        private Section _item;
        public Section Item
        {
            get
            {
                return _item;
            }
            set
            {
                if (_item == value) return;
                if (!Items.Contains(value))
                {
                    throw new Exception("値が不正です");
                }
                _item = value;
            }
        }

        private Section[] _items;
        public Section[] Items
        {
            get
            {
                if (_items == null) _items = CreateItems();
                return _items;
            }
        }

        private Section[] CreateItems()
        {
            string[] records = GetRecords();
            char[] separator = { ':' };

            Section[] r = new Section[records.Length];
            for (int i = 0; i < records.Length; i++)
            {
                string[] field = records[i].Split(separator);
                if (field.Length != 2)
                {
                    throw new Exception("セクションの指定が間違っています");
                }

                Section section = new Section();
                section.Id = byte.Parse(field[0]);
                section.Title = field[1];

                r[i] = section;
            }
            return r;
        }

        private string[] GetRecords()
        {
            char[] separator = { '|' };
            string text = "1:第1営業課|2:第2営業課|3:第3営業課";
            string[] records = text.Split(separator);
            return records;
        }
    }
}
