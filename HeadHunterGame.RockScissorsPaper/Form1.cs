using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace HeadHunterGame.RockScissorsPaper
{
    public partial class Form1 : Form
    {
        private readonly ILogger appLogger;
        int rounds = 100;
        int timerPerRouind = 6;
        bool gameOver = false;

        string[] CPUChoicesList = { "rock", "paper", "scissor", "paper", "scissor", "rock"};

        int randomNumber = 0;
        Random rnd = new Random();
        string CPUChoice;
        string playerChoice;
        int PlayerScore;
        int CPUScore;
        public Form1(ILogger<Form1> logger)
        {
            appLogger = logger;
            InitializeComponent();

            countDownTimer.Enabled = true;
            playerChoice = "none";
            txtCountdown.Text = "5";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //new game started
            appLogger.LogInformation("New Game Started....");

            PlayerScore = 0;
            CPUScore = 0;
            rounds = 100;
            txtScore.Text = "Player: " + PlayerScore + " - " + "CPU:" + CPUScore;
            playerChoice = "none";
            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.Empty;
            picCPU.Image = Properties.Resources.Empty;

            gameOver = false;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Rock;
            playerChoice = "rock";
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Scissor;
            playerChoice = "scissor";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Paper;
            playerChoice = "paper";
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRouind -= 1;
            txtCountdown.Text = timerPerRouind.ToString();
            txtRounds.Text = "Rounds: " + rounds;

            if(timerPerRouind < 1)
            {
                countDownTimer.Enabled = false;
                timerPerRouind = 6;
                randomNumber = rnd.Next(0, CPUChoicesList.Length);
                CPUChoice = CPUChoicesList[randomNumber];

                switch(CPUChoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.Rock;
                        break;
                    case "scissor":
                        picCPU.Image = Properties.Resources.Scissor;
                        break;
                    case "paper":
                        picCPU.Image = Properties.Resources.Paper;
                        break;
                }

                if(rounds>1)
                {
                    checkGame();
                }
                else
                {
                    if (PlayerScore > CPUScore)
                    {
                        appLogger.LogInformation($"Player wins this game..");
                        MessageBox.Show("Player wins");
                    }
                    else
                    {
                        appLogger.LogInformation($"CPU wins this game..");
                        MessageBox.Show("CPU wins");
                    }

                    gameOver = true;
                }
            }         
        }

        private void checkGame()
        {     
            if (playerChoice =="rock" && CPUChoice =="paper")
            {
                CPUScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds.ToString()} CPU Wins, Paper Covers Rock..");
                MessageBox.Show("CPU Wins, Paper Covers Rock");
            }
            else if (playerChoice == "scissor" && CPUChoice == "rock")
            {
                CPUScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} CPU Wins, Rock Breaks Scissor..");
                MessageBox.Show("CPU Wins, Rock Breaks Scissor");
            }
            else if (playerChoice == "paper" && CPUChoice == "scissor")
            {
                CPUScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} CPU Wins, Scissor Cuts Paper..");
                MessageBox.Show("CPU Wins, Scissor Cuts Paper");
            }
            else if (playerChoice == "rock" && CPUChoice == "paper")
            {
                PlayerScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} Player Wins, Paper Covers Rock..");
                MessageBox.Show("Player Wins, Paper Covers Rock");
            }
            else if (playerChoice == "scissor" && CPUChoice == "rock")
            {
                PlayerScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} Player Wins, Rock Breaks Scissor..");
                MessageBox.Show("Player Wins, Rock Breaks Scissor");
            }
            else if (playerChoice == "paper" && CPUChoice == "scissor")
            {
                PlayerScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} Player Wins, Scissor Cuts Paper..");
                MessageBox.Show("Player Wins, Scissor Cuts Paper");
            }

            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                PlayerScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} Player Wins, Paper Covers Rock..");
                MessageBox.Show("Player Wins, Paper Covers Rock");
            }
            else if (playerChoice == "scissor" && CPUChoice == "paper")
            {
                PlayerScore += 1;
                rounds -= 1;
                appLogger.LogInformation($"Round : {rounds} Player Wins, Scissor Cuts Paper..");
                MessageBox.Show("Player Wins, Scissor Cuts Paper");
            }
            else if (playerChoice == "none") 
            {
                appLogger.LogInformation($"Round: {rounds} Player selected {playerChoice}");
                MessageBox.Show("Please select the option");
            }
            else
            {
                appLogger.LogInformation($"Round : {rounds} Player Wins, Scissor Cuts Paper..");
                MessageBox.Show("Draw");
            }


            startNextRound();
        }

        private void startNextRound()
        {
            if (gameOver == true)
            {
                appLogger.LogInformation($"All {rounds}  Rounds completed, Game is Over..");
                return;
            }

            appLogger.LogInformation($"Next Round Started");
            txtScore.Text = "Player: " + PlayerScore + " - " + "CPU: " + CPUScore;
            playerChoice = "none";
            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.Empty;
            picCPU.Image = Properties.Resources.Empty;
        }

        private void txtCountdown_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Rock;
            playerChoice = "rock";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //need to correct the logic

            //string[] commanLineArgs = Environment.GetCommandLineArgs();
            //if(commanLineArgs.Length > 1)
            //{
            //    InitialNewGameConfigurationSet();
            //}
            //foreach (string x in commanLineArgs)
            //{
            //    if (x.Contains("Start", StringComparison.InvariantCulture))
            //    {
            //        InitialNewGameConfigurationSet();
            //    }
            //    else if (x.Contains("Stop" , StringComparison.InvariantCulture))
            //    {
            //        appLogger.LogInformation("Game Exit....");
            //        Environment.Exit(0);
            //    }
            //    else
            //    {
            //        InitialNewGameConfigurationSet();
            //    }
            //}
        }

        private void InitialNewGameConfigurationSet()
        {
           
        }

        private void InitialNewRoundConfigurationSet()
        {
            
        }
    }
}
