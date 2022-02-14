using System.Collections.Generic;

namespace MVQ
{
    public class ViewBehaviour
    {
        private readonly IDictionary<INode, IEnumerable<INode>> _animationTree;
        private readonly INode _rootNode;

        private INode _currentNode;

        public ViewBehaviour(IDictionary<INode, IEnumerable<INode>> animationTree,
            INode rootNode)
        {
            _animationTree = animationTree;
            _rootNode = rootNode;
           
            _currentNode = rootNode;
        }

        public void Update()
        {
            if (_currentNode.Active())
            {
                _currentNode.Execute();
                return;
            }

            if (!_animationTree.ContainsKey(_currentNode))
                _currentNode = _rootNode;

            SelectNextNode();
        }

        private void SelectNextNode()
        {
            var transitionNodes = _animationTree[_currentNode];

            foreach (var node in transitionNodes)
            {
                if (!node.Active())
                    continue;

                ChangeNode(node);
                
                return;
            }
        }

        private void ChangeNode(INode node)
        {
            _currentNode.Reset();
            _currentNode = node;
            _currentNode.Enter();
        }
    }
}