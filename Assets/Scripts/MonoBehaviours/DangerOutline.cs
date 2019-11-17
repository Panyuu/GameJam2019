using UnityEngine;

[RequireComponent(typeof(LineRenderer), typeof(SphereCollider))]
public class DangerOutline : MonoBehaviour
{
    [Range(0, 50)]
    public int segments = 50;

    private LineRenderer _line;

    private void Start()
    {
        _line = gameObject.GetComponent<LineRenderer>();

        if (_line != null)
        {
            _line.positionCount = segments + 1;
            _line.useWorldSpace = false;
        }

        var radius = GetComponent<SphereCollider>().radius;

        CreatePoints(radius);

        _line.widthMultiplier = 0.10f;
    }

    private void CreatePoints(float radius)
    {
        var angle = 20f;

        for (var i = 0; i < segments + 1; i++)
        {
            var x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            var z = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

            _line.SetPosition(i, new Vector3(x, 0, z));

            angle += 360f / segments;
        }
    }
}
