using UnityEngine;

namespace MVQ
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private int _damage;
        [SerializeField] private RobotFactory _robotFactory;
        [SerializeField] private string _robotId;

        private IGameEntityView _view;
        private Health _health;

        private void Awake()
        {
            var robot = _robotFactory.Create(_robotId);
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