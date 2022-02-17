
string namePlayer;
int counterOfAttempts = 0;
int counter = 0;
int userNumber;
int secretNumber;
int exit = 0;
bool isWin = false;
Console.WriteLine("Добро пожаловать в игру \" Угадай число \"");

do
{
    Console.Write("Введите ваше имя: ");
    namePlayer = Console.ReadLine().ToUpperInvariant();
    if (namePlayer.Length == 0 && counter == 0) Console.WriteLine("Похоже вас никак не зовут вы пустое место))) Давай те придумаем хоть какое-нибудь имя. ");
    else if (string.IsNullOrWhiteSpace(namePlayer) && counter == 1) Console.WriteLine("Это не имя а пробелы в жизни какие-то ))))");
    else if (namePlayer.Length == 0 && counter == 2) 
    {
        Console.WriteLine("Даю последний шанс.");
        Console.Write("Введите ваше имя: ");
        namePlayer = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(namePlayer)) Console.WriteLine("Хорошо пустое место так пустое место, настаивать не буду. Нажмите Enter что-бы продолжить.");
        else
        {
            Console.WriteLine($"{namePlayer}? Странное имя ну да ладно начнем начнем игру. Нажмите Enter что-бы продолжить.");
        }
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"{namePlayer}? Странное имя ну да ладно начнем игру.  Нажмите Enter что-бы продолжить.");
        counter = 2;
        Console.ReadKey();
    }
    counter++;
} while (counter != 3);
Console.Clear();



do
{
    while (!isWin)
    {

        if (exit == 0)
        {
            secretNumber = new Random().Next(0, 1000);
            do
            {
                counterOfAttempts++;
                Console.Write("Введите число от 0 до 999 загаданное мной: ");
                if (int.TryParse(Console.ReadLine(), out userNumber))
                {
                    if (secretNumber == userNumber)
                    {
                        Console.WriteLine($"Поздравляю {namePlayer} вы угадали с {counterOfAttempts} попытки");
                        isWin = true;
                    }
                    int res = 0;
                    if (userNumber > secretNumber)
                    {
                        res = userNumber - secretNumber;
                    }
                    else
                    {
                        res = secretNumber - userNumber;
                    }
                    if (userNumber > 999 || userNumber < 0) Console.WriteLine($"Нужно ввести чисто от 0 до 999. Вы ввели {userNumber}");
                    else if (res > 100) Console.WriteLine("Ну очень холодно");
                    else if (res <= 90 && res >= 80) Console.WriteLine("Теплее");
                    else if (res <= 80 && res >= 70) Console.WriteLine("Уже можно снять куртку");
                    else if (res <= 70 && res >= 60) Console.WriteLine("Теплее можно снимать шапку");
                    else if (res <= 60 && res >= 50) Console.WriteLine("Ух!!! а в свиторке то жарко.");
                    else if (res <= 50 && res >= 40) Console.WriteLine("В фуболке уже стоять можно.");
                    else if (res <= 40 && res >= 30) Console.WriteLine("Пожалуй поменяю штаны на шорты.");
                    else if (res <= 30 && res >= 20) Console.WriteLine("Начинает припекать");
                    else if (res <= 20 && res >= 10) Console.WriteLine("Пора готовить веник для баньки)))))");
                    else if (res <= 10 && res >= 5) Console.WriteLine("Ну очень жарко");
                    else if (res == 5) Console.WriteLine("Адище!!!!!!!!!!!");
                    else if (res == 4) Console.WriteLine("Гоооооооорюююююю помогите!!!!!!!!!!!");
                    else if (res == 3) Console.WriteLine("Почти Почти Почти Почти!!!!!!!!!!!");
                    else if (res == 2) Console.WriteLine("Ну вот вот уже!!!!!!!!!!!");
                    else if (res < 1) Console.WriteLine("Нууууууууууууууууууууууууууууууууууууууууууууууууу!!!!!!!!!!!");


                }
                else
                {
                    Console.WriteLine("Вы ввели не число попробуйте снова.Нажмите Enter что-бы продолжить.");
                    Console.ReadKey();
                }

            } while (secretNumber != userNumber);
        }

    }

    Console.WriteLine("Введите 0 чтобы сыграть еще раз");
    Console.WriteLine("Введите 1 чтобы закончить игру");
    if (int.TryParse(Console.ReadLine(), out exit))
    {
        if (exit == 0)
        {
            Console.WriteLine("Поееееееееехххххалиии!!!!!!!!!!!");
            isWin = false;
        }
        else if (exit == 1)
        {
            Console.WriteLine($"Отличная была игра {namePlayer.ToUpper()}, удачи!");
            isWin = true;
        }
        else if (exit > 1)
        {
            Console.WriteLine("Вы ввели не 1 или 0 попробуйте снова.Нажмите Enter что-бы продолжить.");
            Console.ReadKey();
        }

    }
    else
    {
        Console.WriteLine("Вы ввели не 1 или 0 попробуйте снова.Нажмите Enter что-бы продолжить.");
        Console.ReadKey();
    }

} while (!isWin);
