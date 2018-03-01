package md5e7b732364c907136ad539f09ba10bfb3;


public class DashboardActivityA
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SampleOne.DashboardActivityA, SampleOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DashboardActivityA.class, __md_methods);
	}


	public DashboardActivityA () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DashboardActivityA.class)
			mono.android.TypeManager.Activate ("SampleOne.DashboardActivityA, SampleOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
