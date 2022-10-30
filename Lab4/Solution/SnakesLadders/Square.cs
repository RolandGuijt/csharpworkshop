namespace SnakesLadders
{
    internal class Square
    {
        public Square(int number)
        {
            Number = number;
        }

        public int Number { get; }
        public bool IsSnake { get; set; }
        public bool IsLadder { get; set; }
        public int Modifier { get; set; }
    }
}
