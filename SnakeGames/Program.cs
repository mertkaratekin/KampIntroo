using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oyun alanının boyutunu belirleyin
            int width = 20;
            int height = 20;

            // Yılanın başlangıç konumunu belirleyin
            int snakeX = width / 15;
            int snakeY = height / 5;

            // Yılanın ilk hareket yönünü belirleyin
            int directionX = 1;
            int directionY = 0;

            // Yılanın vücut bölümlerini tutacak bir liste oluşturun
            List<int[]> snakeBody = new List<int[]>();

            // Oyunu çalıştırın
            while (true)
            {
                // Ekranı temizleyin
                Console.Clear();

                // Yılanın yeni pozisyonunu hesaplayın
                snakeX += directionX;
                snakeY += directionY;

                // Yılanın pozisyonunu ekrana çizin
                Console.SetCursorPosition(snakeX, snakeY);
                Console.Write("0");

                // Yılanın vücut bölümlerini ekrana çizin
                foreach (int[] bodyPart in snakeBody)
                {
                    Console.SetCursorPosition(bodyPart[0], bodyPart[1]);
                    Console.Write("*");
                }

                // Yılanın vücut bölümlerini güncelleyin
                int[] newBodyPart = { snakeX, snakeY };
                snakeBody.Add(newBodyPart);
                if (snakeBody.Count > 5)
                {
                    snakeBody.RemoveAt(0);
                }

                // Kullanıcının yön tuşlarına basmasını bekleyin
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        directionX = -1;
                        directionY = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        directionX = 1;
                        directionY = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        directionX = 0;
                        directionY = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        directionX = 0;
                        directionY = 1;
                        break;
                }
            }
        }
    }
}
