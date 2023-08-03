namespace Lab4_5
{
    internal interface IMovable : IDrivable, ISteerable
    {
        void Accelerate();
        void Brake();
    }
}
