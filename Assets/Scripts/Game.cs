using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject onitamaPiece;
    public GameObject possibleMoveCard;

    private GameObject[,] positions = new GameObject[5, 5];
    private GameObject[] redPlayerPieces = new GameObject[5];
    private GameObject[] bluePlayerPieces = new GameObject[5];

    private GameObject[] redPlayerMoveCards = new GameObject[2];
    private GameObject[] bluePlayerMoveCards = new GameObject[2];

    private GameObject activeMoveCard;
    private string currentPlayer;
    private bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        redPlayerPieces = new GameObject[] {
            CreatePiece("redKing",2,4), CreatePiece("redPiece",0,4) ,
            CreatePiece("redPiece",1,4) ,
            CreatePiece("redPiece",3,4) , CreatePiece("redPiece",4,4)
        };

        bluePlayerPieces = new GameObject[] {
            CreatePiece("blueKing",2,0), CreatePiece("bluePiece",0,0) ,
            CreatePiece("bluePiece",1,0) ,
            CreatePiece("bluePiece",3,0) , CreatePiece("bluePiece",4,0)
        };

        for (int i = 0; i < redPlayerPieces.Length; i++ )
        {
            SetPositionPiece(redPlayerPieces[i]);
            SetPositionPiece(bluePlayerPieces[i]);
        }

        
        //Instantiate(possibleMoveCard, new Vector3(0, 0, -1), Quaternion.identity);
    }


    public GameObject CreatePiece(string name, int x, int y)
    {
        GameObject obj = Instantiate(onitamaPiece, new Vector3(0, 0, -2), Quaternion.identity);
        OnitamaMan om = obj.GetComponent<OnitamaMan>();
        om.name = name;
        om.SetXBoard(x);
        om.SetYBoard(y);
        om.Activate();
        return obj;

    }

    public void SetPositionPiece (GameObject obj)
    {
        OnitamaMan om = obj.GetComponent<OnitamaMan>();
        positions[om.GetXBoard(), om.GetYBoard()] = obj;
    }
  
}
