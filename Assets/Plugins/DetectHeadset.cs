#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;
#elif UNITY_ANDROID && !UNITY_EDITOR
using UnityEngine;
#endif

public class DetectHeadset
{
#if UNITY_IOS && !UNITY_EDITOR
	[DllImport ("__Internal")]
	static private extern bool _Detect();
#endif
		
    public static bool CanDetect()
    {
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR
		return true;
#else
        return false;
#endif
    }

    public static bool Detect()
    {
#if UNITY_IOS && !UNITY_EDITOR

		return _Detect();

#elif UNITY_ANDROID && !UNITY_EDITOR
		
		using var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		using var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		using var androidPlugin = new AndroidJavaObject(
			"com.davikingcode.DetectHeadset.DetectHeadset",
			currentActivity);
		
		return androidPlugin.Call<bool>("_Detect");

#else
		
        return true;
		
#endif
    }
}