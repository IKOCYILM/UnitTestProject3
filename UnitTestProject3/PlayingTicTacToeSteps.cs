using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace UnitTestProject3
{
    [Binding]
    public class PlayingTicTacToeSteps

    {
        private TicTacToeEngine myEngine = new TicTacToeEngine();

        [Given(@"I start a game of tic tac toe")]
        public void GivenIStartAGameOfTicTacToe()
        {
            myEngine.InitNewGame();
        }
        
        [When(@"I make my first move")]
        public void WhenIMakeMyFirstMove()
        {
            myEngine.takeTurn(); 
        }
        
        [Then(@"the board looks like")]
        public void ThenTheBoardLooksLike(Table table)
        {
            Row[] rows = table.CreateSet<Row>();
            
            Assert.Equals(myEngine.getValueOfField(0), table.);
            Assert.Equals(myEngine.getValueOfField(1), "-");
            Assert.Equals(myEngine.getValueOfField(2), "-");
            Assert.Equals(myEngine.getValueOfField(3), "-");
            Assert.Equals(myEngine.getValueOfField(4), "-");
            Assert.Equals(myEngine.getValueOfField(5), "-");
            Assert.Equals(myEngine.getValueOfField(6), "-");
            Assert.Equals(myEngine.getValueOfField(7), "-");
            Assert.Equals(myEngine.getValueOfField(8), "-");
        }
    }
}
