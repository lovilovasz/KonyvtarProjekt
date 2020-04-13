using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAPI_Patron_Client.Models;

namespace WebAPI_Patron_Client.DataProviders
{
    public static class BookDataProvider
    {
        //server url
        private static string url = "http://localhost:5000/api/library";

        //visszaadja a konyvtarban levo konyvek listajat
        public static IList<Book> GetBooks()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    //deszerializaljuk a rawdata stringet
                    var books = JsonConvert.DeserializeObject<IList<Book>>(rawData);
                    return books;
                }
                else
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void CreateBook(Book book)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(book);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateBook(Book book)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(book);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var result = client.PutAsync(url, content).Result;

                if (!result.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(result.StatusCode.ToString());
                }
            }
        }

        public static void DeleteBook(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(url + "/" + id).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
