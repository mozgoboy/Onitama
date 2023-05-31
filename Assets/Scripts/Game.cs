using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;



public class Game : MonoBehaviour
{
    public GameObject onitamaPiece;
    public GameObject possibleMoveCard;
    private DataMaps dM;

    private GameObject[,] positions = new GameObject[5, 5];
    private GameObject[] redPlayerPieces = new GameObject[5];
    private GameObject[] bluePlayerPieces = new GameObject[5];

    private Dictionary <string, GameObject> redPlayerMoveCards = new Dictionary<string, GameObject>() ;
    private Dictionary<string, GameObject> bluePlayerMoveCards = new Dictionary<string, GameObject>() ;

    private GameObject activeMoveCard;
    private string currentPlayer;
    private bool gameOver;



    // Start is called before the first frame update
    void Start()
    {
        DataMaps dM = this.GetComponent<DataMaps>();
        dM.CreateSprites();
        dM.CreateColors();
        dM.CreateCardSchemes();
        var arr = Enumerable.Range(0, dM.getNumberOfCards()).ToArray();
        var rnd = new System.Random();
        var randomized = arr.OrderBy(item => rnd.Next()).ToArray();
        var cardsInGame = new ArraySegment<int>(randomized, 0, 5).ToArray();
        if (dM.getOnitamaMoveCardColor(dM.getCardNameById(cardsInGame[0])) == "blue")
        {
            bluePlayerMoveCards["blueNext"] = CreateCard("blueNext", cardsInGame[0], "blue", dM);
        }
        else
        {
            redPlayerMoveCards["redNext"] = CreateCard("redNext", cardsInGame[0], "red", dM);
        }
        redPlayerMoveCards["redLeft"] = CreateCard("redLeft",cardsInGame[1], "red", dM);
        redPlayerMoveCards["redRight"] = CreateCard("redRight", cardsInGame[2], "red", dM);
        bluePlayerMoveCards["blueLeft"] = CreateCard("blueLeft", cardsInGame[3], "blue", dM);
        bluePlayerMoveCards["blueRight"] = CreateCard("blueRight", cardsInGame[4], "blue", dM);

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

    public GameObject CreateCard  (string position, int id, string player, DataMaps dM)
    {
        GameObject obj = Instantiate(possibleMoveCard, new Vector3(0, 0, -1), Quaternion.identity);
        OnitamaMoveCard om = obj.GetComponent<OnitamaMoveCard>();
        om.name = dM.getCardNameById(id);
        om.SetPosition(position);
        om.SetId(id);
        om.GameOn();
        om.SetPlayer(player);
        om.Activate(dM);
        return obj;
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



