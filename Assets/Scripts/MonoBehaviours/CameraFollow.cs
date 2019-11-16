using Unity.Mathematics;
using UnityEngine;

[DisallowMultipleComponent]
public class CameraFollow : MonoBehaviour {
    private static FollowCameraSettings _cameraSettings;
    private float3 _camOffset;
    private float _maxDist;
    public Transform objectToFollow;

    private void Start() {
        _cameraSettings = GameManager.GameSettings.camSettigns;
        _camOffset = Quaternion.Euler(_cameraSettings.viewAngle, 0.0f, 0.0f) *
                     new Vector3(0.0f, 0.0f, -_cameraSettings.distanceToPlayer);
        transform.position = new float3 {xyz = objectToFollow.position} + _camOffset;
        transform.rotation = Quaternion.Euler(_cameraSettings.viewAngle, 0.0f, 0.0f);
        _maxDist = _cameraSettings.maxDistFromPlayer * _cameraSettings.maxDistFromPlayer;
    }

    // Update is called once per frame
    private void LateUpdate() {
        var camPos = new float3 {xyz = transform.position};
        var objPos = new float3 {xyz = objectToFollow.position} + _camOffset;
        var offset = objPos.xz - camPos.xz;
        var dist = math.lengthsq(offset);
        if (dist < _maxDist) return;
        transform.position = camPos + new float3 {xz = offset, y = 0} * Time.deltaTime * (dist / _maxDist - 1);
    }
}