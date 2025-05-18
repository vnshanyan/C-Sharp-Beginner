using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //**Практичные задачи на логические и побитовые операторы**
            //1: Умный дом: управление системой безопасности
            //Ввод:
            //* `isDoorClosed`, `isWindowClosed`, `isAlarmArmed` (вводится как `"yes"`/`"no"`)
            //Если **все** закрыто **и** сигнализация активна → `Дом под охраной`.
            //Если дверь или окно открыты при активной сигнализации → `Сработала тревога!`.

            Console.WriteLine("Дверь закрыта??");
            string isDoorClosed = Console.ReadLine();
            Console.WriteLine("Окно закрыто?");
            string isWindowClosed = Console.ReadLine();
            Console.WriteLine("Сигнализация активна?");
            string isAlarmArmed = Console.ReadLine();
            if(isDoorClosed == "yes" && isWindowClosed == "yes" && isAlarmArmed == "yes")
            {
                Console.WriteLine("Дом под охраной");
            }
            else if((isDoorClosed != "yes" || isWindowClosed != "yes") && isAlarmArmed == "yes")
            {
                Console.WriteLine("Сработала тревога!");
            }

            //2: Геймпад: дешифратор нажатий
            //Каждая кнопка — бит:
            //* A = 1(`0001`)
            //* B = 2(`0010`)
            //* X = 4(`0100`)
            //* Y = 8(`1000`)
            //Ввод: число 0–15 — комбинация нажатий.
            //Вывести, какие кнопки нажаты, используя `&`.

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Give a number (0-15):");
                int pressedKey = int.Parse(Console.ReadLine());
                if ((pressedKey & (1 << 0)) != 0)
                {
                    Console.WriteLine("A");
                }
                else if ((pressedKey & (1 << 1)) != 0)
                {
                    Console.WriteLine("B");
                }
                else if ((pressedKey & (1 << 2)) != 0)
                {
                    Console.WriteLine("X");
                }
                else if ((pressedKey & (1 << 3)) != 0)
                {
                    Console.WriteLine("Y");
                }
            }

            //3: Диагностика автомобиля
            //Ввод флагов системы(1 = неисправность, 0 = в норме):
            //* `engine`, `brakes`, `airbag`, `abs`
            //Объедините флаги в одно число:
            //`status = (engine << 3) | (brakes << 2) | (airbag << 1) | abs`
            //Выведите битовую строку статуса и диагноз(по битам).

            Console.WriteLine("Enter engine status:");
            int engineStatus = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brakes status:");
            int brakesStatus = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Airbag status:");
            int airbagStatus = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ABS status:");
            int absStatus = int.Parse(Console.ReadLine());

            int status = (engineStatus << 3) | (brakesStatus << 2) | (airbagStatus << 1) | absStatus;
            int engine = 1 << 3;
            int brake = 1 << 2;
            int airbug = 1 << 1;
            int abs = 1 << 0;
            string binary = Convert.ToString(status, toBase: 2);
            if((status & engine) != 0)
            {
                Console.WriteLine("Engine Fault!");
            }
            if((status & brake) != 0)
            {
                Console.WriteLine("Brakes Fault!");
            }
            if ((status & airbug) != 0)
            {
                Console.WriteLine("Airbug Fault!");
            }
            if ((status & abs) != 0)
            {
                Console.WriteLine("ABS Fault!");
            }
            Console.WriteLine(binary);

            //4: Генерация чека со скидками
            //Ввод:
            //*Цена
            //* Есть ли промокод(`"yes"`/`"no"`)
            //*Покупка в выходной(`"yes"`/`"no"`)
            //Если оба условия выполняются → скидка 20 %, иначе 10 % или 0 %.
            //Используй логические операторы для расчёта.

            Console.WriteLine("Price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Promo code:");
            string promoCode = Console.ReadLine();
            Console.WriteLine("Weekend purchase?");
            string weekendPurchase = Console.ReadLine();
            if(promoCode == "yes" && weekendPurchase == "yes")
            {
                Console.WriteLine($"Price: {price - price * 0.2}");
            }
            else if(promoCode == "yes" || weekendPurchase == "yes")
            {
                Console.WriteLine($"Price: {price - price * 0.1}");
            }
            else
            {
                Console.WriteLine($"Price: {price}");
            }

            //5: 🧠 Мини - капча с битами
            //Сгенерируй два случайных числа(1–15).
            //Покажи их в двоичном виде.
            //Пользователь вводит `AND`, `OR` или `XOR`.
            //Применить соответствующий оператор, показать результат в двоичном виде.

            int randomNumber1 = new Random().Next(1, 16);
            int randomNumber2 = new Random().Next(1, 16);
            Console.WriteLine(Convert.ToString(randomNumber1, 2));
            Console.WriteLine(Convert.ToString(randomNumber2, 2));
            Console.WriteLine("Which logical operator?");
            string logicalOperator = Console.ReadLine();
            switch (logicalOperator)
            {
                case "AND":
                    Console.WriteLine(randomNumber1 & randomNumber2);
                    break;
                case "OR":
                    Console.WriteLine(randomNumber1 | randomNumber2);
                    break;
                case "XOR":
                    Console.WriteLine(randomNumber1 ^ randomNumber2);
                    break;
            }

            //6: 💡 Контроллер освещения
            //3 комнаты: кухня, зал, ванная.
            //Ввод: `isKitchenLightOn`, `isHallLightOn`, `isBathroomLightOn`.
            //Сформируй целое число(битовая маска), где каждый бит — свет в комнате.
            //Выведи итоговую маску и дешифруй включённые лампы.

            Console.WriteLine("Is kitchen light on?");
            string isKitchenLightOn = Console.ReadLine();
            Console.WriteLine("Is hall light on?");
            string isHallLightOn = Console.ReadLine();
            Console.WriteLine("Is bathroom light on?");
            string isBathroomLightOn = Console.ReadLine();

            bool kitchen = (isKitchenLightOn == "yes");
            bool hall = (isHallLightOn == "yes");
            bool bathroom = (isBathroomLightOn == "yes");
            int mask = 0;

            if(kitchen)
            {
                mask |= (1 << 2);
            }
            if(hall)
            {
                mask |= (1 << 1);
            }
            if (bathroom)
            {
                mask |= (1 << 0);
            }
            Console.WriteLine($"Binary: {Convert.ToString(mask, 2)}");

            if((mask & (1 << 2)) != 0)
            {
                Console.WriteLine("Kitchen light is on!");
            }
            if ((mask & (1 << 1)) != 0)
            {
                Console.WriteLine("Hall light is on!");
            }
            if ((mask & (1 << 0)) != 0)
            {
                Console.WriteLine("Bathroom light is on!");
            }
            if (mask == 0)
            {
                Console.WriteLine("All lights are off!");
            }

            //7: 🔒 Генератор прав доступа
            //Каждому ресурсу присвоен бит:
            //    *Read = 1
            //    * Write = 2
            //    * Execute = 4
            //Вводит админ: какие права дать(например: `read, write`)
            //Сформировать итоговую маску(int) и вывести её.
            //Позже пользователь вводит значение и проверяется, есть ли `Write` → `mask & 2 != 0`

            Console.WriteLine("Give read access?");
            string readAccess = Console.ReadLine();
            Console.WriteLine("Give write access?");
            string writeAccess = Console.ReadLine();
            Console.WriteLine("Give execute access?");
            string executeAccess = Console.ReadLine();

            bool isRead = readAccess == "yes";
            bool isWrite = writeAccess == "yes";
            bool isExecute = executeAccess == "yes";

            int read = 1 << 0;
            int write = 1 << 1;
            int execute = 1 << 2;
            int mask = 0;
            if(isRead)
            {
                mask |= read;
            }
            if (isWrite)
            {
                mask |= write;
            }
            if (isExecute)
            {
                mask |= execute;
            }
            Console.WriteLine($"Mask: {Convert.ToString(mask, 2)}");

            if((mask & read) != 0)
            {
                Console.WriteLine("Give read access!");
            }
            if((mask & write) != 0)
            {
                Console.WriteLine("Give write access!");
            }
            if ((mask & execute) != 0)
            {
                Console.WriteLine("Give execute access!");
            }
            if(mask == 0)
            {
                Console.WriteLine("No Access.");
            }

            //8: 🔍 Идентификатор смены бита
            //Вводятся два числа.
            //Найти позицию первого отличающегося бита(используй `^` и побитовый сдвиг + маску).

            Console.WriteLine("Write first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number:");
            int number2 = int.Parse(Console.ReadLine());

            int LogicalXOROperation = number1 ^ number2;
            if(LogicalXOROperation == 0)
            {
                Console.WriteLine("Numbers are identical.");
                return;
            }

            int position = 0;
            while((LogicalXOROperation & 1) == 0)
            {
                LogicalXOROperation = 1 << 0;
                position++;
            }
            Console.WriteLine($"Position: {position}");

            //9: 📡 Передача сигнала
            //Устройство принимает 4 - битные пакеты.
            //Ввод: 4 значения `b1 b2 b3 b4` (0 или 1)
            //Собери число: `(b1 << 3) | (b2 << 2) | (b3 << 1) | b4`
            //Выведи результат в десятичном и двоичном виде.

            Console.WriteLine("Enter firtst value (1/0):");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value (1/0):");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value (1/0):");
            int b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth value (1/0):");
            int b4 = int.Parse(Console.ReadLine());
            int mask = (b1 << 3) | (b2 << 2) | (b3 << 1) | b4;
            Console.WriteLine($"Mask: {Convert.ToString(mask, 2)}");
            Console.WriteLine($"Mask: {mask}");

            //10: 🎯 Детектор условий доступа
            //Пользователь вводит:
            //* `IsEmployee` (`yes`/`no`)
            //* `HasBadge`
            //* `HasKeycard`
            //Доступ разрешён, если:
            //*Сотрудник * *и * *(есть пропуск** или**ключ - карта)
            //Реализуй проверку с `&&` и `||`.

            Console.WriteLine("IsEmployee?");
            string isEmployee = Console.ReadLine();
            Console.WriteLine("Hasbadge?");
            string hasBadge = Console.ReadLine();
            Console.WriteLine("HasKeycard?");
            string hasKeycard = Console.ReadLine();

            if(isEmployee == "yes" && (hasBadge == "yes" || hasKeycard == "yes"))
            {
                Console.WriteLine("Has Access.");
            }
            else
            {
                Console.WriteLine("No Access");
            }

            //**Продвинутые задачи — логические и побитовые операторы**
            //11: 🔐 Генератор PIN-кодов по флагам
            //Пользователь вводит флаги(0 или 1):
            //* `needDigits`, `needLetters`, `needSymbols`, `isTemporary`
            //На основе битовой маски `(needDigits << 3) | (needLetters << 2) | (needSymbols << 1) | isTemporary`
            //Сформируй и расшифруй конфигурацию PIN - кода.

            Console.WriteLine("Need digits?");
            int needDigits = int.Parse(Console.ReadLine());
            Console.WriteLine("Need symbols?");
            int needSymbols = int.Parse(Console.ReadLine());
            Console.WriteLine("Need letters?");
            int needLetters = int.Parse(Console.ReadLine());
            Console.WriteLine("Is temporary?");
            int isTemporary = int.Parse(Console.ReadLine());

            int mask = (needDigits << 3) | (needLetters << 2) | (needSymbols << 1) | isTemporary;
            Console.WriteLine($"Mask: {mask}");

            if((mask & (1 << 3)) != 0)
            {
                Console.WriteLine("Includes digits");
            }
            if ((mask & (1 << 2)) != 0)
            {
                Console.WriteLine("Includes letters");
            }
            if ((mask & (1 << 1)) != 0)
            {
                Console.WriteLine("Includes symbols");
            }
            if ((mask & (1 << 0)) != 0)
            {
                Console.WriteLine("Is temporary");
            }

            //12: 🌡️ Температурный сенсор
            //Сенсор передаёт 8 - битное значение:
            //*старшие 4 бита = градусы(0–15)
            //* младшие 4 бита = десятые градуса(0–9)
            //Ввод: одно целое число 0–255
            //Вывести температуру в формате: `X.Y °C`
            //Пример: `0b10100011` = `10.3 °C`

            Console.WriteLine("Enter sensor value: ");
            int value = int.Parse(Console.ReadLine());
            int degrees = value >> 4;       // upper 4 bits //4-7
            int tenths = value & 0b00001111;    // lower 4 bits //0-3 max 15
            Console.WriteLine($"\nBinary: 0b{Convert.ToString(value, 2).PadLeft(8, '0')}");
            Console.WriteLine($"Temperature: {degrees}.{tenths} °C");

            //13: 🎥 Система доступа к фильму
            //Ввод:
            //*возраст
            //* есть ли подписка(yes/ no)
            //*рейтинг фильма(G, PG, R)
            //Проверить:
            //*Если `R` → нужен возраст ≥ 18 и подписка
            //*Если `PG` → ≥13 или подписка
            //*Если `G` → доступен всем
            //Используй логические условия и флаги.
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Subscription:");
            string subscription = Console.ReadLine();
            Console.WriteLine("Movie rating:");
            string movieRating = Console.ReadLine();

            switch(movieRating)
            {
                case "R":
                    if(age >= 18 && subscription == "yes")
                    {
                        Console.WriteLine("Access granted");
                    }
                    break;
                case "PG":
                    if (age >= 13 || subscription == "yes")
                    {
                        Console.WriteLine("Access granted");
                    }
                    break;
                case "G":
                    Console.WriteLine("Access granted");
                    break;
                default:
                    Console.WriteLine("Access deny.");
                    break;
            }

            //14: 🚦 Светофор с битами
            //Ввод: одно число от 0 до 7
            //Каждый бит = цвет:
            //Красный = 1(0001)
            //Жёлтый = 2(0010)
            //Зелёный = 4(0100)
            //Выведи активные цвета.
            Console.WriteLine("Enter one number from 0 to 7");
            int number = int.Parse(Console.ReadLine());

            int red = 1 << 0;
            int yellow = 1 << 1;
            int green = 1 << 2;

            if((number & red) != 0)
            {
                Console.WriteLine("Red is active");
            }
            if((number & yellow) != 0)
            {
                Console.WriteLine("Yellow is active");
            }
            if((number & green) != 0)
            {
                Console.WriteLine("Green is active");
            }

            //15: 🧬 Гены и мутации
            //Ввод 2 бинарных гена(0–15)
            //*Найди, какие биты различаются(XOR)
            //* Определи, сколько мутаций(подсчёт установленных битов)
            Console.WriteLine("Enter number1 from 0 to 15:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2 from 0 to 15");
            int second = Convert.ToInt32(Console.ReadLine());
            int XOR = first ^ second;
            int mutationCount = 0;
            int temp = XOR;
            while (temp != 0)
            {
                mutationCount += temp & 1;
                temp >>= 1;
            }
            Console.WriteLine($"Count: {mutationCount}, Mutations: {Convert.ToString(XOR, 2)}");

            //16: 🎫 Проверка QR-пропуска
            //Пользователь вводит 8 - битный пропуск
            //* 1 - й бит = действует ли
            //* 2 - й = платный
            //* 3 - й = временный
            //* 4 - й = VIP
            //Проверь действительность и статус(используй побитовые операторы)

            Console.WriteLine("Enter QR pass:");
            int QRPass = int.Parse(Console.ReadLine());

            int valid = 1 << 0;
            int paid = 1 << 1;
            int temporary = 1 << 2;
            int vip = 1 << 3;

            bool isValid = (QRPass & valid) != 0;
            bool isPaid = (QRPass & paid) != 0;
            bool isTemporary = (QRPass & temporary) != 0;
            bool isVip = (QRPass & valid) != 0;

            if (isValid)
            {
                Console.WriteLine("Valid!");
            }
            if(isPaid)
            {
                Console.WriteLine("Paid!");
            }
            if(isTemporary)
            {
                Console.WriteLine("Temporary!");
            }
            if(isVip)
            {
                Console.WriteLine("VIP!");
            }

            //17: 🖥️ BIOS - настройки
            //Ввод настроек(0–255). Каждый бит — включён ли параметр:
            //Bit 0: USB boot
            //Bit 1: Secure Boot
            //Bit 2: Virtualization
            //Bit 3: Fast Boot
            //Проверь и выведи включённые опции.

            Console.WriteLine("Enter BIOS settings value:");
            int settingsValue = int.Parse(Console.ReadLine());

            int usbBoot = 1 << 0;
            int secureBoot = 1 << 1;
            int virtualization = 1 << 2;
            int fastBoot = 1 << 3;

            bool isUsbBoot = (settingsValue & usbBoot) != 0;
            bool isSecureBoot = (settingsValue & secureBoot) != 0;
            bool isVirtualization = (settingsValue & virtualization) != 0;
            bool isFastBoot = (settingsValue & fastBoot) != 0;
            if (isUsbBoot)
            {
                Console.WriteLine("USB Boot!");
            }
            if (isSecureBoot)
            {
                Console.WriteLine("Secure Boot!");
            }
            if (isVirtualization)
            {
                Console.WriteLine("Virtualization!");
            }
            if (isFastBoot)
            {
                Console.WriteLine("Fast Boot!");
            }

            //18: ⌚ Планировщик уведомлений
            //Уведомления кодируются 7 битами(1 – включено в день):
            //Пн = 1, Вт = 2, ..., Вс = 64
            //Пользователь вводит число(например, 5 = Пн и Ср)
            //Проверь, запланировано ли уведомление на Сб → `(value & 32) != 0`

            Console.WriteLine("Write number:");
            int day = int.Parse(Console.ReadLine());
            if ((day & 1) != 0) Console.WriteLine("Monday");
            if ((day & 2) != 0) Console.WriteLine("Tuesday");
            if ((day & 4) != 0) Console.WriteLine("Wednesday");
            if ((day & 8) != 0) Console.WriteLine("Thursday");
            if ((day & 16) != 0) Console.WriteLine("Friday");
            if ((day & 32) != 0) Console.WriteLine("Saturday");
            if ((day & 64) != 0) Console.WriteLine("Sunday");

            //19: 📶 Wi - Fi модуль
            //Ввод:
            //4 флага состояния: сигнал, доступ, DNS, прокси
            //Сформируй статус и выведи в виде `0bXXXX`
            //Покажи статус по каждому флагу.

            Console.WriteLine("Signal ok? (0 or 1): ");
            int signal = int.Parse(Console.ReadLine());
            Console.WriteLine("Access ok? (0 or 1): ");
            int access = int.Parse(Console.ReadLine());
            Console.WriteLine("DNS ok? (0 or 1): ");
            int dns = int.Parse(Console.ReadLine());
            Console.WriteLine("Proxy ok? (0 or 1): ");
            int proxy = int.Parse(Console.ReadLine());

            int status = (signal << 3) | (access << 2) | (dns << 1) | proxy;
            Console.WriteLine($"Status: 0b{Convert.ToString(status, 2)}");

            Console.WriteLine($"Signal: {(signal == 1 ? "Ok" : "Fail")}");
            Console.WriteLine($"Access: {(access == 1 ? "Ok" : "Fail")}");
            Console.WriteLine($"DNS: {(dns == 1 ? "Ok" : "Fail")}");
            Console.WriteLine($"proxy: {(proxy == 1 ? "Ok" : "Fail")}");

            //20: 🕹️ Контроллер cheat mode
            //Игрок вводит код в виде числа
            //Если установлены одновременно биты 1(jump) и 4(invincibility) → включить чит-режим
            //Если только один — дать подсказку, какой бит включить
            Console.WriteLine("Code: ");
            int code = int.Parse(Console.ReadLine());
            bool isJump = (code & (1 << 1)) != 0;
            bool isInvinicibility = (code & (1 << 4)) != 0;
            if (isJump && isInvinicibility)
            {
                Console.WriteLine("Active cheat mode.");
            }
            else if (isJump)
            {
                Console.WriteLine("Hint: Turn on invincibility.");
            }
            else if (isInvinicibility)
            {
                Console.WriteLine("Hint: Turn on jump.");
            }
        }
    }
}
