using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
    internal class Program
    {
        struct str
        {
            public string Region;
            public int Population;
        }

        public static void Main(string[] args)
        {
            var list = new List<str>();
            FillList(ref list);

            var searchRegion = true;

            do
            {
                Console.Write("Введите номер области чтобы посмотреть её население: ");
                var tmp = Console.ReadLine();

                if (tmp != null)
                {
                    switch (tmp.ToLower())
                    {
                        case "выход":
                            searchRegion = false;
                            break;
                        case "список":
                            ShowAvailableRegions(ref list);
                            break;
                        default:
                            RegionInformation(tmp, ref list);
                            break;
                    }
                }
            } while (searchRegion);
        }

        private static void FillList(ref List<str> list)
        {
            var index = 1;
            list.Add(new str() {Region = "Винницкая область", Population = 842_842});
            list.Add(new str() {Region = "Волынская область", Population = 845_621});
            list.Add(new str() {Region = "Днепропетровская область", Population = 108_842});
            list.Add(new str() {Region = "Донецкая область", Population = 132_846});
            list.Add(new str() {Region = "Житомирская область", Population = 2_846_548});
            list.Add(new str() {Region = "Закарпатская область", Population = 84_542});
            list.Add(new str() {Region = "Запорожская область", Population = 5_845_842});
            list.Add(new str() {Region = "Ивано-Франковская область", Population = 9_954_001});
            list.Add(new str() {Region = "Киевская область", Population = 32_158});
            list.Add(new str() {Region = "Кировоградская область", Population = 894_512});
            list.Add(new str() {Region = "Луганская область", Population = 108});
            list.Add(new str() {Region = "Львовская область", Population = 186_128});
            list.Add(new str() {Region = "Николаевская область", Population = 48_842});
            list.Add(new str() {Region = "Одесская область", Population = 942_518});
            list.Add(new str() {Region = "Полтавская область", Population = 320_184});
            list.Add(new str() {Region = "Ровненская область", Population = 75_121});
            list.Add(new str() {Region = "Сумская область", Population = 890_020});
            list.Add(new str() {Region = "Тернопольская область", Population = 132_021});
            list.Add(new str() {Region = "Харьковская область", Population = 731_016});
            list.Add(new str() {Region = "Херсонская область", Population = 21_308});
            list.Add(new str() {Region = "Хмельницкая область", Population = 123_123});
            list.Add(new str() {Region = "Черкасская область", Population = 605_018});
            list.Add(new str() {Region = "Черниговская область", Population = 843_015});
            list.Add(new str() {Region = "Черновицкая область", Population = 48_010});
        }

        private static void ShowAvailableRegions(ref List<str> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Region}");
            }

            Console.WriteLine();
        }

        private static void RegionInformation(string region, ref List<str> list)
        {
            var noneOutput = true;
            foreach (var item in list.Where(item =>
                string.Equals(region, item.Region, StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(region, item.Region.Replace(" область", null),
                    StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine($"{item.Region} насчитывает в себе {item.Population} людей.");
                noneOutput = false;
            }

            if (!noneOutput) return;
            Console.WriteLine("Совпадений не найдено! Убедитесь в правильности ввода!");
            Console.WriteLine("Или введите \"выход\" для выхода и \"список\" для просмотра доступных областей");
        }
    }
}