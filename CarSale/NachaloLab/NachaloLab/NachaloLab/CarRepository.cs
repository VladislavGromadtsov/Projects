using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NachaloLab
{
    public class CarRepository
    {
        SQLiteAsyncConnection database;

        public CarRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Car>();
        }
        public async Task<List<Car>> GetItemsAsync()
        {
            return await database.Table<Car>().ToListAsync();

        }
        public async Task<Car> GetItemAsync(int id)
        {
            return await database.GetAsync<Car>(id);
        }
        public async Task<int> DeleteItemAsync(Car item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Car item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }

        public async Task<List<Car>> GetCarsList() 
        {
            return await database.Table<Car>().ToListAsync();
        }

        public async Task<ObservableCollection<Car>> GetCarsCollection() 
        {
            List<Car> CarsList = await GetCarsList();
            ObservableCollection<Car> CarsCollection = new ObservableCollection<Car>(CarsList);
            return CarsCollection;
        }

        //public CarRepository(string filename)
        //{
        //    string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
        //    database = new SQLiteConnection(databasePath);
        //    database.CreateTable<Car>();
        //}

        //public IEnumerable<Car> GetItems()
        //{
        //    return (from i in database.Table<Car>() select i).ToList();
        //}

        //public Car GetItem(int id)
        //{
        //    return database.Get<Car>(id);
        //}
        //public int DeleteItem(int id)
        //{
        //    return database.Delete<Car>(id);
        //}
        //public int SaveItem(Car item)
        //{
        //    if (item.Id != 0)
        //    {
        //        database.Update(item);
        //        return item.Id;
        //    }
        //    else
        //    {
        //        return database.Insert(item);
        //    }
        //}
    }
}
