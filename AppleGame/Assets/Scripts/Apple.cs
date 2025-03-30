using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] private int num;
    Sprite[] sprites = new Sprite[9];
    [SerializeField] private Sprite spriteApple1;
    [SerializeField] private Sprite spriteApple2;
    [SerializeField] private Sprite spriteApple3;
    [SerializeField] private Sprite spriteApple4;
    [SerializeField] private Sprite spriteApple5;
    [SerializeField] private Sprite spriteApple6;
    [SerializeField] private Sprite spriteApple7;
    [SerializeField] private Sprite spriteApple8;
    [SerializeField] private Sprite spriteApple9;

    void Start()
    {
        sprites[0] = spriteApple1;
        sprites[1] = spriteApple2;
        sprites[2] = spriteApple3;
        sprites[3] = spriteApple4;
        sprites[4] = spriteApple5;
        sprites[5] = spriteApple6;
        sprites[6] = spriteApple7;
        sprites[7] = spriteApple8;
        sprites[8] = spriteApple9;

        num = Random.Range(1, 9);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[num -1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
