using UnityEngine;

namespace MVQ
{
    public class MonoBehaviourView : MonoBehaviour, IGameEntityView
    {
        private ViewBehaviour _viewBehaviour;
        
        public void Initialize(ViewBehaviour viewBehaviour)
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