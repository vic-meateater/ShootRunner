using UnityEngine;

namespace Client.Scriptable_Objects
{
    [CreateAssetMenu(fileName = nameof(GameConfig), menuName = "ShootRunner/Config/" + nameof(GameConfig), 
        order = 100)]
    public class GameConfig: ScriptableObject
    {
        [field: SerializeField] public GameObject SpawnPoint { get; private set; }
    }
}