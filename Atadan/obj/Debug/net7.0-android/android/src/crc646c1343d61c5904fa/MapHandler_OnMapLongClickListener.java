package crc646c1343d61c5904fa;


public class MapHandler_OnMapLongClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.OnMapLongClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapLongClick:(Lcom/google/android/gms/maps/model/LatLng;)V:GetOnMapLongClick_Lcom_google_android_gms_maps_model_LatLng_Handler:Android.Gms.Maps.GoogleMap/IOnMapLongClickListenerInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Maui.GoogleMaps.Handlers.MapHandler+OnMapLongClickListener, Maui.GoogleMaps", MapHandler_OnMapLongClickListener.class, __md_methods);
	}


	public MapHandler_OnMapLongClickListener ()
	{
		super ();
		if (getClass () == MapHandler_OnMapLongClickListener.class) {
			mono.android.TypeManager.Activate ("Maui.GoogleMaps.Handlers.MapHandler+OnMapLongClickListener, Maui.GoogleMaps", "", this, new java.lang.Object[] {  });
		}
	}


	public void onMapLongClick (com.google.android.gms.maps.model.LatLng p0)
	{
		n_onMapLongClick (p0);
	}

	private native void n_onMapLongClick (com.google.android.gms.maps.model.LatLng p0);

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
