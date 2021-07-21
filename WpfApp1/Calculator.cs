using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Calculator
    {
        private List<ClassItem> listItem;
        private double total = 0;
        
        public Calculator()
        {
            this.listItem = new List<ClassItem>();
        }
        public void addItem(ClassItem item)
        {
            this.listItem.Add(item);
            this.total += item.getSubTotal();
        }
        public double getTotal()
        {
            return total;
        }
        public List<ClassItem> getListItem()
        {
            return listItem;
        }
    }
}
