using HotelFinder.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAllHotels();
        Task<Hotel> GetHotelById(int id);
        Task<Hotel> GetHotelByName(string name);
        Task<Hotel> CreateHotel(Hotel hotel);
        Task<Hotel> UpdateHotel(Hotel hotel);
        Task DeleteHotel(int id);

        // Abstract classlara genel olarak interfaceler yazılır.
        // Abstract class ortak özellikleri olan nesneleri bir çatı altında toplamak için kullanılır.
        // Abstract sınıfta emtot ve değişkenler tanımlanabilir.
        // new ile oluşturulamaz
    }
}
