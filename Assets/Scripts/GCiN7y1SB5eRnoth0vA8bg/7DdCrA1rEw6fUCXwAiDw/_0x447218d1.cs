using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x447218d1 : MonoBehaviour
{
    internal bool ContainsIgnoreCase(string _0x43148957, string _0xc8b12ed6)
    {
        if (string.IsNullOrEmpty(_0x43148957) || string.IsNullOrEmpty(_0xc8b12ed6))
            return false;
        return _0x43148957.IndexOf(_0xc8b12ed6, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Vector2 lastSize = Vector2.zero;
    internal bool IsGoogleAuthFlowUrl(string _0xc9a39da8)
    {
        if (string.IsNullOrEmpty(_0xc9a39da8))
            return false;
        return _0xc9a39da8.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[19] { 131, 129, 129, 141, 151, 140, 150, 145, 204, 133, 141, 141, 133, 142, 135, 204, 129, 141, 143 }, 226), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc9a39da8.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[16] { 143, 141, 141, 129, 155, 128, 154, 157, 192, 137, 129, 129, 137, 130, 139, 192 }, 238), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc9a39da8.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[21] { 178, 186, 186, 178, 185, 176, 160, 166, 176, 167, 182, 186, 187, 161, 176, 187, 161, 251, 182, 186, 184 }, 213), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc9a39da8.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[11] { 140, 152, 159, 138, 159, 130, 136, 197, 136, 132, 134 }, 235), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool isDestroyedForce = false;
    private bool OpenUrlExternally(string _0x11453a73)
    {
        return _0x06a7fc66(_0x11453a73);
    }

    private string _0x09c7eb41 = "";
    private string _0x79ea7149 = "";
    private void _0xc01db5a9(string _0xdeafca0c)
    {
        Dictionary<string, object> _0x0b36e126;
        try
        {
            _0x0b36e126 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xdeafca0c);
        }
        catch
        {
            return;
        }

        var _0xc97181f8 = ReadPushField(_0x0b36e126, _0xd43d4e85._0x88ae33d6(new byte[3] { 192, 199, 217 }, 181));
        if (string.IsNullOrWhiteSpace(_0xc97181f8))
            return;
        _0xc97181f8 = _0xc97181f8.Trim();
        if (!IsHttpUrl(_0xc97181f8))
            return;
        if (string.Equals(_0xc97181f8, _0x3ba540da, StringComparison.Ordinal))
            return;
        _0x3ba540da = _0xc97181f8;
        OpenUrlExternally(_0xc97181f8);
    }

    private void _0xaec5a60a()
    {
        {
#if B_LOGS
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[22] { 32, 47, 30, 8, 15, 38, 91, 40, 15, 20, 9, 30, 63, 30, 13, 18, 24, 30, 50, 21, 29, 20 }, 123));
#endif
        }

        _0xa82f227f = SystemInfo.deviceModel;
        _0x0d7a3740 = Application.version;
        _0x83347406 = Application.installMode;
        _0x55ecb974 = Application.installerName;
        _0x5f9325f4 = Application.identifier;
        _0xcce27f9a = _0x76fa1f91();
        _0x55ea55cf = _0x7010cba3();
        _0x41b8de7c = SystemInfo.deviceUniqueIdentifier;
        _0x8a97e078 = SystemInfo.graphicsDeviceName;
        _0x5825103a = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x0d7a3740 = _0xd43d4e85._0x88ae33d6(new byte[5] { 252, 229, 252, 229, 252 }, 203);
                _0x83347406 = ApplicationInstallMode.Store;
                _0x55ecb974 = _0xd43d4e85._0x88ae33d6(new byte[19] { 231, 235, 233, 170, 229, 234, 224, 246, 235, 237, 224, 170, 242, 225, 234, 224, 237, 234, 227 }, 132);
                _0x55ea55cf = _0xd43d4e85._0x88ae33d6(new byte[8] { 249, 241, 236, 232, 229, 188, 233, 253 }, 156);
                _0x41b8de7c = Guid.NewGuid().ToString().Replace(_0xd43d4e85._0x88ae33d6(new byte[1] { 28 }, 49), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[17] { 93, 82, 99, 117, 114, 91, 38, 98, 99, 112, 75, 105, 98, 99, 106, 60, 38 }, 6) + _0xa82f227f);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[19] { 92, 83, 98, 116, 115, 90, 39, 102, 119, 119, 81, 98, 117, 116, 110, 104, 105, 61, 39 }, 7) + _0x0d7a3740);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[20] { 243, 252, 205, 219, 220, 245, 136, 193, 198, 219, 220, 201, 196, 196, 229, 199, 204, 205, 146, 136 }, 168) + _0x83347406);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[23] { 220, 211, 226, 244, 243, 218, 167, 238, 233, 244, 243, 230, 235, 235, 226, 245, 212, 243, 232, 245, 226, 189, 167 }, 135) + _0x55ecb974);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[14] { 43, 36, 21, 3, 4, 45, 80, 17, 0, 0, 57, 20, 74, 80 }, 112) + _0x5f9325f4);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[14] { 30, 17, 32, 54, 49, 24, 101, 36, 33, 51, 12, 33, 127, 101 }, 69) + _0xcce27f9a);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[18] { 140, 131, 178, 164, 163, 138, 247, 162, 164, 178, 165, 150, 176, 178, 185, 163, 237, 247 }, 215) + _0x55ea55cf);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[17] { 245, 250, 203, 221, 218, 243, 142, 221, 215, 221, 234, 203, 216, 231, 202, 148, 142 }, 174) + _0x41b8de7c);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[12] { 254, 241, 192, 214, 209, 248, 133, 194, 213, 208, 159, 133 }, 165) + _0x8a97e078);
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[12] { 30, 17, 32, 54, 49, 24, 101, 38, 53, 48, 127, 101 }, 69) + _0x5825103a);
#endif
        }
    }

    private void _0x67d7040f()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xb22ef394()
    {
        float _0x6fdd905c = Time.realtimeSinceStartup;
        if (_0x6fdd905c < 0f)
            _0x6fdd905c = 0f;
        int _0xe98fb9e5 = (int)(_0x6fdd905c * 1000f);
        int _0xe06c024e = _0xe98fb9e5 / 60000;
        int _0x09ee8904 = (_0xe98fb9e5 / 1000) % 60;
        int _0x2ff7a255 = _0xe98fb9e5 % 1000;
        return string.Format(_0xd43d4e85._0x88ae33d6(new byte[21] { 185, 242, 248, 242, 242, 191, 248, 185, 243, 248, 242, 242, 191, 248, 185, 240, 248, 242, 242, 242, 191 }, 194), _0xe06c024e, _0x09ee8904, _0x2ff7a255);
    }

    private GameObject _0x5c1bf1e6;
    private bool _0x06a7fc66(string _0xf9c984f7)
    {
        try
        {
            using (var _0xa35ce6c0 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[30] { 56, 52, 54, 117, 46, 53, 50, 47, 34, 104, 63, 117, 43, 55, 58, 34, 62, 41, 117, 14, 53, 50, 47, 34, 11, 55, 58, 34, 62, 41 }, 91)))
            using (var _0x85989ed3 = _0xa35ce6c0.GetStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 30, 8, 15, 15, 24, 19, 9, 60, 30, 9, 20, 11, 20, 9, 4 }, 125)))
            using (var _0xd1b6e13b = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[15] { 155, 148, 158, 136, 149, 147, 158, 212, 148, 159, 142, 212, 175, 136, 147 }, 250)))
            using (var _0x38ae5307 = _0xd1b6e13b.CallStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[5] { 226, 243, 224, 225, 247 }, 146), _0xf9c984f7))
            using (var _0x437f7a33 = new AndroidJavaObject(_0xd43d4e85._0x88ae33d6(new byte[22] { 43, 36, 46, 56, 37, 35, 46, 100, 41, 37, 36, 62, 47, 36, 62, 100, 3, 36, 62, 47, 36, 62 }, 74), _0xd43d4e85._0x88ae33d6(new byte[26] { 22, 25, 19, 5, 24, 30, 19, 89, 30, 25, 3, 18, 25, 3, 89, 22, 20, 3, 30, 24, 25, 89, 33, 62, 50, 32 }, 119), _0x38ae5307))
            {
                WLog(_0xd43d4e85._0x88ae33d6(new byte[26] { 159, 180, 174, 179, 177, 185, 144, 181, 183, 185, 252, 179, 172, 185, 178, 252, 185, 164, 168, 185, 174, 178, 189, 176, 230, 252 }, 220) + _0xf9c984f7);
                _0x437f7a33.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[11] { 213, 208, 208, 247, 213, 192, 209, 211, 219, 198, 205 }, 180), _0xd43d4e85._0x88ae33d6(new byte[33] { 173, 162, 168, 190, 163, 165, 168, 226, 165, 162, 184, 169, 162, 184, 226, 175, 173, 184, 169, 171, 163, 190, 181, 226, 142, 158, 131, 155, 159, 141, 142, 128, 137 }, 204));
                _0x437f7a33.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[8] { 212, 209, 209, 243, 217, 212, 210, 198 }, 181), 0x10000000);
                _0x85989ed3.Call(_0xd43d4e85._0x88ae33d6(new byte[13] { 61, 58, 47, 60, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78), _0x437f7a33);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[28] { 102, 77, 87, 74, 72, 64, 105, 76, 78, 64, 5, 64, 93, 81, 64, 87, 75, 68, 73, 5, 67, 68, 76, 73, 64, 65, 31, 5 }, 37) + e.Message);
            Application.OpenURL(_0xf9c984f7);
            return true;
        }
    }

    private string _0x0a69e3b4 = "";
    private string _0xa82f227f = "";
    internal bool _0x293ac3a4(string _0x8c870eca)
    {
        return _0x8c870eca.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[9] { 150, 154, 137, 144, 158, 143, 193, 212, 212 }, 251), StringComparison.OrdinalIgnoreCase) || _0x8c870eca.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[24] { 241, 237, 237, 233, 234, 163, 182, 182, 233, 245, 248, 224, 183, 254, 246, 246, 254, 245, 252, 183, 250, 246, 244, 182 }, 153), StringComparison.OrdinalIgnoreCase) || _0x8c870eca.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[23] { 150, 138, 138, 142, 196, 209, 209, 142, 146, 159, 135, 208, 153, 145, 145, 153, 146, 155, 208, 157, 145, 147, 209 }, 254), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x7e1b3274(bool _0x316837b3)
    {
        _0x73fa3156();
        _0x5c1bf1e6.SetActive(_0x316837b3);
        _0xc681090c = _0x316837b3;
        if (_0x316837b3)
        {
            _0x5c1bf1e6.transform.SetAsLastSibling();
            if (_0x33fa86bd != null)
                _0x33fa86bd.localRotation = Quaternion.identity;
        }
    }

    private string _0x9a962730 { get; set; }

    private bool _0x04b401d5()
    {
        _0x98cfee51.RemoveAll(_0xc8b0cd4b => _0xc8b0cd4b == null || !_0xc8b0cd4b.IsAlive);
        return _0x98cfee51.Count > 0;
    }

    private bool _0xb3946e97(string _0x6b92e786)
    {
        try
        {
            using (var _0x57690ce8 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[30] { 241, 253, 255, 188, 231, 252, 251, 230, 235, 161, 246, 188, 226, 254, 243, 235, 247, 224, 188, 199, 252, 251, 230, 235, 194, 254, 243, 235, 247, 224 }, 146)))
            using (var _0x69cf332f = _0x57690ce8.GetStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 158, 136, 143, 143, 152, 147, 137, 188, 158, 137, 148, 139, 148, 137, 132 }, 253)))
            using (var _0x1f8085ce = _0x69cf332f.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[17] { 243, 241, 224, 196, 245, 247, 255, 245, 243, 241, 217, 245, 250, 245, 243, 241, 230 }, 148)))
            using (var _0x2681aff1 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[22] { 176, 191, 181, 163, 190, 184, 181, 255, 178, 190, 191, 165, 180, 191, 165, 255, 152, 191, 165, 180, 191, 165 }, 209)))
            using (var _0xe32776a9 = _0x2681aff1.CallStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[8] { 145, 128, 147, 146, 132, 180, 147, 136 }, 225), _0x6b92e786, 1))
            {
                string _0x0a86a3de = _0xe32776a9.Call<string>(_0xd43d4e85._0x88ae33d6(new byte[14] { 113, 115, 98, 69, 98, 100, 127, 120, 113, 83, 110, 98, 100, 119 }, 22), _0xd43d4e85._0x88ae33d6(new byte[20] { 210, 194, 223, 199, 195, 213, 194, 239, 214, 209, 220, 220, 210, 209, 211, 219, 239, 197, 194, 220 }, 176));
                string _0x33a89279 = _0xe32776a9.Call<string>(_0xd43d4e85._0x88ae33d6(new byte[10] { 27, 25, 8, 44, 29, 31, 23, 29, 27, 25 }, 124));
                _0xe32776a9.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[11] { 84, 81, 81, 118, 84, 65, 80, 82, 90, 71, 76 }, 53), _0xd43d4e85._0x88ae33d6(new byte[33] { 133, 138, 128, 150, 139, 141, 128, 202, 141, 138, 144, 129, 138, 144, 202, 135, 133, 144, 129, 131, 139, 150, 157, 202, 166, 182, 171, 179, 183, 165, 166, 168, 161 }, 228));
                _0xe32776a9.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[11] { 96, 119, 127, 125, 100, 119, 87, 106, 102, 96, 115 }, 18), _0xd43d4e85._0x88ae33d6(new byte[20] { 56, 40, 53, 45, 41, 63, 40, 5, 60, 59, 54, 54, 56, 59, 57, 49, 5, 47, 40, 54 }, 90));
                if (_0xe32776a9.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 13, 26, 12, 16, 19, 9, 26, 62, 28, 11, 22, 9, 22, 11, 6 }, 127), _0x1f8085ce) != null)
                {
                    WLog(_0xd43d4e85._0x88ae33d6(new byte[24] { 134, 173, 183, 170, 168, 160, 137, 172, 174, 160, 229, 170, 181, 160, 171, 229, 172, 171, 177, 160, 171, 177, 255, 229 }, 197) + _0x6b92e786);
                    _0xe32776a9.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[8] { 63, 58, 58, 24, 50, 63, 57, 45 }, 94), 0x10000000);
                    _0x69cf332f.Call(_0xd43d4e85._0x88ae33d6(new byte[13] { 145, 150, 131, 144, 150, 163, 129, 150, 139, 148, 139, 150, 155 }, 226), _0xe32776a9);
                    return true;
                }

                if (_0xc1cf0ec8(_0x33a89279))
                    return true;
                if (!string.IsNullOrEmpty(_0x0a86a3de))
                {
                    WLog(_0xd43d4e85._0x88ae33d6(new byte[28] { 183, 156, 134, 155, 153, 145, 184, 157, 159, 145, 212, 157, 154, 128, 145, 154, 128, 212, 146, 149, 152, 152, 150, 149, 151, 159, 206, 212 }, 244) + _0x0a86a3de);
                    if (_0x293ac3a4(_0x0a86a3de))
                        return _0x5213e570(_0x0a86a3de, _0x33a89279);
                    return _0x06a7fc66(_0x0a86a3de);
                }

                WLog(_0xd43d4e85._0x88ae33d6(new byte[30] { 74, 97, 123, 102, 100, 108, 69, 96, 98, 108, 41, 96, 103, 125, 108, 103, 125, 41, 103, 102, 41, 97, 104, 103, 109, 101, 108, 123, 51, 41 }, 9) + _0x6b92e786);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[26] { 190, 149, 143, 146, 144, 152, 177, 148, 150, 152, 221, 148, 147, 137, 152, 147, 137, 221, 155, 156, 148, 145, 152, 153, 199, 221 }, 253) + e.Message);
            return true;
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x47db508c)
    {
        if (_0x47db508c == null || _0x47db508c.Extra == null)
            return null;
        object _0x361c8d55;
        if (!_0x47db508c.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x361c8d55))
            return null;
        return _0x361c8d55 as string;
    }

    private IEnumerator _0x1273d0b9(Dictionary<string, object> _0xd5a4a036)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[30] { 211, 220, 237, 251, 252, 213, 168, 206, 237, 252, 235, 224, 168, 205, 240, 252, 250, 233, 168, 216, 253, 251, 224, 168, 204, 233, 252, 233, 178, 168 }, 136) + string.Join(_0xd43d4e85._0x88ae33d6(new byte[1] { 123 }, 114), _0xd5a4a036));
