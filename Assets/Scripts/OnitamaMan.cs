using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnitamaMan : MonoBehaviour
{
    public GameObject controller;
    public GameObject movePlate;
    public GameObject possibleMoveCard;

    private int xBoard = -1;
    private int yBoard = -1;

    private string player;

    public Sprite redKing, redPiece, blueKing, bluePiece;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");
        SetCoords();

        switch (this.name)
        {
            case "redKing": this.GetComponent<SpriteRenderer>().sprite = redKing; break;
            case "redPiece": this.GetComponent<SpriteRenderer>().sprite = redPiece; break;
            case "blueKing": this.GetComponent<SpriteRenderer>().sprite = blueKing; break;
            case "bluePiece": this.GetComponent<SpriteRenderer>().sprite = bluePiece; break;
        }
    }

    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x += -2;
        y += -2;

        this.transform.position = new Vector3(x, y, -1);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard (int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }

}

