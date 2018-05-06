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
	public partial class View1 : ContentView
	{
        //ZXingScannerView zxing;
        //ZXingDefaultOverlay overlay;

        public View1()
		{
			InitializeComponent ();
        //    Scan();
        }

        private void btnScan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScanPage());
           // new NavigationPage((Page)Activator.CreateInstance(typeof(QRScanner)));
            //var scanPage = new ZXingScannerPage();

            //scanPage.OnScanResult += (result) =>
            //{
            //    // Stop scanning
            //    scanPage.IsScanning = false;

            //    // Pop the page and show the result
            //    Device.BeginInvokeOnMainThread(async () =>
            //    {
            //        await Navigation.PopAsync();
            //       //await DisplayAlert("Scanned Barcode", result.Text, "OK");
            //    });
            //};

            //// Navigate to our scanner page
            //await Navigation.PushAsync(scanPage);
            //try
            //{
            //    var scanner = DependencyService.Get<IQrScanningService>();
            //    var result = await scanner.ScanAsync();
            //    if (result != null)
            //    {
            //        txtBarcode.Text = result;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
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