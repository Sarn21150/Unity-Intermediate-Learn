using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    //public delegate int MoneyChange();
    //public static event MoneyChange OnMoneyChange;
    public UnityEvent<int> OnMoneyChange;
    private int _money;
    public int Money
    {
        get => _money;
        //get
        //{
        //  return _money
        //}

        set
        {
            //Money = 123
            //value = 123
            
            _money += value;
            //_money += value
            OnMoneyChange.Invoke(_money);
        }
    }

}
