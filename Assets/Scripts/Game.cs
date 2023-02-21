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
    private string[] allCardNames = new string[32] { "aalCard", "affeCard", "bearCard", "dogCard", "dracheCard", "elefantCard", "foxCard", "froschCard", "gansCard",
        "giraffeCard", "gottesCard", "hahnCard", "haseCard", "iguanaCard", "kirinCard", "kobraCard", "krabbeCard", "kranichCard",
        "mouseCard", "ochseCard", "otterCard", "pandaCard", "pferdCard", "phoenixCard", "ratCard", "sableCard", "seaCard", "tanukiCard",
        "tigerCard", "turtleCard", "viperCard", "wildCard" };

    private GameObject[] redPlayerMoveCards = new GameObject[3];
    private GameObject[] bluePlayerMoveCards = new GameObject[3];

    private GameObject activeMoveCard;
    private string currentPlayer;
    private bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        int[] cardsInGame = new int[5] {Random.Range(0, 32) , Random.Range(0, 32), Random.Range(0, 32), Random.Range(0, 32), Random.Range(0, 32) };
        GameObject firstPlayerCard = CreateCard(allCardNames[cardsInGame[0]], "redLeft", cardsInGame[0],"red");
        if (firstPlayerCard.GetComponent<OnitamaMoveCard>().GetColor() == "blue")
        {
            bluePlayerMoveCards[2] = CreateCard(allCardNames[cardsInGame[0]], "blueNext", cardsInGame[0], "blue");
        }
        else
        {
            redPlayerMoveCards[2] = CreateCard(allCardNames[cardsInGame[0]], "redNext", cardsInGame[0], "red");
        }
        Destroy(firstPlayerCard);
        redPlayerMoveCards = new GameObject[3];
        bluePlayerMoveCards = new GameObject[3];
        redPlayerMoveCards[0] = CreateCard(allCardNames[cardsInGame[1]],"redLeft",cardsInGame[1], "red");
        redPlayerMoveCards[1] = CreateCard(allCardNames[cardsInGame[2]], "redRight", cardsInGame[2], "red");
        bluePlayerMoveCards[0] = CreateCard(allCardNames[cardsInGame[3]], "blueLeft", cardsInGame[3], "blue");
        bluePlayerMoveCards[1] = CreateCard(allCardNames[cardsInGame[4]], "blueRight", cardsInGame[4], "blue");

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

    public GameObject CreateCard (string name, string position, int id, string player)
    {
        GameObject obj = Instantiate(possibleMoveCard, new Vector3(0, 0, -1), Quaternion.identity);
        OnitamaMoveCard om = obj.GetComponent<OnitamaMoveCard>();
        om.name = name;
        om.SetPosition(position);
        om.SetId(id);
        om.GameOn();
        om.SetPlayer(player);
        om.Activate();
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
