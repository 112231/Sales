using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Sales
{
    using ItemsType = ObservableCollection<SalesMonthModel>;
    static class SalesModel
    {
        private static readonly ItemsType _monthItems = new ItemsType();

        public static ItemsType MonthModels
        {
            get
            {
                return _monthItems;
            }
        }

        public static void Renew()
        {
            _monthItems.Clear();
            SalesMonthModel prev = null;
            for (byte month = 1; month <= 12; month++)
            {
                SalesMonthModel item = new SalesMonthModel(month, prev);
                _monthItems.Add(item);
                prev = item;
            }
        }
    }
}
