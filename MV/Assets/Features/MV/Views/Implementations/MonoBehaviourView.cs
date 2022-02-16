using BehaviourTrees;
using UnityEngine;

namespace MVQ
{
    public class MonoBehaviourView : MonoBehaviour, IView
    {
        private BehaviourTree _viewBehaviour;
        
        public void Initialize(BehaviourTree viewBehaviour)
        {
            _viewBehaviour = viewBehaviour;
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void GameUpdate()
        {
            _viewBehaviour.Update();
        }
    }
}