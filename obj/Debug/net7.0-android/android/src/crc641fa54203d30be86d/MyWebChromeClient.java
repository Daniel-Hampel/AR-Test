package crc641fa54203d30be86d;


public class MyWebChromeClient
	extends crc6452ffdc5b34af3a0f.MauiWebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPermissionRequest:(Landroid/webkit/PermissionRequest;)V:GetOnPermissionRequest_Landroid_webkit_PermissionRequest_Handler\n" +
			"";
		mono.android.Runtime.register ("AR_Test.Platforms.Android.MyWebChromeClient, AR-Test", MyWebChromeClient.class, __md_methods);
	}


	public MyWebChromeClient ()
	{
		super ();
		if (getClass () == MyWebChromeClient.class) {
			mono.android.TypeManager.Activate ("AR_Test.Platforms.Android.MyWebChromeClient, AR-Test", "", this, new java.lang.Object[] {  });
		}
	}


	public void onPermissionRequest (android.webkit.PermissionRequest p0)
	{
		n_onPermissionRequest (p0);
	}

	private native void n_onPermissionRequest (android.webkit.PermissionRequest p0);

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
