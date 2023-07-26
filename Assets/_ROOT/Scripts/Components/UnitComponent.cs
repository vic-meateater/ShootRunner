using UnityEngine;

namespace Client.Components
{
    public struct UnitComponent
    {
        public Transform Transform;
        public Vector3 Position;
        public Vector3 Direction;
        public Quaternion Rotation;
        public float MoveSpeed;
        public float RotateSpeed;
    }
}