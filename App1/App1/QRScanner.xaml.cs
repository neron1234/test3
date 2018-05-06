using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QRScanner :  ContentPage
    {
        ZXingScannerView zxing;
        ZXingDefaultOverlay overlay;
        public QRScanner ()
		{
			InitializeComponent ();
           // Scan();
        }

        //private async void Scan()
        //{
        //    var scanPage = new ZXingScannerPage();

        //    scanPage.OnScanResult += (result) =>
        //    {
        //        // Stop scanning
        //        scanPage.IsScanning = false;

        //        // Pop the page and show the result
        //        Device.BeginInvokeOnMainThread(async () =>
        //        {
        //            await Navigation.PopAsync();
        //            // await DisplayAlert("Scanned Barcode", result.Text, "OK");
        //        });
        //    };

        //    // Navigate to our scanner page
        //    await Navigation.PushAsync(scanPage);
        //}
    }
}