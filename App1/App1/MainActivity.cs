using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;
using App1.Fragments;
using System;
using Android.Views;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity, View.IOnTouchListener
    {
        AdView adView;
        Button btn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            adView = FindViewById<AdView>(Resource.Id.adView);
            var adRequest = new AdRequest.Builder().Build();
            adView.LoadAd(adRequest);
            adView.Touch += AdView_Touch;
            adView.AdListener = new AdListener(this);
            btn = FindViewById<Button>(Resource.Id.buttonShowHide);

            btn.Click += Btn_Click;
       
            

        }

        private void AdView_Touch(object sender, View.TouchEventArgs e)
        {
            throw new NotImplementedException();
        }

        class AdListener : Android.Gms.Ads.AdListener
        {
            MainActivity main;

            public AdListener(MainActivity innerMain)
            {
                main = innerMain;
            }

            public override void OnAdLoaded()
            {
                base.OnAdLoaded();
                
            }

            public override void OnAdClicked()
            {
                base.OnAdClicked();
                return;
            }
            public override void OnAdLeftApplication()
            {
                base.OnAdLeftApplication();
            }
        }
        private void Test(object sender, System.EventArgs e)
        {
        }

            private void Btn_Click(object sender, System.EventArgs e)
        {
            try
            {

                //var fm = FragmentManager.BeginTransaction();
                //var top = new TopSectionFragment();
                //fm.Add(Resource.Id.topFrag, top);
                //fm.Hide(top);
                //fm.Remove(top);

                //fm.Detach(top);

                var x = FragmentManager.FindFragmentById(Resource.Id.container_fragments) as TopSectionFragment;

                var top = new TopSectionFragment();//FragmentManager.FindFragmentById(Resource.Id.topFrag) as TopSectionFragment;

                var ft = FragmentManager.BeginTransaction();
                if(x==null)
                    ft.Add(Resource.Id.container_fragments, top);
                else
                    ft.Remove(x);
                ft.SetTransition(FragmentTransit.FragmentFade);
                ft.Commit();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool OnTouch(View v, MotionEvent e)
        {
            throw new NotImplementedException();
        }
    }
}

