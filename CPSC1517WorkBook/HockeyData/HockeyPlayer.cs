namespace Hockey.Data
{
    /// <summary>
    /// An instance of this class will hold data about a hockey
    /// player.
    /// </summary>
    public class HockeyPlayer
    {
        // Data fields
        private string _birthPlace;
        private string _firstName;
        private string _lastName;
        private int _heightInInches;
        private int _weightInPounds;
        private DateOnly _dateOfBirth;

        // Properties
        public string BirthPlace
        {
            get
            {
                return _birthPlace;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }

                _birthPlace = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }

                _heightInInches = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                if (value < currentDate)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("The date should not be in the future");
                }
            }
        }

        public Position Position { 
            get; set; 
        }

        public Shot Shot { get; set; }

        public weightInpounds _weightinPounds
        {
            get;
            set;
        }

        // Default constructor aka name plus emptery parameter list
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _weightInPounds = 0;
            _heightInInches = 0;
            Position = Position.Center;
            Shot = Shot.Left;
        }

        // Greedy constructor
        public HockeyPlayer(string firstName, string lastName, string birthPlace,
            DateOnly birthDate, int weightInPounds, int heightInInches,
            Position position = Position.Center,
            Shot shot = Shot.Left)
        {
            // TODO: implement and use the remaining properties
            BirthPlace = birthPlace;
            HeightInInches = heightInInches;
            DateOfBirth = birthDate;
            Shot = shot;
            Position = position;
        }

        // HockeyPlayer player = new HockeyPlayer("jane", "doe", "edmonton",new DateOnly(), 1, 2);
    }
}