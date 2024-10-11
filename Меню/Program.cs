List<Menu> menus = new List<Menu>(10);
menus.Add(new Menu("Салат из свежей капусты с огурцом", "Капуста белокочанная,Огурец,Укроп,Масло подсолнечное,Соль,Перец черный", 69, 60,"")); 
menus.Add (new Menu("Солянка с картошкой и колбасой классическая","Картофель,Яйцо,Огурец,Колбаса,Перец болгарский,Лук зеленый,Укроп,Петрушка,Квас,Соль,Перец черный,Сметана",200,359,"Орехи"));
menus.Add(new Menu("Завтрак с авокадо и яйцом", "Хлеб,Авокадо,Яйцо,Помидор,Салат,Сок лимонный,Соль,Перец черный", 150, 278, "Цитрусовые"));
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
                    }
                }
                break;
            }
        case 2:
            {

                Console.Write("Введите продукты: ");
                string product = Console.ReadLine();

                string[] products = product.Split(" ");
                int a = 0;

                for (int i = 0; i < menus.Count; i++)
                {
                    for (int j = 0; j < products.Length; j++)
                    {
                        if (menus[i].Product.ToLower().IndexOf(products[j].ToLower()) != -1)
                        {
                            a++;
                        }
                    }
                    if (a != products.Length)
                    {
                        menus.Remove(menus[i]);
                        a = 0;
                    }
                    a = 0;
                }
                break;
            }
        case 3:
            {
                string Allergen = "";
                Console.WriteLine("Список аллергенов:\n1.Глютен\n2.Орехи\n3.Цитрусовые");
                int choiceAllergen = int.Parse(Console.ReadLine());
                if (choiceAllergen == 1)
                {
                    Allergen = "Глютен";
                }
                if (choiceAllergen == 2)
                {
                    Allergen = "Орехи";
                }
                if (choiceAllergen == 3)
                {
                    Allergen = "Цитрусовые";
                }


                for (int i = 0; i < menus.Count; i++)
                {
                    if (menus[i].Allergens.IndexOf(Allergen) != -1)
                    {
                        menus.Remove(menus[i]);
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