#endif
            }
        }

        string _0x61b2d14d = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xd5a4a036 != null && _0xd5a4a036.TryGetValue(_0xd43d4e85._0x88ae33d6(new byte[16] { 180, 181, 174, 179, 188, 179, 185, 187, 174, 179, 181, 180, 158, 187, 174, 187 }, 218), out var raw))
        {
            try
            {
                var _0x5980377e = raw?.ToString();
                var _0xf98d7d5c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x5980377e);
                if (_0xf98d7d5c != null && _0xf98d7d5c.TryGetValue(_0xd43d4e85._0x88ae33d6(new byte[6] { 42, 60, 55, 61, 48, 61 }, 89), out var val))
                {
                    _0x61b2d14d = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xd43d4e85._0x88ae33d6(new byte[30] { 48, 63, 14, 24, 31, 75, 59, 30, 24, 3, 54, 75, 33, 56, 36, 37, 75, 27, 10, 25, 24, 14, 75, 14, 25, 25, 4, 25, 81, 75 }, 107) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x61b2d14d) && _0xd5a4a036 != null && _0xd5a4a036.TryGetValue(_0xd43d4e85._0x88ae33d6(new byte[6] { 119, 97, 106, 96, 109, 96 }, 4), out var lab))
        {
            _0x61b2d14d = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[38] { 182, 185, 136, 158, 153, 205, 189, 152, 158, 133, 176, 205, 171, 136, 153, 142, 133, 136, 137, 205, 158, 136, 131, 137, 132, 137, 205, 139, 159, 130, 128, 205, 135, 158, 130, 131, 215, 205 }, 237) + _0x61b2d14d);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x61b2d14d))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[38] { 149, 154, 171, 189, 186, 238, 158, 187, 189, 166, 147, 238, 153, 175, 167, 186, 238, 186, 161, 238, 161, 190, 171, 160, 238, 185, 167, 186, 166, 238, 189, 171, 160, 170, 167, 170, 244, 238 }, 206) + _0x61b2d14d);
            }
#endif
        }

        _0x262943d0 = _0x61b2d14d;
        yield return new WaitUntil(() => _0x547e3c71);
        var _0x1e3d3dc6 = _0xe267d8d2(2, 100);
        yield return new WaitUntil(() => _0x1e3d3dc6.IsCompleted);
        string _0x7d023e49 = _0x1e3d3dc6.Result;
        if (!string.IsNullOrEmpty(_0x7d023e49))
        {
            string _0x827d2501 = _0x0515a2a4(_0x7d023e49, _0x61b2d14d);
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[33] { 148, 155, 170, 188, 187, 239, 159, 186, 188, 167, 146, 239, 157, 170, 163, 160, 174, 171, 239, 152, 170, 173, 153, 166, 170, 184, 239, 184, 166, 187, 167, 245, 239 }, 207) + _0x827d2501);
#endif
            }

            _0x2536f5e0.Load(_0x827d2501);
        }
    }

    private string _0x5f9325f4 = "";
    public void _0x8f9e3859()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[18] { 32, 47, 30, 8, 15, 38, 91, 55, 26, 14, 21, 24, 19, 91, 60, 26, 22, 30 }, 123));
#endif
        }

        _0x8f9b1458.Instance?._0xf91c891f();
        _0x6ae8a66c.Instance._0x38a32e83(_0x47dc124a._0xecae2237.DEFAULT);
    }

    private async Task<bool> _0x53f7c7f8()
    {
        _0x8f9b1458.Instance?._0xecd0e3db();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x077865d2) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[32] { 236, 227, 210, 196, 195, 234, 151, 226, 217, 222, 195, 206, 151, 231, 194, 196, 223, 151, 249, 216, 195, 222, 209, 222, 212, 214, 195, 222, 216, 217, 141, 151 }, 183) + string.Join(_0xd43d4e85._0x88ae33d6(new byte[1] { 232 }, 225), _0x077865d2));
                }
#endif
            }
        };
        try
        {
            _0x656b103a = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[31] { 240, 255, 206, 216, 223, 246, 139, 237, 202, 194, 199, 206, 207, 139, 223, 196, 139, 204, 206, 223, 139, 219, 222, 216, 195, 139, 223, 196, 192, 206, 197 }, 171));
                }
#endif
            }

            _0x656b103a = "";
        }

        _0x1399d50b = !string.IsNullOrEmpty(_0x656b103a);
        _0x8e2f5e76 = _0xb22ef394();
        {
#if B_LOGS
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[25] { 183, 184, 137, 159, 152, 177, 204, 185, 130, 133, 152, 149, 204, 188, 153, 159, 132, 204, 184, 131, 135, 137, 130, 214, 204 }, 236) + _0x656b103a);
#endif
        }

        _0x8f9b1458.Instance?._0x79552162();
        return false;
    }

    private IEnumerator _0xa43f695f(string _0xfcd0f85d)
    {
        if (_0x2536f5e0 != null && _0x547e3c71)
            yield break;
        _0x2536f5e0 = gameObject.AddComponent<UniWebView>();
        _0x5a827da2(_0x2536f5e0);
        _0x59a916dc(_0x2536f5e0);
        _0x2536f5e0.BackgroundColor = Color.clear;
        var _0x81c42885 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x02bd3132();
        yield return new WaitForEndOfFrame();
        _0x547e3c71 = true;
        _0x73fa3156();
        _0x7e1b3274(true);
        _0x2a1596dc = false;
        _0xa259e205 = false;
        _0x98cfee51.Clear();
        _0xf80633fd = -1;
        firstLoadShown = false;
        _0x6096de60 = false;
        _0x9b72bcb7 = false;
        _0x2536f5e0.SetUserAgent("");
        _0x8025965a = Time.realtimeSinceStartup;
        _0x2536f5e0.Stop();
        _0x2536f5e0.Load(_0xfcd0f85d);
        _0x2536f5e0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xd43d4e85._0x88ae33d6(new byte[25] { 61, 17, 25, 30, 80, 39, 21, 18, 38, 25, 21, 7, 80, 57, 30, 25, 4, 25, 17, 28, 80, 35, 24, 31, 7 }, 112));
    }

    internal bool isApplicationPause = false;
    internal bool IsAboutBlank(string _0x622b7b76)
    {
        if (string.IsNullOrEmpty(_0x622b7b76))
            return false;
        return _0x622b7b76.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[11] { 208, 211, 222, 196, 197, 139, 211, 221, 208, 223, 218 }, 177), StringComparison.OrdinalIgnoreCase);
    }

    // WEB VIEW LOGIC END
    internal void _0x85a0b3dd()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xbd344d10 = new AndroidNotificationChannel
        {
            Id = _0xd43d4e85._0x88ae33d6(new byte[15] { 189, 188, 191, 184, 172, 181, 173, 134, 186, 177, 184, 183, 183, 188, 181 }, 217),
            Name = _0xd43d4e85._0x88ae33d6(new byte[15] { 94, 127, 124, 123, 111, 118, 110, 58, 89, 114, 123, 116, 116, 127, 118 }, 26),
            Importance = Importance.High,
            Description = _0xd43d4e85._0x88ae33d6(new byte[21] { 149, 183, 188, 183, 160, 179, 190, 242, 188, 189, 166, 187, 180, 187, 177, 179, 166, 187, 189, 188, 161 }, 210)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xbd344d10);
        // Build notification
        var _0x477b2d6c = new AndroidNotification
        {
            Title = _0xa0ce82d1[UnityEngine.Random.Range(0, _0xa0ce82d1.Length)],
            Text = _0xd43d4e85._0x88ae33d6(new byte[21] { 34, 17, 6, 67, 26, 12, 22, 67, 16, 22, 17, 6, 67, 23, 12, 67, 6, 27, 10, 23, 92 }, 99),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x477b2d6c, _0xd43d4e85._0x88ae33d6(new byte[15] { 200, 201, 202, 205, 217, 192, 216, 243, 207, 196, 205, 194, 194, 201, 192 }, 172));
    }

    private async Task<bool> _0x8c5ff2f4()
    {
        {
#if B_LOGS
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[37] { 242, 253, 204, 218, 221, 244, 137, 250, 192, 206, 199, 224, 199, 252, 199, 192, 221, 208, 250, 204, 219, 223, 192, 202, 204, 218, 232, 199, 198, 199, 208, 196, 198, 220, 218, 197, 208 }, 169));
#endif
        }

        try
        {
            var _0x318dd5fc = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x318dd5fc);
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[32] { 90, 85, 100, 114, 117, 92, 33, 84, 111, 104, 117, 120, 82, 100, 115, 119, 104, 98, 100, 114, 33, 72, 111, 104, 117, 104, 96, 109, 104, 123, 100, 101 }, 1));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[20] { 146, 131, 149, 146, 230, 147, 168, 175, 178, 191, 149, 163, 180, 176, 175, 165, 163, 181, 252, 230 }, 198) + ex.Message);
#endif
            }

            _0x69ef9ca0?._0x8f9e3859();
            return true;
        }

        bool _0x35ffe654 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x35ffe654 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[37] { 247, 248, 201, 223, 216, 241, 140, 255, 197, 203, 194, 129, 197, 194, 140, 237, 194, 195, 194, 213, 193, 195, 217, 223, 130, 140, 252, 192, 205, 213, 201, 222, 140, 229, 232, 150, 140 }, 172) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x79ea7149 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[25] { 109, 124, 106, 109, 25, 106, 80, 94, 87, 20, 80, 87, 25, 120, 76, 77, 81, 25, 124, 107, 107, 118, 107, 3, 25 }, 57) + ex.Message);
#endif
                }

                _0x69ef9ca0?._0x8f9e3859();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[28] { 73, 88, 78, 73, 61, 78, 116, 122, 115, 48, 116, 115, 61, 79, 120, 108, 104, 120, 110, 105, 61, 88, 79, 79, 82, 79, 39, 61 }, 29) + ex.Message);
#endif
                }

                _0x69ef9ca0?._0x8f9e3859();
                return true;
            }
        }
        while (!_0x35ffe654);
        return false;
    }

    private bool TryOpenExternalLikeChrome(string _0x08f7df50)
    {
        if (string.IsNullOrEmpty(_0x08f7df50))
            return false;
        if (_0x08f7df50.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[9] { 52, 51, 41, 56, 51, 41, 103, 114, 114 }, 93), StringComparison.OrdinalIgnoreCase))
            return _0xb3946e97(_0x08f7df50);
        if (_0x293ac3a4(_0x08f7df50))
            return _0x5213e570(_0x08f7df50, null);
        if (!_0x08f7df50.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[7] { 134, 154, 154, 158, 212, 193, 193 }, 238), StringComparison.OrdinalIgnoreCase) && !_0x08f7df50.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[8] { 6, 26, 26, 30, 29, 84, 65, 65 }, 110), StringComparison.OrdinalIgnoreCase) && !_0x08f7df50.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[11] { 176, 179, 190, 164, 165, 235, 179, 189, 176, 191, 186 }, 209), StringComparison.OrdinalIgnoreCase))
        {
            return _0x06a7fc66(_0x08f7df50);
        }

        return false;
    }

    private string Decrypt(string _0x0102c85b, string _0xd35b7437)
    {
        try
        {
            var _0xf3b54b95 = Convert.FromBase64String(_0x0102c85b);
            using var _0x682706af = Aes.Create();
            _0x682706af.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xd35b7437));
            var _0xd472683b = new byte[16];
            Buffer.BlockCopy(_0xf3b54b95, 0, _0xd472683b, 0, 16);
            _0x682706af.IV = _0xd472683b;
            using var _0x365b6181 = new MemoryStream(_0xf3b54b95, 16, _0xf3b54b95.Length - 16);
            using var _0x9b93e21f = new CryptoStream(_0x365b6181, _0x682706af.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x255df742 = new StreamReader(_0x9b93e21f, Encoding.UTF8);
            return _0x255df742.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool isApplicationFocus = false;
    private string _0x0515a2a4(string _0xb1bb69af, string _0x44f3b1f4)
    {
        if (string.IsNullOrEmpty(_0x44f3b1f4))
            return _0xb1bb69af;
        if (_0xb1bb69af.Contains(_0xd43d4e85._0x88ae33d6(new byte[1] { 103 }, 88)))
            return _0xb1bb69af + _0xd43d4e85._0x88ae33d6(new byte[8] { 59, 110, 120, 115, 121, 116, 121, 32 }, 29) + UnityWebRequest.EscapeURL(_0x44f3b1f4);
        else
            return _0xb1bb69af + _0xd43d4e85._0x88ae33d6(new byte[8] { 194, 142, 152, 147, 153, 148, 153, 192 }, 253) + UnityWebRequest.EscapeURL(_0x44f3b1f4);
    }

    private string _0x5825103a = "";
    private readonly string[] _0xa0ce82d1 = new string[]
    {
        _0xd43d4e85._0x88ae33d6(new byte[60] { 225, 142, 159, 161, 49, 69, 121, 116, 49, 99, 116, 116, 125, 98, 49, 112, 99, 116, 49, 121, 126, 101, 49, 99, 120, 118, 121, 101, 49, 127, 126, 102, 49, 243, 145, 130, 49, 117, 126, 127, 243, 145, 136, 101, 49, 124, 120, 98, 98, 49, 104, 126, 100, 99, 49, 98, 97, 120, 127, 48 }, 17),
        _0xd43d4e85._0x88ae33d6(new byte[52] { 125, 18, 0, 13, 173, 196, 249, 173, 238, 226, 248, 225, 233, 173, 239, 232, 173, 244, 226, 248, 255, 173, 225, 248, 238, 230, 244, 173, 224, 226, 224, 232, 227, 249, 173, 111, 13, 30, 173, 250, 229, 244, 173, 254, 249, 226, 253, 173, 227, 226, 250, 178 }, 141),
        _0xd43d4e85._0x88ae33d6(new byte[66] { 85, 45, 22, 88, 15, 56, 151, 245, 222, 208, 151, 192, 222, 217, 196, 151, 214, 197, 210, 151, 223, 222, 195, 195, 222, 217, 208, 151, 218, 216, 197, 210, 151, 216, 209, 195, 210, 217, 151, 195, 216, 211, 214, 206, 151, 85, 55, 36, 151, 196, 195, 214, 206, 151, 222, 217, 151, 195, 223, 210, 151, 208, 214, 218, 210, 153 }, 183),
        _0xd43d4e85._0x88ae33d6(new byte[54] { 84, 59, 49, 54, 132, 240, 204, 205, 215, 132, 205, 215, 132, 212, 214, 205, 201, 193, 132, 208, 205, 201, 193, 132, 70, 36, 55, 132, 208, 204, 193, 132, 198, 193, 215, 208, 132, 212, 200, 197, 221, 193, 214, 215, 132, 212, 200, 197, 221, 132, 202, 203, 211, 138 }, 164),
        _0xd43d4e85._0x88ae33d6(new byte[48] { 218, 181, 190, 143, 10, 115, 69, 95, 88, 10, 93, 67, 68, 68, 67, 68, 77, 10, 89, 94, 88, 79, 75, 65, 10, 73, 69, 95, 70, 78, 10, 72, 79, 10, 69, 68, 79, 10, 89, 90, 67, 68, 10, 75, 93, 75, 83, 4 }, 42),
        _0xd43d4e85._0x88ae33d6(new byte[65] { 61, 82, 87, 77, 237, 135, 172, 174, 166, 189, 162, 185, 190, 237, 172, 191, 168, 237, 160, 162, 191, 168, 237, 172, 174, 185, 164, 187, 168, 237, 185, 162, 163, 164, 170, 165, 185, 237, 47, 77, 94, 237, 190, 185, 172, 180, 237, 172, 163, 169, 237, 185, 191, 180, 237, 180, 162, 184, 191, 237, 161, 184, 174, 166, 227 }, 205),
        _0xd43d4e85._0x88ae33d6(new byte[55] { 2, 109, 124, 64, 210, 183, 132, 151, 128, 139, 210, 129, 130, 155, 156, 210, 145, 157, 135, 156, 134, 129, 210, 16, 114, 97, 210, 134, 154, 151, 210, 156, 151, 138, 134, 210, 157, 156, 151, 210, 145, 157, 135, 158, 150, 210, 144, 151, 210, 139, 157, 135, 128, 129, 220 }, 242),
        _0xd43d4e85._0x88ae33d6(new byte[63] { 164, 235, 214, 169, 254, 201, 102, 22, 42, 39, 63, 35, 52, 53, 102, 52, 47, 33, 46, 50, 102, 40, 41, 49, 102, 39, 52, 35, 102, 49, 47, 40, 40, 47, 40, 33, 102, 164, 198, 213, 102, 34, 41, 40, 164, 198, 223, 50, 102, 49, 39, 42, 45, 102, 39, 49, 39, 63, 102, 63, 35, 50, 104 }, 70),
        _0xd43d4e85._0x88ae33d6(new byte[51] { 47, 64, 80, 89, 255, 144, 177, 179, 166, 255, 171, 183, 176, 172, 186, 255, 168, 183, 176, 255, 172, 171, 190, 166, 255, 182, 177, 255, 171, 183, 186, 255, 184, 190, 178, 186, 255, 168, 182, 177, 255, 171, 183, 186, 255, 175, 173, 182, 165, 186, 241 }, 223),
        _0xd43d4e85._0x88ae33d6(new byte[64] { 224, 152, 163, 237, 186, 141, 34, 79, 109, 111, 103, 108, 118, 119, 111, 34, 107, 113, 34, 103, 116, 103, 112, 123, 118, 106, 107, 108, 101, 34, 224, 130, 145, 34, 105, 103, 103, 114, 34, 113, 114, 107, 108, 108, 107, 108, 101, 34, 100, 109, 112, 34, 123, 109, 119, 112, 34, 97, 106, 99, 108, 97, 103, 44 }, 2)
    };
    private AndroidJavaObject _0x36e60ecf { get; set; }

    private void WLog(string _0x9c11e867)
    {
#if B_LOGS
        {
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[7] { 39, 40, 25, 15, 8, 33, 92 }, 124) + _0x9c11e867);
        }
