using Features.Robots.Views;
using UnityEngine;

namespace Features.Robots.Models
{
    [CreateAssetMenu(menuName = "RobotConfig")]
    internal class RobotConfig : ScriptableObject
    {
        [SerializeField] private RobotModelConfig _modelConfig;
        [SerializeField] private RobotViewConfig _viewConfig;
        [SerializeField] private string _id;

        public RobotModelConfig ModelConfig => _modelConfig;
        public RobotViewConfig ViewConfig => _viewConfig;
        public string Id => _id;
    }
}