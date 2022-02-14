using UnityEngine;

namespace MVQ
{
    public class HealthFactory : MonoBehaviour
    {
        public Health Create(int health)
        {
            return new Health(health);
        }
    }
}