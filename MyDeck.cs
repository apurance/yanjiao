using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace yanjiao
{
    public class MyDeck : INotifyPropertyChanged
    {
        private List<int> _deck = null;

        public MyDeck()
        {
            _deck = new List<int>();
        }

        public string TheValue
        {
            get
            {
                string str = string.Empty;
                foreach (int d in _deck)
                {
                    if (d == 1)
                    {
                        str += "A ";
                    }
                    else if (d == 11)
                    {
                        str += "J ";
                    }
                    else if (d == 12)
                    {
                        str += "Q ";
                    }
                    else if (d == 13)
                    {
                        str += "K ";
                    }
                    else
                    {
                        str += d + " ";
                    }
                }
                return str;
            }
        }

        public int[] ToArray()
        {
            return _deck.ToArray();
        }

        public void Update(List<int> value)
        {
            _deck = new List<int>(value);
            NotifyPropertyChanged(() => TheValue);
        }

        public void Add(int value)
        {
            _deck.Add(value);
            NotifyPropertyChanged(() => TheValue);
        }

        public void Back()
        {
            if (_deck.Count == 0)
            {
                return;
            }
            _deck.RemoveAt(_deck.Count - 1);
            NotifyPropertyChanged(() => TheValue);
        }

        public void Clear()
        {
            _deck.Clear();
            NotifyPropertyChanged(() => TheValue);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged == null)
                return;

            var memberExpression = property.Body as MemberExpression;
            if (memberExpression == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
        }
    }
}
