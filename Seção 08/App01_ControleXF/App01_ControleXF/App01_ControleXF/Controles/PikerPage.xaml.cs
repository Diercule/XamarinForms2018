﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PikerPage : ContentPage
	{
		public PikerPage ()
		{
			InitializeComponent ();
		}

        private void ActionMudarIndex(object sender, EventArgs e)
        {
            Picker obj = (Picker)sender;
            resultado.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();
        }
    }
}