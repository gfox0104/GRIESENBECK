﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp.ViewModel;

namespace WpfApp.Model
{
    class Acronym : ViewModelBase
    {
        private string _acronymName;
        private string _acronymDesc;
        private int _projSovID;
        private bool _active;
        private int _coItemNo;
        private bool _matOnly;

        public int ProjSovID
        {
            get => _projSovID;
            set
            {
                if (value == _projSovID) return;
                _projSovID = value;
                OnPropertyChanged();
            }
        }

        public string AcronymName
        {
            get => _acronymName;
            set
            {
                if (value == _acronymName) return;
                _acronymName = value;
                OnPropertyChanged();
            }
        }

        public string AcronymDesc
        {
            get => _acronymDesc;
            set
            {
                if (value == _acronymDesc) return;
                _acronymDesc = value;
                OnPropertyChanged();
            }
        }

        public bool Active
        {
            get => _active;
            set
            {
                if (value == _active) return;
                _active = value;
                OnPropertyChanged();
            }
        }

        public int CoItemNo
        {
            get => _coItemNo;
            set
            {
                if (value == _coItemNo) return;
                _coItemNo = value;
                OnPropertyChanged();
            }
        }

        public bool MatOnly
        {
            get => _matOnly;
            set
            {
                if (value == _matOnly) return;
                _matOnly = value;
                OnPropertyChanged();
            }
        }

     
    }
}
