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
                if (_CurrentSquare.IsSnake)
                {
                    newPosition = newPosition - _CurrentSquare.Modifier;
                    Console.WriteLine($"But there's a snake there! You're pushed back {_CurrentSquare.Modifier} squares!");
                }
                if (_CurrentSquare.IsLadder)
                {
                    newPosition = newPosition + _CurrentSquare.Modifier;
                    Console.WriteLine($"But a ladder takes you {_CurrentSquare.Modifier} squares higher!");
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
            _Squares[10].IsSnake = true;
            _Squares[10].Modifier = 4;
            _Squares[20].IsSnake = true;
            _Squares[20].Modifier = 14;
            _Squares[27].IsSnake = true;
            _Squares[27].Modifier = 8;
            _Squares[39].IsSnake = true;
            _Squares[39].Modifier = 3;
            _Squares[50].IsSnake = true;
            _Squares[50].Modifier = 19;
            _Squares[70].IsSnake = true;
            _Squares[70].Modifier = 14;
            _Squares[77].IsSnake = true;
            _Squares[77].Modifier = 21;
        }

        private void CreateLadders()
        {
            _Squares[0].IsLadder = true;
            _Squares[0].Modifier = 10;
            _Squares[14].IsLadder = true;
            _Squares[14].Modifier = 5;
            _Squares[41].IsLadder = true;
            _Squares[41].Modifier = 12;
            _Squares[46].IsLadder = true;
            _Squares[46].Modifier = 14;
            _Squares[48].IsLadder = true;
            _Squares[48].Modifier = 4;
            _Squares[55].IsLadder = true;
            _Squares[55].Modifier = 20;
            _Squares[63].IsLadder = true;
            _Squares[63].Modifier = 2;
            _Squares[89].IsLadder = true;
            _Squares[89].Modifier = 5;
        }
    }
}
