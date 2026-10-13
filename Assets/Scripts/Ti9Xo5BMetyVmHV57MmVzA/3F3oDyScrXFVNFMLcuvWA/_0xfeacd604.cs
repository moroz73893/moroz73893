using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xfeacd604 : MonoBehaviour
{
    private Vector3 _0x17f1ef02 { get; set; }
    private Vector3 _0x7ebe7e90 { get; set; }

    private void Awake()
    {
        this._0x55b5430d = this.GetComponent<Camera>();
        _0xfed8827c = this;
        this._0xe4c878b4();
    }

    private float _0x40c194de = 1;
    private _0xe0cecabd _0x040ee417 = _0xe0cecabd.Portrait;
    private Vector3 _0xc6b4be40 { get; set; }
    private Vector3 _0x65317194 { get; set; }
    private float _0x6e589156 { get; set; }

    public enum _0xe0cecabd
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xd43234b9 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xb1ae1268;
        Matrix4x4 _0xfded8ee6 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x55b5430d.orthographic)
        {
            float _0xd9dcee61 = this._0x55b5430d.farClipPlane - this._0x55b5430d.nearClipPlane;
            float _0x1eb94e56 = (this._0x55b5430d.farClipPlane + this._0x55b5430d.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x1eb94e56), new Vector3(this._0x55b5430d.orthographicSize * 2 * this._0x55b5430d.aspect, this._0x55b5430d.orthographicSize * 2, _0xd9dcee61));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x55b5430d.fieldOfView, this._0x55b5430d.farClipPlane, this._0x55b5430d.nearClipPlane, this._0x55b5430d.aspect);
        }

        Gizmos.matrix = _0xfded8ee6;
    }

    private void _0xe4c878b4()
    {
        float _0x7ccaf86b, _0x9d7d2e19, _0x44688c3b, _0x20aebf90;
        if (this._0x040ee417 == _0xe0cecabd.Landscape)
            this._0x55b5430d.orthographicSize = 1f / this._0x55b5430d.aspect * this._0x40c194de / 2f;
        else
            this._0x55b5430d.orthographicSize = this._0x40c194de / 2f;
        this._0x6e589156 = 2f * this._0x55b5430d.orthographicSize;
        this._0x53e185c9 = this._0x6e589156 * this._0x55b5430d.aspect;
        float _0x83fab5c3 = this._0x55b5430d.transform.position.x;
        float _0x09a001da = this._0x55b5430d.transform.position.y;
        _0x7ccaf86b = _0x83fab5c3 - this._0x53e185c9 / 2;
        _0x9d7d2e19 = _0x83fab5c3 + this._0x53e185c9 / 2;
        _0x44688c3b = _0x09a001da + this._0x6e589156 / 2;
        _0x20aebf90 = _0x09a001da - this._0x6e589156 / 2;
        this._0x8411c6a8 = new Vector3(_0x7ccaf86b, _0x20aebf90, 0);
        this._0x17f1ef02 = new Vector3(_0x83fab5c3, _0x20aebf90, 0);
        this._0x65317194 = new Vector3(_0x9d7d2e19, _0x20aebf90, 0);
        this._0xc6b4be40 = new Vector3(_0x7ccaf86b, _0x09a001da, 0);
        this._0xd43234b9 = new Vector3(_0x83fab5c3, _0x09a001da, 0);
        this._0x3fabf560 = new Vector3(_0x9d7d2e19, _0x09a001da, 0);
        this._0x7ebe7e90 = new Vector3(_0x7ccaf86b, _0x44688c3b, 0);
        this._0x57ff5f6d = new Vector3(_0x83fab5c3, _0x44688c3b, 0);
        this._0xc9e2688c = new Vector3(_0x9d7d2e19, _0x44688c3b, 0);
    }

    private Vector3 _0x3fabf560 { get; set; }

    private static _0xfeacd604 _0xfed8827c;
    private Vector3 _0xc9e2688c { get; set; }
    private Vector3 _0x57ff5f6d { get; set; }

    private new Camera _0x55b5430d;
    private Color _0xb1ae1268 = Color.white;
    private Vector3 _0x8411c6a8 { get; set; }
    //public bool executeInUpdate;
    private float _0x53e185c9 { get; set; }
}