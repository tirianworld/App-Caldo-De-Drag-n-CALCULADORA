using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject background;
    public WeightedRandomList<Transform> lootTable;

    public Transform itemHolder;
    public CaldoCoins CC;

    Animator animator;
    private void Awake()
    {
        CC = GameObject.Find("CaldoCoins").GetComponent<CaldoCoins>();
        background = GameObject.Find("Background");
        background.SetActive(false);


    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
           
        
    }
    public void Open()
    {
        
        if (IsOpen())
        {
            animator.SetTrigger("close");
            HideItem();
        }
        else
        {
            if (CC.Caldocoins > 5)
            {
                CC.SpendCoins(5);
                animator.SetTrigger("open");
            }

        }
    }

    bool IsOpen()
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsName("ChestOpen");
    }

    void HideItem()
    {
        itemHolder.localScale = Vector3.zero;
        itemHolder.gameObject.SetActive(false);

        foreach (Transform child in itemHolder)
        {
            Destroy(child.gameObject);
        }
    }

    void ShowItem()
    {
        Transform item = lootTable.GetRandom();
        Instantiate(item, itemHolder);
        itemHolder.gameObject.SetActive(true);
    }
}
