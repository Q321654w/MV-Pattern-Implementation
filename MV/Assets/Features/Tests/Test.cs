using Features.Healthes;
using Features.Robots.Models;
using Features.Robots.Views;
using Features.Views;
using UnityEngine;

namespace Features.Tests
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private int _damage;
        [SerializeField] private RobotFactory _modelFactory;
        [SerializeField] private RobotViewFactory _viewFactory;
        [SerializeField] private string _robotId;

        private Health _health;
        private IView _view;

        private void Awake()
        {
            var robot = _modelFactory.Create(_robotId);
            _view = _viewFactory.Create(_robotId, robot);
            
            _health = robot.Health();
        }

        private void Update()
        {
            _view.GameUpdate();
        }

        [ContextMenu("Damage")]
        public void Damage()
        {
            _health.TakeDamage(_damage);
        }
    }
}