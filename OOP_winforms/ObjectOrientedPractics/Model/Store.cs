﻿using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Store
    {
        List<Item> _items;
        List<Customer> _customers;

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }

    
}
