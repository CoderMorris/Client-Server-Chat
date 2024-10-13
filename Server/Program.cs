//Импортирует пространство имён .NET Framework, необходимое для работы с базовыми классами и интерфейсами.
using System;
//Импортирует пространство имён, содержащее обобщённые коллекции, такие как списки, словари и очереди.
using System.Collections.Generic;
//Импортирует пространство имён, предоставляющее методы для работы с LINQ (Language Integrated Query),
//которые позволяют выполнять запросы к коллекциям данных.
using System.Linq;
//Импортирует пространство имён, содержащее классы и интерфейсы для работы с задачами в многопоточной среде.
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Server
{
    static class Program
    {
        //Атрибут, указывающий, что метод Main должен выполняться в однопоточном режиме
        [STAThread]
        static void Main()
        {
            // Вызывает метод EnableVisualStyles, который позволяет использовать
            // визуальные стили для элементов управления Windows Forms.
            Application.EnableVisualStyles();
            //Устанавливает значение по умолчанию для совместимого рендеринга текста в Windows Forms.
            Application.SetCompatibleTextRenderingDefault(false);
            //Запускает новый экземпляр класса Server и передаёт его методу Run,
            //который управляет жизненным циклом приложения Windows Forms.
            Application.Run(new Server());
        }
    }
}
