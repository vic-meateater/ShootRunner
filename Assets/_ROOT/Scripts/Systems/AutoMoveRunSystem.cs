using Client.Components;
using Client.Services;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Client
{
    public sealed class AutoMoveRunSystem : IEcsRunSystem
    {
        private readonly EcsFilterInject<Inc<UnitComponent, MovingComponent>> _filteredEntities = default;
        private readonly EcsCustomInject<TimeService> _time = default;
        
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _filteredEntities.Value)
            {
                ref var unit = ref _filteredEntities.Pools.Inc1.Get(entity);
                ref var moving = ref _filteredEntities.Pools.Inc2.Get(entity);
                
                unit.Transform.transform.Translate(moving.Direction * unit.MoveSpeed * _time.Value.DeltaTime);
            }
        }
    }
}