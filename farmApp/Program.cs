using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Name;

namespace App
{
    class Program
    {

        static void Main(string[] args)
        {   List<Farm> FarmList = new List<Farm>() { 
        new Farm() {  FarmName = "JohnFarms", FarmType = FarmType.cattle , FarmProduce = "Millet" , YearOfEst = "2001" , ManagerNumber = 0908765432, ManagerName = "Sam yam" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "wefarms", FarmType = FarmType.crop ,  FarmProduce = "Weath" , YearOfEst = "2000" , ManagerNumber = 0908765432, ManagerName = "John fred" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "BiFarms", FarmType = FarmType.poutry , FarmProduce = "birds" ,YearOfEst = "1955" , ManagerNumber = 0908765432, ManagerName = "Mulk malik" , Address = "45 Ahmadiway" ,},
        new Farm() {  FarmName = "RamFarms" , FarmType = FarmType.Potato , FarmProduce = "Ram" , YearOfEst = "1990" , ManagerNumber = 0908765432, ManagerName = "Malik Calik" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "CowFarms" , FarmType = FarmType.Livestock , FarmProduce = "Cow" , YearOfEst = "1990" , ManagerNumber = 0908765432, ManagerName = "Don Paul" , Address = "45 Ahmadiway" ,},

        new Farm() {  FarmName = "JohnFarms", FarmType = FarmType.cattle , FarmProduce = "Millet" , YearOfEst = "2001" , ManagerNumber = 0908765432, ManagerName = "Sam yam" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "wefarms", FarmType = FarmType.crop ,  FarmProduce = "Weath" , YearOfEst = "2000" , ManagerNumber = 0908765432, ManagerName = "John fred" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "BiFarms", FarmType = FarmType.poutry , FarmProduce = "birds" ,YearOfEst = "1955" , ManagerNumber = 0908765432, ManagerName = "Mulk malik" , Address = "45 Ahmadiway" ,},
        new Farm() {  FarmName = "RamFarms" , FarmType = FarmType.Potato , FarmProduce = "Ram" , YearOfEst = "1990" , ManagerNumber = 0908765432, ManagerName = "Malik Calik" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "CowFarms" , FarmType = FarmType.Livestock , FarmProduce = "Cow" , YearOfEst = "1990" , ManagerNumber = 0908765432, ManagerName = "Don Paul" , Address = "45 Ahmadiway" ,},


        new Farm() {  FarmName = "JohnFarms", FarmType = FarmType.cattle , FarmProduce = "Millet" , YearOfEst = "2001" , ManagerNumber = 0908265432, ManagerName = "Samson yam" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "wefarms", FarmType = FarmType.crop ,  FarmProduce = "Weath" , YearOfEst = "2000" , ManagerNumber = 0901276542, ManagerName = "Joh fred" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "BiFarms", FarmType = FarmType.poutry , FarmProduce = "birds" ,YearOfEst = "1955" , ManagerNumber = 0908126432, ManagerName = "Mul malik" , Address = "45 Ahmadiway" ,},
        new Farm() {  FarmName = "RamFarms" , FarmType = FarmType.Potato , FarmProduce = "Ram" , YearOfEst = "1990" , ManagerNumber = 0908243432, ManagerName = "Akpan Calik" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "CowFarms" , FarmType = FarmType.Livestock , FarmProduce = "Cow" , YearOfEst = "1990" , ManagerNumber = 0908765432, ManagerName = "Jon Paul" , Address = "45 Ahmadiway" ,},


        new Farm() {  FarmName = "JohnFarms", FarmType = FarmType.cattle , FarmProduce = "Millet" , YearOfEst = "2001" , ManagerNumber =098978432, ManagerName = "Sam yonm" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "wefarms", FarmType = FarmType.crop ,  FarmProduce = "Weath" , YearOfEst = "2000" , ManagerNumber = 0908709832, ManagerName = "John fraed" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "BiFarms", FarmType = FarmType.poutry , FarmProduce = "birds" ,YearOfEst = "1955" , ManagerNumber = 0900988902, ManagerName = "Mulk maleeik" , Address = "45 Ahmadiway" ,},
        new Farm() {  FarmName = "RamFarms" , FarmType = FarmType.Potato , FarmProduce = "Ram" , YearOfEst = "1990" , ManagerNumber = 0900985432, ManagerName = "Malik Caark" , Address = "45 Ahmadiway" ,} ,
        new Farm() {  FarmName = "CowFarms" , FarmType = FarmType.Livestock , FarmProduce = "Cow" , YearOfEst = "1990" , ManagerNumber = 090098432, ManagerName = "Don Paulin" , Address = "45 Ahmadiway" ,}
    };

            // <string> stringList = new List<string>()
            // List<Farm> FarmList = FarmList<>();

            var farmProps = FarmList.Select(f => f.FarmName).ToList();
            var farmMan = FarmList.Select(m => m.ManagerName ).ToList();
            var farmPhon= FarmList.Select(mn => mn.ManagerNumber).ToList();



            foreach(var name in FarmList){
                Console.WriteLine($"Farm Name: {name.FarmName}, Manager Name: {name.ManagerName}, Manager Phone Number:{name.ManagerNumber}");
                Console.WriteLine(name  );
            }

            var farmGroup = FarmList.GroupBy(d => d.FarmName).ToList();

        foreach (var item in farmGroup)
        {
            Console.WriteLine($"The Farms ARE GROUPED BY FARM NAMES: {item.Key}");
            foreach (var farm in item)
            {
                Console.WriteLine($"\n \n {farm.FarmName} ||| {farm.ManagerName} ||| {farm.FarmType} ||| {farm.FarmProduce} ||| {farm.ManagerNumber}");
            }
            //System.Console.WriteLine($"\n \n {item.FarmName} ||| {item.ManagerName} ||| {item.FarmType} ||| {item.ManagerPhoneNumber}");
        }


        

        }

    }

 }   