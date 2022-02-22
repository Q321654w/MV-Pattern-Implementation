using System.Linq;
using Features.Healthes;
using UnityEngine;

namespace Features.Robots.Models
{
    public class RobotFactory : MonoBehaviour
    {
        [SerializeField] private RobotConfig[] _configs;
        [SerializeField] private HealthFactory _healthFactory;

        public RobotModel Create(string id)
        {
            var config = _configs.Single(s => s.Id == id);
            var modelConfig = config.ModelConfig;
            
            var health = _healthFactory.Create(modelConfig.StartHitPoints);
            var robot = new RobotModel(health);

            return robot;
        }
    }
}