using TMPro;
using UnityEngine;

public class MiniSaveManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;

    // 保存数据
    public void SaveData()
    {
        PlayerPrefs.SetString("input", inputField.text);
    }

    // 加载数据
    public void LoadData()
    {
        inputField.text = PlayerPrefs.GetString("input");
    }

    // 删除数据
    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("input");
        //PlayerPrefs.DeleteAll(); 
    }
}
