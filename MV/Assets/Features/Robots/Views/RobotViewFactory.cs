using System.Linq;
using Features.BehaviourTrees;
using Features.BehaviourTrees.INodes;
using Features.BehaviourTrees.INodes.Implementations.Actions;
using Features.BehaviourTrees.INodes.Implementations.AnimatorNodes;
using Features.BehaviourTrees.INodes.Implementations.Composites;
using Features.Robots.Models;
using Features.Views;
using UnityEngine;

namespace Features.Robots.Views
{
    public class RobotViewFactory : MonoBehaviour
    {
        [SerializeField] private RobotConfig[] _configs;
        [SerializeField] private string _sourceId;

        public IView Create(string id, RobotModel robotModel)
        {
            var config = _configs.Single(s => s.Id == id);
            var viewConfig = config.ViewConfig;
            
            var view = Instantiate(viewConfig.View);
            var animator = view.gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = viewConfig.AnimatorController;

            var rootNode = new Sequence(new INode[] 
            {
                new AnimatorIntChangeNode(robotModel.Health(), _sourceId , animator),
                new PlayParticleNode(viewConfig.ParticleSystemPrefab, view.transform)
            });

            var customAnimator = new BehaviourTree(rootNode);
            view.Initialize(customAnimator);

            return view;
        }
    }
}