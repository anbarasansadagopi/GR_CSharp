using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using GR.Domain;
using Newtonsoft.Json;

namespace GR
{
    public class Program
    {
        IUpdateItemFactory UpdateItemFactory { get; set; }
        public IList<Item> Items;

        public Program(IUpdateItemFactory strategyFactory)
        {
            UpdateItemFactory = strategyFactory;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            var ioc = new Ioc();
            var updateStrategy = ioc.Resolve<IUpdateItemFactory>();

            var app = new Program(updateStrategy)
            {
                Items = GetDefaultInventory()
            };

            app.UpdateQuality();

            var filename = $"inventory_{DateTime.Now:yyyyddMM-HHmmss}.txt";
            var inventoryOutput = JsonConvert.SerializeObject(app.Items, Formatting.Indented);
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename), inventoryOutput);

            Console.ReadKey();
        }

        public static List<Item> GetDefaultInventory()
        {
            return new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 15,
                            Quality = 20
                        },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                };
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                System.Console.WriteLine(item.Name + " : " + item.Quality.ToString());
                var strategy = UpdateItemFactory.Create(item);
                strategy.UpdateItem(item);
            }
        }
    }
}