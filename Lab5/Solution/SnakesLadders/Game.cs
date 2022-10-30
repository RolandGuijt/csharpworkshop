namespace SnakesLadders
{
    internal class Game
    {
        private Square[] _Squares = new Square[100];
        private Square _CurrentSquare;
        public int TurnNo { get; set; } = 0;

        public void Start()
        {
            CreateBoardArray();
            _CurrentSquare = _Squares[0];

            while (true)
            {
                TurnNo++;

                Console.WriteLine($"You're at square {_CurrentSquare.Number}.");
                Console.WriteLine("Press a key to roll the die!");
                Console.ReadKey();

                var dieRoll = new Random().Next(6) + 1;
                var newPosition = _CurrentSquare.Number + dieRoll;

                Console.WriteLine($"You rolled a {dieRoll}. That gets you to square {newPosition}.");

                if (newPosition >= 100)
                    break;

                _CurrentSquare = _Squares[newPosition - 1];
                if (_CurrentSquare is SpecialSquare)
                {
                    var specialSquare = (SpecialSquare)_CurrentSquare;
                    newPosition = newPosition + specialSquare.Modifier;
                    Console.WriteLine(specialSquare.Message);
                }

                _CurrentSquare = _Squares[newPosition - 1];
            }
        }

        private void CreateBoardArray()
        {
            for (int i = 0; i < 100; i++)
            {
                _Squares[i] = new Square(i + 1);
            }
            CreateSnakes();
            CreateLadders();
        }

        private void CreateSnakes()
        {
            var snakeSquares = new int[10, 20, 27, 39, 50, 70, 77];
            foreach (var square in snakeSquares)
                _Squares[square] = new SnakeSquare(_Squares[square].Number);
        }

        private void CreateLadders()
        {
            var ladderSquares = new int[2, 15, 18, 29, 39, 45, 60, 71, 78];
            foreach (var square in ladderSquares)
                _Squares[square] = new LadderSquare(_Squares[square].Number);
        }
    }
}
