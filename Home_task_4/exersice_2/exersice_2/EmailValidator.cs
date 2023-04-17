using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_2
{
    public class EmailValidator
    {
        private List<string> validEmails;
        private List<string> invalidEmails;

        public EmailValidator()
        {
            validEmails = new List<string>();
            invalidEmails = new List<string>();
        }

        public void FindEmail(string text)
        {

            foreach (string word in text.Split(' '))
            {
                if (word.Contains('@'))
                {
                    if (IsValidEmail(word))
                    {
                        validEmails.Add(word);
                    }
                    else
                    {
                        invalidEmails.Add(word);
                    }
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            // Перевіряємо, чи є символ "@" в рядку
            if (!email.Contains("@"))
            {
                return false;
            }

            // Розділяємо рядок email на локальну частину та домен
            string[] parts = email.Split('@');
            string localPart = parts[0];
            string domain = parts[1];

            // Перевіряємо довжину локальної частини та домену
            if (localPart.Length > 64 && localPart.Length < 0 || domain.Length > 255 && domain.Length < 0)
            {
                return false;
            }

            // Перевіряємо, що локальна частина та домен містять лише дозволені символи
            string allowedCharsLocal = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&'*+-/=?^_`{|}~.";
            string allowedCharsDomain = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-.";

            foreach (char c in localPart)
            {
                if (!allowedCharsLocal.Contains(c))
                {
                    return false;
                }
            }

            foreach (char c in domain)
            {
                if (!allowedCharsDomain.Contains(c))
                {
                    return false;
                }
            }

            // Перевіряємо, що крапка не з'являється на початку чи в кінці локальної частини та домену
            if (localPart.StartsWith(".") || localPart.EndsWith(".") || domain.StartsWith(".") || domain.EndsWith("."))
            {
                return false;
            }

            // Перевіряємо, що крапка не з'являється послідовно у локальній частині
            for (int i = 0; i < localPart.Length - 1; i++)
            {
                if (localPart[i] == '.' && localPart[i + 1] == '.')
                {
                    return false;
                }
            }

            return true;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Valid emails:");
            foreach (string email in validEmails)
            {
                sb.AppendLine(email);
            }
            sb.AppendLine();
            sb.AppendLine("Invalid emails:");
            foreach (string email in invalidEmails)
            {
                sb.AppendLine(email);
            }
            return sb.ToString();
        }
    }
}
