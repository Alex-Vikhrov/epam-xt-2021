using System;
using System.IO;
using System.Text;

namespace _4._1._1_FILE_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Устанавливаем путь к каталогу, за которым будем наблюдать
            FileSystemWatcher watcher = new FileSystemWatcher();
            
            try
            {
                watcher.Path = @"G:\Repository";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // Указываем цели наблюдения 
            watcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            // Следим только за текстовыми файлами 
            watcher.Filter = "*.txt";

            // Добавляем обработчик событий 
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Начнем наблюдение за каталогом 
            watcher.EnableRaisingEvents = true;

            // Ожидаем от пользователя команду завершения 
            Console.WriteLine(@"Пожалуйста нажмите 'q' чтобы выйти из приложения.");
            while (Console.Read() != 'q');
        }

        static void OnChanged(object sourse, FileSystemEventArgs e)
        {
            // Сообщить о действии изменения файла
            Console.WriteLine("Файл: {0} был изменен {1}!", e.FullPath, e.ChangeType);
        }

        static void OnCreated(object sourse, FileSystemEventArgs e)
        {
            // Сообщить о действии создания файла
            Console.WriteLine("Файл: {0} был создан {1}!", e.FullPath, e.ChangeType);
        }

        static void OnDeleted(object sourse, FileSystemEventArgs e)
        {
            // Сообщить о действии удаления файла
            Console.WriteLine("Файл: {0} был удален {1}!", e.FullPath, e.ChangeType);
        }

        static void OnRenamed(object sourse, RenamedEventArgs e)
        {
            // Сообщить о действии переименования файла 
            Console.WriteLine("Файл: {0} был переименнован в {1}", e.OldFullPath, e.FullPath);
        }
    }
}










#region V1
//var path = @"G:\Repository\probnic.txt";

//FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

////Console.WriteLine(fileStream.CanRead);

//StreamReader reader = new StreamReader(fileStream);

//Console.WriteLine(reader.ReadToEnd());



//FileInfo myFile = new FileInfo(path);

//if (!myFile.Exists)
//{
//    Console.WriteLine("Файл не существует!");
//}
//else
//{
//    Console.WriteLine("Файл существует.");
//}
//InputModeSelection();
#endregion

#region Enum FileMod
//enum File_Mods
//{
//    Open = 1,
//    Append,
//    Creat,
//    CreatNew,
//    Truncate
//}
//static void InputModeSelection()
//{
//    var path = @"G:\Repository\probnic.txt";
//    var path2 = @"G:\Repository\text.txt";

//    FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

//    fileStream = new FileStream(path2, FileMode.Create, FileAccess.ReadWrite);
//    fileStream = new FileStream(path2, FileMode.Append, FileAccess.Write);

//    StreamReader reader = new StreamReader(fileStream);



//    do
//    {
//        Console.WriteLine("Выберите какой режим хотите использовать:" + Environment.NewLine +
//            "1. Открыть и посмотреть файл" + Environment.NewLine +
//            "2. Открыть существующий или дописать в конец текст ?" + Environment.NewLine +
//            "3. Создать новый или перезаписть старый ?" + Environment.NewLine +
//            "4. Создает новый. Проверяет есть ли уже такой." + Environment.NewLine +
//            "5. Открывает существующий, и отчищает существующий. Новый не создается.");

//        File_Mods fileMode = (File_Mods)Int32.Parse(Console.ReadLine());

//        switch (fileMode)
//        {
//            case File_Mods.Open:
//                Console.WriteLine(reader.ReadToEnd());
//                reader.Dispose();
//                break;
//            case File_Mods.Append:
//                Console.WriteLine(reader.ReadToEnd());
//                break;
//            case File_Mods.Creat:
//                Console.WriteLine(reader.ReadToEnd());
//                reader.Dispose();
//                break;
//        }
//    } while (true);
#endregion