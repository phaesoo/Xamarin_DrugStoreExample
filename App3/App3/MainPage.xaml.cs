using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            bool isClickHospital = false;

            SearchButtonHospital.Clicked += async (sender, e) =>
            {
                if (!isClickHospital)
                {
                    await SearchBtnsTop.TranslateTo(0, 200, 700, Easing.SinIn);
                    isClickHospital = true;
                }
                else
                {
                    await SearchBtnsTop.TranslateTo(0, -1, 700, Easing.SinIn);
                    isClickHospital = false;
                }
            };

            bool isClickDrugStore = false;

            SearchBtnDrugStore.Clicked += async (sender, e) =>
            {
                if (!isClickDrugStore)
                {
                    await SearchBtnBottom.TranslateTo(0, -200, 700, Easing.SinIn);
                    isClickDrugStore = true;
                }
                else
                {
                    await SearchBtnBottom.TranslateTo(0, 1, 700, Easing.SinIn);
                    isClickDrugStore = false;
                }
            };
        }
    }
}
