﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    public partial class ParityEncryptControl : UserControl
    {
        public ParityEncryptControl()
        {
            InitializeComponent();
        }

        private void samplesPerRegionTextBox_TextChanged(object sender, EventArgs e)
        {
            Main.activeAlgorithm.init();
        }
    }
}