using Unity.Mathematics;
using UnityEngine;

[DisallowMultipleComponent]
public class CameraFollow : MonoBehaviour {
    private static FollowCameraSettings _cameraSettings;
    public Transform objectToFollow;

    private void Start() {
        _cameraSettings = GameManager.GameSettings.camSettigns;
    }

    // Update is called once per frame
    private void LateUpdate() {
        var camPos = new float3 {xyz = transform.position};
        var objPos = new float3 {xyz = objectToFollow.position};
        var offset = objPos.xz - camPos.xz;
        var dist = math.lengthsq(offset);
        if (dist < _cameraSettings.maxDistFromPlayer) return;
        transform.position = camPos + new float3 {xz = offset, y = 0} * Time.deltaTime * dist;
    }
}