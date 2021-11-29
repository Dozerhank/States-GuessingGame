using System;
using System.Collections.Generic;
using System.Text;

namespace States_CardGame
{
    class Context
    {
    //INITIALIZATION
        //Create State and set to null
        private State _state = null;

    //METHODS
        //Allows the state to be changed during runtime
        public Context(State state)
        {
            this.TransitionTo(state);
        }

        //Change the current state
        public void TransitionTo(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        //Assigns a random card, strings for the buttons, and the correct answer
        public void setanswer()
        {
            this._state.setAnswer();
        }

        //Checks the picked answer against the correct answer
        public void checkanswer(string answer)
        {
            this._state.checkAnswer(answer);
        }

        //Increments level by 1
        public void incrementlevel()
        {
            this._state.incrementLevel();
        }

        //Resets the game to level 1
        public void resetgame()
        {
            this._state.resetGame();
        }
    }
}