namespace SnakesLadders
{
    internal class LadderSquare: SpecialSquare
    {
        public LadderSquare(int number): base(number) { }

        public override int Modifier => new Random().Next(25) + 1;
        public override string Message { get { return $"But a ladder takes you {Modifier} squares higher!"; } }
    }
}
