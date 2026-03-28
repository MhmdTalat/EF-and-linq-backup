// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;
using EFCore.Model;
using Microsoft.EntityFrameworkCore;


//join field
// using (var context = new APPContext())
// {
//     var joincatpro = from c in context.Categories
//                      join p in context.Products on c.Id equals p.CategoryId
//                      select new { CategoryName = c.Name, ProductName = p.Name, Price = p.Price };

//     foreach (var item in joincatpro)
//     {
//         // ألوان
//         Console.BackgroundColor = ConsoleColor.Green;
//         Console.ForegroundColor = ConsoleColor.White;

//         // نص الصندوق
//         string line = $" Category: {item.CategoryName} | Product: {item.ProductName} | price: {item.Price}    |";

//         // رسم الصندوق
//         string topBottom = "+" + new string('-', line.Length) + "+";
//         string middle = "|" + line + "|";

//         Console.WriteLine(topBottom);
//         Console.WriteLine(middle);
//         Console.WriteLine(topBottom);

//         Console.ResetColor();
//         Console.WriteLine(); // فاصل سطر
//     }

// }

//left join
// using (var context = new APPContext())
// {
//     var leftjoincatpro = from c in context.Categories
//                          join p in context.Products on c.Id equals p.CategoryId into catpro
//                          from subp in catpro.DefaultIfEmpty()
//                          select new { CategoryName = c.Name, ProductName = subp != null ? subp.Name : "No Product", Price = subp != null ? subp.Price : 0 };

//     foreach (var item in leftjoincatpro)
//     {
//         // ألوان
//         Console.BackgroundColor = ConsoleColor.Green;
//         Console.ForegroundColor = ConsoleColor.White;

//         // نص الصندوق
//         string line = $" Category: {item.CategoryName} | Product: {item.ProductName} | price: {item.Price}    |";

//         // رسم الصندوق
//         string topBottom = "+" + new string('-', line.Length) + "+";
//         string middle = "|" + line + "|";

//         Console.WriteLine(topBottom);
//         Console.WriteLine(middle);
//         Console.WriteLine(topBottom);

//         Console.ResetColor();
//         Console.WriteLine(); // فاصل سطر
//     }
// }

//right join
// using (var context = new APPContext())
// {
//     var rightjoincatpro = from p in context.Products
//                           join c in context.Categories on p.CategoryId equals c.Id into procat
//                           from subc in procat.DefaultIfEmpty()
//                           select new { CategoryName = subc != null ? subc.Name : "No Category", ProductName = p.Name, Price = p.Price };

//     foreach (var item in rightjoincatpro)
//     {
//         // ألوان
//         Console.BackgroundColor = ConsoleColor.Green;
//         Console.ForegroundColor = ConsoleColor.White;

//         // نص الصندوق
//         string line = $" Category: {item.CategoryName} | Product: {item.ProductName} | price: {item.Price}    |";

//         // رسم الصندوق
//         string topBottom = "+" + new string('-', line.Length) + "+";
//         string middle = "|" + line + "|";

//         Console.WriteLine(topBottom);
//         Console.WriteLine(middle);
//         Console.WriteLine(topBottom);

//         Console.ResetColor();
//         Console.WriteLine(); // فاصل سطر
//     }

// }


//cross join
// using (var context = new APPContext())
// {
//     var crossjoincatpro = from c in context.Categories
//                           from p in context.Products
//                           select new { CategoryName = c.Name, ProductName = p.Name, Price = p.Price };

//     foreach (var item in crossjoincatpro)
//     {
//         // ألوان
//         Console.BackgroundColor = ConsoleColor.Green;
//         Console.ForegroundColor = ConsoleColor.White;

//         // نص الصندوق
//         string line = $" Category: {item.CategoryName} | Product: {item.ProductName} | price: {item.Price}    |";

//         // رسم الصندوق
//         string topBottom = "+" + new string('-', line.Length) + "+";
//         string middle = "|" + line + "|";

//         Console.WriteLine(topBottom);
//         Console.WriteLine(middle);
//         Console.WriteLine(topBottom);

//         Console.ResetColor();
//         Console.WriteLine(); // فاصل سطر
//     }
// }


// //order by
// using (var context = new APPContext())
// {
//     var orderbycatpro = from p in context.Products
//                         orderby p.Price descending
//                         select new { ProductName = p.Name, Price = p.Price };

//     foreach (var item in orderbycatpro)
//     {
//         // ألوان
//         Console.BackgroundColor = ConsoleColor.Green;
//         Console.ForegroundColor = ConsoleColor.White;

//         // نص الصندوق
//         string line = $" Product: {item.ProductName} | price: {item.Price}    |";

//         // رسم الصندوق
//         string topBottom = "+" + new string('-', line.Length) + "+";
//         string middle = "|" + line + "|";

