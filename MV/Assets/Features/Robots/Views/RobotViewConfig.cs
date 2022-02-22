using Features.Views.Implementations;
using UnityEditor.Animations;
using UnityEngine;

namespace Features.Robots.Views
{
    [CreateAssetMenu(menuName = "RobotConfig/View")]
    public class RobotViewConfig : ScriptableObject
    {
        [SerializeField] private AnimatorController _animatorController;
        [SerializeField] private MonoBehaviourView _view;
        [SerializeField] private ParticleSystem _particleSystemPrefab;

        public AnimatorController AnimatorController => _animatorController;
        public MonoBehaviourView View => _view;
        public ParticleSystem ParticleSystemPrefab => _particleSystemPrefab;
    }
}