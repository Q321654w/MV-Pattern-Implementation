using Features.BehaviourTrees;
using Features.BehaviourTrees.INodes;
using UnityEngine;

namespace Features.Views.Implementations
{
    public class MonoBehaviourView : MonoBehaviour, IView
    {
        private BehaviourTree _viewBehaviour;
        
        public void Initialize(BehaviourTree viewBehaviour)
        {
            _viewBehaviour = viewBehaviour;
        }

        public void GameUpdate()
        {
            var status = _viewBehaviour.Status();
            
            switch (status)
            {
                case Status.Running:
                    _viewBehaviour.Update();
                    break;

                case Status.Idle:
                    _viewBehaviour.Start();
                    break;
                
                default:
                    _viewBehaviour.Reset();
                    break;
            }
        }
        
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}