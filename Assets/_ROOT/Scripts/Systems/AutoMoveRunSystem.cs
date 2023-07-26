using Client.Components;
using Client.Markers;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Client
{
    public sealed class AutoMoveRunSystem : IEcsRunSystem
    {
        private readonly EcsFilterInject<Inc<UnitComponent, ControlledByPlayer>> _filteredEntities = default;
        private readonly EcsCustomInject<SharedData> _sharedData = default;
        
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _filteredEntities.Value)
            {
                
            }
        }
    }
}