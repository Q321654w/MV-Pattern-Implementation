using UnityEditor.Animations;
using UnityEngine;

namespace MVQ
{
    [CreateAssetMenu(menuName = "RobotConfig")]
    public class RobotViewConfig : ScriptableObject
    {
        [SerializeField] private AnimatorController _animatorController;
        [SerializeField] private MonoBehaviourView _view;
        [SerializeField] private string _id;

        public AnimatorController AnimatorController => _animatorController;
        public MonoBehaviourView View => _view;
        public string Id => _id;
    }
}