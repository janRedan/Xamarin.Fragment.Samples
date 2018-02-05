using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace App1.Fragments
{
    public class TopSectionFragment : Fragment
    {

        EditText topTxt;
        EditText bottomTxt;
        Button btn;
        ImageView img;



        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            
            var view = inflater.Inflate(Resource.Layout.top_fragment, container, false);
            img = view.FindViewById<ImageView>(Resource.Id.imageView1);
            Picasso.With(this.Activity).Load(@"http://admov.blob.core.windows.net/ads/4663beb2-068a-47c6-898f-dede9867cb18.png").Into(img);
            //topTxt = view.FindViewById<EditText>(Resource.Id.topTextInput);
            //bottomTxt = view.FindViewById<EditText>(Resource.Id.bottomTextInput);
            //btn = view.FindViewById<Button>(Resource.Id.button1);

            //btn.Click += Btn_Click;
            return view;

            // return base.OnCreateView(inflater, container, savedInstanceState);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}