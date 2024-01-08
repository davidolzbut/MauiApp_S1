using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_S1.Views;

public partial class AddFlowerPage : ContentPage
{
    public AddFlowerPage()
    {
        InitializeComponent();
    }

    private void BtnBack_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}