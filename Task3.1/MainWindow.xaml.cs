﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Анимация размера текста
            DoubleAnimation fontSizeAnimation = new DoubleAnimation
            {
                From = 20, //это понятно
                To = 40, //это тоже
                Duration = new Duration(TimeSpan.FromSeconds(1)), //КД
                AutoReverse = true, //Возвращение к тому же состаянию кнопки
                RepeatBehavior = new RepeatBehavior(2) //количество повторов
            };

            // Анимация ширины кнопки
            DoubleAnimation widthAnimation = new DoubleAnimation
            {
                From = 100,
                To = 200,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = new RepeatBehavior(2)
            };

            // Анимация высоты кнопки
            DoubleAnimation heightAnimation = new DoubleAnimation
            {
                From = 50,
                To = 100,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = new RepeatBehavior(2)
            };

            // Создание Storyboard и добавление анимаций
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(fontSizeAnimation);//добавление анимаций
            storyboard.Children.Add(widthAnimation);
            storyboard.Children.Add(heightAnimation);

            // Установка целей анимаций
            Storyboard.SetTarget(fontSizeAnimation, AnimatedButton); //установка цели для анимации
            Storyboard.SetTargetProperty(fontSizeAnimation, new PropertyPath(Button.FontSizeProperty));//задает свойство, которое будет анимироваться.

            Storyboard.SetTarget(widthAnimation, AnimatedButton);
            Storyboard.SetTargetProperty(widthAnimation, new PropertyPath(Button.WidthProperty));

            Storyboard.SetTarget(heightAnimation, AnimatedButton);
            Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(Button.HeightProperty));

            // Запуск анимации
            storyboard.Begin();//начало анимации
        }
    }
}