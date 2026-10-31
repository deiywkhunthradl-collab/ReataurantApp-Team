
using System;
using System.Collections.Generic;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "ร้านข้าวมันไก่", Type = "อาหารไทย", Rating = 4.5 },
                new Restaurant { Id = 2, Name = "ร้านชาบู", Type = "ชาบู", Rating = 4.6 },
                new Restaurant { Id = 3, Name = "ร้านพิซซ่า", Type = "อาหารอิตาเลียน", Rating = 4.2 },
                new Restaurant { Id = 4, Name = "ร้านซูชิ", Type = "อาหารญี่ปุ่น", Rating = 4.8 },
                new Restaurant { Id = 5, Name = "ร้านเบอร์เกอร์", Type = "อาหารฟาสต์ฟู้ด", Rating = 4.3 }
            };

            Console.WriteLine("===== รายชื่อร้านอาหาร =====");

            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine(
                    $"{r.Id}. {r.Name} | {r.Type} | คะแนน {r.Rating}");
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("จำนวนร้านอาหารทั้งหมด: " + restaurants.Count);

            double totalRating = 0;

            foreach (Restaurant r in restaurants)
            {
                totalRating += r.Rating;
            }

            double averageRating = totalRating / restaurants.Count;

            Console.WriteLine("คะแนนเฉลี่ย: " + averageRating.ToString("0.00"));

            Console.WriteLine("\nขอบคุณที่ใช้งานระบบ RestaurantApp!");
        }
    }
}
