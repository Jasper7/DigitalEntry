using System;
using System.Collections.Generic;
using DigitalEntry.Helpers;
using DigitalEntry.ViewModels;
using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace DigitalEntry.Views
{
    public partial class CodeCheckPage : ContentPage
    {
        CodeCheckVM VM;
        private ZXingScannerView _scannerView;

        public CodeCheckPage()
        {
            InitializeComponent();

            PermissioRequest();

            VM = new CodeCheckVM();
            BindingContext = VM;
        }

        private void CreateScannerView()
        {
            var options = new ZXing.Mobile.MobileBarcodeScanningOptions()
            {
                AutoRotate = true
            };

            var s = new ZXingScannerView()
            {
                Options = options,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                IsScanning = true
            };

            s.OnScanResult += OnScanResult;

            if (_scannerView != null)
                RootView.Children.Remove(_scannerView);

            _scannerView = s;
            RootView.Children.Insert(0, _scannerView);
        }

        private async void OnScanResult(Result result)
        {
            if(!VM.IsBusy && !(VM.IsDeny || VM.IsApprove))
                await VM.DetectCode(result.Text);
        }

        private async void PermissioRequest()
        {
            var resultPermission = await PermissionHelper.CheckCameraPermission();
            if (resultPermission)
            {
                CreateScannerView();

                _scannerView.IsScanning = true;
            }
        }

        void OnDeny(System.Object sender, System.EventArgs e)
        {
            VM.IsDeny = false;
            VM.IsApprove = false;
        }

        void OnAccept(System.Object sender, System.EventArgs e)
        {
            VM.IsDeny = false;
            VM.IsApprove = false;
        }

        void OnClose(System.Object sender, System.EventArgs e)
        {
            VM.IsDeny = false;
            VM.IsApprove = false;
        }
    }
}

