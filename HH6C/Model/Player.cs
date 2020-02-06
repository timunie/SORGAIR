﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Model
{
    public class Player : BaseClass
    {
        // Default constructor for Player
        public Player()
        {

        }

        private long? _ID;
        public long? ID
        {
            get { return _ID; }
            set { _ID = value; RaisePropertyChanged(nameof(ID)); }
        }

        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; RaisePropertyChanged(nameof(Username)); }
        }

        // Used for the second datatemplate
        public ObservableCollection<string> Pets { get; private set; } = new ObservableCollection<string>();
    }
}
