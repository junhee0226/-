using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;


namespace homework
{

    internal class Program
    {
        enum Lobby
        {
            None = 0,
            Status = 1,
            Inven = 2,
            Store = 3
        }
        public void Main(string[] args)
        {

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다");

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");

            Lobby choice = Lobby.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = Lobby.Status;
                    break;
                case "2":
                    choice = Lobby.Inven;
                    break;
                case "3":
                    choice = Lobby.Store;
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다");
                    break;
            }
        }
        private void Status()
        {
            Console.WriteLine("캐릭터의 정보가 표시됩니다");

            int[] playerStats = new int[7];

            Random rand = new Random();
            for (int i = 0; i < playerStats.Length; i++)
            {
                playerStats[i] = rand.Next(1, 11);
            }

            Console.WriteLine("Lv.01" + playerStats[0]);
            Console.WriteLine("Chad: ");
            Console.WriteLine("공격력: " + playerStats[1]);
            Console.WriteLine("방어력: " + playerStats[2]);
            Console.WriteLine("체력: 100" + playerStats[3]);
            Console.WriteLine("Gold: " + playerStats[4] + "G");
        }

        static void Inven()
        {
            Console.WriteLine("아이템 목록");
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    input = Lobby.Status;
                    break;
                case "0":
                    input = Lobby.None;
                    break;
            }

        }
    }
}
