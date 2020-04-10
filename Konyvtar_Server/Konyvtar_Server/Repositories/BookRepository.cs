using Konyvtar_Server.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Konyvtar_Server.Repositories
{
    public static class BookRepository
    {

        //kiolvasom a .json fileombol az adataimat
        public static IList<Book> GetBooks()
        {
            var appDataPath = GetAppDataPath();
            if (File.Exists(appDataPath))
            {
                var rawContent = File.ReadAllText(appDataPath);
                var books = JsonSerializer.Deserialize<IList<Book>>(rawContent);
                return books;
            }
            else
            {
                return new List<Book>();
            }
        }

        // beleírom a .json fileomba a tárolni kívánt adataimat
        public static void StorePeople(IList<Book> books)
        {
            var appDataPath = GetAppDataPath();
            var rawContent = JsonSerializer.Serialize(books);
            File.WriteAllText(appDataPath, rawContent);
        }


        //Ezzel az utolsó két metódussal megkapom az AppData folderemben lévő könyvtárat amiben benne van a .json fileom
        public static string GetAppDataPath()
        {
            var fulllocalAppFolder = GetLocalFolder();
            var appDataPath = Path.Combine(fulllocalAppFolder, "Books.json");
            return appDataPath;
        }

        public static string GetLocalFolder()
        {
            var localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var fulllocalAppFolder = Path.Combine(localAppDataFolder, "Konyvtar_Server");
            if (!Directory.Exists(fulllocalAppFolder))
            {
                Directory.CreateDirectory(fulllocalAppFolder);
            }
            return fulllocalAppFolder;
        }
    }
}