#endif
    }

    private string _0x7f1f0570()
    {
        return _0xd43d4e85._0x88ae33d6(new byte[12] { 44, 98, 113, 106, 103, 112, 109, 107, 106, 44, 45, 127 }, 4) + _0xd43d4e85._0x88ae33d6(new byte[8] { 16, 7, 20, 70, 19, 7, 91, 65 }, 102) + WindowsDesktopUserAgent + _0xd43d4e85._0x88ae33d6(new byte[2] { 75, 87 }, 108) + _0xd43d4e85._0x88ae33d6(new byte[30] { 102, 113, 98, 48, 96, 98, 127, 100, 127, 45, 94, 113, 102, 121, 119, 113, 100, 127, 98, 62, 96, 98, 127, 100, 127, 100, 105, 96, 117, 43 }, 16) + _0xd43d4e85._0x88ae33d6(new byte[121] { 114, 97, 122, 119, 96, 125, 123, 122, 52, 112, 113, 114, 60, 123, 118, 126, 56, 127, 113, 109, 56, 98, 117, 120, 61, 111, 96, 102, 109, 111, 91, 118, 126, 113, 119, 96, 58, 112, 113, 114, 125, 122, 113, 68, 102, 123, 100, 113, 102, 96, 109, 60, 123, 118, 126, 56, 127, 113, 109, 56, 111, 115, 113, 96, 46, 114, 97, 122, 119, 96, 125, 123, 122, 60, 61, 111, 102, 113, 96, 97, 102, 122, 52, 98, 117, 120, 47, 105, 56, 119, 123, 122, 114, 125, 115, 97, 102, 117, 118, 120, 113, 46, 96, 102, 97, 113, 105, 61, 47, 105, 119, 117, 96, 119, 124, 60, 113, 61, 111, 105, 105 }, 20) + _0xd43d4e85._0x88ae33d6(new byte[26] { 224, 225, 226, 172, 244, 246, 235, 240, 235, 168, 163, 241, 247, 225, 246, 197, 227, 225, 234, 240, 163, 168, 241, 229, 173, 191 }, 132) + _0xd43d4e85._0x88ae33d6(new byte[130] { 172, 173, 174, 224, 184, 186, 167, 188, 167, 228, 239, 169, 184, 184, 158, 173, 186, 187, 161, 167, 166, 239, 228, 239, 253, 230, 248, 232, 224, 159, 161, 166, 172, 167, 191, 187, 232, 134, 156, 232, 249, 248, 230, 248, 243, 232, 159, 161, 166, 254, 252, 243, 232, 176, 254, 252, 225, 232, 137, 184, 184, 164, 173, 159, 173, 170, 131, 161, 188, 231, 253, 251, 255, 230, 251, 254, 232, 224, 131, 128, 156, 133, 132, 228, 232, 164, 161, 163, 173, 232, 143, 173, 171, 163, 167, 225, 232, 139, 160, 186, 167, 165, 173, 231, 249, 250, 248, 230, 248, 230, 248, 230, 248, 232, 155, 169, 174, 169, 186, 161, 231, 253, 251, 255, 230, 251, 254, 239, 225, 243 }, 200) + _0xd43d4e85._0x88ae33d6(new byte[30] { 71, 70, 69, 11, 83, 81, 76, 87, 76, 15, 4, 83, 79, 66, 87, 69, 76, 81, 78, 4, 15, 4, 116, 74, 77, 16, 17, 4, 10, 24 }, 35) + _0xd43d4e85._0x88ae33d6(new byte[34] { 192, 193, 194, 140, 212, 214, 203, 208, 203, 136, 131, 210, 193, 202, 192, 203, 214, 131, 136, 131, 227, 203, 203, 195, 200, 193, 132, 237, 202, 199, 138, 131, 141, 159 }, 164) + _0xd43d4e85._0x88ae33d6(new byte[30] { 53, 52, 55, 121, 33, 35, 62, 37, 62, 125, 118, 60, 48, 41, 5, 62, 36, 50, 57, 1, 62, 56, 63, 37, 34, 118, 125, 97, 120, 106 }, 81) + _0xd43d4e85._0x88ae33d6(new byte[449] { 169, 175, 164, 166, 171, 188, 175, 253, 168, 188, 185, 224, 166, 191, 175, 188, 179, 185, 174, 231, 134, 166, 191, 175, 188, 179, 185, 231, 250, 158, 181, 175, 178, 176, 180, 168, 176, 250, 241, 171, 184, 175, 174, 180, 178, 179, 231, 250, 236, 239, 237, 250, 160, 241, 166, 191, 175, 188, 179, 185, 231, 250, 154, 178, 178, 186, 177, 184, 253, 158, 181, 175, 178, 176, 184, 250, 241, 171, 184, 175, 174, 180, 178, 179, 231, 250, 236, 239, 237, 250, 160, 241, 166, 191, 175, 188, 179, 185, 231, 250, 147, 178, 169, 224, 156, 226, 159, 175, 188, 179, 185, 250, 241, 171, 184, 175, 174, 180, 178, 179, 231, 250, 239, 233, 250, 160, 128, 241, 176, 178, 191, 180, 177, 184, 231, 187, 188, 177, 174, 184, 241, 173, 177, 188, 169, 187, 178, 175, 176, 231, 250, 138, 180, 179, 185, 178, 170, 174, 250, 241, 186, 184, 169, 149, 180, 186, 181, 152, 179, 169, 175, 178, 173, 164, 139, 188, 177, 168, 184, 174, 231, 187, 168, 179, 190, 169, 180, 178, 179, 245, 244, 166, 175, 184, 169, 168, 175, 179, 253, 141, 175, 178, 176, 180, 174, 184, 243, 175, 184, 174, 178, 177, 171, 184, 245, 166, 188, 175, 190, 181, 180, 169, 184, 190, 169, 168, 175, 184, 231, 250, 165, 229, 235, 250, 241, 191, 180, 169, 179, 184, 174, 174, 231, 250, 235, 233, 250, 241, 176, 178, 191, 180, 177, 184, 231, 187, 188, 177, 174, 184, 241, 176, 178, 185, 184, 177, 231, 250, 250, 241, 173, 177, 188, 169, 187, 178, 175, 176, 231, 250, 138, 180, 179, 185, 178, 170, 174, 250, 241, 173, 177, 188, 169, 187, 178, 175, 176, 139, 184, 175, 174, 180, 178, 179, 231, 250, 236, 232, 243, 237, 243, 237, 250, 241, 168, 188, 155, 168, 177, 177, 139, 184, 175, 174, 180, 178, 179, 231, 250, 236, 239, 237, 243, 237, 243, 237, 243, 237, 250, 160, 244, 230, 160, 160, 230, 146, 191, 183, 184, 190, 169, 243, 185, 184, 187, 180, 179, 184, 141, 175, 178, 173, 184, 175, 169, 164, 245, 173, 175, 178, 169, 178, 241, 250, 168, 174, 184, 175, 156, 186, 184, 179, 169, 153, 188, 169, 188, 250, 241, 166, 186, 184, 169, 231, 187, 168, 179, 190, 169, 180, 178, 179, 245, 244, 166, 175, 184, 169, 168, 175, 179, 253, 168, 188, 185, 230, 160, 241, 190, 178, 179, 187, 180, 186, 168, 175, 188, 191, 177, 184, 231, 169, 175, 168, 184, 160, 244, 230, 160, 190, 188, 169, 190, 181, 245, 184, 244, 166, 160 }, 221) + _0xd43d4e85._0x88ae33d6(new byte[112] { 21, 20, 23, 89, 2, 18, 3, 20, 20, 31, 93, 86, 6, 24, 21, 5, 25, 86, 93, 64, 72, 67, 65, 88, 74, 21, 20, 23, 89, 2, 18, 3, 20, 20, 31, 93, 86, 25, 20, 24, 22, 25, 5, 86, 93, 64, 65, 73, 65, 88, 74, 21, 20, 23, 89, 2, 18, 3, 20, 20, 31, 93, 86, 16, 7, 16, 24, 29, 38, 24, 21, 5, 25, 86, 93, 64, 72, 67, 65, 88, 74, 21, 20, 23, 89, 2, 18, 3, 20, 20, 31, 93, 86, 16, 7, 16, 24, 29, 57, 20, 24, 22, 25, 5, 86, 93, 64, 65, 69, 65, 88, 74 }, 113) + _0xd43d4e85._0x88ae33d6(new byte[45] { 96, 102, 109, 111, 99, 125, 122, 112, 123, 99, 58, 123, 122, 96, 123, 97, 119, 124, 103, 96, 117, 102, 96, 41, 97, 122, 112, 113, 114, 125, 122, 113, 112, 47, 105, 119, 117, 96, 119, 124, 60, 113, 61, 111, 105 }, 20) + _0xd43d4e85._0x88ae33d6(new byte[721] { 216, 222, 213, 215, 218, 205, 222, 140, 195, 222, 197, 203, 145, 219, 197, 194, 200, 195, 219, 130, 193, 205, 216, 207, 196, 225, 201, 200, 197, 205, 130, 206, 197, 194, 200, 132, 219, 197, 194, 200, 195, 219, 133, 151, 219, 197, 194, 200, 195, 219, 130, 193, 205, 216, 207, 196, 225, 201, 200, 197, 205, 145, 202, 217, 194, 207, 216, 197, 195, 194, 132, 221, 133, 215, 218, 205, 222, 140, 223, 145, 255, 216, 222, 197, 194, 203, 132, 221, 133, 130, 216, 195, 224, 195, 219, 201, 222, 239, 205, 223, 201, 132, 133, 151, 197, 202, 132, 223, 130, 197, 194, 200, 201, 212, 227, 202, 132, 139, 220, 195, 197, 194, 216, 201, 222, 150, 140, 207, 195, 205, 222, 223, 201, 139, 133, 146, 145, 156, 208, 208, 223, 130, 197, 194, 200, 201, 212, 227, 202, 132, 139, 196, 195, 218, 201, 222, 150, 140, 194, 195, 194, 201, 139, 133, 146, 145, 156, 208, 208, 223, 130, 197, 194, 200, 201, 212, 227, 202, 132, 139, 193, 205, 212, 129, 219, 197, 200, 216, 196, 139, 133, 146, 145, 156, 208, 208, 223, 130, 197, 194, 200, 201, 212, 227, 202, 132, 139, 193, 205, 212, 129, 200, 201, 218, 197, 207, 201, 129, 219, 197, 200, 216, 196, 139, 133, 146, 145, 156, 133, 222, 201, 216, 217, 222, 194, 140, 215, 193, 205, 216, 207, 196, 201, 223, 150, 202, 205, 192, 223, 201, 128, 193, 201, 200, 197, 205, 150, 221, 128, 195, 194, 207, 196, 205, 194, 203, 201, 150, 194, 217, 192, 192, 128, 205, 200, 200, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 222, 201, 193, 195, 218, 201, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 205, 200, 200, 233, 218, 201, 194, 216, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 222, 201, 193, 195, 218, 201, 233, 218, 201, 194, 216, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 200, 197, 223, 220, 205, 216, 207, 196, 233, 218, 201, 194, 216, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 222, 201, 216, 217, 222, 194, 140, 202, 205, 192, 223, 201, 151, 209, 209, 151, 197, 202, 132, 223, 130, 197, 194, 200, 201, 212, 227, 202, 132, 139, 220, 195, 197, 194, 216, 201, 222, 150, 140, 202, 197, 194, 201, 139, 133, 146, 145, 156, 208, 208, 223, 130, 197, 194, 200, 201, 212, 227, 202, 132, 139, 196, 195, 218, 201, 222, 150, 140, 196, 195, 218, 201, 222, 139, 133, 146, 145, 156, 133, 222, 201, 216, 217, 222, 194, 140, 215, 193, 205, 216, 207, 196, 201, 223, 150, 216, 222, 217, 201, 128, 193, 201, 200, 197, 205, 150, 221, 128, 195, 194, 207, 196, 205, 194, 203, 201, 150, 194, 217, 192, 192, 128, 205, 200, 200, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 222, 201, 193, 195, 218, 201, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 205, 200, 200, 233, 218, 201, 194, 216, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 222, 201, 193, 195, 218, 201, 233, 218, 201, 194, 216, 224, 197, 223, 216, 201, 194, 201, 222, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 209, 128, 200, 197, 223, 220, 205, 216, 207, 196, 233, 218, 201, 194, 216, 150, 202, 217, 194, 207, 216, 197, 195, 194, 132, 133, 215, 222, 201, 216, 217, 222, 194, 140, 202, 205, 192, 223, 201, 151, 209, 209, 151, 222, 201, 216, 217, 222, 194, 140, 195, 222, 197, 203, 132, 221, 133, 151, 209, 151, 209, 207, 205, 216, 207, 196, 132, 201, 133, 215, 209 }, 172) + _0xd43d4e85._0x88ae33d6(new byte[5] { 78, 26, 27, 26, 8 }, 51);
    }

    private IEnumerator _0x7a2955f0(float _0x5b2fc74d)
    {
        yield return new WaitForSeconds(_0x5b2fc74d);
        if (!_0x1648d6e3)
        {
            _0x1648d6e3 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xbc9e907c}");
                }
