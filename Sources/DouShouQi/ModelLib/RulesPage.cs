/***************************************************************************
* RulesPage.cs
* -------------------------------------------------------------------------
* Project       : DouShouQi Mythology
* Author        : ANGIA Shreya
* Date          : 22/05/2025
* Description   : Creates the different sections of the rules page with
*                 their title, content and image.
* -------------------------------------------------------------------------
***************************************************************************/

using System;

namespace DouShouQiModel
{
    public class RulesPage
    {
        public string? Title { get; set; }  
        public string? Content { get; set; } 
        public string? Image { get; set; } 

        public static RulesPage BoardPresentation => new RulesPage 
        {
            Title = "Board Presentation",
            Content = "The board is a 7x9 grid with 63 squares. Each player has 7 pieces, which are placed on the first three rows of their side of the board. The goal is to capture the opponent's den.",
            Image = "plateau.png" 
        };

        public static RulesPage Pieces => new RulesPage
        { 
            Title = "The goal",
            Content = "The goal of the game is to capture the opponent's den. The first player to do so wins the game. Players can move their pieces according to the rules of the game, and they can capture their opponent's pieces by landing on the same square as them.",
            Image = "plateau.png"
        }; 

        public static RulesPage Movement => new RulesPage
        {
            Title = "Special movements",
            Content = "The pieces can move in different ways depending on their type. For example, the rat can move to any adjacent square, while the elephant can only move diagonally. Players must be strategic in their movements to capture their opponent's pieces and protect their own.",
            Image = "plateau.png"
        };

        public static RulesPage SpecialCells => new RulesPage
        {
            Title = "Special cells",
            Content = "There are special cells on the board that can affect the game. For example, the river cell can only be crossed by certain pieces, and the den cell is where the player's den is located. Players must be aware of these special cells and use them to their advantage.",
            Image = "plateau.png"
        }; 
    }
}