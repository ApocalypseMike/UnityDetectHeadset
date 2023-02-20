package com.davikingcode.DetectHeadset;

import android.content.Context;
import android.media.AudioDeviceInfo;
import android.media.AudioManager;

public class DetectHeadset {

    static AudioManager myAudioManager;

    public DetectHeadset(Context context) {
        myAudioManager = (AudioManager) context.getSystemService(Context.AUDIO_SERVICE);
    }

    public boolean _Detect()
    {
        AudioDeviceInfo[] audioDeviceInfo = myAudioManager.getDevices(AudioManager.GET_DEVICES_INPUTS);
        for (AudioDeviceInfo deviceInfo : audioDeviceInfo) {
            if (deviceInfo.getType() == AudioDeviceInfo.TYPE_BLUETOOTH_SCO ||
                deviceInfo.getType() == AudioDeviceInfo.TYPE_WIRED_HEADSET ||
                deviceInfo.getType() == AudioDeviceInfo.TYPE_WIRED_HEADPHONES)
                return true;
        }
        return false;
    }
}