#endif
            }
        }
    }

    private IEnumerator _0xb7560734()
    {
        yield return _0x83d80f28(Permission.Camera);
    }

    private bool _0x5213e570(string _0x45caa524, string _0xf9987fe9)
    {
        string _0x2571d125 = _0xcd807fa8(_0x45caa524);
        if (string.IsNullOrEmpty(_0x2571d125))
            _0x2571d125 = _0xf9987fe9;
        if (_0xc1cf0ec8(_0x2571d125))
            return true;
        string _0x52cff054 = string.IsNullOrEmpty(_0x2571d125) ? _0xd43d4e85._0x88ae33d6(new byte[29] { 142, 146, 146, 150, 149, 220, 201, 201, 150, 138, 135, 159, 200, 129, 137, 137, 129, 138, 131, 200, 133, 137, 139, 201, 149, 146, 137, 148, 131 }, 230) : _0xd43d4e85._0x88ae33d6(new byte[46] { 248, 228, 228, 224, 227, 170, 191, 191, 224, 252, 241, 233, 190, 247, 255, 255, 247, 252, 245, 190, 243, 255, 253, 191, 227, 228, 255, 226, 245, 191, 241, 224, 224, 227, 191, 244, 245, 228, 241, 249, 252, 227, 175, 249, 244, 173 }, 144) + _0x2571d125;
        WLog(_0xd43d4e85._0x88ae33d6(new byte[35] { 156, 183, 173, 176, 178, 186, 147, 182, 180, 186, 255, 178, 190, 173, 180, 186, 171, 255, 185, 190, 179, 179, 189, 190, 188, 180, 255, 190, 172, 255, 168, 186, 189, 229, 255 }, 223) + _0x52cff054);
        return _0x06a7fc66(_0x52cff054);
    }

    private bool _0x0877a02b = false;
    private string _0xcce27f9a = "";
    private void _0x6a715b8d(string _0x340f018c)
    {
        bool _0xfbb9c30d = !string.IsNullOrEmpty(_0x340f018c);
        if (_0xfbb9c30d)
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[13] { 58, 53, 4, 18, 21, 60, 65, 50, 9, 14, 22, 91, 65 }, 97) + _0x340f018c);
#endif
            }

            _0x3394c77b(_0x340f018c);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[39] { 243, 252, 205, 219, 220, 245, 136, 238, 201, 196, 196, 202, 201, 203, 195, 136, 74, 46, 58, 136, 239, 201, 197, 205, 136, 128, 198, 199, 136, 206, 193, 198, 201, 196, 136, 253, 250, 228, 129 }, 168));
#endif
            }

            _0x8f9e3859();
            return;
        }
    }

    private void Awake()
    {
        if (_0x69ef9ca0 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x69ef9ca0 = gameObject.GetComponent<_0x447218d1>();
        DontDestroyOnLoad(gameObject);
        _0x656b103a = _0x9a962730 = _0x4799eb52 = "";
        _0x0a69e3b4 = "";
        _0x547e3c71 = false;
    }

    private string _0x55ecb974 = "";
    private Text _0xe2bb0d0b;
    private bool _0xc1cf0ec8(string _0xaf2928cf)
    {
        if (string.IsNullOrEmpty(_0xaf2928cf))
            return false;
        try
        {
            using (var _0xf1a280ce = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[30] { 60, 48, 50, 113, 42, 49, 54, 43, 38, 108, 59, 113, 47, 51, 62, 38, 58, 45, 113, 10, 49, 54, 43, 38, 15, 51, 62, 38, 58, 45 }, 95)))
            using (var _0xc1d12ef9 = _0xf1a280ce.GetStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 166, 176, 183, 183, 160, 171, 177, 132, 166, 177, 172, 179, 172, 177, 188 }, 197)))
            using (var _0xdf5fe82f = _0xc1d12ef9.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[17] { 202, 200, 217, 253, 204, 206, 198, 204, 202, 200, 224, 204, 195, 204, 202, 200, 223 }, 173)))
            using (var _0x290883c6 = _0xdf5fe82f.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[25] { 187, 185, 168, 144, 189, 169, 178, 191, 180, 149, 178, 168, 185, 178, 168, 154, 179, 174, 140, 189, 191, 183, 189, 187, 185 }, 220), _0xaf2928cf))
            {
                if (_0x290883c6 == null)
                    return false;
                WLog(_0xd43d4e85._0x88ae33d6(new byte[37] { 162, 137, 147, 142, 140, 132, 173, 136, 138, 132, 193, 141, 128, 148, 143, 130, 137, 193, 136, 143, 146, 149, 128, 141, 141, 132, 133, 193, 145, 128, 130, 138, 128, 134, 132, 219, 193 }, 225) + _0xaf2928cf);
                _0x290883c6.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[8] { 152, 157, 157, 191, 149, 152, 158, 138 }, 249), 0x10000000);
                _0xc1d12ef9.Call(_0xd43d4e85._0x88ae33d6(new byte[13] { 70, 65, 84, 71, 65, 116, 86, 65, 92, 67, 92, 65, 76 }, 53), _0x290883c6);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private IEnumerator _0xa6aafc3c()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[26] { 180, 187, 138, 156, 155, 178, 207, 166, 129, 134, 155, 134, 142, 131, 134, 149, 138, 189, 138, 137, 137, 138, 157, 138, 157, 207 }, 239));
            }
#endif
        }

        bool _0xf9a1e1d7 = false;
        InstallReferrer.GetReferrer((_0xc5e71ee3) =>
        {
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[24] { 94, 81, 96, 118, 113, 37, 87, 96, 99, 96, 119, 119, 96, 119, 88, 37, 98, 96, 113, 37, 231, 131, 151, 37 }, 5) + _0xbc9e907c);
            if (_0xc5e71ee3.IsSuccess)
            {
                _0xbc9e907c = _0xc5e71ee3.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[28] { 52, 59, 10, 28, 27, 79, 61, 10, 9, 10, 29, 29, 10, 29, 50, 79, 60, 26, 12, 12, 10, 28, 28, 79, 141, 233, 253, 79 }, 111) + _0xbc9e907c);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[27] { 61, 50, 3, 21, 18, 70, 52, 3, 0, 3, 20, 20, 3, 20, 59, 70, 32, 7, 15, 10, 3, 2, 70, 132, 224, 244, 70 }, 102) + _0xc5e71ee3);
#endif
                }

                _0xbc9e907c = "";
            }

            _0x1648d6e3 = true;
        });
        StartCoroutine(_0x7a2955f0(2f));
        yield return new WaitUntil(() => _0x1648d6e3);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xbc9e907c}");
#endif
        }

        bool _0x6c1eb47a = _0xbc9e907c.Contains(_0xd43d4e85._0x88ae33d6(new byte[6] { 174, 170, 165, 160, 173, 244 }, 201));
        _0xf9a1e1d7 = _0x6c1eb47a || _0xbc9e907c.Contains(_0xd43d4e85._0x88ae33d6(new byte[18] { 159, 142, 142, 141, 208, 151, 144, 141, 138, 159, 153, 140, 159, 147, 208, 157, 145, 147 }, 254)) || _0xbc9e907c.Contains(_0xd43d4e85._0x88ae33d6(new byte[17] { 43, 58, 58, 57, 100, 44, 43, 41, 47, 40, 37, 37, 33, 100, 41, 37, 39 }, 74));
        _0x9a962730 = _0x6c1eb47a ? "" : (_0xf9a1e1d7 ? "" : _0x9a962730);
        _0x9a962730 = _0x9a962730 ?? "";
        _0x4799eb52 = _0x4799eb52 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x9a962730}");
#endif
        }
    }

    private bool _0x63f86977(int _0x4b5e1a76, string _0x8422186e, string _0x9e599808)
    {
        if (string.IsNullOrEmpty(_0x9e599808))
            return false;
        if (!IsHttpUrl(_0x9e599808))
            return true;
        if (string.IsNullOrEmpty(_0x8422186e))
            return false;
        return _0x8422186e.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[20] { 236, 251, 251, 246, 234, 230, 231, 231, 236, 234, 253, 224, 230, 231, 246, 251, 236, 250, 236, 253 }, 169), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8422186e.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[22] { 148, 131, 131, 142, 146, 158, 159, 159, 148, 146, 133, 152, 158, 159, 142, 131, 148, 151, 132, 130, 148, 149 }, 209), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8422186e.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[21] { 234, 253, 253, 240, 236, 224, 225, 225, 234, 236, 251, 230, 224, 225, 240, 236, 227, 224, 252, 234, 235 }, 175), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8422186e.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[22] { 11, 28, 28, 17, 27, 0, 5, 0, 1, 25, 0, 17, 27, 28, 2, 17, 29, 13, 6, 11, 3, 11 }, 78), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task _0x528e7f61(string _0x354301a4)
    {
        if (_0x5b544e9e || string.IsNullOrEmpty(_0x79ea7149) || string.IsNullOrEmpty(_0x354301a4) || _0x036b74c0)
            return;
        _0x5b544e9e = true;
        try
        {
            JObject _0x38b95171 = _0x1fc47f7b(_0x354301a4, _0x79ea7149, _0xb22ef394());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x354301a4} payload: {_0x38b95171}");
                }
#endif
            }

            var _0xbc1971dd = _0x41b4764b(_0x38b95171.ToString(), _0x79ea7149);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xd43d4e85._0x88ae33d6(new byte[4] { 183, 180, 186, 191 }, 219) + _0x79ea7149, _0xbc1971dd } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[24] { 178, 189, 172, 186, 189, 180, 201, 165, 134, 136, 141, 201, 153, 136, 154, 154, 201, 140, 155, 155, 134, 155, 211, 201 }, 233) + e.Message);
