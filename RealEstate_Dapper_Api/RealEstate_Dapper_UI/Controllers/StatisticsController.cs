﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region Aktif Kategori Sayısı
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44369/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region Aktif Çalışan Sayısı
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44369/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion

            #region Daire Sayısı
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44369/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData3;
            #endregion

            #region Ortalama Kiralık Ürün Fiyatı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44369/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsonData4;
            #endregion

            #region Ortalama Satılık Ürün Fiyatı
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44369/api/Statistics/AverageProductPriceBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData5;
            #endregion

            #region Ortalama Oda Sayısı
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44369/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData6;
            #endregion

            #region Kategori Sayısı
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44369/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData7;
            #endregion

            #region En Fazla Ürünü Olan Kategori Adı
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44369/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData8;
            #endregion

            #region En Fazla Ürünü Olan Şehir Adı
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44369/api/Statistics/CityNameByMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsonData9;
            #endregion

            #region Farklı Şehir Sayısı
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44369/api/Statistics/DifferentCityCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsonData10;
            #endregion

            #region En Fazla Ürünü Olan Çalışan Adı
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44369/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData11;
            #endregion

            #region Son Ürün Fiyatı
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44369/api/Statistics/LastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsonData12;
            #endregion

            #region En Yeni Bina Yılı
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44369/api/Statistics/NewestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData13;
            #endregion

            #region En Eski Bina Yılı
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44369/api/Statistics/OldestBuildingYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData14;
            #endregion

            #region Pasif Kategori Sayısı
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44369/api/Statistics/PassiveCategoryCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData15;
            #endregion

            #region Ürün Sayısı
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:44369/api/Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData16;
            #endregion

            return View();
        }
    }
}
