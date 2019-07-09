using System;
using System.Collections.Generic;

namespace RandallsCarLot
{
  class Program
  {
    static void Main(string[] args)
    {

      Dictionary<string, Dictionary<string, List<string>>> vehicles = new Dictionary<string, Dictionary<string, List<string>>>();

      //   vehicles = {
      //     "vehicle" = {
      //       { "year", "2008"},
      //       { "model", "Damfresh"},
      //       { "make", "Biotraxquote"},
      //       { "color", "sky magenta"}
      //     }
      //   }

      // single car!

      var modelT = new Dictionary<string, string>()
      {
          {"year", "1914"},
          {"Make", "Ford"},
          {"Model", "T"},
          {"Price", "300"}
      };

      var modelX = new Dictionary<string, string>()
      {
          {"year", "2018"},
          {"Make", "Tesla"},
          {"Model", "X"},
          {"Price", "45,000"}
      };

      List<Dictionary<string, string>> garage = new List<Dictionary<string, string>>();

      garage.Add(modelT);
      garage.Add(modelX);

      //Pain Points
      //1. loooooong code
      //2. Redundant

      //Again but with classes - class is below

      var ford2 = new Car();
      ford2.Year = 2019;
      ford2.Year = 2017;
      ford2.Model = "Ford";
      ford2.Make = "Fiesta";
      ford2.Price = 32499.99;

      var tesla2 = new Car()
      {
        Year = 2017,
        Model = "X",
        Make = "Tesla",
        Price = 80000.68
      };

      var garage2 = new List<Car>() { ford2, tesla2 };

      tesla2.Drive();

      //       "vehicles": [
      //           {
      //         "vehicle": {
      //             "year": "2008",
      //                   "model": "Damfresh",
      //                   "make": "Biotraxquote",
      //                   "color": "sky magenta"
      //         },
      //         "sales_agent": {
      //             "mobile": "(896) 478-6975",
      //             "last_name": "Botsford",
      //             "first_name": "Shaina"
      //         },
      //         "credit": {
      //             "credit_provider": "J.P.Morgan Chase & Co",
      //             "account": "601109582720302"
      //         }
      //     },
      //     {
      //         "vehicle": {
      //             "year": "2010",
      //             "model": "Hotquadtrax",
      //             "make": "Transtintechno",
      //             "color": "robin egg blue"
      //         },
      //         "sales_agent": {
      //             "mobile": "562.300.2912",
      //             "last_name": "Davis",
      //             "first_name": "Gerardo"
      //         },
      //         "credit": {
      //             "credit_provider": "PNC Financial Services",
      //             "account": "34578280562836"
      //         }
      //     }
      // ]        }
    }
  }
}