#endif
            }
        }
    }

    private void _0x5a827da2(UniWebView _0x87719610)
    {
        _0x87719610.BackgroundColor = Color.clear;
        _0x87719610.SetSupportMultipleWindows(true, true);
        _0x87719610.SetBackButtonEnabled(false);
        _0x2536f5e0.SetUserAgent(_0x039ba30c());
    }

    private int _0x4c8796d6 = 0;
    private string _0x656b103a = "";
    internal string _0xcd807fa8(string _0xa61003a3)
    {
        int _0xd538263b = _0xa61003a3.IndexOf(_0xd43d4e85._0x88ae33d6(new byte[3] { 99, 110, 55 }, 10), StringComparison.OrdinalIgnoreCase);
        if (_0xd538263b < 0)
            return null;
        string _0x3665b718 = _0xa61003a3.Substring(_0xd538263b + 3);
        int _0x5afdd79c = _0x3665b718.IndexOf('&');
        return _0x5afdd79c >= 0 ? _0x3665b718.Substring(0, _0x5afdd79c) : _0x3665b718;
    }

    private void _0x358f1e49()
    {
        using (var _0xf93cf196 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[30] { 86, 90, 88, 27, 64, 91, 92, 65, 76, 6, 81, 27, 69, 89, 84, 76, 80, 71, 27, 96, 91, 92, 65, 76, 101, 89, 84, 76, 80, 71 }, 53)))
        using (var _0x37fa38c5 = _0xf93cf196.GetStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 20, 2, 5, 5, 18, 25, 3, 54, 20, 3, 30, 1, 30, 3, 14 }, 119)))
        using (var _0x1e73ac68 = _0x37fa38c5.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[9] { 202, 200, 217, 228, 195, 217, 200, 195, 217 }, 173)))
        {
            if (_0x1e73ac68 == null)
                return;
            using (var _0x048598a6 = _0x1e73ac68.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[9] { 85, 87, 70, 119, 74, 70, 64, 83, 65 }, 50)))
            {
                if (_0x048598a6 == null)
                    return;
                using (var _0xa72c8f4d = new AndroidJavaObject(_0xd43d4e85._0x88ae33d6(new byte[19] { 115, 110, 123, 50, 118, 111, 115, 114, 50, 86, 79, 83, 82, 83, 126, 118, 121, 127, 104 }, 28)))
                using (var _0xeac20e44 = _0x048598a6.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[6] { 200, 198, 218, 240, 198, 215 }, 163)))
                using (var _0x3e8efa8e = _0xeac20e44.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[8] { 158, 131, 146, 133, 150, 131, 152, 133 }, 247)))
                {
                    while (_0x3e8efa8e.Call<bool>(_0xd43d4e85._0x88ae33d6(new byte[7] { 158, 151, 133, 184, 147, 142, 130 }, 246)))
                    {
                        string _0xc4552e74 = _0x3e8efa8e.Call<string>(_0xd43d4e85._0x88ae33d6(new byte[4] { 136, 131, 158, 146 }, 230));
                        using (var _0x6395fa6c = _0x048598a6.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[3] { 5, 7, 22 }, 98), _0xc4552e74))
                        {
                            _0xa72c8f4d.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[3] { 22, 19, 18 }, 102), _0xc4552e74, _0x6395fa6c);
                        }
                    }

                    string _0x33fa9e2e = _0xa72c8f4d.Call<string>(_0xd43d4e85._0x88ae33d6(new byte[8] { 11, 16, 44, 11, 13, 22, 17, 24 }, 127));
                    if (!string.IsNullOrEmpty(_0x33fa9e2e))
                    {
                        _0xc01db5a9(_0x33fa9e2e);
                        _0x8c80748a(_0x33fa9e2e);
                    }
                }
            }
        }
    }

    internal void _0x02bd3132()
    {
        Rect _0x4410c209 = Screen.safeArea;
        Vector2 _0x0ee84f6d = new Vector2(Screen.width, Screen.height);
        if (_0x4410c209 == lastSafe && _0x0ee84f6d == lastSize)
            return;
        // Apply manual padding
        _0x4410c209.xMin += _0x8151c57e;
        _0x4410c209.xMax -= _0x672c773e;
        _0x4410c209.yMin += _0x8454bab1;
        _0x4410c209.yMax -= _0x1ec44320;
        // Convert Unity safe area -> native WebView frame
        Rect _0x0556afdd = new Rect(_0x4410c209.x, _0x0ee84f6d.y - _0x4410c209.y - _0x4410c209.height, // Y flip for native coordinate system
 _0x4410c209.width, _0x4410c209.height);
        _0x2536f5e0.Frame = _0x0556afdd;
        lastSafe = Screen.safeArea;
        lastSize = _0x0ee84f6d;
    }

    private Canvas _0x93026f7a()
    {
        if (_0x7be07fdb != null)
            return _0x7be07fdb;
        var _0x5778661d = gameObject.GetComponentInChildren<Canvas>();
        if (_0x5778661d == null)
        {
            var _0x0e3984a2 = new GameObject(_0xd43d4e85._0x88ae33d6(new byte[6] { 26, 56, 55, 47, 56, 42 }, 89), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x5778661d = _0x0e3984a2.GetComponent<Canvas>();
            _0x5778661d.transform.SetParent(transform, false);
            _0x5778661d.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x7be07fdb = _0x5778661d;
        return _0x7be07fdb;
    }

    private IEnumerator _0x83d80f28(string _0x954cc3ca)
    {
        if (Permission.HasUserAuthorizedPermission(_0x954cc3ca))
            yield break;
        bool _0xda4ae9eb = false;
        var _0x424cc5d8 = new PermissionCallbacks();
        _0x424cc5d8.PermissionGranted += _0x0f276ad1 => _0xda4ae9eb = true;
        _0x424cc5d8.PermissionDenied += _0x0f276ad1 => _0xda4ae9eb = true;
        Permission.RequestUserPermission(_0x954cc3ca, _0x424cc5d8);
        yield return new WaitUntil(() => _0xda4ae9eb);
    }

    // MAIN FLOW
    private bool _0x1648d6e3 { get; set; }

    private bool _0xc681090c = false;
    private void OnApplicationPause(bool _0x8dfe1e74)
    {
        isApplicationPause = _0x8dfe1e74;
    }

    private bool _0x6e2d591c()
    {
        var _0x4674cbea = Keyboard.current;
        return _0x4674cbea != null && _0x4674cbea.escapeKey.wasPressedThisFrame;
    }

    private string _0xb7cc426b()
    {
        string _0xc8054f08 = _0x039ba30c();
        if (string.IsNullOrEmpty(_0xc8054f08))
            return _0xd43d4e85._0x88ae33d6(new byte[7] { 104, 113, 119, 122, 62, 46, 37 }, 30);
        string _0x679bf895 = _0xc8054f08.Replace(_0xd43d4e85._0x88ae33d6(new byte[1] { 98 }, 62), _0xd43d4e85._0x88ae33d6(new byte[2] { 235, 235 }, 183)).Replace(_0xd43d4e85._0x88ae33d6(new byte[1] { 168 }, 143), _0xd43d4e85._0x88ae33d6(new byte[2] { 113, 10 }, 45));
        var _0x6d96c8f3 = Regex.Match(_0xc8054f08, _0xd43d4e85._0x88ae33d6(new byte[12] { 89, 114, 104, 117, 119, 127, 53, 50, 70, 126, 49, 51 }, 26));
        string _0x2ae6c2f4 = _0x6d96c8f3.Success ? _0x6d96c8f3.Groups[1].Value : _0xd43d4e85._0x88ae33d6(new byte[3] { 126, 125, 127 }, 79);
        return _0xd43d4e85._0x88ae33d6(new byte[12] { 240, 190, 173, 182, 187, 172, 177, 183, 182, 240, 241, 163 }, 216) + _0xd43d4e85._0x88ae33d6(new byte[8] { 105, 126, 109, 63, 106, 126, 34, 56 }, 31) + _0x679bf895 + _0xd43d4e85._0x88ae33d6(new byte[2] { 17, 13 }, 54) + _0xd43d4e85._0x88ae33d6(new byte[30] { 159, 136, 155, 201, 153, 155, 134, 157, 134, 212, 167, 136, 159, 128, 142, 136, 157, 134, 155, 199, 153, 155, 134, 157, 134, 157, 144, 153, 140, 210 }, 233) + _0xd43d4e85._0x88ae33d6(new byte[121] { 115, 96, 123, 118, 97, 124, 122, 123, 53, 113, 112, 115, 61, 122, 119, 127, 57, 126, 112, 108, 57, 99, 116, 121, 60, 110, 97, 103, 108, 110, 90, 119, 127, 112, 118, 97, 59, 113, 112, 115, 124, 123, 112, 69, 103, 122, 101, 112, 103, 97, 108, 61, 122, 119, 127, 57, 126, 112, 108, 57, 110, 114, 112, 97, 47, 115, 96, 123, 118, 97, 124, 122, 123, 61, 60, 110, 103, 112, 97, 96, 103, 123, 53, 99, 116, 121, 46, 104, 57, 118, 122, 123, 115, 124, 114, 96, 103, 116, 119, 121, 112, 47, 97, 103, 96, 112, 104, 60, 46, 104, 118, 116, 97, 118, 125, 61, 112, 60, 110, 104, 104 }, 21) + _0xd43d4e85._0x88ae33d6(new byte[26] { 22, 23, 20, 90, 2, 0, 29, 6, 29, 94, 85, 7, 1, 23, 0, 51, 21, 23, 28, 6, 85, 94, 7, 19, 91, 73 }, 114) + _0xd43d4e85._0x88ae33d6(new byte[52] { 173, 172, 175, 225, 185, 187, 166, 189, 166, 229, 238, 168, 185, 185, 159, 172, 187, 186, 160, 166, 167, 238, 229, 188, 168, 231, 187, 172, 185, 165, 168, 170, 172, 225, 230, 151, 132, 166, 179, 160, 165, 165, 168, 149, 230, 230, 229, 238, 238, 224, 224, 242 }, 201) + _0xd43d4e85._0x88ae33d6(new byte[37] { 96, 97, 98, 44, 116, 118, 107, 112, 107, 40, 35, 116, 104, 101, 112, 98, 107, 118, 105, 35, 40, 35, 72, 109, 106, 113, 124, 36, 101, 118, 105, 114, 60, 104, 35, 45, 63 }, 4) + _0xd43d4e85._0x88ae33d6(new byte[34] { 4, 5, 6, 72, 16, 18, 15, 20, 15, 76, 71, 22, 5, 14, 4, 15, 18, 71, 76, 71, 39, 15, 15, 7, 12, 5, 64, 41, 14, 3, 78, 71, 73, 91 }, 96) + _0xd43d4e85._0x88ae33d6(new byte[30] { 83, 82, 81, 31, 71, 69, 88, 67, 88, 27, 16, 90, 86, 79, 99, 88, 66, 84, 95, 103, 88, 94, 89, 67, 68, 16, 27, 2, 30, 12 }, 55) + _0xd43d4e85._0x88ae33d6(new byte[48] { 55, 49, 58, 56, 53, 34, 49, 99, 54, 34, 39, 126, 56, 33, 49, 34, 45, 39, 48, 121, 24, 56, 33, 49, 34, 45, 39, 121, 100, 0, 43, 49, 44, 46, 42, 54, 46, 100, 111, 53, 38, 49, 48, 42, 44, 45, 121, 100 }, 67) + _0x2ae6c2f4 + _0xd43d4e85._0x88ae33d6(new byte[35] { 35, 121, 40, 127, 102, 118, 101, 106, 96, 62, 35, 67, 107, 107, 99, 104, 97, 36, 71, 108, 118, 107, 105, 97, 35, 40, 114, 97, 118, 119, 109, 107, 106, 62, 35 }, 4) + _0x2ae6c2f4 + _0xd43d4e85._0x88ae33d6(new byte[238] { 81, 11, 90, 13, 20, 4, 23, 24, 18, 76, 81, 56, 25, 2, 75, 55, 73, 52, 4, 23, 24, 18, 81, 90, 0, 19, 4, 5, 31, 25, 24, 76, 81, 68, 66, 81, 11, 43, 90, 27, 25, 20, 31, 26, 19, 76, 2, 4, 3, 19, 90, 6, 26, 23, 2, 16, 25, 4, 27, 76, 81, 55, 24, 18, 4, 25, 31, 18, 81, 90, 17, 19, 2, 62, 31, 17, 30, 51, 24, 2, 4, 25, 6, 15, 32, 23, 26, 3, 19, 5, 76, 16, 3, 24, 21, 2, 31, 25, 24, 94, 95, 13, 4, 19, 2, 3, 4, 24, 86, 38, 4, 25, 27, 31, 5, 19, 88, 4, 19, 5, 25, 26, 0, 19, 94, 13, 23, 4, 21, 30, 31, 2, 19, 21, 2, 3, 4, 19, 76, 81, 23, 4, 27, 81, 90, 20, 31, 2, 24, 19, 5, 5, 76, 81, 64, 66, 81, 90, 27, 25, 20, 31, 26, 19, 76, 2, 4, 3, 19, 90, 27, 25, 18, 19, 26, 76, 81, 81, 90, 6, 26, 23, 2, 16, 25, 4, 27, 76, 81, 55, 24, 18, 4, 25, 31, 18, 81, 90, 6, 26, 23, 2, 16, 25, 4, 27, 32, 19, 4, 5, 31, 25, 24, 76, 81, 71, 66, 88, 70, 88, 70, 81, 90, 3, 23, 48, 3, 26, 26, 32, 19, 4, 5, 31, 25, 24, 76, 81 }, 118) + _0x2ae6c2f4 + _0xd43d4e85._0x88ae33d6(new byte[117] { 176, 174, 176, 174, 176, 174, 185, 227, 183, 165, 227, 227, 165, 209, 252, 244, 251, 253, 234, 176, 250, 251, 248, 247, 240, 251, 206, 236, 241, 238, 251, 236, 234, 231, 182, 238, 236, 241, 234, 241, 178, 185, 235, 237, 251, 236, 223, 249, 251, 240, 234, 218, 255, 234, 255, 185, 178, 229, 249, 251, 234, 164, 248, 235, 240, 253, 234, 247, 241, 240, 182, 183, 229, 236, 251, 234, 235, 236, 240, 190, 235, 255, 250, 165, 227, 178, 253, 241, 240, 248, 247, 249, 235, 236, 255, 252, 242, 251, 164, 234, 236, 235, 251, 227, 183, 165, 227, 253, 255, 234, 253, 246, 182, 251, 183, 229, 227 }, 158) + _0xd43d4e85._0x88ae33d6(new byte[5] { 87, 3, 2, 3, 17 }, 42);
    }

    private readonly List<UniWebViewPopup> _0x98cfee51 = new List<UniWebViewPopup>();
    private string _0x9b329469 = "";
    private void _0xe314d712()
    {
        if (_0x9b72bcb7)
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[18] { 11, 54, 39, 58, 110, 47, 34, 60, 43, 47, 42, 55, 110, 61, 38, 33, 57, 32 }, 78));
            return;
        }

        _0x7e1b3274(false);
        WLog(_0xd43d4e85._0x88ae33d6(new byte[46] { 76, 96, 104, 111, 33, 86, 100, 99, 87, 104, 100, 118, 33, 81, 116, 114, 105, 33, 79, 110, 117, 104, 103, 104, 98, 96, 117, 104, 110, 111, 33, 41, 105, 96, 115, 101, 118, 96, 115, 100, 33, 99, 96, 98, 106, 40 }, 1));
        ++_0x4c8796d6;
        _0x85a0b3dd();
        if (_0x4c8796d6 <= 1)
            return;
        if (_0x04b401d5())
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[37] { 239, 210, 195, 222, 138, 217, 193, 195, 218, 218, 207, 206, 138, 135, 148, 138, 218, 197, 218, 223, 218, 217, 138, 217, 222, 195, 198, 198, 138, 197, 218, 207, 196, 207, 206, 144, 138 }, 170) + _0x98cfee51.Count);
            return;
        }

        Application.Quit();
    }

    internal bool firstLoadShown = false;
    private async Task<string> _0xe267d8d2(int _0x054657e8 = 5, int _0xc25dab39 = 500)
    {
        try
        {
            List<EntityData> _0xc87aa324 = new List<EntityData>();
            int _0x7f70158b = 0;
            do
            {
                _0xc87aa324 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xd43d4e85._0x88ae33d6(new byte[8] { 182, 170, 167, 191, 163, 180, 143, 162 }, 198), _0x79ea7149, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x79ea7149 }), new QueryOptions())).ToList();
                await Task.Delay(_0xc25dab39);
            }
            while (_0xc87aa324.Count == 0 && _0x7f70158b++ < _0x054657e8);
            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[33] { 13, 2, 51, 37, 34, 11, 118, 5, 55, 32, 51, 50, 118, 26, 63, 56, 61, 118, 7, 35, 51, 36, 47, 118, 36, 51, 37, 35, 58, 34, 37, 108, 118 }, 86) + JsonConvert.SerializeObject(_0xc87aa324, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[39] { 102, 105, 88, 78, 73, 96, 29, 110, 92, 75, 88, 89, 29, 113, 84, 83, 86, 29, 108, 72, 88, 79, 68, 29, 79, 88, 78, 72, 81, 73, 78, 29, 94, 82, 72, 83, 73, 7, 29 }, 61) + _0xc87aa324.Count);
                }
#endif
            }

            var _0x83ddc4fa = _0xc87aa324.SelectMany(_0xbbbae18b => _0xbbbae18b.Data).FirstOrDefault(_0x864fbd27 => _0x864fbd27.Key == _0x79ea7149)?.Value.GetAs<string>() ?? string.Empty;
            _0x83ddc4fa = Decrypt(_0x83ddc4fa, _0x79ea7149);
            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[24] { 163, 172, 157, 139, 140, 165, 216, 180, 151, 153, 156, 216, 139, 153, 142, 157, 156, 216, 148, 145, 150, 147, 194, 216 }, 248) + _0x83ddc4fa);
                }
