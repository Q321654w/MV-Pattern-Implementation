using Features.Healthes;

namespace Features.Robots.Models
{
    public class RobotModel
    {
        private readonly Health _health;

        public RobotModel(Health health)
        {
            _health = health;
        }

        public Health Health()
        {
            return _health;
        }
    }
}