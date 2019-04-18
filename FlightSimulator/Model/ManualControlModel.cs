﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.ViewModels;
using FlightSimulator.Model;

namespace FlightSimulator.Model
{
    class ManualControlModel : BaseNotify
    {

        public ManualControlModel() {
            Info.ServerInstance.PorpertyChanged += Instance_PropertyChanged();
            
        }
    }
}
