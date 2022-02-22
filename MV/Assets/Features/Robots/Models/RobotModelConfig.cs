using UnityEngine;

namespace Features.Robots.Models
{
    [CreateAssetMenu(menuName = "RobotConfig/Model")]
    internal class RobotModelConfig : ScriptableObject
    {
        [SerializeField] private int _startHitPoints;

        public int StartHitPoints => _startHitPoints;
    }
}