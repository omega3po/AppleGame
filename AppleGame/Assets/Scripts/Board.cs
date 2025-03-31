using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private Camera myCamera;
    [SerializeField] private Apple appleToSpawn;

    private int numWidthPadding;
    private int numHeightPadding;
    private float widthPadding;
    private float heightPadding;
    private Vector3 spawnTrans;

    void Start()
    {
        float aspect = (float)Screen.width / Screen.height;
        float worldHeight = myCamera.orthographicSize * 2;
        float worldWidth = worldHeight * aspect;
        gameObject.transform.position = new Vector3(-worldWidth / 2, 0);

        spawnTrans = new Vector3(-worldWidth / 2, 0, 0);
        numWidthPadding = width + 1;
        numHeightPadding = height + 1;
        widthPadding = worldWidth / numWidthPadding;
        
        spawnTrans.x += widthPadding;
       

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Instantiate(appleToSpawn, spawnTrans, Quaternion.identity);
                spawnTrans.x += widthPadding;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
