using Client.Services;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using UnityEngine;

namespace Client {
    sealed class TimeSystem : IEcsRunSystem
    {
        private readonly EcsCustomInject<TimeService> _timeService;
        public void Run (IEcsSystems systems)
        {
            _timeService.Value.Time = Time.time;
            _timeService.Value.UnscaledTime = Time.unscaledTime;
            _timeService.Value.DeltaTime = Time.deltaTime;
            _timeService.Value.UnscaledDeltaTime = Time.unscaledDeltaTime;
        }
    }
}