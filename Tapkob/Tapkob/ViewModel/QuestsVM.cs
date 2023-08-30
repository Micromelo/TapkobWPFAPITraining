﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapkob.Model;
using Tapkob.Utilities;

namespace Tapkob.ViewModel
{
    internal class QuestsVM : BaseVM
    {
        public ObservableCollection<TaskModel> Tasks { get; set; }

        public QuestsVM()
        {

        }
    }
}
