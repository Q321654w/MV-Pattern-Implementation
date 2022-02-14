namespace MVQ
{
    public class Health : IValue<int>
    {
        private int _hitPoints;

        public Health(int hitPoints)
        {
            _hitPoints = hitPoints;
        }

        public void TakeDamage(int damage)
        {
            _hitPoints -= damage;
        }

        public int HitPoints()
        {
            return _hitPoints;
        }

        public int Value()
        {
            return _hitPoints;
        }
    }
}