using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Google.Android.Material;
using AndroidX.AppCompat.App;
//using Android.Support.V7.App;
using AndroidX.Preference;
//using Android.Support.V7.Preferences;
using Android.Views;
using Android.Widget;

namespace SettingsPageTry
{
    [Activity(Label = "SettingsActivity")]
    public class SettingsActivity : PreferenceFragmentCompat
    {
        public override void OnCreatePreferences(Bundle savedInstanceState, string rootKey)
        {
            SetPreferencesFromResource(Resource.Xml.preferences, rootKey);
        }

        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    SetPreferencesFromResource(Resource.Xml.preferences)

        //    // Create your application here
        //    if(FragmentManager.FindFragmentById(Resource.Id.content) == null)
        //    {
        //        FragmentManager.BeginTransaction().Add(Resource.Id.content, SettingsFragment).Commit();
        //    }
        //}
    }
}