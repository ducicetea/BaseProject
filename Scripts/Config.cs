using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Config {
    public const float LINE_RES = .045f;
    public enum GAME_STATE : int {
        READY = 0,
        DRAWING = 1,
        STANDBY = 2,
    }

    public enum STAGE : int {
        LINE = 0,
        COLOR = 1
    }

    public enum PEN_ANIM : int {
        IDLE = 0,
        LEFT = 1,
        RIGHT = 2,
    }

    public enum DIRECTION : int {
        RIGHT = -1,
        LEFT = 1,
    }

    public enum BOOLEAN : int {
        FALSE = 0,
        TRUE = 1
    }

    public enum LINE_INDEX : int {
        DRAWING = 0,
        MASK = 100,
        FOCUS = 150,
        DONE = 200,
    }

    public enum EVENT_TYPE : int {
        STEP_COMPLETE = 0,
        LEVEL_COMPLETE = 1
    }

    public enum SOUND_INDEX : int {
        BUTTON = 0,
        WON = 1,
        FINISH_DRAW = 2,
    }

    public const int VIBRATE_DURATION = 15;
    public const int LEVEL_RATING_ENABLED = 15;
    public const int MAX_MAP_INDEX = 74;
    public const string IS_SOUND = "isSound";
    public const string IS_MUSIC = "isMusic";
    public const string IS_VIBRATION = "isVibration";
    public const string USER_LEVEL = "userLevel";
    public const string IS_UNLOCKED_COLOR = "isUnlockColor";
    public const string IS_RATED = "isRated";
}
