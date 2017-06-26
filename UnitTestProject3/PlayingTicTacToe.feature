Feature: Playing Tic Tac Toe
	This is an engine which calculates the best move of the right decision
	
Scenario: Init board
	Given I start a game of tic tac toe
	When I start with an empty board
	Then the board looks like
	 | first | second | third |
	 | - | - | - |
	 | - | - | - |
	 | - | - | - |


@mytag
Scenario: First move
	Given I start a game of tic tac toe
	When I make my first move 
	Then the board looks like
	 | first | second | third |
	 | - | - | - |
	 | - | X | - |
	 | - | - | - |
