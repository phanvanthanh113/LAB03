using UnityEngine;
using UnityEngine.SceneManagement; // Import thư viện quản lý scene

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Kiểm tra nếu Player chạm vào
        {
            SceneManager.LoadScene("New Scene"); // Đổi tên Scene tại đây
        }
    }
}
