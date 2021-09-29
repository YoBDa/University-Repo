using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListAgain.Classes;
using ListAgain;
using System.Threading;

namespace ListAgain.Forms
{
    public partial class Form1 : Form
    {
        private AddItemForm AIF;
        private NewList list;
        BindingSource bs;
        public Form1()
        {
            list = new NewList();
            bs = new BindingSource();
            list.StateChanged += List_StateChanged;            
            InitializeComponent();
            lbData.DataSource = bs;
        }

        private void List_StateChanged()
        {
            bs.DataSource = list.ToList();
            DrawStats();
        }
        private void DrawStats()
        {

            int Spacing = 10;//px Промежуток между колонками
            int CaptionsWidth = 30;//px Ширина подписи
            int ColumnWidth = 10; //px Ширина полос
           
            Bitmap bitmap = new Bitmap(pbGraph.Width, pbGraph.Height);// Рисовать будем в битмапе, чтоб можно было пролистывать рисунок
            //если рисовать на контроле, то рисунок при ролистывании не сохраняется
            Graphics gr = Graphics.FromImage(bitmap); //создаем объект Graphics из Bitmap, чтоб стереть с PictureBox предыдущее изображение
            gr.FillRectangle(SystemBrushes.Control, 0, 0, pbGraph.Width, pbGraph.Height);//
            pbGraph.Image = bitmap;

            if (list.Count == 0) return;//Если лист пуст, то выходим, ничего не рисуем
            SortedDictionary<int, int> Stats = new SortedDictionary<int, int>();//Упорядоченный словарь для сбора статистики по записям
            foreach (int Item in list)//обработка всех записей
            {
                if (!Stats.ContainsKey(Item))//Если такого элемента еще не существует
                {
                    Stats.Add(Item, 1);//Добавляем его и устанавливаем его количество = 1
                }
                else
                {
                    Stats[Item]++; //А если существует, то увеличиваем количество на 1
                }
            }
            
            int ColumnCount = Stats.Keys.Count; // количество колонок
            int MaxCount = Stats.Values.Max();// Какой элемент повторяется большее кол-во раз
            int ColumnMaxLength = pbGraph.Width - CaptionsWidth; //px Максимальная длина колонки
            int ColumnMinLength = ColumnMaxLength / MaxCount;//px Минимальная длина колонки
            

            //Начинаем рисоватб
            int CurrentColumn = 0;//текущая колонка
            int PlotHeight = (ColumnWidth + Spacing) * ColumnCount;//Высота битмапа
            pbGraph.Height = PlotHeight; //Для появления полосы прокрутки устанавливаем высоту pictureBox'a
            bitmap = new Bitmap(pbGraph.Width, pbGraph.Height); //Создаем новый обЪект Bitmap с новыми характеристиками
            gr = Graphics.FromImage(bitmap);// Соответственно создаем новый Graphics из нового Bitmap
            Font font = SystemFonts.DefaultFont; //Задаем шрифт
            Random rnd = new Random((int)DateTime.Now.Ticks); //рандом цвета
            Rainbow rnb = new Rainbow();
            foreach (var Pair in Stats)
            {
                Brush brush = new SolidBrush((Color)rnb.Current); //Задаем цвет колонок, в скобках укажите желаемый Color.Black, к примеру
                rnb.MoveNext();
                gr.DrawString(Pair.Key.ToString(), font, SystemBrushes.ControlText, new Point(0, CurrentColumn * (Spacing + ColumnWidth)));//рисуем подпись
                gr.FillRectangle(brush, CaptionsWidth, CurrentColumn * (Spacing + ColumnWidth),
                    Map(Pair.Value, 1, MaxCount, ColumnMinLength, ColumnMaxLength), ColumnWidth);//Рисуем колонку
                CurrentColumn++;//Увеличиваем номер обрабатываемой колонки
            }
            pbGraph.Image = bitmap;//выводим битмап
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AIF = new AddItemForm(lbData.SelectedIndex);
            AIF.Show();
            AIF.ValueGet += AIF_ValueGet;
        }

        private void AIF_ValueGet(int Value, int Index )
        {
            if (Index < 0)
                list.Add(Value);
            else
                list.AddAt(Value, Index);
            AIF.ValueGet += AIF_ValueGet;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        private void btRmSelected_Click(object sender, EventArgs e)
        {
            list.RemoveAt(lbData.SelectedIndex);
        }

        private void btRmFirst_Click(object sender, EventArgs e)
        {
            list.RemoveAt(0);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            list.Sort();
        }

        private int Map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            try
            {
                return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
            }
            catch (DivideByZeroException)
            {
                return out_max;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawStats();
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < 500; i++)
            {
                list.Add(rnd.Next(0, 50));
            }
        }
    }
}
