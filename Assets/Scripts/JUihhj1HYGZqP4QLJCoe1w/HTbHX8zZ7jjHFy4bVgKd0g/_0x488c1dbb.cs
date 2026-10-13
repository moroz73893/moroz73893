using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x488c1dbb : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x211a8a94 = this.gameObject.GetComponent<_0x488c1dbb>();
    }

    private static _0x488c1dbb _0x211a8a94;
    private Touch? _0x9325109d()
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
            return null;
        foreach (Touch _0xfe59f0e8 in Touch.activeTouches)
            if (!_0xfe59f0e8.ended)
                if (this._0x650bedff(_0xfe59f0e8))
                    return _0xfe59f0e8;
        return null;
    }

    private bool _0x8a54cbaa(Touch? _0x6465cb43, Bounds _0x35763f6b, TouchPhase _0xfc13e7ea)
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
        {
            _0x6465cb43 = null;
            return false;
        }

        if (_0x6465cb43 != null)
            if (_0x6465cb43.Value.phase == _0xfc13e7ea)
            {
                Vector3 _0xb15754f6 = Camera.main.ScreenToWorldPoint(_0x6465cb43.Value.screenPosition);
                Vector3 _0x5170db06 = new(_0xb15754f6.x, _0xb15754f6.y, _0x35763f6b.center.z);
                if (_0x35763f6b.Contains(_0x5170db06) && this._0x650bedff(_0x6465cb43.Value))
                    return true;
            }

        return false;
    }

    private void _0xec385552(Touch? _0xd4d93079)
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
        {
            _0xd4d93079 = null;
            return;
        }

        int _0x1545f688 = _0xd4d93079.Value.touchId;
        _0xd4d93079 = Touch.activeTouches.FirstOrDefault(_0xfaab2f7e => _0xfaab2f7e.touchId == _0x1545f688);
        if (!this._0x650bedff(_0xd4d93079.Value))
            _0xd4d93079 = null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xa7e51ba7(Bounds _0xbc6d1997)
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
            return null;
        foreach (Touch _0x326470d2 in Touch.activeTouches)
            if (!_0x326470d2.ended)
            {
                Vector3 _0x8524ba63 = Camera.main.ScreenToWorldPoint(_0x326470d2.screenPosition);
                Vector3 _0x776c421d = new(_0x8524ba63.x, _0x8524ba63.y, _0xbc6d1997.center.z);
                if (_0xbc6d1997.Contains(_0x776c421d) && this._0x650bedff(_0x326470d2))
                    return _0x326470d2;
            }

        return null;
    }

    private bool _0x650bedff(Touch? _0x5c3bffed)
    {
        if (!_0x5c3bffed.HasValue)
            return false;
        Vector3 _0x48921500 = Camera.main.ScreenToWorldPoint(_0x5c3bffed.Value.screenPosition);
        Vector3 _0xe42444a8 = _0x48921500;
        _0xe42444a8.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xe42444a8))
            return true;
        _0x5c3bffed = null;
        return false;
    }

    private Touch? _0xb412de63(Bounds _0x7482a82d, TouchPhase _0x5a0deaee)
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
            return null;
        foreach (Touch _0xd66ee6bf in Touch.activeTouches)
            if (_0xd66ee6bf.phase == _0x5a0deaee)
            {
                Vector3 _0xee849531 = Camera.main.ScreenToWorldPoint(_0xd66ee6bf.screenPosition);
                Vector3 _0x01ed766a = new(_0xee849531.x, _0xee849531.y, _0x7482a82d.center.z);
                if (_0x7482a82d.Contains(_0x01ed766a) && this._0x650bedff(_0xd66ee6bf))
                    return _0xd66ee6bf;
            }

        return null;
    }

    private Touch? _0x5eab85f6()
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
            return null;
        foreach (Touch _0x9ececa91 in Touch.activeTouches)
            if (_0x9ececa91.ended)
                if (this._0x650bedff(_0x9ececa91))
                    return _0x9ececa91;
        return null;
    }

    private Touch? _0x582c35ea(Bounds _0x1ee213fb)
    {
        if (!_0xfc90c1ec.Instance._0x445fd59a)
            return null;
        foreach (Touch _0x23f6a7d9 in Touch.activeTouches)
            if (_0x23f6a7d9.ended)
            {
                Vector3 _0x097668f1 = Camera.main.ScreenToWorldPoint(_0x23f6a7d9.screenPosition);
                Vector3 _0xa62fd951 = new(_0x097668f1.x, _0x097668f1.y, _0x1ee213fb.center.z);
                if (_0x1ee213fb.Contains(_0xa62fd951) && this._0x650bedff(_0x23f6a7d9))
                    return _0x23f6a7d9;
            }

        return null;
    }
}