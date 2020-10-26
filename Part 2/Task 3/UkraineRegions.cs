using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
    public class UkraineRegions
    {
        private string _region;
        private int _population;
        private static readonly List<UkraineRegions> List = new List<UkraineRegions>();

        private UkraineRegions(string region, int population)
        {
            _region = region;
            _population = population;
        }

        public UkraineRegions()
        {
            FillList();
        }

        public void InteractionWithRegions()
        {
            var searchRegion = true;
            do
            {
                Console.Write("Введите номер области чтобы посмотреть её население: ");
                var currentRegion = Console.ReadLine();
                if (currentRegion == null) return;
                switch (currentRegion.ToLower())
                {
                    case "выход":
                        searchRegion = false;
                        break;
                    case "список":
                        ShowAvailableRegions();
                        break;
                    default:
                        RegionInformation(currentRegion);
                        break;
                }
            } while(searchRegion);
        }

        private void FillList()
        {
            List.Add(new UkraineRegions(_region = "Винницкая область", _population = 842_842));
            List.Add(new UkraineRegions(_region = "Волынская область", _population = 845_621));
            List.Add(new UkraineRegions(_region = "Днепропетровская область", _population = 108_842));
            List.Add(new UkraineRegions(_region = "Донецкая область", _population = 132_846));
            List.Add(new UkraineRegions(_region = "Житомирская область", _population = 2_846_548));
            List.Add(new UkraineRegions(_region = "Закарпатская область", _population = 84_542));
            List.Add(new UkraineRegions(_region = "Запорожская область", _population = 5_845_842));
            List.Add(new UkraineRegions(_region = "Ивано-Франковская область", _population = 9_954_001));
            List.Add(new UkraineRegions(_region = "Киевская область", _population = 32_158));
            List.Add(new UkraineRegions(_region = "Кировоградская область", _population = 894_512));
            List.Add(new UkraineRegions(_region = "Луганская область", _population = 108));
            List.Add(new UkraineRegions(_region = "Львовская область", _population = 186_128));
            List.Add(new UkraineRegions(_region = "Николаевская область", _population = 48_842));
            List.Add(new UkraineRegions(_region = "Одесская область", _population = 942_518));
            List.Add(new UkraineRegions(_region = "Полтавская область", _population = 320_184));
            List.Add(new UkraineRegions(_region = "Ровненская область", _population = 75_121));
            List.Add(new UkraineRegions(_region = "Сумская область", _population = 890_020));
            List.Add(new UkraineRegions(_region = "Тернопольская область", _population = 132_021));
            List.Add(new UkraineRegions(_region = "Харьковская область", _population = 731_016));
            List.Add(new UkraineRegions(_region = "Херсонская область", _population = 21_308));
            List.Add(new UkraineRegions(_region = "Хмельницкая область", _population = 123_123));
            List.Add(new UkraineRegions(_region = "Черкасская область", _population = 605_018));
            List.Add(new UkraineRegions(_region = "Черниговская область", _population = 843_015));
            List.Add(new UkraineRegions(_region = "Черновицкая область", _population = 48_010));
        }

        private static void ShowAvailableRegions()
        {
            foreach (var item in List)
            {
                Console.WriteLine($"{item._region}");
            }

            Console.WriteLine();
        }

        private static void RegionInformation(string region)
        {
            var noneOutput = true;
            foreach (var item in List.Where(item =>
                item._region != null &&
                (string.Equals(region, item._region, StringComparison.CurrentCultureIgnoreCase) ||
                 string.Equals(region, item._region.Replace(" область", null),
                     StringComparison.CurrentCultureIgnoreCase))))
            {
                Console.WriteLine($"{item._region} насчитывает в себе {item._population} людей.");
                noneOutput = false;
            }

            if (!noneOutput) return;
            Console.WriteLine("Совпадений не найдено! Убедитесь в правильности ввода!");
            Console.WriteLine("Или введите \"выход\" для выхода и \"список\" для просмотра доступных областей");
        }
    }
}