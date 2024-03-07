using Lab4VisualProg;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Text.RegularExpressions;

//////1 ПОдсчёт почтовых индексов
RegularExpressions words = new RegularExpressions();
string papper = "Я отправил письма по почтовым индексам: 454312, 141242, 331219, 13541341. Ой последнее неправильно";
int count = words.PostCount(papper);
Console.WriteLine($"Задание 1:\n{papper}\nЧисло почтовых индексов: "+count+"\n\n");


//////2 Перестановка первой и последней буквы слова
RegularExpressions glossary = new RegularExpressions();
string wordsSecond = "В предметной области строительного предприятия требования пользователей могут варьироваться в зависимости от конкретных потребностей и характера проектов";
Console.WriteLine($"Задание 2:\n{glossary.Replaceble(wordsSecond)}\n\n");


//////3 
RegularExpressions numbers = new RegularExpressions();
string phoneNumber = "Звнили по номеру +7 (863) 297-51-11, я его переадресовал на следущий номер: +7 (8633) 456-43";
Console.WriteLine($"Задание 3:\n{numbers.HideNumber(phoneNumber)}\n\n");


//////4
RegularExpressions autoText = new RegularExpressions();
string textOfAuto = "Автомобиль с номером С227НА22, мотоцикл с номером 8776АЕ64 и машина должностного лица с номером А134АА обнаружены";
Console.WriteLine($"Задание 4:\n{autoText.FindAutoNum(textOfAuto)}\n\n");


//////5
RegularExpressions iP = new RegularExpressions();
string textOfip = "Мы обнаружили IP-адреса: 192.168.0.1 и 10.0.0.1. А может и 1000.231.2141. или 1.1.1.1";
Console.WriteLine($"Задание 5:\n{iP.ReturnIp(textOfip)}");


/////6 доп
RegularExpressions PhoneNum = new RegularExpressions();
Console.WriteLine($"Задание 6 доп:\n{PhoneNum.CorrectPhoneNumber("+79999794444")}");
Console.WriteLine($"\n{PhoneNum.CorrectPhoneNumber("82214124232")}");
Console.WriteLine($"\n{PhoneNum.CorrectPhoneNumber("2214124232")}");