//         Console.WriteLine(topBottom);
//         Console.WriteLine(middle);
//         Console.WriteLine(topBottom);

//         Console.ResetColor();
//         Console.WriteLine(); // فاصل سطر
//     }
// }

//first and firstordefault
// using (var context = new APPContext())
// {
//     var firstproduct = context.Products.FirstOrDefault(p => p.Price > 100 && p.Price % 2 == 0);
//     if (firstproduct != null)
//     {
//         Console.WriteLine($"First Product: {firstproduct.Name}, Price: {firstproduct.Price}");
//     }
//     else
//     {
//         Console.WriteLine("No product found with price greater than 100.");
//     }
// }


//update part
// using (var context = new APPContext())
// {
//     var updatepid = context.Products.FirstOrDefault(p => p.Id == 1);
//     if (updatepid != null)
//     {
//         updatepid.Price = 200;
//         context.SaveChanges();
//         Console.WriteLine($"Product with ID 1 updated to new price: {updatepid.Price}");
//     }
//     else
//     {
//         Console.WriteLine("Product with ID 1 not found.");
//     }
// }

//addnew data

// var context = new APPContext();
// if (context.Products.Any())
// {

//     var category1 = new Category { Name = "Electronics" };
//     var category2 = new Category { Name = "Books" };

//     context.Categories.AddRange(category1, category2);
//     context.SaveChanges();

//     var product1 = new Product { Name = "Laptop", Price = 999.99m, CategoryId = category1.Id };
//     var product2 = new Product { Name = "Smartphone", Price = 499.99m, CategoryId = category1.Id };
//     var product3 = new Product { Name = "Novel", Price = 19.99m, CategoryId = category2.Id };

//     context.Products.AddRange(product1, product2, product3);
//     context.SaveChanges();
// }

//update data by user input
// var context = new APPContext();
// Console.Write("Enter the ID of the product you want to update: ");
// string? inputid = Console.ReadLine();

// if (int.TryParse(inputid, out int productId))
// {
//     var updatepid = context.Products.FirstOrDefault(p => p.Id == productId);

//     if (updatepid != null)
//     {
//         Console.Write("Enter new price for product with ID {0}: ", productId);

//         string? input = Console.ReadLine(); // اقرأ مرة واحدة
//         if (!string.IsNullOrEmpty(input) && decimal.TryParse(input, out decimal newPrice))
//         {
//             updatepid.Price = newPrice;
//             context.SaveChanges();
//             Console.WriteLine($"Product with ID {productId} updated to new price: {updatepid.Price}");
//             var prid = from p in context.Products
//                        where p.Id == 1
//                        select new { ProductName = p.Name, Price = p.Price };
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Price not updated.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Product with ID {0} not found.", productId);
//     }
// }


//add new product by user input
// using var context = new APPContext();

// // قراءة والتحقق من CategoryId
// Console.WriteLine("Enter Category ID:");
// string? input = Console.ReadLine();
// if (!int.TryParse(input, out int categoryId) || categoryId <= 0)
// {
//     Console.WriteLine("Invalid CategoryId. It must be a positive integer.");
//     return;
// }

// // التحقق من وجود الـ Category في DB
// if (!context.Categories.Any(c => c.Id == categoryId))
// {
//     Console.WriteLine($"CategoryId {categoryId} does not exist in the database.");
//     return;
// }

// // قراءة اسم المنتج
// Console.WriteLine("Enter Product Name:");
// string? productName = Console.ReadLine();
// if (string.IsNullOrWhiteSpace(productName))
// {
//     Console.WriteLine("Product name cannot be empty.");
//     return;
// }

// // قراءة والتحقق من السعر
// Console.WriteLine("Enter Product Price:");
// string? priceInput = Console.ReadLine();
// if (!decimal.TryParse(priceInput, out decimal price) || price <= 0)
// {
//     Console.WriteLine("Invalid price. It must be a positive number.");
//     return;
// }

// // إنشاء المنتج
// var newProduct = new Product
// {
//     Name = productName.Trim(),
//     Price = price,
//     CategoryId = categoryId
// };

// // إضافة المنتج وحفظه في DB
// context.Products.Add(newProduct);
// context.SaveChanges();

// Console.WriteLine($"Product '{newProduct.Name}' added successfully under Category ID {categoryId} with price {newProduct.Price:C}.");



//add new category by user input
// using var context = new APPContext();
// Console.WriteLine("Enter Category Name:");
// string? categoryName = Console.ReadLine();
// var newCategory = new Category { Name = categoryName };
// context.Categories.Add(newCategory);
// context.SaveChanges();
// Console.WriteLine($"Category '{newCategory.Name}' added successfully with ID {newCategory.Id}.");
