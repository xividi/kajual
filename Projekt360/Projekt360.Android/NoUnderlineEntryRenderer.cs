﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Projekt360.Droid
{
    public class NoUnderlineEntryRenderer : EntryRenderer
    {
        public NoUnderlineEntryRenderer(Context context) : base(context) { }    
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.Background = null;
        }
    }
}