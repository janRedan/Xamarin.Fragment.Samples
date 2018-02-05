package md5579855c995bdb073d8182511e793544c;


public class MainActivity_AdListener
	extends com.google.android.gms.ads.AdListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdLoaded:()V:GetOnAdLoadedHandler\n" +
			"n_onAdClicked:()V:GetOnAdClickedHandler\n" +
			"n_onAdLeftApplication:()V:GetOnAdLeftApplicationHandler\n" +
			"";
		mono.android.Runtime.register ("App1.MainActivity+AdListener, App1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_AdListener.class, __md_methods);
	}


	public MainActivity_AdListener ()
	{
		super ();
		if (getClass () == MainActivity_AdListener.class)
			mono.android.TypeManager.Activate ("App1.MainActivity+AdListener, App1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_AdListener (md5579855c995bdb073d8182511e793544c.MainActivity p0)
	{
		super ();
		if (getClass () == MainActivity_AdListener.class)
			mono.android.TypeManager.Activate ("App1.MainActivity+AdListener, App1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "App1.MainActivity, App1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onAdLoaded ()
	{
		n_onAdLoaded ();
	}

	private native void n_onAdLoaded ();


	public void onAdClicked ()
	{
		n_onAdClicked ();
	}

	private native void n_onAdClicked ();


	public void onAdLeftApplication ()
	{
		n_onAdLeftApplication ();
	}

	private native void n_onAdLeftApplication ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
