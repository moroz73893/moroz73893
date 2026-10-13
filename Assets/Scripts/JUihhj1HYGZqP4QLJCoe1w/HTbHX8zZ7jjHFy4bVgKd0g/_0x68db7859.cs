using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x68db7859 : MonoBehaviour
{
    private int _0x87277937 => this.CustomTimeInitial + _0xfc90c1ec._0x336f8966._0xf965c70a * 10;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x87277937;
        this.CurrentGameIndex = _0xfc90c1ec.Instance._0xcd9014e9;
        foreach (Button _0xb2297873 in this.HomeButtons)
            _0xb2297873.onClick.AddListener(() =>
            {
                this._0x91d478d9();
            });
        foreach (Button _0xaf410c14 in this.PauseButtons)
            _0xaf410c14.onClick.AddListener(() =>
            {
                _0xfc90c1ec.Instance._0x6026dd4a(false);
                _0xda9f334f.Instance._0x5582d170(_0x47dc124a._0x4d40a7ba.PAUSE);
            });
        this._0xb3dec8c4();
        this.LevelNumberText.ForEach(_0xe63fdbc1 => _0xe63fdbc1.text = $"LVL {_0xfc90c1ec._0x336f8966._0xf965c70a + 1}");
        if (_0xa1ead1db.Instance.IsTimerEnabled)
        {
            this._0x2b1a1e7c();
            this.StartCoroutine(this._0x7c2b5131());
        }
    }

    public List<Button> HomeButtons = new();
    private void _0x2b1a1e7c()
    {
        this.TimerText.ForEach(_0xe63fdbc1 => _0xe63fdbc1.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x13316654._0x6de1ffd6(new byte[6] { 224, 224, 209, 183, 254, 254 }, 141)));
    }

    public void _0x047ad059(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xb3dec8c4();
            this._0x6c9d40ca();
        }
    }

    public int CustomTimeInitial = 30;
    public List<TMP_Text> ScoreText = new();
    private void _0x978e5587()
    {
        if (this.ScoreCurrent >= this._0x531e1473)
            this._0x17b6cbc1();
        else
            this._0xf140bb7f();
    }

    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> LevelNumberText = new();
    private IEnumerator _0x7c2b5131()
    {
        this._0x2b1a1e7c();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xfc90c1ec.Instance._0xcd9014e9 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xfc90c1ec.Instance._0x445fd59a)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x2b1a1e7c();
            }
        }

        if (!this.IsGameEnd)
            this._0xf140bb7f();
    }

    public void _0x91d478d9()
    {
        _0xfc90c1ec.Instance._0x6026dd4a(true);
        _0xfc90c1ec.Instance._0xc04bfe9e(_0x47dc124a._0x48063541.SCENE_0);
    }

    private void _0xb3dec8c4()
    {
        if (_0xa1ead1db.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xe63fdbc1 => _0xe63fdbc1.text = $"{this.ScoreCurrent}/{this._0x531e1473}");
        else
            this.ScoreText.ForEach(_0xe63fdbc1 => _0xe63fdbc1.text = $"{this.ScoreCurrent}");
    }

    private static _0x68db7859 _0x76a7614f;
    public int CustomTargetScore = 10;
    private void Awake()
    {
        _0x76a7614f = this.gameObject.GetComponent<_0x68db7859>();
    }

    private void _0x984a32cc()
    {
        this.IsGameEnd = true;
        _0xfc90c1ec.IsAfterLevelComplete = true;
    }

    [HideInInspector]
    public int ScoreCurrent;
    public List<Button> PauseButtons = new();
    [HideInInspector]
    public bool IsGameEnd;
    private int _0x39afbb87 => this.ScoreCurrent;

    public List<TMP_Text> TimerText = new();
    public void _0xf140bb7f()
    {
        if (_0xa1ead1db.Instance.IsOnlyWinGameEndEnabled)
            this._0x17b6cbc1();
        if (!this.IsGameEnd)
        {
            this._0x984a32cc();
            _0xfc90c1ec.IsAfterLevelComplete = false;
            _0xfc90c1ec.IsAfterLevelFailed = true;
            _0xa471e4fa _0x551a879a = _0xda9f334f.Instance._0xd8443e1d(_0x47dc124a._0x4d40a7ba.LOSE).GetComponent<_0xa471e4fa>();
            if (_0xa1ead1db.Instance.IsCheckScoreEnabled)
                _0x551a879a.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x531e1473}";
            else
                _0x551a879a.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x551a879a.ContentAdditionalText.text = $"{0}";
            _0x47dc124a._0xd6107ecd._0xdfb099ed += 0;
            _0xda9f334f.Instance._0x5582d170(_0x47dc124a._0x4d40a7ba.LOSE);
        }
    }

    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public int TimeLeft;
    public void _0x17b6cbc1()
    {
        if (!this.IsGameEnd)
        {
            this._0x984a32cc();
            _0xfc90c1ec.IsAfterLevelComplete = true;
            _0xfc90c1ec.IsAfterLevelFailed = false;
            _0xa471e4fa _0x5c60b79e = _0xda9f334f.Instance._0xd8443e1d(_0x47dc124a._0x4d40a7ba.WIN).GetComponent<_0xa471e4fa>();
            if (_0xa1ead1db.Instance.IsCheckScoreEnabled)
                _0x5c60b79e.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x531e1473}";
            else
                _0x5c60b79e.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xa1ead1db.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x47dc124a._0xd6107ecd._0xdfb099ed)
                    _0x47dc124a._0xd6107ecd._0xdfb099ed = this.ScoreCurrent;
                _0x5c60b79e.ContentAdditionalText.text = $"{_0x47dc124a._0xd6107ecd._0xdfb099ed}";
            }
            else
            {
                _0x5c60b79e.ContentAdditionalText.text = $"{this._0x39afbb87}";
                _0x47dc124a._0xd6107ecd._0xdfb099ed += this._0x39afbb87;
            }

            if (_0xa1ead1db.Instance.IsLevelIncrementOnWin)
                ++_0xfc90c1ec._0x336f8966._0xf965c70a;
            _0xda9f334f.Instance._0x5582d170(_0x47dc124a._0x4d40a7ba.WIN);
        }
    }

    private int _0x531e1473 => this.CustomTargetScore + _0xfc90c1ec._0x336f8966._0xf965c70a * 10;

    private void _0x6c9d40ca()
    {
        if (this.ScoreCurrent > _0xfc90c1ec._0x336f8966._0x292b8c9c)
            _0xfc90c1ec._0x336f8966._0x292b8c9c = this.ScoreCurrent;
        if (_0xa1ead1db.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x531e1473)
                this._0x17b6cbc1();
    }
}

internal static class _0x13316654
{
    internal static string _0x6de1ffd6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}