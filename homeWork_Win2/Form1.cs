namespace homeWork_Win2
{
    public partial class Form1 : Form
    {
        private int _min;
        private int _max;
        private int _attempts;
        private int _currentGuess;
        private bool _correctGuess;
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeGuess()
        {
            var random = new Random();
            if (_correctGuess) return;

            _currentGuess = random.Next(_min, _max + 1);
            _attempts++;

            HigherLowerMessage($"Is your number {_currentGuess}?");
        }
        private void StartGuessingGame()
        {
            _min = 1;
            _max = 2000;
            _attempts = 0;
            _correctGuess = false;

            MakeGuess();
        }


        private void HigherLowerMessage(string text)
        {
            var msgBox = new Form()
            {
                Width = 400,
                Height = 200,
                Text = "Guess the Number"
            };

            var label = new Label()
            {
                Left = 50,
                Top = 20,
                Text = text,
                Width = 300
            };
            var higherButton = new Button()
            {
                Text = "Higher",
                Left = 50,
                Height = 30,
                Width = 100,
                Top = 70
            };
            var correctButton = new Button()
            {
                Text = "Correct",
                Left = 150,
                Height = 30,
                Width = 100,
                Top = 70
            };
            var lowerButton = new Button()
            {
                Text = "Lower",
                Left = 250,
                Height = 30,
                Width = 100,
                Top = 70
            };

            higherButton.Click += (sender, e) =>
            {
                msgBox.Dispose();
                _min = _currentGuess + 1;
                MakeGuess();
            };
            correctButton.Click += (sender, e) =>
            {
                msgBox.Dispose();
                _correctGuess = true;
                ShowResult();
            };
            lowerButton.Click += (sender, e) =>
            {
                msgBox.Dispose();
                _max = _currentGuess - 1;
                MakeGuess();
            };

            msgBox.Controls.Add(label);
            msgBox.Controls.Add(higherButton);
            msgBox.Controls.Add(correctButton);
            msgBox.Controls.Add(lowerButton);

            msgBox.ShowDialog();
        }

        private void ShowResult()
        {
            MessageBox.Show($"I guessed your number in {_attempts} attempts!", "Correct Guess");

            var playAgain = MessageBox.Show("Do you want to play again?", "Play Again",
                                                     MessageBoxButtons.YesNo);

            if (playAgain == DialogResult.Yes)
            {
                StartGuessingGame();
            }
            else
            {
                this.Close();
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            StartGuessingGame();
        }
    }
}
