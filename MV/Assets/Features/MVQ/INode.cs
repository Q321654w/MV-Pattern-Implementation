namespace MVQ
{
    public interface INode
    {
        void Enter();
        bool Active();
        void Execute();
        void Reset();
    }
}