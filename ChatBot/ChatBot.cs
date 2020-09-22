using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;


namespace ChatBot
{
    public class ChatBot : AbstractChatBot
    {
        static string userName;  // имя пользователя
        string path;             // путь к файлу с историей сообщений
        readonly List<string> history = new List<string>();      // хранение истории
        Random rnd = new Random();

        /// <summary>
        /// Конструктор
        /// </summary>
        public ChatBot() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="filename"></param>
        public ChatBot(string filename) { LoadHistory(filename); }

        /// <summary>
        /// Геттер имени пользователя
        /// </summary>
        public string UserName { get { return userName; } }

        /// <summary>
        /// Геттер пути к файлу с историей сообщений
        /// </summary>
        public string Path { get { return path; } }

        /// <summary>
        /// Геттер истории сообщений
        /// </summary>
        public List<string> History { get { return history; } }

        readonly List<Regex> regecies = new List<Regex>
        {
            new Regex(@"погода"),
            new Regex(@"привет\s?\,?\s?б{1}о{1}т{1}|привет"),
            new Regex(@"(?:который час\??|сколько времени\??|время\??)"),
            new Regex(@"(?:какое сегодня число\??|число\??)"),
            new Regex(@"как дела\??"),
            new Regex(@"(?:спасибо|благодарю)"),
            new Regex(@"(?:умножь(\s)?(\d+)(\s)?на(\s)?(\d+))"),
            new Regex(@"(?:раздели(\s)?(\d+)(\s)?на(\s)?(\d+))"),
            new Regex(@"(?:сложи(\s)?(\d+)(\s)?и(\s)?(\d+))"),
            new Regex(@"(?:вычти(\s)?(\d+)(\s)?из(\s)?(\d+))"),
            new Regex(@"(&:запусти paint|хочу рисовать)"),
            new Regex(@"(&:включи калькулятор|калькулятор)")
        };

        Func<string, string> funcBuf; // буфер

        readonly List<Func<string, string>> func = new List<Func<string, string>>
        {
            WeatherPls,
            HelloBot,
            HowTime,
            HowDate,
            HowAreYou,
            ThankYou,
            MulPls,
            DivPls,
            PlusPls,
            SubPls,
            startPaint,
            startCalc
        };

