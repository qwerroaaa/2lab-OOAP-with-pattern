using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private PizzaBasic currentPizza = new CheesePizza();
        public Form1()
        {
            InitializeComponent();
            choosePizza.Items.Add("Сырная пицца");
            choosePizza.Items.Add("Барбекю пицца");

            addToPizza.Items.Add("Томат");
            addToPizza.Items.Add("Сыр");
            addToPizza.Items.Add("Мясо");
        }

        private void UpdateForm()
        {
            ChoseElem.Text = currentPizza.GetDescription();
            priceBox.Text = $"{currentPizza.GetCost()} руб.";
        }

        // Абстрактный класс базовой пиццы
        public abstract class PizzaBasic
        {
            public abstract int GetCost();
            public abstract string GetDescription();
        }

        // Класс сырной пиццы
        public class CheesePizza : PizzaBasic
        {
            public override int GetCost()
            {
                // Цена сырной пиццы
                return 450;
            }

            public override string GetDescription()
            {
                return "Сырная пицца";
            }
        }

        // Класс барбекю пиццы
        public class BarbecuePizza : PizzaBasic
        {
            public override int GetCost()
            {
                // Цена барбекю пиццы
                return 560;
            }

            public override string GetDescription()
            {
                return "Барбекю пицца";
            }
        }

        // Абстрактный класс декоратора
        public abstract class Decorator : PizzaBasic
        {
            protected PizzaBasic pizzaBasic;

            public Decorator(PizzaBasic pizzaBasic)
            {
                this.pizzaBasic = pizzaBasic;
            }
        }

        // Класс добавки томата
        public class AddTomato : Decorator
        {
            public AddTomato(PizzaBasic pizzaBasic) : base(pizzaBasic) { }

            public override int GetCost()
            {
                // Дополнительная цена за томаты
                return pizzaBasic.GetCost() + 15;
            }

            public override string GetDescription()
            {
                return pizzaBasic.GetDescription() + ", Добавка: Томат";
            }
        }

        // Класс добавки сыра
        public class AddCheese : Decorator
        {
            public AddCheese(PizzaBasic pizzaBasic) : base(pizzaBasic) { }

            public override int GetCost()
            {
                // Дополнительная цена за сыр
                return pizzaBasic.GetCost() + 30;
            }

            public override string GetDescription()
            {
                return pizzaBasic.GetDescription() + ", Добавка: Сыр";
            }
        }

        // Класс добавки мяса
        public class AddMeat : Decorator
        {
            public AddMeat(PizzaBasic pizzaBasic) : base(pizzaBasic) { }

            public override int GetCost()
            {
                // Дополнительная цена за мясо
                return pizzaBasic.GetCost() + 50;
            }

            public override string GetDescription()
            {
                return pizzaBasic.GetDescription() + ", Добавка: Мясо";
            }
        }

        private void choosePizza_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (choosePizza.Text)
            {
                case "Сырная пицца":
                    currentPizza = new CheesePizza();
                    break;
                case "Барбекю пицца":
                    currentPizza = new BarbecuePizza();
                    break;
                default:
                    currentPizza = null; // Если пицца не выбрана, устанавливаем выбранный объект в null
                    break;
            }
            priceBox.Text = $"{currentPizza.GetCost()} руб.";
            UpdateForm();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (addToPizza.Text)
            {
                case "Томат":
                    currentPizza = new AddTomato(currentPizza); 
                    break;
                case "Сыр":
                    currentPizza = new AddCheese(currentPizza); 
                    break;
                case "Мясо":
                    currentPizza = new AddMeat(currentPizza); 
                    break;
                default:
                    currentPizza = null; // Если добавка не выбрана, устанавливаем выбранный объект в null
                    break;
            }
            UpdateForm();
        }

    }
}
