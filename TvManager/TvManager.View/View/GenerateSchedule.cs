﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    public partial class GenerateSchedule : Form
    {
        private IShowService showService;
        private IAdService adService;
        public GenerateSchedule(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();
        }

        private void GenerateSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
