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
    public partial class ViewAds : Form
    {
        private IShowService showService;
        private IAdService adService;

        public ViewAds(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();
        }

        private void ViewAds_Load(object sender, EventArgs e)
        {

        }
    }
}