using System;

namespace ДР_12_3
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.AddEvent += MainWindowAdd;
            this.mainWindow.SubEvent += MainWindowSub;
            this.mainWindow.MulEvent += MainWindowMul;
            this.mainWindow.DivEvent += MainWindowDiv;
        }

        void MainWindowAdd(object sender, EventArgs e)
        {
            string variable = model.Add(Convert.ToInt32(mainWindow.TextBox_1.Text),
                                        Convert.ToInt32(mainWindow.TextBox_2.Text)); //Вызов метода Add модели который принимает 2 аргумента целого типа и возвращает значение строкового типа 
            mainWindow.TextBox_Result.Text = variable;
        }
        void MainWindowSub(object sender, EventArgs e)
        {
            string variable = model.Sub(Convert.ToInt32(mainWindow.TextBox_1.Text),
                                        Convert.ToInt32(mainWindow.TextBox_2.Text));//Вызов метода Sub модели который принимает 2 аргумента целого типа и возвращает значение строкового типа
            mainWindow.TextBox_Result.Text = variable;
        }
        void MainWindowMul(object sender, EventArgs e)
        {
            string variable = model.Multi(Convert.ToInt32(mainWindow.TextBox_1.Text),
                                          Convert.ToInt32(mainWindow.TextBox_2.Text));//Вызов метода Multi модели который принимает 2 аргумента целого типа и возвращает значение строкового типа
            mainWindow.TextBox_Result.Text = variable;
        }
        void MainWindowDiv(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.TextBox_1.Text),
                                        Convert.ToInt32(mainWindow.TextBox_2.Text));//Вызов метода Div модели который принимает 2 аргумента целого типа и возвращает значение строкового типа
            mainWindow.TextBox_Result.Text = variable;
        }
    }
}
