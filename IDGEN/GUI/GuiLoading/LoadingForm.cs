﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IDGEN.Gui.GuiLoading
{
    public partial class LoadingForm : Form
    {
        public LoadingForm( Form form)
        {
            InitializeComponent();
            
            this.Owner = form;  
        }
    }
}