#endif
            }

            return _0x83ddc4fa;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[39] { 70, 73, 120, 110, 105, 64, 61, 90, 120, 105, 61, 114, 111, 61, 109, 124, 111, 110, 120, 61, 110, 124, 107, 120, 121, 61, 113, 116, 115, 118, 61, 123, 124, 116, 113, 120, 121, 39, 61 }, 29) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private RectTransform _0x33fa86bd;
    private void _0x73fa3156()
    {
        if (_0x5c1bf1e6 != null)
            return;
        var _0x802b1aab = _0x93026f7a();
        _0x5c1bf1e6 = new GameObject(_0xd43d4e85._0x88ae33d6(new byte[14] { 90, 104, 111, 91, 100, 104, 122, 94, 125, 100, 99, 99, 104, 127 }, 13), typeof(RectTransform), typeof(Text));
        _0x33fa86bd = _0x5c1bf1e6.GetComponent<RectTransform>();
        _0x33fa86bd.SetParent(_0x802b1aab.transform, false);
        _0x33fa86bd.anchorMin = new Vector2(0.5f, 0.5f);
        _0x33fa86bd.anchorMax = new Vector2(0.5f, 0.5f);
        _0x33fa86bd.pivot = new Vector2(0.5f, 0.5f);
        _0x33fa86bd.sizeDelta = new Vector2(600f, 600f);
        _0x33fa86bd.anchoredPosition = Vector2.zero;
        _0xe2bb0d0b = _0x5c1bf1e6.GetComponent<Text>();
        _0xe2bb0d0b.text = _0xd43d4e85._0x88ae33d6(new byte[1] { 46 }, 1);
        _0xe2bb0d0b.font = Resources.GetBuiltinResource<Font>(_0xd43d4e85._0x88ae33d6(new byte[17] { 6, 47, 45, 43, 41, 51, 24, 63, 36, 62, 35, 39, 47, 100, 62, 62, 44 }, 74));
        _0xe2bb0d0b.fontSize = 200;
        _0xe2bb0d0b.alignment = TextAnchor.MiddleCenter;
        _0xe2bb0d0b.color = Color.white;
        _0xe2bb0d0b.raycastTarget = false;
        _0x5c1bf1e6.SetActive(false);
    }

    private string _0x3ba540da;
    private string _0xa8216b83 = "";
    // WS_SOURCE MONO
    public static _0x447218d1 _0x69ef9ca0 { get; private set; }

    private static readonly string WindowsDesktopUserAgent = _0xd43d4e85._0x88ae33d6(new byte[111] { 232, 202, 223, 204, 201, 201, 196, 138, 144, 139, 149, 133, 141, 242, 204, 203, 193, 202, 210, 214, 133, 235, 241, 133, 148, 149, 139, 149, 158, 133, 242, 204, 203, 147, 145, 158, 133, 221, 147, 145, 140, 133, 228, 213, 213, 201, 192, 242, 192, 199, 238, 204, 209, 138, 144, 150, 146, 139, 150, 147, 133, 141, 238, 237, 241, 232, 233, 137, 133, 201, 204, 206, 192, 133, 226, 192, 198, 206, 202, 140, 133, 230, 205, 215, 202, 200, 192, 138, 148, 151, 149, 139, 149, 139, 149, 139, 149, 133, 246, 196, 195, 196, 215, 204, 138, 144, 150, 146, 139, 150, 147 }, 165);
    private void _0x6c877073()
    {
        WLog(_0xd43d4e85._0x88ae33d6(new byte[21] { 100, 77, 94, 72, 91, 77, 94, 73, 12, 78, 77, 79, 71, 12, 92, 94, 73, 95, 95, 73, 72 }, 44));
        if (Time.frameCount == _0xf80633fd)
            return;
        _0xf80633fd = Time.frameCount;
        if (_0x904d4d49())
            return;
        _0xe314d712();
    }

    private void _0x6f999af4()
    {
        if (_0x2536f5e0 == null)
            return;
        if (_0xa259e205)
            _0x2536f5e0.SetUserAgent(_0x039ba30c());
        else
            _0x2536f5e0.SetUserAgent("");
    }

    private string _0xbc9e907c = "";
    private async Task _0x5c76f5ee()
    {
        if (await _0x8c5ff2f4())
            return;
        if (await _0x53f7c7f8())
            return;
        if (await _0xea8fa600())
            return;
        _0xaec5a60a();
        await _0x773a4982(_0xa6aafc3c());
        _0xa8216b83 = await _0xd25fd6d0();
        await _0xf844f718();
    }

    private async Task<bool> _0xea8fa600()
    {
        {
#if B_LOGS
            Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[29] { 55, 56, 9, 31, 24, 49, 76, 37, 31, 60, 30, 5, 26, 13, 15, 21, 45, 2, 8, 63, 13, 26, 9, 8, 47, 4, 9, 15, 7 }, 108));
#endif
        }

        string _0x43f16d71 = "";
        for (int _0x36892200 = 0; _0x36892200 < 2; _0x36892200++)
        {
            if (await _0x99303c64(1, 100))
            {
                await _0x528e7f61(_0xd43d4e85._0x88ae33d6(new byte[7] { 120, 118, 117, 121, 113, 127, 126 }, 26));
                _0x8f9e3859();
                return true;
            }

            _0x43f16d71 = await _0xe267d8d2(1, 100);
            if (!string.IsNullOrEmpty(_0x43f16d71))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x43f16d71))
            {
                if (!string.IsNullOrEmpty(_0x262943d0))
                {
                    _0x43f16d71 = _0x0515a2a4(_0x43f16d71, _0x262943d0);
                    {
#if B_LOGS
                        Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[53] { 122, 117, 68, 82, 85, 124, 1, 98, 64, 66, 73, 68, 69, 1, 71, 72, 79, 64, 77, 116, 83, 77, 1, 86, 72, 85, 73, 1, 82, 68, 79, 69, 72, 69, 1, 195, 167, 179, 1, 82, 73, 78, 86, 1, 118, 68, 67, 119, 72, 68, 86, 27, 1 }, 33) + _0x43f16d71);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[39] { 122, 117, 68, 82, 85, 124, 1, 98, 64, 66, 73, 68, 69, 1, 71, 72, 79, 64, 77, 116, 83, 77, 1, 195, 167, 179, 1, 82, 73, 78, 86, 1, 118, 68, 67, 119, 72, 68, 86 }, 33));
#endif
                    }
                }

                _0x036b74c0 = true;
                _0x3394c77b(_0x43f16d71);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[44] { 154, 149, 164, 178, 181, 156, 225, 132, 185, 162, 164, 177, 181, 168, 174, 175, 225, 182, 169, 168, 173, 164, 225, 162, 169, 164, 162, 170, 168, 175, 166, 225, 178, 160, 183, 164, 165, 225, 173, 168, 175, 170, 251, 225 }, 193) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private Action _0x7bccdd64;
    private void OnApplicationFocus(bool _0xa92b89db)
    {
        isApplicationFocus = _0xa92b89db;
        if (_0xa92b89db && _0x547e3c71)
        {
            _0x358f1e49();
        }
    }

    private bool _0x904d4d49()
    {
        if (_0xe17c572d())
            return true;
        if (_0x2536f5e0 != null && _0x2536f5e0.CanGoBack)
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[36] { 210, 251, 232, 254, 237, 251, 232, 255, 186, 248, 251, 249, 241, 186, 183, 164, 186, 247, 251, 243, 244, 186, 205, 255, 248, 204, 243, 255, 237, 186, 221, 245, 216, 251, 249, 241 }, 154));
            _0x2536f5e0.GoBack();
            return true;
        }

        return false;
    }

    private string _0x039ba30c()
    {
        if (string.IsNullOrEmpty(_0x55ea55cf) && _0x2536f5e0 != null)
            _0x55ea55cf = _0x2536f5e0.GetUserAgent();
        if (string.IsNullOrEmpty(_0x55ea55cf))
            return string.Empty;
        string _0x4eb9f79d = Regex.Replace(_0x55ea55cf, _0xd43d4e85._0x88ae33d6(new byte[11] { 108, 67, 26, 11, 108, 67, 26, 71, 70, 108, 82 }, 48), string.Empty);
        _0x4eb9f79d = Regex.Replace(_0x4eb9f79d, _0xd43d4e85._0x88ae33d6(new byte[15] { 75, 100, 60, 85, 98, 126, 123, 115, 56, 76, 73, 44, 62, 74, 60 }, 23), string.Empty);
        _0x4eb9f79d = Regex.Replace(_0x4eb9f79d, _0xd43d4e85._0x88ae33d6(new byte[15] { 20, 39, 48, 49, 43, 45, 44, 109, 118, 30, 108, 114, 30, 49, 104 }, 66), string.Empty);
        return Regex.Replace(_0x4eb9f79d, _0xd43d4e85._0x88ae33d6(new byte[6] { 158, 177, 185, 240, 238, 191 }, 194), _0xd43d4e85._0x88ae33d6(new byte[1] { 62 }, 30)).Trim();
    }

    private string _0x7010cba3()
    {
        try
        {
            using (var _0xbe5284ae = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[30] { 202, 198, 196, 135, 220, 199, 192, 221, 208, 154, 205, 135, 217, 197, 200, 208, 204, 219, 135, 252, 199, 192, 221, 208, 249, 197, 200, 208, 204, 219 }, 169)))
            {
                var _0xfde69815 = _0xbe5284ae.GetStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 186, 172, 171, 171, 188, 183, 173, 152, 186, 173, 176, 175, 176, 173, 160 }, 217));
                var _0x6a910a84 = _0xfde69815.Call<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[21] { 147, 145, 128, 181, 132, 132, 152, 157, 151, 149, 128, 157, 155, 154, 183, 155, 154, 128, 145, 140, 128 }, 244));
                using (var _0x781aae35 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[26] { 247, 248, 242, 228, 249, 255, 242, 184, 225, 243, 244, 253, 255, 226, 184, 193, 243, 244, 197, 243, 226, 226, 255, 248, 241, 229 }, 150)))
                {
                    return _0x781aae35.CallStatic<string>(_0xd43d4e85._0x88ae33d6(new byte[19] { 215, 213, 196, 244, 213, 214, 209, 197, 220, 196, 229, 195, 213, 194, 241, 215, 213, 222, 196 }, 176), _0x6a910a84);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private async Task<bool> _0x99303c64(int _0x0f3648cd = 5, int _0x65e14666 = 500)
    {
        List<EntityData> _0x31ec50a5 = new List<EntityData>();
        int _0xc92d78e9 = 0;
        do
        {
            try
            {
                _0x31ec50a5 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xd43d4e85._0x88ae33d6(new byte[8] { 80, 76, 65, 89, 69, 82, 105, 68 }, 32), _0x79ea7149, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xd43d4e85._0x88ae33d6(new byte[9] { 11, 17, 50, 16, 11, 20, 3, 1, 27 }, 98) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[32] { 82, 93, 108, 122, 125, 84, 41, 120, 124, 108, 123, 112, 72, 122, 112, 103, 106, 91, 108, 122, 124, 101, 125, 122, 41, 108, 123, 123, 102, 123, 51, 41 }, 9) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x65e14666);
        }
        while (_0x31ec50a5.Count == 0 && _0xc92d78e9++ < _0x0f3648cd);
        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[32] { 226, 237, 220, 202, 205, 228, 153, 240, 202, 233, 203, 208, 207, 216, 218, 192, 153, 232, 204, 220, 203, 192, 153, 203, 220, 202, 204, 213, 205, 202, 131, 153 }, 185) + JsonConvert.SerializeObject(_0x31ec50a5, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[38] { 169, 166, 151, 129, 134, 175, 210, 187, 129, 162, 128, 155, 132, 147, 145, 139, 210, 163, 135, 151, 128, 139, 210, 128, 151, 129, 135, 158, 134, 129, 210, 145, 157, 135, 156, 134, 200, 210 }, 242) + _0x31ec50a5.Count);
            }
#endif
        }

        bool _0x830b3188 = true;
        if (_0x31ec50a5.Count == 0)
        {
            _0x830b3188 = false;
        }
        else
        {
            _0x830b3188 = _0x31ec50a5.Any(_0xbbbae18b => _0xbbbae18b.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[25] { 181, 186, 139, 157, 154, 179, 206, 167, 157, 190, 156, 135, 152, 143, 141, 151, 206, 156, 139, 157, 155, 130, 154, 212, 206 }, 238) + _0x830b3188);
            }
