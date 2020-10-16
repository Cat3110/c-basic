// Требуется добавить в проект ссылку на сборку System.Windows.Forms
using System.Threading;// Для создания паузы перед закрытием приложения
using System.Windows.Forms;
class ShowForm
{
    public static void Main()
    {
        // Создаем объект класса Form
        Form form = new Form();
        // Обращаемся к некоторым свойствам графического окна
        form.Text = "Это простое графическое окно";
        form.Width = 100;
        // Показываем этот объект
        form.Show();
        // Если не сделать паузу, то консольное окно и форма закроются
        Thread.Sleep(3000);
    }
}
