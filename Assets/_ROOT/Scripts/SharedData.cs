using Client.Scriptable_Objects;
using UnityEngine;

namespace Client
{
    public class SharedData:MonoBehaviour
    {
        [field: SerializeField] public PlayerConfig PlayerConfig { get; private set; }
        [field: SerializeField] public GameConfig GameConfig { get; private set; }
    }
}