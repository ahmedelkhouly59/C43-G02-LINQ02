using System;
using System.Collections.Generic;
using LINQ2.Data;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggregate Operators Q1
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category).Select(c => new
            //{
            //    category = c.Key,
            //    total_units = c.Sum(x => x.UnitPrice)
            //});
            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregate Operators Q2
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category).Select(c => new
            //{
            //    category = c.Key,
            //    min_price = c.Min(x => x.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregate Operators Q3
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into g
            //             let min_price = g.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 min_price_category = g.Where(p => p.UnitPrice == min_price)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{ item.Category} --- {string.Join(", ", item.min_price_category.Select(p => p.ProductName))}");
            //}

            #endregion
            #region Aggregate Operators Q4
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category).Select(c => new
            //{
            //    category = c.Key,
            //    max_price = c.Max(x => x.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregate Operators Q5
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into g
            //             let max_price = g.Max(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 max_price_category = g.Where(p => p.UnitPrice == max_price)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} --- {string.Join(", ", item.max_price_category.Select(p => p.ProductName))}");
            //}
            #endregion
            #region Aggregate Operators Q6
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category).Select(c => new
            //{
            //    category = c.Key,
            //    average = c.Average(x => x.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators Q1
            //var result = ListGenerator.ProductsList.Select(p => p.Category).Distinct();
            //foreach (var item in result) { 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators Q2
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName[0]).Union(ListGenerator.CustomersList.Select(c => c.CustomerName[0])).Distinct();
            //foreach (var item in result) { 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators Q3
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName[0]).Intersect(ListGenerator.CustomersList.Select(c => c.CustomerName[0])).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators Q4
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName[0]).Except(ListGenerator.CustomersList.Select(c => c.CustomerName[0])).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators Q5
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName).Concat(ListGenerator.CustomersList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Partitioning Operators Q1
            //var result = ListGenerator.CustomersList.Where(c => c.Region == "WA").Take(3);
            //foreach (var item in result) { 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Partitioning Operators Q2
            //var result = ListGenerator.CustomersList.Where(c => c.Region == "WA").Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Partitioning Operators Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num >= index);
            //foreach (int num in result) { 
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Partitioning Operators Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(num => num % 3 == 0);
            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Partitioning Operators Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where((num, index) => num < index);
            //foreach (int num in result) { 
            //    Console.Write(num);
            //}
            #endregion
            #region Quantifiers Q1
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Where(word => word.Contains("ei"));
            //foreach (var word in result) { 
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Quantifiers Q2
            //var result = ListGenerator.ProductsList.GroupBy(p=>p.Category).Where(c=>c.Any(x=>x.UnitsInStock==0)).Select(g => new
            //{
            //    Category = g.Key,
            //    Products = g
            //});
            //foreach (var item in result) {
            //    Console.WriteLine($"{item.Category}: {string.Join(", ", item.Products.Select(p => p.ProductName))}");
            //}   
            #endregion
            #region Quantifiers Q3
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category).Where(c => c.All(x => x.UnitsInStock != 0)).Select(g => new
            //{
            //    Category = g.Key,
            //    Products = g
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {string.Join(", ", item.Products.Select(p => p.ProductName))}");
            //}
            #endregion
            #region Grouping Operators Q1
            //List<int> numbers = new List <int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"\nNumbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var num in group)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            #endregion
            #region Grouping Operators Q2
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.GroupBy(word => char.ToUpper(word[0]));
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"\nWords starting with '{group.Key}':");
            //    foreach (var word in group.Take(20)) 
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion
            #region Grouping Operators Q3
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.GroupBy(word => String.Concat(word.OrderBy(c => c)));
            //foreach (var word in result) {
            //    Console.WriteLine("....");
            //    foreach (var item in word)
            //    {
            //        Console.WriteLine(item);

            //    }
            //}
            #endregion

        }
    }
}
