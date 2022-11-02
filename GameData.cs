using System;

namespace PairsAssignment;

[Serializable]
public class GameData
{
    public bool PlayerOneTurn;
    public string P1Name;
    public int P1Score;
    public string P2Name;
    public int P2Score;
    public int[,] Cards;

    public GameData(int[,] cards, bool playerOneTurn, int p1Score, int p2Score, string p1Name, string p2Name)
    {
        Cards = cards;
        PlayerOneTurn = playerOneTurn;
        P1Score = p1Score;
        P2Score = p2Score;
        P1Name = p1Name;
        P2Name = p2Name;
    }
}