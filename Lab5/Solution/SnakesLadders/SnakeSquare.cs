namespace SnakesLadders
{
    internal class SnakeSquare: SpecialSquare
    {
        public SnakeSquare(int number): base(number) { }
        public override int Modifier => new Random().Next(-25) - 1;
        public override string Message { get { return $"But there's a snake there! You're pushed back {Modifier} squares!"; } }
}
