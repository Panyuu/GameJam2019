using System;
using UnityEngine.Serialization;

[Serializable]
public struct FollowCameraSettings {
    public float maxDistFromPlayer;
    public float followSpeed;
    public float viewAngle;
    public float distanceToPlayer;
}