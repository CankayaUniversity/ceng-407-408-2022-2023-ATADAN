package crc640ec0e25fce38384b;


public class DelegateSnapshotReadyCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.SnapshotReadyCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSnapshotReady:(Landroid/graphics/Bitmap;)V:GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler:Android.Gms.Maps.GoogleMap/ISnapshotReadyCallbackInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Maui.GoogleMaps.Android.Logics.DelegateSnapshotReadyCallback, Maui.GoogleMaps", DelegateSnapshotReadyCallback.class, __md_methods);
	}


	public DelegateSnapshotReadyCallback ()
	{
		super ();
		if (getClass () == DelegateSnapshotReadyCallback.class) {
			mono.android.TypeManager.Activate ("Maui.GoogleMaps.Android.Logics.DelegateSnapshotReadyCallback, Maui.GoogleMaps", "", this, new java.lang.Object[] {  });
		}
	}


	public void onSnapshotReady (android.graphics.Bitmap p0)
	{
		n_onSnapshotReady (p0);
	}

	private native void n_onSnapshotReady (android.graphics.Bitmap p0);

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
