﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.ViewModel;

namespace WpfApp.Model
{
    class ReportActiveProject : ViewModelBase
    {
        private int _projectID;
        private string _projectName;
        private string _jobNo;
        private int _customerID;
        private string _customerName;
        private int _salesmanID;
        private string _salesman;
        private List<ProjectMatTracking> _projectMatTracking;
        private DateTime _targetDate;

        public int ProjectID
        {
            get => _projectID;
            set
            {
                if (value == _projectID) return;
                _projectID = value;
                OnPropertyChanged();
            }
        }

        public string ProjectName
        {
            get => _projectName;
            set
            {
                if (value == _projectName) return;
                _projectName = value;
                OnPropertyChanged();
            }
        }

        public string JobNo
        {
            get => _jobNo;
            set
            {
                if (value == _jobNo) return;
                _jobNo = value;
                OnPropertyChanged();
            }
        }

        public int CustomerID
        {
            get => _customerID;
            set
            {
                if (value == _customerID) return;
                _customerID = value;
                OnPropertyChanged();
            }
        }

        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (value == _customerName) return;
                _customerName = value;
                OnPropertyChanged();
            }
        }

        public int SalesmanID
        {
            get => _salesmanID;
            set
            {
                if (value == _salesmanID) return;
                _salesmanID = value;
                OnPropertyChanged();
            }
        }

        public string SalesmanName
        {
            get => _salesman;
            set
            {
                if (value == _salesman) return;
                _salesman = value;
                OnPropertyChanged();
            }
        }

        public List<ProjectMatTracking> ProjectMatTrackings
        {
            get => _projectMatTracking;
            set
            {
                if (value == _projectMatTracking) return;
                _projectMatTracking = value;
                OnPropertyChanged();
            }
        }

        public DateTime TargetDate
        {
            get => _targetDate;
            set
            {
                if (value == _targetDate) return;
                _targetDate = value;
                OnPropertyChanged();
            }
        }
    }
}