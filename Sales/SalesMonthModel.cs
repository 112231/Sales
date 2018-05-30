using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Sales
{
    using ItemsType = ObservableCollection<Result>;
    class SalesMonthModel
    {
        private readonly SalesMonthModel _previousModel;
        public SalesMonthModel(byte month, SalesMonthModel previousModel)
        {
            _resultItems.CollectionChanged += _resultItems_CollectionChanged;
            _previousModel = previousModel;
            _month = month;
            Renew();
        }
        private readonly byte _month;
        public byte Month
        {
            get
            {
                return _month;
            }
        }
        public int PlanPrice
        {
            get
            {
                return 1000000;
            }
        }
        public int ResultPrice { get; private set; }
        public int SubtractPrice
        {
            get
            {
                return ResultPrice - PlanPrice;
            }
        }
        public int TotalPrice
        {
            get
            {
                int p =
                    _previousModel == null ?
                        0 :
                        _previousModel.TotalPrice;
                return p + SubtractPrice;
            }
        }
        private readonly ItemsType _resultItems = new ItemsType();
        public ItemsType ResultItems
        {
            get
            {
                return _resultItems;
            }
        }

        public void Renew()
        {
            //todo: 未実装(Sales.SalesMonthModel.Renew())
            throw new System.NotImplementedException();
        }

        public void Add(Result row)
        {
            //todo: 未実装(Sales.SalesMonthModel.Add())
            throw new System.NotImplementedException();
        }

        public void Remove(Result row)
        {
            //todo: 未実装(Sales.SalesMonthModel.Remove())
            throw new System.NotImplementedException();
        }
        public int SaveChanges()
        {
            //todo: 未実装(Sales.SalesMonthModel.SaveChanges())
            throw new System.NotImplementedException();
        }

        private void _resultItems_CollectionChanged(
            object sender, NotifyCollectionChangedEventArgs e)
        {
            var q =
                from p in _resultItems
                select p.Price;
            ResultPrice = q.Sum();
        }
    }
}
