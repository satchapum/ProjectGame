// using UnityEngine;

// public class GameManager : MonoBehaviour
// {
//     public static GameManager Instance { get; private set; }

//     public FloatSO damageSO;
//     public FloatSO healthSO;
//     public FloatSO lvHealthSO;
//     public FloatSO lvDamageSO;
//     public FloatSO coinSO;
//     public FloatSO CurrentCoinUseHpSO;
//     public FloatSO CurrentCoinUseDamageSO;
//     public FloatSO score;


//     private void Awake()
//     {
//         if (Instance == null)
//         {
//             Instance = this;
//             DontDestroyOnLoad(gameObject);
//         }
//         else
//         {
//             Destroy(gameObject);
//         }
//     }
// }
