// Опросник: из 4 ответов 1 верный

int countQuestion = 3; //кол-во вопросов
int countAnswer = 4; //кол-во ответов на 1 вопрос
int count = 0; // счетчик вопросов
int num = 0; // номер ответа

string[] Question = new string[]{"Содержание вопроса1", "Содержание вопроса2", "Содержание вопроса3"};

string[,] variantAnswer = new string[3,4]{{"Ответ1", "Ответ2", "Ответ3", "Ответ4"}, 
{"Ответ1", "Ответ2", "Ответ3", "Ответ4"}, {"Ответ1", "Ответ2", "Ответ3", "Ответ4"}};

bool [,] etalonAnswer = new bool[3,4]{{false, true, false, false}, 
{false, false, true, false}, {true, false, false, false}};

bool [,] Answer = new bool[3,4]{{false, false, false, false}, 
{false, false, false, false}, {false, false, false, false}};


int i = 0;

while (count < countQuestion)
{
    Console.WriteLine($" Вопрос {count+1} {Question[count]}");
    
    if (i < countQuestion)
    {
        for(int j = 0; j < countAnswer; j++)
    {
        Console.WriteLine($"{variantAnswer[i,j]}");
    }
    }
    Console.WriteLine("Введите цифру номера ответа - ");
    num = int.Parse(Console.ReadLine())-1;
    Answer[count,num] = true; // отмечаем в массиве позицию выбранного вопроса

    

    if (Answer[count,num] == etalonAnswer[count,num])
    {
        Console.WriteLine("правильный ответ");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("неправильный ответ");
        Console.WriteLine();
    }
    count++;
}    
