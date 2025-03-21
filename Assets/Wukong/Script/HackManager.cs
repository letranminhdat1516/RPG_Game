using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Wukong.Script
{
    public class HackManager : MonoBehaviour
    {
        private bool isImmortal = false; // Trạng thái bất tử

        void Update()
        {
            // Kiểm tra nếu GameManager.Instance chưa sẵn sàng thì không chạy hack
            if (GameManager.Instance == null)
            {
                Debug.LogWarning("⚠️ GameManager.Instance chưa được khởi tạo!");
                return;
            }

            // Key Hack Bindings
            if (Input.GetKeyDown(KeyCode.C))
            {
                GameManager.Instance.AddCoin(1000);
                Debug.Log("🚀 Hack: +1000 Coin! Tổng Coin: " + GameManager.Instance.Coin);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                GameManager.Instance.SavedLives += 1000;    
                Debug.Log("❤️ Hack: +1000 Mạng! Tổng Mạng: " + GameManager.Instance.SavedLives);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                GameManager.Instance.AddBullet(1000);
                Debug.Log("🔫 Hack: +1000 Đạn! Tổng Đạn: " + GameManager.Instance.Bullet);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                Debug.Log("🏆 Hack: Hoàn thành màn chơi ngay lập tức!");
                GameManager.Instance.GameFinish();
            }
        }

        public bool IsImmortal()
        {
            return isImmortal;
        }
    }
}
