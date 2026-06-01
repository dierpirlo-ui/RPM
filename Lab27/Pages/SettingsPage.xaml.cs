using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using LabWork27.Models;

namespace LabWork27.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        private static List<Cat> _cats =
        [
            new() { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
            new() { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
            new() { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
            new() { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
            new() { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
            new() { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветная", Age = 6 },
            new() { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
            new() { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
            new() { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
            new() { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
        ];

        public SettingsPage()
        {
            InitializeComponent();
            GenerateCatsContent();
        }

        private void GenerateCatsContent()
        {
            var breedsGroups = _cats.GroupBy(cat => cat.Breed);
            CatsPanel.Children.Clear();
            foreach (var group in breedsGroups)
            {
                Expander expander = new()
                {
                    Header = group.Key
                };

                StackPanel checkBoxPanel = new();
                foreach (var cat in group)
                {
                    CheckBox checkBox = new()
                    {
                        Content = cat.Name
                    };
                    checkBoxPanel.Children.Add(checkBox);
                }

                expander.Content = checkBoxPanel;
                CatsPanel.Children.Add(expander);
            }
        }
    }
}
