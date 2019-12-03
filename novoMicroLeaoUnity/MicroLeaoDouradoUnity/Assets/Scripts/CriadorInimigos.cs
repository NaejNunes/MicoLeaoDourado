using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorInimigos : MonoBehaviour
{
    public GameObject[] inimigo;
    public static float posX, posY;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(this.inimigo[0], new Vector2(CriadorInimigos.posX + 6f, CriadorInimigos.posY), Quaternion.identity);
        Instantiate(this.inimigo[1], new Vector2(CriadorInimigos.posX + 6f, CriadorInimigos.posY + 3f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;

    }
}
