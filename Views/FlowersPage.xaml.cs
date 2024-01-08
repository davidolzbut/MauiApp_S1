using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp_S1;

namespace MauiApp_S1.Views;

public partial class FlowersPage : ContentPage
{
    public FlowersPage()
    {
        InitializeComponent();
    }

    private void BtnAddFlower_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddFlowerPage));
    }
}