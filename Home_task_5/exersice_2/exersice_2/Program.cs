using System.Text;

namespace exersice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Користувач створює структуру магазину:
            Store store = new Store("Магазин");
            Department department1 = new Department("Підрозділ 1");
            department1.AddProduct(new Product("Товар 1", 10, 5, 2));
            department1.AddProduct(new Product("Товар 2", 8, 4, 3));
            department1.AddProduct(new Product("Товар 3", 7, 6, 1));
            store.AddDepartment(department1);

            Department department2 = new Department("Підрозділ 2");
            department2.AddProduct(new Product("Товар 4", 9, 3, 4));
            department2.AddProduct(new Product("Товар 5", 6, 7, 2));
            store.AddDepartment(department2);

            // Створюємо коробку для магазину:
            Box mainBox = new Box(store.Name);

            // Запаковуємо товари в коробки:
            PackProducts(store, mainBox);
            Console.WriteLine($"Загальна кількість коробок у магазині: {CountBoxes(mainBox)}");
            PrintBoxInfo(mainBox, "");
        }
        static void PackProducts(Department department, Box parentBox)
        {
            foreach (Product product in department.GetProducts())
            {
                bool packed = false;
                foreach (Box box in parentBox.GetBoxes())
                {
                    if (box.Height >= product.Height && box.Width >= product.Width && box.Length >= product.Length && box.IsEmpty())
                    {
                        box.AddBox(new Box(product.Name, product.Height, product.Width, product.Length));
                        box.SetDimensions(box.Height, box.Width, box.Length - product.Length);
                        packed = true;
                        break;
                    }
                }
                if (!packed)
                {
                    Box newBox = new Box($"Коробка для {department.Name}");
                    newBox.SetDimensions(parentBox.Height, parentBox.Width, parentBox.Length);
                    newBox.AddBox(new Box(product.Name, product.Height, product.Width, product.Length));
                    newBox.SetDimensions(newBox.Height, newBox.Width, newBox.Length - product.Length);
                    parentBox.AddBox(newBox);
                }
            }
        }

        static void PackProducts(Store store, Box parentBox)
        {
            foreach (Department department in store.GetDepartments())
            {
                PackProducts(department, parentBox);
            }
        }

        static int CountBoxes(Box box)
        {
            int count = 1;
            foreach (Box b in box.GetBoxes())
            {
                count += CountBoxes(b);
            }
            return count;
        }

        static void PrintBoxInfo(Box box, string indent)
        {
            Console.WriteLine($"{indent}Коробка '{box.Name}'");
            if (!box.IsEmpty())
            {
                Console.WriteLine($"{indent}  Вміщує:");
                foreach (Box innerBox in box.GetBoxes())
                {
                    PrintBoxInfo(innerBox, indent + "    ");
                }
            }
        }
    }
}