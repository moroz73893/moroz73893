using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x47dc124a
{
    public static class _0x4d40a7ba
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0xf09d5d02
    {
        private static readonly _0xf09d5d02 _0x93897ec2 = new();
        public static readonly _0xf09d5d02[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x93897ec2,
            _0x93897ec2,
            _0x93897ec2,
        };
        private int _0xe448793a => 0;
        private int _0x23c69e6b => 10;
        private string _0x87bafb0b => _0xc2a50f6c._0xaf433451(new byte[4] { 208, 248, 243, 232 }, 157);
        private string _0x73fa8307 => _0xc2a50f6c._0xaf433451(new byte[8] { 25, 16, 3, 16, 25, 46, 101, 40 }, 85);

        private int _0x636b88e1
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xc2a50f6c._0xaf433451(new byte[25] { 150, 160, 167, 167, 176, 187, 161, 146, 185, 186, 183, 180, 185, 150, 189, 180, 165, 161, 176, 167, 156, 187, 177, 176, 173 }, 213)))
                    PlayerPrefs.SetInt(_0xc2a50f6c._0xaf433451(new byte[25] { 250, 204, 203, 203, 220, 215, 205, 254, 213, 214, 219, 216, 213, 250, 209, 216, 201, 205, 220, 203, 240, 215, 221, 220, 193 }, 185), 0);
                return PlayerPrefs.GetInt(_0xc2a50f6c._0xaf433451(new byte[25] { 12, 58, 61, 61, 42, 33, 59, 8, 35, 32, 45, 46, 35, 12, 39, 46, 63, 59, 42, 61, 6, 33, 43, 42, 55 }, 79));
            }

            set => PlayerPrefs.SetInt(_0xc2a50f6c._0xaf433451(new byte[25] { 143, 185, 190, 190, 169, 162, 184, 139, 160, 163, 174, 173, 160, 143, 164, 173, 188, 184, 169, 190, 133, 162, 168, 169, 180 }, 204), value);
        }

        public int _0xf965c70a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x87bafb0b}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x87bafb0b}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x87bafb0b}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x87bafb0b}CurrentLevelIndex", value);
        }

        public int _0x292b8c9c
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x87bafb0b}BestScore"))
                    this._0x292b8c9c = 0;
                return PlayerPrefs.GetInt($"{this._0x87bafb0b}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x87bafb0b}BestScore", value);
        }

        public bool _0xd2ad42b9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x87bafb0b}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x87bafb0b}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x87bafb0b}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x87bafb0b}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xd6107ecd
    {
        public static int _0xdfb099ed
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xc2a50f6c._0xaf433451(new byte[5] { 117, 89, 95, 88, 69 }, 54)))
                    PlayerPrefs.SetInt(_0xc2a50f6c._0xaf433451(new byte[5] { 252, 208, 214, 209, 204 }, 191), 0);
                return PlayerPrefs.GetInt(_0xc2a50f6c._0xaf433451(new byte[5] { 166, 138, 140, 139, 150 }, 229));
            }

            set
            {
                PlayerPrefs.SetInt(_0xc2a50f6c._0xaf433451(new byte[5] { 152, 180, 178, 181, 168 }, 219), value);
                _0xfc90c1ec.Instance._0x58c2b860();
            }
        }
    }

    public static class _0x48063541
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xecae2237
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0xc2a50f6c
{
    internal static string _0xaf433451(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}