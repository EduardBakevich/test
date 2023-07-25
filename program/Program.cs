/*Написать программу, которая из заданного массива строк 
([“Hello”, “2”, “world”, “:-)”]) сформирует массив 
из строк, длина которых меньше либо равна 3 символам.*/

string[] initialArray = new string[] {“Hello”, “2”, “world”, “:-)”};
string[] sortArray = new string[initialArray.Length];
void Sort (string[] initialArray, string[] sortArray)
{
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
    if(initialArray[i].Length <= 3)
        {
        sortArray[count] = initialArray[i];
        count++;
        }
    }
}
