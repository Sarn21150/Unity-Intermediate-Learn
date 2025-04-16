using UnityEngine;
using PrimeTween;

public class Coin : MonoBehaviour, ICollectable
{
    [SerializeField] private int price = 5;
    void PrintCurrentMoney(int currentMoney)
    {
        Debug.Log($"Currunt money is {currentMoney}");
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChange.AddListener(PrintCurrentMoney);

        
    }

    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChange.RemoveListener(PrintCurrentMoney);
    }
    public void Collect()
    {
        
        GameManager.Instance.Money = price;
        Destroy(gameObject);
    }
}
