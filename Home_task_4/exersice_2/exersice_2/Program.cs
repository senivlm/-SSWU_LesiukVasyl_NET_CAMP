namespace exersice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "simple@example.com very.common@example.com disposable.style.email.with+symbol@example.com other.email-with-hyphen@example.com fully-qualified-domain@example.com user.name+tag+sorting@example.com (може перейти до вхідних повідомлень user.name@example.com залежно від поштового сервера) x@example.com (локальна частина з однією буквою) example-indeed@strange-example.com admin@mailserver1 (локальне доменне ім'я без TLD, хоча ICANN дуже відлякує бездоганні електронні адреси[5]) example@s.example (див. Список Інтернет-доменів вищого рівня) \" \"@example.org (пробіл між цитатами) \"john..doe\"@example.org (цитується подвійна крапка) mailhost!username@example.org (гангфікований маршрут хоста, який використовується для пошти uucp) user%example.com@example.org (% user%example.com@example.org маршруту пошти до user@example.com через example.org)" 
                + "Abc.example.com (без символу @)\r\nA@b@c@example.com (тільки один @ дозволений поза лапок)\r\na\"b(c)d,e:f;g<h>i[j\\k]l@example.com (жоден із спеціальних символів у цій локальній частині не допускається поза лапок)\r\njust\"not\"right@example.com (just\"not\"right@example.com рядки повинні бути розділені крапками або єдиний елемент, що складається з локальної частини)\r\nthis is\"not\\allowed@example.com (пробіли, лапки та косої риски можуть існувати лише тоді, коли в цитованих рядках і передує зворотна косої риски)\r\nthis\\ still\\\"not\\\\allowed@example.com (навіть якщо уникнути (передує зворотній косої риси), пробіли, лапки та косої риски все одно повинні міститись лапками)\r\n1234567890123456789012345678901234567890123456789012345678901234+x@example.com (місцева частина довша 64 символів)\r\ni_like_underscore@but_its_not_allow_in _this_part.example.com (Підкреслення заборонено в частині домену)";
            EmailValidator emailValidator = new EmailValidator();
            emailValidator.FindEmail(text);
            Console.WriteLine(emailValidator);
        }
    }
}