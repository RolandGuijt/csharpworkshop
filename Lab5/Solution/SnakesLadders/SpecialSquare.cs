namespace SnakesLadders
{
    internal class SpecialSquare: Square
    {
        public SpecialSquare(int number): base(number) { }

        public virtual string Message { get; set; }
        public virtual int Modifier { get; } = 0;
    }
}
