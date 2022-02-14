using UnityEngine;

namespace MVQ
{
    [CreateAssetMenu(menuName = "RobotConfig")]
    internal class RobotConfig : ScriptableObject
    {
        [SerializeField] private int _startHitPoints;
        [SerializeField] private string _id;
        [SerializeField] private string _viewId;

        public int StartHitPoints => _startHitPoints;
        public string Id => _id;
        public string ViewId => _viewId;
    }
}