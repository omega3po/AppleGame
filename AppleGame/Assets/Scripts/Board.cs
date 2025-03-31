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
    
        numWidthPadding = width + 1;
        numHeightPadding = height + 1;
        widthPadding = worldWidth / numWidthPadding;
        heightPadding = worldHeight / numHeightPadding;
        spawnTrans = new Vector3(-worldWidth / 2 + widthPadding, -worldHeight / 2 + heightPadding, 0);

        //spawnTrans.x += widthPadding;
        //spawnTrans.y += heightPadding;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Instantiate(appleToSpawn, spawnTrans, Quaternion.identity);
                spawnTrans.x += widthPadding;
            }
            spawnTrans.x = -worldWidth / 2 + widthPadding;
            spawnTrans.y += heightPadding;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
