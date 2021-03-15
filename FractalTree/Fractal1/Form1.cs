using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Fractal1
{
    public partial class Form1 : Form
    {
        int n = 20;
        bool flag1 = true, flag2 = true;
        public EventHandler evh;

        
        public Form1()
        {
            InitializeComponent();
            txtforN.Text = n.ToString();
            treepanel.Select();
            txtforN.GotFocus += Focus;
        }
        public void DrawF(int x, int y, int len, double angle, PaintEventArgs e, Graphics g=null) //Функция, которая отрисовывает наши ветки, где x и y - координаты, переменная len - длина, а переменная angle - угол поворота
        {
            if (g == null)
            {
                g = e.Graphics;
            }
            double x1, y1; //Новые координаты, которые мы расчитаем исходя из длины и угла
            x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0); // к координате х прибавляем длину умноженную на уравнение окружности и присваиваем это всё в x1
            y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0); // к координате y прибавляем длину умноженную на уравнение окружности и присваиваем это всё в y1
            g.DrawLine(new Pen(Color.Black, len / 25), x, treepanel.Height - y, (int)x1, treepanel.Height - (int)y1); //Рисуем линию от координат x,y до координат x1,y1; Создаём карандаш Pen(Color.Black, (len/25) - длину делим на 25, чтобы сделать ветки пожирнее), x1 и y1 - преобразуем в целые числа, чтобы осуществлять отрисовку и от panel1.Height вычитаем координаты y и y1, чтобы рисунок отрисовывался с нижней части нашей панели
            if (len > treepanel.Height / n) // Функция DrawF будет вызываться бесконечно, когда её длина станет больше 20 пикселей, тогда функция DrawF - прекратится
            {
                DrawF((int)x1, (int)y1, (int)(len / 1.5), angle + 35, e,g); //Рисуем следующую ветку в координатах x1, y1, длину len делим на 1.5 - чтобы ветки были красивее, а к углу angle - прибавляем 35 градусов, для того чтобы нарисовать правую сторону нашего фрактального древа
                DrawF((int)x1, (int)y1, (int)(len / 1.5), angle - 35, e,g); //Рисуем следующую ветку в координатах x1, y1, длину len делим на 1.5 - чтобы ветки были красивее, а от угла angle - вычитаем 35 градусов, для того чтобы нарисовать левую сторону нашего фрактального древа
                if(flag1)
                    DrawF((int)x1, (int)y1, (int)(len / 1.5), angle + 15, e, g); //Рисуем дополнительные ветки с другими углами, при изменении угла или длины ветви будут изменяться 
                if(flag2)
                    DrawF((int)x1, (int)y1, (int)(len / 1.5), angle - 15, e, g); //Рисуем дополнительные ветки с другими углами, при изменинии угла или длины ветви будут изменяться
            }
        }

        private void Focus(object sender, EventArgs e)
        {
            txtforN.Text = "";
        }

        private void treepanel_Paint(object sender, PaintEventArgs e)
        {
            //UIContext = SynchronizationContext.Current;
            //if(UIContext!=null)
            //ThreadPool.QueueUserWorkItem(
            //    delegate { UIContext.Send(delegate { DrawF(treepanel.Width / 2, 0, (treepanel.Height / 3) / (1 - 2 / 3), 0, e); },null); }
            //    , null
            //    );
            DrawF(treepanel.Width / 2, 0, (treepanel.Height / 3) / (1 - 2 / 3), 0, e); // При помощи функции рисуем в нашей Панеле линию с верха Панели и задаем длину - 300, угол 0, и Paint аргументы передаём 

        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtforN.Text);
            flag1 = checkbranch1.Checked;
            flag2 = checkbranch2.Checked;
            treepanel.Invalidate();


        }
    }
}
