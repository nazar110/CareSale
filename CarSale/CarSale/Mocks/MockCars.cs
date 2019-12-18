using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSale.Models;

namespace CarSale.Mocks
{
    public class MockCars
    {
        public List<CarDTO> AllCars = new List<CarDTO>()
        {
            new CarDTO() {
                ImageUrl = "https://i.wheelsage.org/pictures/citroen/jumpy/autowp.ru_citroen_jumpy_6.jpg",
                Brandname = "Citroen",
                Modelname = "Jumpy",
                Color = "Silver",
                Features = "Good minivan for travelling",
                CountryOfOrigin = "France",
                Price = 10000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new CarDTO() {
                ImageUrl = "https://www.kia.ru/upload/iblock/be3/be394654349dfe8ade80903436244872.png",
                Brandname = "Kia",
                Modelname = "Sportage",
                Color = "Blue",
                Features = "Compact crossover",
                CountryOfOrigin = "Southern Korea",
                Price = 8000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new CarDTO() {
                ImageUrl = "https://avtoprokat.kiev.ua/wp-content/uploads/2018/04/Prokat-Toyota-Camry-2016.jpg",
                Brandname = "Toyota",
                Modelname = "Camry",
                Color = "Black",
                Features = "Good car for city lifestyle",
                CountryOfOrigin = "Japan",
                Price = 7000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new CarDTO() {
                ImageUrl = "https://www.masmotors.ru/colors/chevrolet-camaro/5.png",
                Brandname = "Shevrolet",
                Modelname = "Camaro",
                Color = "Black",
                Features = "Sport car",
                CountryOfOrigin = "USA",
                Price = 25000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new CarDTO() {
                ImageUrl = "https://avtocentr.com.ua/uploads/auto_models/image_model/0000/07.png",
                Brandname = "Kia",
                Modelname = "Soul",
                Color = "Green",
                Features = "Good car for driving in city",
                CountryOfOrigin = "Southern Korea",
                Price = 8000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new CarDTO() {
                ImageUrl = "https://static.turbosquid.com/Preview/2018/11/27__01_04_01/F0000.jpg3DBAE602-187B-4D56-A654-E04BEE40FF4AZoom.jpg",
                Brandname = "Dodge",
                Modelname = "Charger",
                Color = "Red",
                Features = "Good car for fast driving",
                CountryOfOrigin = "USA",
                Price = 24000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new CarDTO() {
                ImageUrl = "https://avilon.ru/upload/iblock/2ab/2abdbd1a91e715f12d8cbbb8804860d3.png",
                Brandname = "Dodge",
                Modelname = "Charger",
                Color = "Red",
                Features = "Good car for fast driving",
                CountryOfOrigin = "USA",
                Price = 24000,
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }
        };
    }
    
}
