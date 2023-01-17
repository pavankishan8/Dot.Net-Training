using System;
using System.Collections.Generic;

namespace Assignments
{
    class ItemClass
    {
        int ItemNo { get; set; }
        string ItemName { get; set; }
        int ItemPrice { get; set; }

        static List<ItemClass> Items = new List<ItemClass>();

        public static void AddItems()
        {
            Random BillNo = new Random();
            string Customer = Helper.GetValue("Enter the Bill Holder Name");
            DateTime date = DateTime.Now;

            Items.Add(new ItemClass { ItemNo = 111, ItemName = "Chocos", ItemPrice = 320 });
            Items.Add(new ItemClass { ItemNo = 112, ItemName = "Britania", ItemPrice = 30 });
            Items.Add(new ItemClass { ItemNo = 113, ItemName = "Parle", ItemPrice = 5 });
            Items.Add(new ItemClass { ItemNo = 114, ItemName = "Choclate", ItemPrice = 20 });
            Items.Add(new ItemClass { ItemNo = 115, ItemName = "Pizza", ItemPrice = 450 });
            Items.Add(new ItemClass { ItemNo = 116, ItemName = "Burger", ItemPrice = 155 });
            Items.Add(new ItemClass { ItemNo = 117, ItemName = "Cheese", ItemPrice = 48 });
            Items.Add(new ItemClass { ItemNo = 118, ItemName = "Paneer", ItemPrice = 56 });
            Items.Add(new ItemClass { ItemNo = 119, ItemName = "Pen", ItemPrice = 5 });
            Items.Add(new ItemClass { ItemNo = 120, ItemName = "Water Bottle", ItemPrice = 10 });
            Items.Add(new ItemClass { ItemNo = 121, ItemName = "Wheat", ItemPrice = 80 });
            Items.Add(new ItemClass { ItemNo = 122, ItemName = "Rice", ItemPrice = 66 });
            Items.Add(new ItemClass { ItemNo = 123, ItemName = "Coconut", ItemPrice = 18 });
            Items.Add(new ItemClass { ItemNo = 124, ItemName = "Perfume", ItemPrice = 220 });

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("ItemNo\t ItemName(Item Price)");
            Console.WriteLine("----------------------------------------------------------");


            foreach (var item in Items)
            {
                Console.WriteLine($"{item.ItemNo}\t {item.ItemName}({item.ItemPrice})");
            }

            bool selection = true;
            do
            {
                int choice = Helper.GetNumber("\nPress 1 to Add items Press 2 to Generate Bill");

                if (choice == 1)
                {
                    Console.WriteLine("Enter the ItemNo you want to Add:");
                    int IdChoice = int.Parse(Console.ReadLine());

                    for (int i = 0; i < Items.Count; i++)
                    {
                        var data = Items[i];
                        if (data.ItemNo == IdChoice)
                        {
                            Console.WriteLine("Enter the quantity:");
                            int Qty = Convert.ToInt32(Console.ReadLine());
                            printClass.printfunc(data.ItemNo, data.ItemName, data.ItemPrice, Qty);
                        }
                    }
                }

                else if (choice == 2)
                {
                    printClass.billgeneration(BillNo, Customer, date);
                    Helper.GetValue("Press Enter to clear the value");
                    Console.Clear();
                    //ItemClass.AddItems();
                }
            } while (selection);
        }

        class printClass
        {
            int showNo { get; set; }
            string showName { get; set; }
            int showPrice { get; set; }
            int showQty { get; set; }
            int showTotal { get; set; }

            static int Val;

            static List<printClass> Data = new List<printClass>();

            public static void printfunc(int ItemNo, string ItemName, int ItemPrice, int Qty)
            {
                Data.Add(new printClass { showNo = ItemNo, showName = ItemName, showPrice = ItemPrice, showQty = Qty, showTotal = (Qty * ItemPrice) });
                Val += Qty * ItemPrice;
            }

            public static void billgeneration(Random BillNo, string CName, DateTime dte)
            {
                Console.WriteLine($"Holder Name:{CName}                            date:{dte}");
                Console.WriteLine($"Bill Number: {BillNo.Next(100, 9999)}");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("ItemID \t ItemName \t ItemPrice \t Quantity \t TotalAmount");
                Console.WriteLine("---------------------------------------------------------------------");

                foreach (var item in Data)
                {
                    Console.WriteLine($"{item.showNo}\t {item.showName}\t {item.showPrice}\t {item.showQty}\t {item.showTotal}");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine($"                                              Grand Total: {printClass.Val}");
                }
            }

            class MainClass
            {
                static void Main(string[] args)
                {
                    ItemClass.AddItems();
                }
            }
        }
    }
}
