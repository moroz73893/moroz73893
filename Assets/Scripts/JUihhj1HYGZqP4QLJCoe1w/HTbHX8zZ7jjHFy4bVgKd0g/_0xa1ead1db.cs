using UnityEngine;

public class _0xa1ead1db : MonoBehaviour
{
    public bool IsTimerEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsStoryEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xa1ead1db>();
            DontDestroyOnLoad(this.gameObject);
            this._0xb5dacc51();
        }
        else
        {
            this._0x9ead9166();
            Destroy(this.gameObject);
        }
    }

    public bool IsSkipSplashEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsCheckScoreEnabled;
    public static _0xa1ead1db Instance;
    public bool IsBestScoreEnabled;
    private void _0x9ead9166()
    {
    }

    private void _0xb5dacc51()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTutorialEnabled;
}