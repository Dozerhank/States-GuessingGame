using System;
using System.Collections.Generic;
using System.Text;

namespace States_CardGame
{
    abstract class State
    {
        protected Context _context;
        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void setAnswer();
        public abstract void checkAnswer(string answer);
        public abstract void incrementLevel();
        public abstract void resetGame();
    }

    //Level 1 State
    class ConcreteStateLevel1 : State
    {
        private Form1 mainForm;
        private static readonly Random rnd = new Random();

        private string[] suits = { "Diamonds", "Spades", "Hearts", "Clubs" };
        private int card;
        private string suit;
        private string answer;

        public ConcreteStateLevel1()
        {

        }

        public ConcreteStateLevel1(Form1 form1)
        {
            mainForm = form1;
            mainForm.level = 1;
            mainForm.updateGUI();
            this.setAnswer();
        }

        public override void setAnswer()
        {
            this.card = rnd.Next(1, 13);
            this.suit = this.suits[rnd.Next(0, 3)];

            string[] choices = { " ", " " };
            int temp = rnd.Next(500) % 2;
            choices[temp] = this.suit;
            this.answer = choices[temp];

            if (temp == 0)
            {
                temp = 1;
            }
            else
            {
                temp = 0;
            }

            choices[temp] = this.suits[rnd.Next(0, 3)];
            while (choices[temp] == this.answer)
            {
                choices[temp] = this.suits[rnd.Next(0, 3)];
            }

            mainForm.updateChoices(choices);
        }

        public override void checkAnswer(string answer)
        {
            mainForm.updateCard(0, card, suit);
            if (this.answer == answer)
            {
                mainForm.updateReveal("Continue");
            }
            else
            {
                mainForm.updateReveal("Try Again");
            }
        }

        public override void incrementLevel()
        {
            mainForm.updateReveal("Check Prediction");
            this._context.TransitionTo(new ConcreteStateLevel2(mainForm, card, suit));
        }

        public override void resetGame()
        {
            mainForm.updateCard(0, 0, " ");
            mainForm.updateCard(1, 0, " ");
            mainForm.updateReveal("Check Prediction");
            this._context.TransitionTo(new ConcreteStateLevel1(mainForm));
        }
    }

    //Level 2 State
    class ConcreteStateLevel2 : State
    {
        private Form1 mainForm;
        private static readonly Random rnd = new Random();

        private string[] suits = { "Diamonds", "Spades", "Hearts", "Clubs" };
        private int card;
        private string suit;
        private int prevCard;
        private string prevSuit;
        private string answer;

        public ConcreteStateLevel2(Form1 form1, int prevCard, string prevSuit)
        {
            mainForm = form1;
            mainForm.level = 2;
            this.prevCard = prevCard;
            this.prevSuit = prevSuit;
            mainForm.updateGUI();
            this.setAnswer();
        }

        public override void setAnswer()
        {
            this.card = rnd.Next(0, 13);
            while (this.card == this.prevCard)
            {
                this.card = rnd.Next(1, 13);
            }

            this.suit = this.suits[rnd.Next(0, 3)];

            string[] choices = { "High", "Low" };
            if (this.card > this.prevCard)
            {
                this.answer = "High";
            }
            else
            {
                this.answer = "Low";
            }

            mainForm.updateChoices(choices);
        }

        public override void checkAnswer(string answer)
        {
            mainForm.updateCard(1, card, suit);
            if (this.answer == answer)
            {
                mainForm.updateReveal("Continue");
            }
            else
            {
                mainForm.updateReveal("Try Again");
            }
        }
        public override void incrementLevel()
        {
            mainForm.updateReveal("Check Prediction");
            mainForm.updateCard(0, card, suit);
            mainForm.updateCard(1, 0, " ");
            this._context.TransitionTo(new ConcreteStateLevel3(mainForm, card, suit));
        }

        public override void resetGame()
        {
            mainForm.updateCard(0, 0, " ");
            mainForm.updateCard(1, 0, " ");
            mainForm.updateReveal("Check Prediction");
            this._context.TransitionTo(new ConcreteStateLevel1(mainForm));
        }
    }

    //Level 3 State
    class ConcreteStateLevel3 : State
    {
        private Form1 mainForm;
        private static readonly Random rnd = new Random();

        private string[] suits = { "Diamonds", "Spades", "Hearts", "Clubs" };
        private int card;
        private string suit;
        private int prevCard;
        private string prevSuit;
        private string answer;

        public ConcreteStateLevel3(Form1 form1, int prevCard, string prevSuit)
        {
            mainForm = form1;
            mainForm.level = 3;
            this.prevCard = prevCard;
            this.prevSuit = prevSuit;
            mainForm.updateGUI();
            this.setAnswer();
        }

        public override void setAnswer()
        {
            this.card = rnd.Next(0, 13);
            while (this.card == this.prevCard)
            {
                this.card = rnd.Next(1, 13);
            }

            this.suit = this.suits[rnd.Next(0, 3)];

            string[] choices = { "Same", "Different" };
            if (this.suit == this.prevSuit)
            {
                this.answer = "Same";
            }
            else
            {
                this.answer = "Different";
            }

            mainForm.updateChoices(choices);
        }

        public override void checkAnswer(string answer)
        {
            mainForm.updateCard(1, card, suit);
            if (this.answer == answer)
            {
                mainForm.updateReveal("YOU WIN! Play Again?");
                mainForm.level = 4;
                mainForm.updateGUI();
            }
            else
            {
                mainForm.updateReveal("Try Again");
            }
        }

        public override void incrementLevel()
        {

        }

        public override void resetGame()
        {
            mainForm.updateCard(0, 0, " ");
            mainForm.updateCard(1, 0, " ");
            mainForm.updateReveal("Check Prediction");
            this._context.TransitionTo(new ConcreteStateLevel1(mainForm));
        }
    }
}