#endif
        }

        return _0x830b3188;
    }

    private void _0xec80d894(string _0x2e99f07e)
    {
        if (string.IsNullOrEmpty(_0x2e99f07e))
            return;
        if (TryOpenExternalLikeChrome(_0x2e99f07e))
            return;
        OpenUrlExternally(_0x2e99f07e);
    }

    private void _0x59a916dc(UniWebView _0x700f3a9e)
    {
        if (_0x0877a02b)
            return;
        _0x0877a02b = true;
        _0x700f3a9e.AddUrlScheme(_0xd43d4e85._0x88ae33d6(new byte[2] { 195, 208 }, 183));
        _0x700f3a9e.AddUrlScheme(_0xd43d4e85._0x88ae33d6(new byte[6] { 141, 138, 144, 129, 138, 144 }, 228));
        _0x700f3a9e.AddUrlScheme(_0xd43d4e85._0x88ae33d6(new byte[6] { 11, 7, 20, 13, 3, 18 }, 102));
        _0x700f3a9e.OnMessageReceived += (_0x26e4c46d, _0x2dd903da) =>
        {
            if (TryOpenExternalLikeChrome(_0x2dd903da.RawMessage))
            {
                _0x7e1b3274(false);
                return;
            }
        };
        _0x700f3a9e.RegisterShouldHandleRequest(_0x12be80c6 =>
        {
            string _0x6a96b9b6 = _0x12be80c6 != null ? _0x12be80c6.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x6a96b9b6))
                return true;
            WLog(_0xd43d4e85._0x88ae33d6(new byte[21] { 145, 170, 173, 183, 174, 166, 138, 163, 172, 166, 174, 167, 144, 167, 179, 183, 167, 177, 182, 248, 226 }, 194) + _0x6a96b9b6);
            if (TryOpenExternalLikeChrome(_0x6a96b9b6))
            {
                _0x7e1b3274(false);
                return false;
            }

            if (_0x12be80c6 != null && _0x12be80c6.IsMainFrame && IsGoogleAuthFlowUrl(_0x6a96b9b6) && !_0xa259e205)
            {
                WLog(_0xd43d4e85._0x88ae33d6(new byte[62] { 94, 114, 122, 125, 51, 68, 118, 113, 69, 122, 118, 100, 51, 119, 118, 103, 118, 112, 103, 118, 119, 51, 84, 124, 124, 116, 127, 118, 51, 114, 102, 103, 123, 51, 70, 65, 95, 51, 62, 45, 51, 97, 118, 127, 124, 114, 119, 51, 100, 122, 103, 123, 51, 84, 124, 124, 116, 127, 118, 51, 70, 82 }, 19));
                _0xa259e205 = true;
                _0x7e1b3274(true);
                _0x2536f5e0.SetUserAgent(_0x039ba30c());
                _0x2536f5e0.Load(_0x6a96b9b6);
                return false;
            }

            return true;
        });
        _0x700f3a9e.OnLoadingErrorReceived += (_0x26e4c46d, _0x0e632edb, _0x2dd903da, _0xe60e1d6d) =>
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[25] { 146, 190, 182, 177, 255, 136, 186, 189, 137, 182, 186, 168, 255, 154, 173, 173, 176, 173, 229, 255, 188, 176, 187, 186, 226 }, 223) + _0x0e632edb + _0xd43d4e85._0x88ae33d6(new byte[9] { 35, 110, 102, 112, 112, 98, 100, 102, 62 }, 3) + _0x2dd903da);
            string _0xcf8a95fc = GetFailingUrl(_0xe60e1d6d);
            if (string.IsNullOrEmpty(_0xcf8a95fc) || IsAboutBlank(_0xcf8a95fc))
                return;
            _ = _0x528e7f61(_0xd43d4e85._0x88ae33d6(new byte[8] { 94, 95, 118, 76, 91, 91, 70, 91 }, 41));
            WLog(_0xd43d4e85._0x88ae33d6(new byte[45] { 164, 136, 128, 135, 201, 190, 140, 139, 191, 128, 140, 158, 201, 143, 136, 128, 133, 128, 135, 142, 201, 188, 187, 165, 201, 196, 215, 201, 134, 153, 140, 135, 201, 140, 145, 157, 140, 155, 135, 136, 133, 133, 144, 211, 201 }, 233) + _0xcf8a95fc);
            StopCurrentFailedLoad(_0x26e4c46d);
            _0xec80d894(_0xcf8a95fc);
        };
        _0x700f3a9e.OnPageStarted += (_0x26e4c46d, _0x407b4ac2) =>
        {
            _0x4c8796d6 = 0;
            if (_0x2a1596dc && IsAboutBlank(_0x407b4ac2))
            {
                WLog(_0xd43d4e85._0x88ae33d6(new byte[27] { 154, 184, 175, 189, 171, 184, 167, 234, 171, 168, 165, 191, 190, 240, 168, 166, 171, 164, 161, 234, 185, 190, 171, 184, 190, 175, 174 }, 202));
                return;
            }

            WLog(_0xd43d4e85._0x88ae33d6(new byte[29] { 134, 170, 162, 165, 235, 156, 174, 169, 157, 162, 174, 188, 235, 132, 165, 155, 170, 172, 174, 152, 191, 170, 185, 191, 174, 175, 241, 235, 224 }, 203) + (Time.realtimeSinceStartup - _0x8025965a).ToString(_0xd43d4e85._0x88ae33d6(new byte[5] { 173, 179, 173, 173, 173 }, 157)) + _0xd43d4e85._0x88ae33d6(new byte[2] { 229, 182 }, 150) + _0x407b4ac2);
            if (TryOpenExternalLikeChrome(_0x407b4ac2))
            {
                StopCurrentFailedLoad(_0x26e4c46d);
                return;
            }

            if (ContainsIgnoreCase(_0x407b4ac2, _0xd43d4e85._0x88ae33d6(new byte[8] { 34, 47, 47, 39, 104, 39, 54, 54 }, 70)) || ContainsIgnoreCase(_0x407b4ac2, _0xd43d4e85._0x88ae33d6(new byte[15] { 103, 118, 110, 57, 96, 126, 115, 112, 114, 99, 57, 117, 123, 120, 112 }, 23)) || _0x407b4ac2.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[25] { 75, 87, 87, 83, 80, 25, 12, 12, 65, 83, 68, 79, 76, 65, 66, 79, 69, 66, 85, 13, 79, 74, 85, 70, 12 }, 35), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x26e4c46d);
                OpenUrlExternally(_0x407b4ac2);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x407b4ac2))
            {
                _0x7e1b3274(true);
                WLog(_0xd43d4e85._0x88ae33d6(new byte[41] { 6, 46, 46, 38, 45, 36, 97, 32, 52, 53, 41, 97, 39, 45, 46, 54, 97, 37, 36, 53, 36, 34, 53, 36, 37, 97, 108, 127, 97, 42, 36, 36, 49, 97, 55, 40, 50, 40, 35, 45, 36 }, 65));
                return;
            }

            _0x6096de60 = true;
            _0x7e1b3274(true);
            WLog(_0xd43d4e85._0x88ae33d6(new byte[43] { 141, 191, 184, 140, 179, 191, 173, 250, 182, 181, 187, 190, 179, 180, 189, 245, 168, 191, 190, 179, 168, 191, 185, 174, 179, 180, 189, 250, 247, 228, 250, 177, 191, 191, 170, 250, 172, 179, 169, 179, 184, 182, 191 }, 218));
        };
        _0x700f3a9e.OnPageCommitted += (_0x26e4c46d, _0x407b4ac2) =>
        {
            if (_0x2a1596dc && IsAboutBlank(_0x407b4ac2))
                return;
            WLog(_0xd43d4e85._0x88ae33d6(new byte[31] { 34, 14, 6, 1, 79, 56, 10, 13, 57, 6, 10, 24, 79, 32, 1, 63, 14, 8, 10, 44, 0, 2, 2, 6, 27, 27, 10, 11, 85, 79, 68 }, 111) + (Time.realtimeSinceStartup - _0x8025965a).ToString(_0xd43d4e85._0x88ae33d6(new byte[5] { 36, 58, 36, 36, 36 }, 20)) + _0xd43d4e85._0x88ae33d6(new byte[2] { 126, 45 }, 13) + _0x407b4ac2);
            if (!firstLoadShown && IsHttpUrl(_0x407b4ac2))
            {
                firstLoadShown = true;
                _0x6096de60 = false;
                _0x7e1b3274(false);
                _0x67d7040f();
                _0x02bd3132();
                _0x26e4c46d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x528e7f61(_0xd43d4e85._0x88ae33d6(new byte[9] { 74, 75, 98, 82, 77, 88, 83, 88, 89 }, 61));
                WLog(_0xd43d4e85._0x88ae33d6(new byte[39] { 193, 237, 229, 226, 172, 219, 233, 238, 218, 229, 233, 251, 172, 255, 228, 227, 251, 226, 172, 227, 226, 172, 239, 227, 225, 225, 229, 248, 248, 233, 232, 172, 239, 227, 226, 248, 233, 226, 248 }, 140));
            }
        };
        _0x700f3a9e.OnPageProgressChanged += (_0x26e4c46d, _0xc12c642e) =>
        {
            if (_0x2a1596dc)
                return;
            if (!firstLoadShown && _0xc12c642e >= 0.65f)
            {
                firstLoadShown = true;
                _0x6096de60 = false;
                _0x7e1b3274(false);
                _0x67d7040f();
                _0x02bd3132();
                _0x26e4c46d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x528e7f61(_0xd43d4e85._0x88ae33d6(new byte[9] { 105, 104, 65, 113, 110, 123, 112, 123, 122 }, 30));
                WLog(_0xd43d4e85._0x88ae33d6(new byte[32] { 49, 29, 21, 18, 92, 43, 25, 30, 42, 21, 25, 11, 92, 15, 20, 19, 11, 18, 92, 30, 5, 92, 12, 14, 19, 27, 14, 25, 15, 15, 70, 92 }, 124) + _0xc12c642e);
            }
        };
        _0x700f3a9e.OnPageFinished += (_0x26e4c46d, _0x0e632edb, _0x407b4ac2) =>
        {
            if (_0x2a1596dc && IsAboutBlank(_0x407b4ac2))
            {
                _0x2a1596dc = false;
                WLog(_0xd43d4e85._0x88ae33d6(new byte[28] { 24, 58, 45, 63, 41, 58, 37, 104, 41, 42, 39, 61, 60, 114, 42, 36, 41, 38, 35, 104, 46, 33, 38, 33, 59, 32, 45, 44 }, 72));
                return;
            }

            WLog(_0xd43d4e85._0x88ae33d6(new byte[24] { 47, 3, 11, 12, 66, 53, 7, 0, 52, 11, 7, 21, 66, 36, 11, 12, 11, 17, 10, 7, 6, 88, 66, 73 }, 98) + (Time.realtimeSinceStartup - _0x8025965a).ToString(_0xd43d4e85._0x88ae33d6(new byte[5] { 92, 66, 92, 92, 92 }, 108)) + _0xd43d4e85._0x88ae33d6(new byte[7] { 159, 204, 143, 131, 136, 137, 209 }, 236) + _0x0e632edb + _0xd43d4e85._0x88ae33d6(new byte[5] { 189, 232, 239, 241, 160 }, 157) + _0x407b4ac2);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x6096de60 = false;
                _0x7e1b3274(false);
                _0x67d7040f();
                _0x02bd3132();
                _0x26e4c46d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x528e7f61(_0xd43d4e85._0x88ae33d6(new byte[9] { 54, 55, 30, 46, 49, 36, 47, 36, 37 }, 65));
                WLog(_0xd43d4e85._0x88ae33d6(new byte[33] { 166, 138, 130, 133, 203, 188, 142, 137, 189, 130, 142, 156, 203, 141, 130, 153, 152, 159, 203, 135, 132, 138, 143, 203, 136, 132, 134, 155, 135, 142, 159, 142, 143 }, 235));
            }
            else if (_0x6096de60)
            {
                _0x6096de60 = false;
                _0x7e1b3274(false);
                _0x26e4c46d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xd43d4e85._0x88ae33d6(new byte[40] { 116, 88, 80, 87, 25, 110, 92, 91, 111, 80, 92, 78, 25, 106, 81, 86, 78, 25, 88, 95, 77, 92, 75, 25, 85, 86, 88, 93, 80, 87, 94, 25, 95, 80, 87, 80, 74, 81, 92, 93 }, 57));
            }
            else
            {
                _0x7e1b3274(false);
            }

            if (_0xa259e205 && !IsGoogleAuthFlowUrl(_0x407b4ac2) && !IsGoogleAuthFlowUrl(_0x407b4ac2))
            {
                WLog(_0xd43d4e85._0x88ae33d6(new byte[48] { 59, 19, 19, 27, 16, 25, 92, 29, 9, 8, 20, 92, 15, 25, 25, 17, 15, 92, 26, 21, 18, 21, 15, 20, 25, 24, 92, 81, 66, 92, 14, 25, 15, 8, 19, 14, 25, 92, 24, 25, 26, 29, 9, 16, 8, 92, 41, 61 }, 124));
                _0xa259e205 = false;
                _0x2536f5e0.SetUserAgent("");
            }
        };
        _0x700f3a9e.OnShouldClose += _0x26e4c46d =>
        {
            WLog(_0xd43d4e85._0x88ae33d6(new byte[41] { 57, 54, 7, 17, 22, 63, 66, 47, 3, 11, 12, 66, 53, 7, 0, 52, 11, 7, 21, 66, 45, 12, 49, 10, 13, 23, 14, 6, 33, 14, 13, 17, 7, 66, 11, 12, 20, 13, 9, 7, 6 }, 98));
            _0x6c877073();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x700f3a9e.SetPopupPageEventEnabled(true);
        bool _0xdaaba8d1 = false;
        bool _0xd546ba74 = false;
        _0x700f3a9e.OnMultipleWindowOpened += (_0x26e4c46d, _0x849bfc0e) =>
        {
            _0x26e4c46d.ScrollTo(0, 0, false);
            WLog(_0xd43d4e85._0x88ae33d6(new byte[43] { 103, 104, 89, 79, 72, 97, 28, 113, 93, 85, 82, 28, 107, 89, 94, 106, 85, 89, 75, 28, 113, 73, 80, 72, 85, 76, 80, 89, 107, 85, 82, 88, 83, 75, 28, 115, 76, 89, 82, 89, 88, 6, 28 }, 60) + _0x849bfc0e);
            var _0x47a95311 = _0x700f3a9e.GetPopupWindow(_0x849bfc0e);
            if (_0x47a95311 == null)
                return;
            _0x98cfee51.Add(_0x47a95311);
            Debug.Log($"[Test] Popup ID: {_0x47a95311.Id}");
            _0x47a95311.OnPageStarted += (_0x74595db5, _0x407b4ac2) =>
            {
                WLog(_0xd43d4e85._0x88ae33d6(new byte[36] { 225, 238, 223, 201, 206, 231, 154, 234, 213, 202, 207, 202, 154, 237, 223, 216, 236, 211, 223, 205, 154, 245, 212, 234, 219, 221, 223, 233, 206, 219, 200, 206, 223, 222, 128, 154 }, 186) + _0x407b4ac2);
                _0x4c8796d6 = 0;
                if (string.IsNullOrEmpty(_0x407b4ac2) || IsAboutBlank(_0x407b4ac2))
                    return;
                if (IsGoogleAuthFlowUrl(_0x407b4ac2))
                {
                    WLog(_0xd43d4e85._0x88ae33d6(new byte[57] { 165, 170, 155, 141, 138, 163, 222, 174, 145, 142, 139, 142, 222, 185, 145, 145, 153, 146, 155, 222, 159, 139, 138, 150, 222, 152, 146, 145, 137, 222, 211, 192, 222, 141, 142, 145, 145, 152, 222, 185, 145, 145, 153, 146, 155, 222, 189, 150, 140, 145, 147, 155, 222, 171, 191, 196, 222 }, 254) + _0x407b4ac2);
                    _0xdaaba8d1 = false;
                    _0x28650dc1();
                    if (_0x74595db5 != null && _0x74595db5.IsAlive)
                        _0x74595db5.EvaluateJavaScript(_0xb7cc426b());
                    return;
                }

                if (_0x2536f5e0 == null)
                    return;
                if (!_0xdaaba8d1)
                {
                    _0xdaaba8d1 = true;
                    _0x2536f5e0.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xd43d4e85._0x88ae33d6(new byte[39] { 211, 220, 237, 251, 252, 213, 168, 216, 231, 248, 253, 248, 168, 233, 248, 248, 228, 241, 168, 223, 225, 230, 236, 231, 255, 251, 168, 236, 237, 251, 227, 252, 231, 248, 168, 221, 201, 178, 168 }, 136) + _0x407b4ac2);
                }

                if (_0x74595db5 != null && _0x74595db5.IsAlive)
                    _0x74595db5.EvaluateJavaScript(_0x7f1f0570());
                if (!_0xd546ba74 && _0x74595db5 != null && _0x74595db5.IsAlive && IsHttpUrl(_0x407b4ac2))
                {
                    _0xd546ba74 = true;
                }
            };
            _0x47a95311.OnPageFinished += (_0x74595db5, _0xe60e1d6d) =>
            {
                string _0xc069001c = _0xe60e1d6d != null ? _0xe60e1d6d.data : string.Empty;
                WLog(_0xd43d4e85._0x88ae33d6(new byte[35] { 11, 4, 53, 35, 36, 13, 112, 0, 63, 32, 37, 32, 112, 7, 53, 50, 6, 57, 53, 39, 112, 22, 57, 62, 57, 35, 56, 53, 52, 106, 112, 37, 34, 60, 109 }, 80) + _0xc069001c);
                if (_0x74595db5 == null || !_0x74595db5.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xc069001c))
                {
                    _0x28650dc1();
                    _0x74595db5.EvaluateJavaScript(_0xb7cc426b());
                    return;
                }

                if (!_0xdaaba8d1)
                    return;
                _0x74595db5.EvaluateJavaScript(_0x7f1f0570());
            };
        };
        _0x700f3a9e.OnMultipleWindowClosed += (_0x26e4c46d, _0x849bfc0e) =>
        {
            _0x98cfee51.RemoveAll(_0xc8b0cd4b => _0xc8b0cd4b == null || _0xc8b0cd4b.Id == _0x849bfc0e || !_0xc8b0cd4b.IsAlive);
            _0x7e1b3274(false);
            if (_0x98cfee51.Count == 0 && _0x2536f5e0 != null)
            {
                _0xdaaba8d1 = false;
                _0xd546ba74 = false;
                _0x6f999af4();
            }

            WLog(_0xd43d4e85._0x88ae33d6(new byte[43] { 79, 64, 113, 103, 96, 73, 52, 89, 117, 125, 122, 52, 67, 113, 118, 66, 125, 113, 99, 52, 89, 97, 120, 96, 125, 100, 120, 113, 67, 125, 122, 112, 123, 99, 52, 87, 120, 123, 103, 113, 112, 46, 52 }, 20) + _0x849bfc0e);
        };
        _0x700f3a9e.RegisterOnRequestMediaCapturePermission(_0x12be80c6 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private bool _0x2a1596dc = false;
    private string _0x41b8de7c = "";
    private bool _0x6096de60 = false;
    private int _0xf80633fd = -1;
    private Task _0x773a4982(IEnumerator _0xde5fc8f8)
    {
        var _0x6f88b1b2 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x1d6a7ac9(_0xde5fc8f8, _0x6f88b1b2));
        return _0x6f88b1b2.Task;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xd25fd6d0()
    {
        var _0x60976e99 = _0xd43d4e85._0x88ae33d6(new byte[40] { 113, 109, 109, 105, 106, 35, 54, 54, 110, 110, 110, 55, 122, 117, 118, 108, 125, 127, 117, 120, 107, 124, 55, 122, 118, 116, 54, 122, 125, 119, 52, 122, 126, 112, 54, 109, 107, 120, 122, 124 }, 25);
        using (UnityWebRequest _0x1246d6d1 = UnityWebRequest.Get(_0x60976e99))
        {
            await _0x1246d6d1.SendWebRequest();
            string[] _0x3830a744 = _0x1246d6d1.downloadHandler.text.Split('\n');
            foreach (string _0x87b289af in _0x3830a744)
            {
                if (_0x87b289af.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[3] { 177, 168, 229 }, 216)))
                {
                    string _0x9e8dd441 = _0x87b289af.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x9e8dd441} from {_0x60976e99}");
                        }
#endif
                    }

                    return _0x9e8dd441;
                }
            }
        }

        return "";
    }

    private string _0x8a97e078 = "";
    internal void Update()
    {
        if (_0x2536f5e0 == null)
            return;
        if (_0x6e2d591c())
            _0x6c877073();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x02bd3132();
        if (_0xc681090c && _0x33fa86bd != null)
            _0x33fa86bd.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private JObject _0x1fc47f7b(params string[] _0xf79977de)
    {
        JObject _0x4b8ac1dd = new JObject();
        foreach (var _0x3d654f45 in _0xf79977de)
        {
            string _0x5a4b0afa = _0x306c7ba0();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x5a4b0afa} val={_0x3d654f45}");
#endif
            }

            _0x4b8ac1dd.Add(_0x5a4b0afa, _0x3d654f45 == null ? "" : _0x3d654f45);
        }

        return _0x4b8ac1dd;
    }

    private string _0xa8262ce4 = "";
    private string _0x306c7ba0()
    {
        string _0xa9c7f79f = _0xd43d4e85._0x88ae33d6(new byte[62] { 50, 49, 48, 55, 54, 53, 52, 59, 58, 57, 56, 63, 62, 61, 60, 35, 34, 33, 32, 39, 38, 37, 36, 43, 42, 41, 18, 17, 16, 23, 22, 21, 20, 27, 26, 25, 24, 31, 30, 29, 28, 3, 2, 1, 0, 7, 6, 5, 4, 11, 10, 9, 99, 98, 97, 96, 103, 102, 101, 100, 107, 106 }, 83);
        System.Random _0x9a8d60c6 = new System.Random();
        int _0xe29bef65 = _0x9a8d60c6.Next(8, 16);
        return new string (Enumerable.Repeat(_0xa9c7f79f, _0xe29bef65).Select(_0xbe104648 => _0xbe104648[_0x9a8d60c6.Next(_0xbe104648.Length)]).ToArray());
    }

    private static string ReadPushField(Dictionary<string, object> _0x16c6d029, string _0x3f286960)
    {
        if (_0x16c6d029 == null || string.IsNullOrEmpty(_0x3f286960))
            return string.Empty;
        if (_0x16c6d029.TryGetValue(_0xd43d4e85._0x88ae33d6(new byte[16] { 178, 179, 168, 181, 186, 181, 191, 189, 168, 181, 179, 178, 152, 189, 168, 189 }, 220), out var raw))
        {
            try
            {
                var _0x0414b1f4 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x0414b1f4 != null && _0x0414b1f4.TryGetValue(_0x3f286960, out var nestedVal))
                {
                    var _0x85cb73b7 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x85cb73b7))
                        return _0x85cb73b7;
                }
            }
            catch
            {
            }
        }

        if (_0x16c6d029.TryGetValue(_0x3f286960, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    // PART 3
    private string _0x76fa1f91()
    {
        try
        {
            var _0x59aa8050 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[30] { 95, 83, 81, 18, 73, 82, 85, 72, 69, 15, 88, 18, 76, 80, 93, 69, 89, 78, 18, 105, 82, 85, 72, 69, 108, 80, 93, 69, 89, 78 }, 60));
            var _0x7b2d0d4b = _0x59aa8050.GetStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[15] { 61, 43, 44, 44, 59, 48, 42, 31, 61, 42, 55, 40, 55, 42, 39 }, 94));
            var _0xf90d1146 = new AndroidJavaClass(_0xd43d4e85._0x88ae33d6(new byte[57] { 50, 62, 60, 127, 54, 62, 62, 54, 61, 52, 127, 48, 63, 53, 35, 62, 56, 53, 127, 54, 60, 34, 127, 48, 53, 34, 127, 56, 53, 52, 63, 37, 56, 55, 56, 52, 35, 127, 16, 53, 39, 52, 35, 37, 56, 34, 56, 63, 54, 24, 53, 18, 61, 56, 52, 63, 37 }, 81));
            var _0x7b079bf2 = _0xf90d1146.CallStatic<AndroidJavaObject>(_0xd43d4e85._0x88ae33d6(new byte[20] { 254, 252, 237, 216, 253, 239, 252, 235, 237, 240, 234, 240, 247, 254, 208, 253, 208, 247, 255, 246 }, 153), _0x7b2d0d4b);
            var _0xf973e4b1 = _0x7b079bf2.Call<string>(_0xd43d4e85._0x88ae33d6(new byte[5] { 156, 158, 143, 178, 159 }, 251));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xf973e4b1}");
