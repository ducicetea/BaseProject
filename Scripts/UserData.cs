using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : Singleton<UserData> {
    public static int _isSound {
        set {
            PlayerPrefs.SetInt(Config.IS_SOUND, value);
        }
        get {
            return PlayerPrefs.GetInt(Config.IS_SOUND, (int)Config.BOOLEAN.TRUE);
        }
    }

    public static int _isMusic {
        set {
            PlayerPrefs.SetInt(Config.IS_MUSIC, value);
        }
        get {
            return PlayerPrefs.GetInt(Config.IS_MUSIC, (int)Config.BOOLEAN.TRUE);
        }
    }

    public static int _isVibration {
        set {
            PlayerPrefs.SetInt(Config.IS_VIBRATION, value);
        }
        get {
            return PlayerPrefs.GetInt(Config.IS_VIBRATION, (int)Config.BOOLEAN.TRUE);
        }
    }
    public static int _currentLevelID {
        set {
            PlayerPrefs.SetInt(Config.USER_LEVEL, value);
        }
        get {
            return PlayerPrefs.GetInt(Config.USER_LEVEL, 0);
        }
    }

    public static int _isUnlockedColor {
        set {
            PlayerPrefs.SetInt(Config.IS_UNLOCKED_COLOR, value);
        }
        get {
            return PlayerPrefs.GetInt(Config.IS_UNLOCKED_COLOR, (int)Config.BOOLEAN.FALSE);
        }
    }

    public static int _isRated {
        set {
            PlayerPrefs.SetInt(Config.IS_RATED, value);
        }
        get {
            return PlayerPrefs.GetInt(Config.IS_RATED, (int)Config.BOOLEAN.FALSE);
        }
    }
}