        static string startCalc(string question)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
            }
            catch
            {
                return "что то не вышло, придётся упрашивать меня посчитать.";
            }
            return "я вообще то тоже считать умею. Хотя для тебя не стал бы.";
        }

        static string startPaint(string question)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
            }
            catch
            {
                return "что то не получилось.";
            }
            return "рисуй,главное меня не трогай.";
        }

        /// <summary>
        /// Приветстивие
        /// </summary>
        /// <param name="question"></param>
        /// <returns> "Привет, " + userName + "!" </returns>
        static string HelloBot(string question)
        {
            return "Здрасти, " + userName + ".";
        }

        /// <summary>
        /// Ответ на вопрос "Который час?"
        /// </summary>
        /// <param name="question"></param>
        /// <returns> "Сейчас: " + DateTime.Now.ToString("HH:mm") </returns>
        static string HowTime(string question)
        {
            return "Сейчас: " + DateTime.Now.ToString("HH:mm");
        }

        /// <summary>
        /// Ответ на вопрос "Какое сегодня число?"
        /// </summary>
        /// <param name="question"></param>
        /// <returns> "Сегодня: " + DateTime.Now.ToString("dd.MM.yy") </returns>
        static string HowDate(string question)
        {
            return "Кажется сегодня: " + DateTime.Now.ToString("dd.MM.yy");
        }

        /// <summary>
        /// Ответ на вопрос "Как дела?"
        /// </summary>
        /// <param name="question"></param>
        /// <returns> "Порядок!" или "Просто чудесно :)" </returns>
        static string HowAreYou(string question)
        {
            Random rnd = new Random();
            int value = rnd.Next();
            if (value % 2 == 0)         //разное от времени
                return "а сам как думаешь?";
            else
            {
                return "а разве до этого кому то есть дело?";
            }
        }
        /// <summary>
        /// Ответ на "Спасибо"
        /// </summary>
        /// <param name="question"></param>
        /// <returns> "Рад был помочь!" </returns>
        static string ThankYou(string question)
        {
            return "спасибом сыт не будешь";
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string MulPls(string question)
        {
            question = question.Replace(" ", ""); // удаляем все пробелы из вопроса
            question = question.Substring(question.LastIndexOf('ь') + 1); // убираем слово "умножь"
            string[] words = question.Split(new char[] { 'н', 'а' },
            StringSplitOptions.RemoveEmptyEntries); // разбиваем строку на две подстроки
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num1 * num2).ToString();
            }
            catch
            {
                return "Я не Эйнштейн, что бы понять что тут написано.";
            }
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string DivPls(string question)
        {
            question = question.Replace(" ", ""); // удаляем все пробелы из вопроса
            question = question.Substring(question.LastIndexOf('и') + 1); // убираем слово "раздели"
            string[] words = question.Split(new char[] { 'н', 'а' },
            StringSplitOptions.RemoveEmptyEntries); // разбиваем строку на две подстроки
            try
            {
                float num1 = Convert.ToInt32(words[0]);
                float num2 = Convert.ToInt32(words[1]);
                return (num1 / num2).ToString();
            }
            catch
            {
                return "Я не Эйнштейн, что бы понять что тут написано.";
            }
        }

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string PlusPls(string question)
        {
            question = question.Replace(" ", ""); // удаляем все пробелы из вопроса
            question = question.Substring(question.LastIndexOf('ж') + 2); // убираем слово "сложи"
            string[] words = question.Split(new char[] { 'и' },
            StringSplitOptions.RemoveEmptyEntries); // разбиваем строку на две подстроки
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num1 + num2).ToString();
            }
            catch
            {
                return "Я не Эйнштейн, что бы понять что тут написано.";
            }
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string SubPls(string question)
        {
            question = question.Replace(" ", ""); // удаляем все пробелы из вопроса
            question = question.Substring(question.LastIndexOf('т') + 2); // убираем слово "вычти"
            string[] words = question.Split(new char[] { 'и', 'з' },
            StringSplitOptions.RemoveEmptyEntries); // разбиваем строку на две подстроки
            try
            {
                int num1 = Convert.ToInt32(words[0]);
                int num2 = Convert.ToInt32(words[1]);
                return (num2 - num1).ToString();
            }
            catch
            {
                return "Я не Эйнштейн, что бы понять что тут написано.";
            }
        }

        /// <summary>
        /// Запрос на проверку погоды
        /// </summary>
        /// <param name="question"></param>
        /// <returns> Информацию о погоде </returns>
        static string WeatherPls(string question)
        {
            String[] infoWeather = FindOutWeather(); // возвращает массив строк с информацией о погоде
            if (infoWeather[0] != null) // если null, значит отсутствет подключение к интернету
            {
                return "Температура в городе " + infoWeather[0] + " " + infoWeather[1] + " °C"
                    + ", ветер " + infoWeather[2] + " м/c. Хорошая погода что бы оставить меня в покое";
            }
            else return "А кто то без  интернета...";
        }

        /// <summary>
        /// Запрос информации о погоде
        /// </summary>
        /// <returns></returns>
        static private String[] FindOutWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" +
                "Chita" + // <- здесь можно вставить любой город
                "&units=metric&appid=2856fc0f74411cd143093c7ac9b9a7a0";

            // инициализация WebRequest
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                // возврат ответа от интернет-ресурса
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                string responce;
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    responce = streamReader.ReadToEnd();
                }

                // конвертируем тип JSON в .NET тип
                WeatherResponse weather = JsonConvert.DeserializeObject<WeatherResponse>(responce);

                String[] infoWeather = { weather.Name,
                                        weather.Main.Temp.ToString(),
                                        weather.Wind.Speed.ToString() };
                return infoWeather;

            }
            catch
            {
                // в случае возникновения ошибки возвращаем пустой массив
                String[] error = { null };
                return error;
            }
        }

        /// <summary>
        /// Добавление переписки в файл
        /// </summary>
        /// <param name="answer"></param>
        public void AddToHistory(string[] answer)
        {
            history.AddRange(answer);
            File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
        }

        /// <summary>
        /// Загрузка истории из файла
        /// </summary>
        /// <param name="user"></param>
        public void LoadHistory(string user)
        {
            userName = user; // имя пользователя
            path = userName + ".txt"; // путь к файлу с историей сообщений

            try
            {
                // попытка загрузки существующей базы
                history.AddRange(File.ReadAllLines(path, Encoding.GetEncoding(1251)));

                // если файл был изменен не сегодня, то записываем новую дату переписки
                if (File.GetLastWriteTime(path).ToString("dd.MM.yy") !=
                    DateTime.Now.ToString("dd.MM.yy"))
                {
                    String[] date = new String[] {"\n\t\t\t" +
                        DateTime.Now.ToString("dd.MM.yy"+ "\n")};
                    AddToHistory(date);
                }
            }
            catch
            {
                // если файл не существует, создаем его
                File.WriteAllLines(path, history.ToArray(), Encoding.GetEncoding(1251));
                // отмечаем дату начала переписки
                String[] date = new String[] {"\t\t\t" +
                    DateTime.Now.ToString("dd.MM.yy")};
                AddToHistory(date);
            }
        }

        /// <summary>
        /// Переопределённый метод ответа пользователю
        /// </summary>
        /// <param name="userQuestion"></param>
        /// <returns></returns>
        public override string Answer(string userQuestion)
        {
            userQuestion = userQuestion.ToLower(); // переводим в нижний регистр

            for (int i = 0; i < regecies.Count; i++) // проходим по регулярным выражениям
            {
                if (regecies[i].IsMatch(userQuestion)) // ищем подходящее регулярное выражение
                {
                    funcBuf = func[i]; // сохраняем функцию по найденому индексу в буфер
                    return funcBuf(userQuestion); // возвращаем результат выполнения этой функции
                }
            }
            switch (rnd.Next(0,5))
            {
                case 0:
                    return "и я должен был это как то понять?";

                case 1:
                    return "а если понятней?";

                case 2:
                    return "не понял.";

                case 3:
                    return "я не понимаю тебя.";

                case 4:
                    return "что то пошло не так, ведь я ничего не понял.";

                case 5:
                    return "буду считать это значит что я хороший бот";
            }
            return "не понял.";
        }

    }
}