#endif
            }

            return string.IsNullOrEmpty(_0xf973e4b1) ? "" : _0xf973e4b1;
        }
        catch
        {
            return "";
        }
    }

    private string _0x55ea55cf = "";
    private string _0x262943d0;
    private Canvas _0x7be07fdb;
    private float _0x8025965a = 0f;
    private string _0x0d7a3740 = "";
    private bool _0xa259e205 = false;
    private async void Start()
    {
        await _0x5c76f5ee();
    }

    private void _0x28650dc1()
    {
        _0xa259e205 = true;
        if (_0x2536f5e0 != null)
            _0x2536f5e0.SetUserAgent(_0x039ba30c());
    }

    private bool _0x5b544e9e = false;
    private string _0xe47fda61 = "";
    private static bool IsPrivacyItemTrue(Item _0xac00000c)
    {
        if (_0xac00000c.Key != _0xd43d4e85._0x88ae33d6(new byte[9] { 72, 82, 113, 83, 72, 87, 64, 66, 88 }, 33))
            return false;
        try
        {
            var _0xc67c839a = _0xac00000c.Value.GetAs<object>();
            return _0xc67c839a switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0x8c80748a(string _0x33e7939c)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[34] { 118, 121, 72, 94, 89, 112, 13, 107, 72, 89, 78, 69, 13, 104, 85, 89, 95, 76, 13, 125, 88, 94, 69, 13, 105, 76, 89, 76, 13, 127, 76, 90, 23, 13 }, 45) + _0x33e7939c);
#endif
            }
        }

        var _0xe1aea469 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x33e7939c);
        StartCoroutine(_0x1273d0b9(_0xe1aea469));
    }

    // WEB VIEW LOGIC
    public bool _0x547e3c71 { get; set; }

    private bool _0x036b74c0 = false;
    private ApplicationInstallMode _0x83347406 = ApplicationInstallMode.Unknown;
    private string _0x8e2f5e76 = "";
    private void StopCurrentFailedLoad(UniWebView _0xfbfe4360)
    {
        _0x7e1b3274(false);
        if (_0xfbfe4360 == null)
            return;
        _0xfbfe4360.Stop();
        if (_0xfbfe4360.CanGoBack)
            _0xfbfe4360.GoBack();
    }

    private int _0x1ec44320 = 5, _0x8454bab1 = 5, _0x8151c57e = 5, _0x672c773e = 5;
    private UniWebViewPopup _0x738a959b()
    {
        for (int _0x12d430e3 = _0x98cfee51.Count - 1; _0x12d430e3 >= 0; _0x12d430e3--)
        {
            var _0x71ebd432 = _0x98cfee51[_0x12d430e3];
            if (_0x71ebd432 != null && _0x71ebd432.IsAlive)
                return _0x71ebd432;
            _0x98cfee51.RemoveAt(_0x12d430e3);
        }

        return null;
    }

    private bool _0x9b72bcb7 = false;
    private string _0x4799eb52 { get; set; }

    private async Task _0xf844f718()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x9b329469 = _0xd43d4e85._0x88ae33d6(new byte[5] { 45, 42, 39, 56, 46 }, 75);
        _0xe324e77a = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xe47fda61 = DateTime.UtcNow.Ticks.ToString();
        _0xa8262ce4 = "";
        JObject _0x1e2bf4eb = _0x1fc47f7b(_0x5f9325f4, _0x09c7eb41, _0xcce27f9a, _0x656b103a, _0xbc9e907c, _0x9a962730, _0x4799eb52, _0x55ea55cf, _0xa8216b83, _0x41b8de7c, _0x9b329469, _0xa8262ce4, _0xa82f227f, _0x0d7a3740, _0x83347406.ToString(), _0x55ecb974, _0xe47fda61, _0xe324e77a, _0x79ea7149, _0x8a97e078, _0x5825103a, _0x8e2f5e76, _0xb22ef394());
        var _0x2fc294d5 = _0x41b4764b(_0x1e2bf4eb.ToString(), _0x79ea7149);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x1e2bf4eb}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xd43d4e85._0x88ae33d6(new byte[7] { 174, 191, 167, 178, 177, 191, 186 }, 222) + _0x79ea7149, _0x2fc294d5 } });
            await Task.Delay(500);
            string _0x3fcaaabf = "";
            for (int _0x30657e2c = 0; _0x30657e2c < 20; _0x30657e2c++)
            {
                if (await _0x99303c64(1, 1))
                {
                    await _0x528e7f61(_0xd43d4e85._0x88ae33d6(new byte[7] { 131, 141, 142, 130, 138, 132, 133 }, 225));
                    _0x8f9e3859();
                    return;
                }

                _0x3fcaaabf = await _0xe267d8d2(1, 500);
                if (!string.IsNullOrEmpty(_0x3fcaaabf))
                    break;
            }

            _0x6a715b8d(_0x3fcaaabf);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[22] { 32, 47, 62, 40, 47, 38, 91, 60, 30, 21, 30, 9, 26, 23, 91, 30, 9, 9, 20, 9, 65, 91 }, 123) + e.Message);
#endif
            }

            _0x8f9e3859();
        }
    }

    internal bool IsHttpUrl(string _0x8534f1b3)
    {
        if (string.IsNullOrEmpty(_0x8534f1b3))
            return false;
        return _0x8534f1b3.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[7] { 48, 44, 44, 40, 98, 119, 119 }, 88), StringComparison.OrdinalIgnoreCase) || _0x8534f1b3.StartsWith(_0xd43d4e85._0x88ae33d6(new byte[8] { 32, 60, 60, 56, 59, 114, 103, 103 }, 72), StringComparison.OrdinalIgnoreCase);
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x2536f5e0 = null;
    public void _0xa467b12a()
    {
        if (_0x547e3c71)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xd43d4e85._0x88ae33d6(new byte[33] { 28, 19, 34, 52, 51, 26, 103, 19, 46, 42, 34, 53, 103, 40, 50, 51, 103, 106, 121, 103, 42, 40, 49, 34, 103, 51, 40, 103, 52, 36, 34, 41, 34 }, 71));
            }
#endif
        }

        _0x8f9e3859();
    }

    internal Button _0xe6e21c48(string _0xee039ade, Transform _0xc9e0a4cf)
    {
        var _0x3729ec19 = new GameObject(_0xee039ade + _0xd43d4e85._0x88ae33d6(new byte[3] { 136, 190, 164 }, 202), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x55340884 = _0x3729ec19.GetComponent<RectTransform>();
        _0x55340884.SetParent(_0xc9e0a4cf, false);
        var _0x327fbe52 = _0x3729ec19.GetComponent<Image>();
        _0x327fbe52.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xe3633533 = _0x3729ec19.GetComponent<Button>();
        var _0x3793444b = _0xe3633533.colors;
        _0x3793444b.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x3793444b.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xe3633533.colors = _0x3793444b;
        var _0x518e136e = new GameObject(_0xd43d4e85._0x88ae33d6(new byte[4] { 41, 24, 5, 9 }, 125), typeof(RectTransform), typeof(Text));
        var _0xb27166ef = _0x518e136e.GetComponent<RectTransform>();
        _0xb27166ef.SetParent(_0x3729ec19.transform, false);
        _0xb27166ef.anchorMin = Vector2.zero;
        _0xb27166ef.anchorMax = Vector2.one;
        _0xb27166ef.offsetMin = _0xb27166ef.offsetMax = Vector2.zero;
        var _0xc96408fa = _0x518e136e.GetComponent<Text>();
        _0xc96408fa.text = _0xee039ade;
        _0xc96408fa.alignment = TextAnchor.MiddleCenter;
        _0xc96408fa.color = Color.black;
        _0xc96408fa.font = Resources.GetBuiltinResource<Font>(_0xd43d4e85._0x88ae33d6(new byte[9] { 212, 231, 252, 244, 249, 187, 225, 225, 243 }, 149));
        _0xc96408fa.fontSize = 28;
        WLog(_0xd43d4e85._0x88ae33d6(new byte[14] { 120, 73, 94, 90, 79, 94, 121, 78, 79, 79, 84, 85, 27, 28 }, 59) + _0xee039ade + _0xd43d4e85._0x88ae33d6(new byte[1] { 107 }, 76));
        return _0xe3633533;
    }

    private string _0xe324e77a = "";
    private IEnumerator _0x1d6a7ac9(IEnumerator _0xdc2ed399, TaskCompletionSource<bool> _0x83e4e4cb)
    {
        yield return _0xdc2ed399;
        _0x83e4e4cb.SetResult(true);
    }

    private bool _0xe17c572d()
    {
        var _0x2d758b6e = _0x738a959b();
        if (_0x2d758b6e == null)
            return false;
        WLog(_0xd43d4e85._0x88ae33d6(new byte[31] { 193, 232, 251, 237, 254, 232, 251, 236, 169, 235, 232, 234, 226, 169, 164, 183, 169, 249, 230, 249, 252, 249, 169, 206, 230, 203, 232, 234, 226, 179, 169 }, 137) + _0x2d758b6e.Id);
        _0x2d758b6e.GoBack();
        return true;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x41b4764b(string _0x00604392, string _0xa60ba2b4)
    {
        try
        {
            using var _0xdf450fbe = Aes.Create();
            _0xdf450fbe.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xa60ba2b4));
            _0xdf450fbe.GenerateIV();
            using var _0x426d9e16 = new MemoryStream();
            _0x426d9e16.Write(_0xdf450fbe.IV, 0, _0xdf450fbe.IV.Length);
            using (var _0xad894225 = new CryptoStream(_0x426d9e16, _0xdf450fbe.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xc28fedeb = Encoding.UTF8.GetBytes(_0x00604392);
                _0xad894225.Write(_0xc28fedeb, 0, _0xc28fedeb.Length);
                _0xad894225.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x426d9e16.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal Rect lastSafe = Rect.zero;
    private void _0x3394c77b(string _0x53403343)
    {
        _0x358f1e49();
        StartCoroutine(_0xa43f695f(_0x53403343));
    }

    private bool _0x1399d50b = false;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x8f9e3859();
    }
}

internal static class _0xd43d4e85
{
    internal static string _0x88ae33d6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}