UnityDetectHeadset
==================

UnityDetectHeadset is a [Unity native plugin](http://docs.unity3d.com/Manual/NativePlugins.html) which enable to detect if a headphone is plugged on iOS & Android.

To use it, import the Plugins folder and inside your code call: `DetectHeadset.Detect();`.

Note it will return **true** on *non supported platform*.

For Android, you need to add permissions:  
`<uses-permission android:name="android.permission.MODIFY_AUDIO_SETTINGS"/>`
`<uses-permission android:name="android.permission.BLUETOOTH"/>`
