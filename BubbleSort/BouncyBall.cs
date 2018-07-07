namespace BubbleSort
{
    internal class BouncyBall : IBall
    {
        public decimal Size { get; }
        public BouncyBall(decimal size)
        {
            Size = size;
        }
    }
}