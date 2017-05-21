using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiAOD_LR4
{
    public class StackSettings
    {
        public string Decision(string str)
        {
            MyStack<char> stack = new MyStack<char>();
            string getStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                // Если скобка закрывается то циклом выводим все знаки что остались
                // в get строку между этими скобками, ну и удаляем открывающую скобку
                if (str[i] == ')')
                {
                    while (stack.Count != 0 && stack.Peek() != '(')
                        getStr += stack.Pop();
                    if (stack.Count != 0 && stack.Peek() == '(')
                        stack.Pop();
                }
                else
                // если знак то выводим 1 последин элемент из стека
                // и добавляем этот знак на вершину стека
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    if (stack.Count != 0 && !IsPrioritySymbol(str[i], stack.Peek()) && stack.Peek() != '(')
                        getStr += stack.Pop();
                    stack.Push(str[i]);
                }
                else
                // добавление не знака, числа или переменной
                    if (str[i] != '(')
                    getStr += str[i];
                else
                // тут же добавление открывающейся скобки
                // открывающаяся скобка добавляется лишь
                // для того что бы при нахождении закрывающейся
                // скобки обозначить нграницу чтения стека
                // так как в степе после этой скобки могут быть ещё знаки
                    if (str[i] == '(')
                    stack.Push(str[i]);
            }
            // может возникнуть ситуация что в стеке останутся знаки
            // выводим их все в строку пока стек не занулится
            while (stack.Count != 0)
                getStr += stack.Pop();
            return getStr;
        }

        // проверка приоритетности знаков * /
        // относительно знаков + -
        private bool IsPrioritySymbol(char index, char peek)
        {
            if ((index == '*' || index == '/') && (peek == '+' || peek == '-'))
                return true;
            else return false;
        }
    }
}