using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnGhost : MonoBehaviour
{

    public CheckRotation rot;

    public float check = 120;

    public GameObject Scott;

    public bool ghostSpawn;

    int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GhostSpawn();
        Spawn();
    }

    private void GhostSpawn()
    {
        if (rot.YRotation == check)
        {
            ghostSpawn = true;
            //print("lol");
        }
    }

    private void Spawn()
    {
        if(ghostSpawn == true)
        {
            Instantiate(Scott, new Vector3(0, 0, 2), Quaternion.identity);
            SceneManager.LoadScene(1);

        }
    }
}
