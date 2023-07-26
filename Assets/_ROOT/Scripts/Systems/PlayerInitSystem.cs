using Client.Components;
using Client.Markers;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using UnityEngine;

namespace Client
{
    public sealed class PlayerInitSystem : IEcsInitSystem
    {
        private readonly EcsPoolInject<UnitComponent> _unitPool = default;
        private readonly EcsPoolInject<ControlledByPlayer> _controlledByPlayerPool = default;
        private readonly EcsPoolInject<MovingComponent> _movingComponentPool = default;

        private readonly EcsCustomInject<SharedData> _sharedData = default;

        public void Init(IEcsSystems systems)
        {
            var playerEntity = _unitPool.Value.GetWorld().NewEntity();

            ref var unit = ref _unitPool.Value.Add(playerEntity);
            ref var moving = ref _movingComponentPool.Value.Add(playerEntity);
            _controlledByPlayerPool.Value.Add(playerEntity);


            var player = _sharedData.Value.PlayerConfig;
            var spawnPoint = _sharedData.Value.GameConfig.SpawnPoint.transform.position;
            var playerGo = Object.Instantiate(player.Prefab, spawnPoint, Quaternion.identity);

            unit.Position = playerGo.transform.position;
            unit.Rotation = playerGo.transform.rotation;
            unit.Transform = playerGo.transform;
            moving.Direction = playerGo.transform.forward;
            unit.MoveSpeed = player.MoveSpeed;
        }
    }
}