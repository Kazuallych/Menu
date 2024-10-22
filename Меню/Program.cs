List<Menu> menus = new List<Menu>(0);
menus.Add(new Menu("Завтрак с яичницей и шпинатом", "Хлеб,Яйцо,Шпинат,Помидор,Лук,Соль,Перец черный", 150, 250, "Глютен"));
menus.Add(new Menu("Завтрак с яичницей и грибами", "Хлеб,Яйцо,Грибы,Помидор,Лук,Соль,Перец черный", 150, 260, "Грибы"));
menus.Add(new Menu("Завтрак с яичницей и сыром", "Хлеб,Яйцо,Сыр,Помидор,Лук,Соль,Перец черный", 150, 290, "Молоко"));
menus.Add(new Menu("Завтрак с яичницей и курицей", "Хлеб,Яйцо,Куриное филе,Помидор,Лук,Соль,Перец черный", 150, 300, "Птица"));
menus.Add(new Menu("Овсянка с бананом", "Овсянка,Банан,Молоко,Мед", 200, 350, "Молоко"));
menus.Add(new Menu("Овсянка с ягодами", "Овсянка,Ягоды,Молоко,Мед", 200, 340, "Ягоды"));
menus.Add(new Menu("Овсянка с орехами", "Овсянка,Орехи,Молоко,Мед", 200, 360, "Орехи"));
menus.Add(new Menu("Овсянка с яблоком", "Овсянка,Яблоко,Мед,Корица", 200, 330, "Яблоки"));
menus.Add(new Menu("Салат с тунцом и фасолью", "Тунец,Фасоль,Лук,Салат,Оливковое масло", 150, 250, "Бобовые"));
menus.Add(new Menu("Салат с тунцом и кукурузой", "Тунец,Кукуруза,Лук,Салат,Оливковое масло", 150, 240, "Кукуруза"));
menus.Add(new Menu("Салат с тунцом и яйцом", "Тунец,Яйцо,Лук,Салат,Оливковое масло", 150, 260, "Яйцо"));
menus.Add(new Menu("Салат с тунцом и авокадо", "Тунец,Авокадо,Лук,Салат,Оливковое масло", 150, 270, "Авокадо"));
menus.Add(new Menu("Паста с томатным соусом", "Паста,Томатный соус,Чеснок,Базилик", 250, 400, "Глютен"));
menus.Add(new Menu("Паста с курицей", "Паста,Куриное филе,Томатный соус,Чеснок", 250, 450, "Птица"));
menus.Add(new Menu("Паста с морепродуктами", "Паста,Морепродукты,Томатный соус,Чеснок", 250, 480, "Моллюски"));
menus.Add(new Menu("Паста с овощами", "Паста,Овощи,Томатный соус,Чеснок", 250, 420, "Овощи"));
menus.Add(new Menu("Суп с курицей и рисом", "Куриное филе,Рис,Морковь,Лук,Бульон", 200, 300, "Рис"));
menus.Add(new Menu("Суп с фасолью", "Фасоль,Морковь,Лук,Бульон", 200, 280, "Бобовые"));
menus.Add(new Menu("Суп с грибами", "Грибы,Морковь,Лук,Бульон", 200, 260, "Грибы"));
menus.Add(new Menu("Суп с тунцом", "Тунец,Морковь,Лук,Бульон", 200, 320, "Рыба"));
while (true)
{

    for (int i = 0; i < menus.Count; i++)
    {
        menus[i].Get();
        Console.WriteLine();
    }
    if (menus.Count == 1)
    {
        Environment.Exit(0);
    }
    Console.WriteLine("1.По цене\n2.По продуктам\n3.По аллергенам\n4.По каллориям");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.Write("Введите сколько вы готовы потратить: ");
                int price = int.Parse(Console.ReadLine());

                for (int i = 0; i < menus.Count; i++)
                {
                    if (menus[i].Price > price)
                    {
                        menus.Remove(menus[i]);
                        i--;
                    }
                }
                break;
            }
        case 2:
            {
                Console.Write("Введите продукты через запятую: ");
                string product = Console.ReadLine();

                string[] products = product.Split(",");
                int a = 0;

                for (int i = 0; i < menus.Count; i++)
                {
                    for (int j = 0; j < products.Length; j++)
                    {
                        products[j] = products[j].Trim();
                        if (menus[i].Product.ToLower().IndexOf(products[j].ToLower()) != -1)
                        {
                            a++;
                        }
                    }
                    if (a != products.Length)
                    {
                        menus.Remove(menus[i]);
                        a = 0;
                        i--;
                    }
                    a = 0;
                }
                break;
            }
        case 3:
            {
                string Allergen = "";
                Console.WriteLine("Список аллергенов:\n1.Глютен\n2.Грибы\n3.Молоко\n4.Птица\n5.Ягоды\n6.Орехи\n7.Яблоки\n8.Бобовые\n9.Кукуруза\n10.Яйцо\n11.Авокадо\n12.Моллюски\n13.Овощи\n14.Рис\n15.Рыба");
                int choiceAllergen = int.Parse(Console.ReadLine());
                switch (choiceAllergen)
                {
                    case 1:
                        {
                            Allergen = "Глютен";
                            break;
                        }
                    case 2:
                        {
                            Allergen = "Грибы";
                            break;
                        }
                    case 3:
                        {
                            Allergen = "Молоко";
                            break;
                        }
                    case 4:
                        {
                            Allergen = "Птица";
                            break;
                        }
                    case 5:
                        {
                            Allergen = "Ягоды";
                            break;
                        }
                    case 6:
                        {
                            Allergen = "Орехи";
                            break;
                        }
                    case 7:
                        {
                            Allergen = "Яблоки";
                            break;
                        }
                    case 8:
                        {
                            Allergen = "Бобовые";
                            break;
                        }
                    case 9:
                        {
                            Allergen = "Кукуруза";
                            break;
                        }
                    case 10:
                        {
                            Allergen = "Яйцо";
                            break;
                        }
                    case 11:
                        {
                            Allergen = "Авокадо";
                            break;
                        }
                    case 12:
                        {
                            Allergen = "Моллюски";
                            break;
                        }
                    case 13:
                        {
                            Allergen = "Овощи";
                            break;
                        }
                    case 14:
                        {
                            Allergen = "Рис";
                            break;
                        }
                    case 15:
                        {
                            Allergen = "Рыба";
                            break;
                        }
                }
                for (int i = 0; i < menus.Count; i++)
                {
                    if (menus[i].Allergens.IndexOf(Allergen) != -1)
                    {
                        menus.Remove(menus[i]);
                        i--;
                    }
                }
                break;
            }
        case 4:
            {
                Console.Write("Количество каллорий: ");
                int calorie = int.Parse(Console.ReadLine());
                for (int i = 0; i < menus.Count; i++)
                {
                    if (menus[i].Calorie > calorie)
                    {
                        menus.Remove(menus[i]);
                        i--;
                    }
                }
                break;
            }
        default:
            {
                Console.WriteLine("Не корректный ввод данных");
                break;
            }
    }
}
class Menu
{
    public string Name = "";
    public int Calorie = 0;
    public string Product = "";
    public int Price = 0;
    public string Allergens = "";

    public void Get()
    {
        Console.Write($"Название: {Name}\nИнгредиенты: {Product}\nЦена: {Price}\nКаллорийность: {Calorie}\n");
    }

    public Menu(string _Name, string _Product, int _Price, int _Calorie,string _Allergens)
    {
        Name = _Name;
        Calorie = _Calorie;
        Product = _Product;
        Allergens = _Allergens;
        Price = _Price;
    }
}
