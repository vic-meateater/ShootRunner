using UnityEngine;

namespace Client.Scriptable_Objects
{
    [CreateAssetMenu(fileName = nameof(PlayerConfig), menuName = "ShootRunner/Config/" + nameof(PlayerConfig), 
        order = 100)]
    public class PlayerConfig: ScriptableObject
    {
        [field: SerializeField] public GameObject Prefab { get; private set; }
    }
}