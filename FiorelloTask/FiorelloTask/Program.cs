using System;
using FiorelloTask.Entities;
using FiorelloTask.Services;

namespace FiorelloTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;

            string chooseStr = "";
            int choose;

            string productName;
            string productCostPriceStr;
            decimal productCostPrice;
            string productSalePriceStr;
            decimal productSalePrice;
            string productDiscountPercentStr;
            decimal productDiscountPercent;
            string productAboutText;
            string productDescriptionTitle;
            string productDescriptionText;
            string productCountStr;
            int productCount;
            string productCreatedAtStr;
            DateTime productCreatedAt;
            string productIsNewStr;
            bool productIsNew;
            string productCategoryIdStr;
            int productCategoryId;

            string idStr;
            int id;

            string startDateStr;
            DateTime startDate;
            string endDateStr;
            DateTime endDate;

            string productIdStr;
            int productId;

            string userIdStr;
            int userId;

            do
            {
                ProductService productService = new ProductService();
                UserService userService = new UserService();
                CommentService commentService = new CommentService();

                Console.WriteLine("-------------------Menu-----------------");
                Console.WriteLine("1. Product elave et");
                Console.WriteLine("2. Product-lar uzre axtaris et");
                Console.WriteLine("3. Secilmis product-un commentlerine bax (productId uzre)");
                Console.WriteLine("4. Secilmis user-in commentlerine bax (userId uzre)");
                Console.WriteLine("5. Commenti sil (id ile)");
                Console.WriteLine("6. Productlarin ortalama qiymetine bax");
                Console.WriteLine("7. Reservasiya elave et");
                Console.WriteLine("0. Verilmis 2 tarix araligindaki Commentlere bax");
                Console.WriteLine("----------------------------------------");


                do
                {
                    Console.WriteLine("Emeliyyat nomresini daxil edin:");
                    chooseStr = Console.ReadLine();
                } while (!int.TryParse(chooseStr, out choose));

                switch (choose)
                {
                    case 1:
                        
                        do
                        {
                            Console.WriteLine("Product adini daxil edin:");
                            productName = Console.ReadLine();

                        } while (string.IsNullOrEmpty(productName));

                        do
                        {
                            Console.WriteLine("Productun oz qiymetini daxil edin:");
                            productCostPriceStr = Console.ReadLine();
                        } while (!decimal.TryParse(productCostPriceStr, out productCostPrice));

                        do
                        {
                            Console.WriteLine("Productun satis qiymetini daxil edin:");
                            productSalePriceStr = Console.ReadLine();
                        } while (!decimal.TryParse(productSalePriceStr, out productSalePrice));

                        do
                        {
                            Console.WriteLine("Productun endirim faizini daxil edin:");
                            productDiscountPercentStr = Console.ReadLine();
                        } while (!decimal.TryParse(productDiscountPercentStr, out productDiscountPercent));

                        do
                        {
                            Console.WriteLine("Haqqinda text-ini daxil edin:");
                            productAboutText = Console.ReadLine();
                        } while (string.IsNullOrEmpty(productAboutText));

                        do
                        {
                            Console.WriteLine("Description title-ini daxil edin:");
                            productDescriptionTitle = Console.ReadLine();
                        } while (string.IsNullOrEmpty(productDescriptionTitle));

                        do
                        {
                            Console.WriteLine("Description text-ini daxil edin:");
                            productDescriptionText = Console.ReadLine();
                        } while (string.IsNullOrEmpty(productDescriptionText));

                        do
                        {
                            Console.WriteLine("Productlarin sayini daxil edin:");
                            productCountStr = Console.ReadLine();
                        } while (!int.TryParse(productCountStr, out productCount));

                        do
                        {
                            Console.WriteLine("Productun hazirlanma tarixini daxil edin:");
                            productCreatedAtStr = Console.ReadLine();
                        } while (!DateTime.TryParse(productCreatedAtStr, out productCreatedAt));

                        do
                        {
                            Console.WriteLine("Product yenidirmi? (TRUE/FALSE)");
                            productIsNewStr = Console.ReadLine();
                        } while (!bool.TryParse(productIsNewStr, out productIsNew));

                        do
                        {
                            Console.WriteLine("CategoryId daxil edin:");
                            productCategoryIdStr = Console.ReadLine();
                        } while (!int.TryParse(productCategoryIdStr, out productCategoryId));

                        Product product = new Product
                        {
                            Name = productName,
                            CostPrice = productCostPrice,
                            SalePrice = productSalePrice,
                            DiscountPercent = productDiscountPercent,
                            DescriptionTitle = productDescriptionTitle,
                            DescriptionText = productDescriptionText,
                            AboutText = productAboutText,
                            Count = productCount,
                            CreatedAt = productCreatedAt,
                            IsNew = productIsNew,
                            CategoryId = productCategoryId
                        };

                        productService.AddProduct(product);

                        break;

                    case 2:

                        do
                        {
                            Console.WriteLine("Axtardiginiz productun id-sini daxil edin:");
                            idStr = Console.ReadLine();
                        } while (!int.TryParse(idStr, out id));

                        Console.WriteLine(productService.GetProductById(id).Name + " - " + productService.GetProductById(id).SalePrice);

                        break;

                    case 3:

                        do
                        {
                            Console.WriteLine("Commentlerine baxmaq ucun productun id-sini daxil edin:");
                            productIdStr = Console.ReadLine();
                        } while (!int.TryParse(productIdStr, out productId));

                        foreach (var item in productService.GetCommentsByProductId(productId))
                        {
                            Console.WriteLine(item.Id + " " + item.Text);
                        }

                        break;

                    case 4:

                        do
                        {
                            Console.WriteLine("Commentlerine baxmaq ucun userin id-sini daxil edin:");
                            userIdStr = Console.ReadLine();
                        } while (!int.TryParse(userIdStr, out userId));

                        foreach (var item in userService.GetCommentsByUserId(userId))
                        {
                            Console.WriteLine(item.Id + " " + item.Text);
                        }

                        break;

                    case 5:

                        do
                        {
                            Console.WriteLine("Silmek istediyiniz commentin id-sini daxil edin:");
                            idStr = Console.ReadLine();
                        } while (!int.TryParse(idStr, out id));

                        commentService.DeleteCommentById(id);

                        break;
                    case 6:

                        Console.WriteLine(productService.ProductSalePriceAverage());

                        break;
                    case 7:

                        do
                        {
                            Console.WriteLine("Startdate daxil edin:");
                            startDateStr = Console.ReadLine();
                        } while (!DateTime.TryParse(startDateStr, out startDate));

                        do
                        {
                            Console.WriteLine("Enddate daxil edin:");
                            endDateStr = Console.ReadLine();
                        } while (!DateTime.TryParse(endDateStr, out endDate));

                        foreach (var item in commentService.GetCommentsThroughDateRange(startDate, endDate))
                        {
                            Console.WriteLine(item.Id + " " + item.Text);
                        }

                        break;

                    case 0:
                        check = false;
                        break;

                    default:
                        Console.WriteLine("Duzgun emeliyyat nomresi daxil edin!");
                        break;
                }


            } while (check);
        }
    }
}
