using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MVQ
{
    public class RobotViewFactory : MonoBehaviour
    {
        [SerializeField] private string _sourceId;
        [SerializeField] private RobotViewConfig[] _configs;

        public IGameEntityView Create(string id, RobotModel robotModel)
        {
            var config = _configs.Single(s => s.Id == id);

            var view = Instantiate(config.View);
            var animator = view.gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = config.AnimatorController;

            var rootNode = new EmptyNode();
            var tree = new Dictionary<INode, IEnumerable<INode>>()
            {
                {
                    rootNode, new List<INode>()
                    {
                        new AnimatorIntChangeNode(robotModel.Health(), _sourceId, animator),
                    }
                },
            };

            var customAnimator = new ViewBehaviour(tree, rootNode);
            view.Initialize(customAnimator);

            return view;
        }
    }
}