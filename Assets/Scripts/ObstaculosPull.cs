using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculosPull : MonoBehaviour
{
    public int obstaculosPoolSize = 5;
    public float tuboMin = -1f;
    public float tuboMax = 3f;
    public float posicionX = 6f;
    private int currentTubo;

    public GameObject obstaculo;
    private Vector2 objectPoolPosition = new Vector2(-10, 0);

    private GameObject[] tubos;
    private float tiempoDeObjetos;
    public float spawnRate = 3;

    // Start is called before the first frame update
    void Start()
    {
        tubos = new GameObject[obstaculosPoolSize];
        for (int i = 0; i < obstaculosPoolSize; i++)
        {
            tubos[i] = Instantiate(obstaculo, objectPoolPosition, Quaternion.identity);
        }
        tiempoDeObjetos += Time.deltaTime;
        if (GameController.instance.gameOver && tiempoDeObjetos >= spawnRate)
        {
            tiempoDeObjetos = 0;
            float posicionY = Random.Range(tuboMin, tuboMax);
            tubos[currentTubo].transform.position = new Vector2(posicionX, posicionY);
            currentTubo++;
            if (currentTubo >= obstaculosPoolSize)
            {
                currentTubo = 0;
            }
            // Y 3 Y -1
            // X
        }
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDeObjetos += Time.deltaTime;
        if (GameController.instance.gameOver && tiempoDeObjetos >= spawnRate)
        {
            tiempoDeObjetos = 0;
            float posY = Random.Range(tuboMin, tuboMax);
            tubos[currentTubo].transform.position = new Vector3(5, posY);
            currentTubo++;
            if (currentTubo >= obstaculosPoolSize)
            {
                currentTubo = 0;
            }
            // Y 3 Y -1
            // X
        }
    }
}