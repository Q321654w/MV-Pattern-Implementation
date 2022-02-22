using UnityEngine;

namespace Features.Healthes
{
    public class HealthFactory : MonoBehaviour
    {
        public Health Create(int health)
        {
            return new Health(health);
        }
    }
}