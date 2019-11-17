using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DangerOutline : MonoBehaviour
{
    [Range(0, 50)]
    public int segments = 50;
    [Range(0, 5)]
    public float xradius = 5;
    [Range(0, 5)]
    public float yradius = 5;
    LineRenderer line;

    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();

        if (line != null)
        {
            line.positionCount = segments + 1;
            line.useWorldSpace = false;
        }

        CreatePoints();

        line.widthMultiplier = 0.10f;
    }

    private void CreatePoints()
    {
        float x;
        float y;
        float z;

        var angle = 20f;

        for (var i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, 0, z));

            angle += (360f / segments);
        }
    }
}
