package crc646c1343d61c5904fa;


public class MapHandler_OnMyLocationButtonClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.OnMyLocationButtonClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMyLocationButtonClick:()Z:GetOnMyLocationButtonClickHandler:Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Maui.GoogleMaps.Handlers.MapHandler+OnMyLocationButtonClickListener, Maui.GoogleMaps", MapHandler_OnMyLocationButtonClickListener.class, __md_methods);
	}


	public MapHandler_OnMyLocationButtonClickListener ()
	{
		super ();
		if (getClass () == MapHandler_OnMyLocationButtonClickListener.class) {
			mono.android.TypeManager.Activate ("Maui.GoogleMaps.Handlers.MapHandler+OnMyLocationButtonClickListener, Maui.GoogleMaps", "", this, new java.lang.Object[] {  });
		}
	}


	public boolean onMyLocationButtonClick ()
	{
		return n_onMyLocationButtonClick ();
	}

	private native boolean n_onMyLocationButtonClick ();

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
