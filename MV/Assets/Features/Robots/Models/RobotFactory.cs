using System.Linq;
using UnityEngine;

namespace MVQ
{
    public class RobotFactory : MonoBehaviour
    {
        [SerializeField] private RobotConfig[] _configs;
        [SerializeField] private HealthFactory _healthFactory;
        [SerializeField] private RobotViewFactory _viewFactory;

        public RobotModel Create(string id)
        {
            var config = _configs.Single(s => s.Id == id);
            
            var health = _healthFactory.Create(config.StartHitPoints);
            var robot = new RobotModel(health);
            
            var view = _viewFactory.Create(config.ViewId, robot);
            
            return robot;
        }
    }
}