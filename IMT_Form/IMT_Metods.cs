namespace IMT_Form
{
    internal class PersonIMT
    {

        /*
           Отредактировать класс PersonIMT следующим образом:
           1. добавить поле пол пользователя
           2. добавить конструкторы класса - без полей, с одним полем - имя, со всеми полями. 
           3. добавить метод SetDimens устанавливающий значения всех параметров и проводящий проверку корректности ввода по следующим правилам:
              пол может быть только male или female
              возраст не более 110 лет
              рост не более 220 см 
              вес не более 200 кг
              нижние границы данных параметров продумайте и обоснуйте самостоятельно. 
           4. Добавить перегрузку метода SetDimens без поля имя и проверки корректности ввода.
           5. Добавить метод Check, проверяющий корректность введенного роста, пола, возраста, веса. По результатам работы метод возвращает логическое
              значение true у случае полной корректности ввода или false, если есть ошибки. 
           6. классу PersonIMT добавить поле result и метод Recomendations, который будет рассчитывтаь ИМТ для мужчин и сообщать 
              реузльтат в виде "диагноза", например "Hypotrophy 2 level", а также метод будет сообщать ИМТ и суть ошибки при попытке вызвать метод для пользователя
              женского пола. 
           7. Создать в классе Main объект класса PersonIMT с помощью конструктора по умолчанию, задать женский пол продемонстрировать на нем работу методов
              SetDimens(со всеми параметрами); ShowInfo и Recomendations (в случае если  метод  Check вернет true)
           8. Создать третий объект класса PersonIMT с помощью конструктора по умолчанию, задать мужской пол. высокий рост и средний вес,
              аналогично предыдущему пункту если метод Check вернет true вызвать методы ShowInfo и Recomendations.
           9. Создать четвертый объект класса PersonIMT с помощью конструктора со всеми параметрами, задать мужской пол, низкий рост, большой вес. Аналогично предыдущему пункту если метод Check 
              вернет true вызвать методы ShowInfo и Recomendations.
           10. Создать пятый объект класса PersonIMT с помощью конструктора с одним параметром. Вызвать для него метод SetDimens, установить женский пол
              аналогично предыдущему пункту если метод Check вернет true вызвать методы ShowInfo и Recomendations.
           11. Для ранее созданного (первого) пользователя добавить его пол и провести аналогичную проверку - если метод Check вернет true вызвать методы ShowInfo и Recomendations.
         */


        public double age;
        public double weight;
        public double height;
        public string name;
        public string gender;
        public string result = "";

        /// <summary>
        /// Конструктор, принимающий все необходимые параметры
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="age">Возраст</param>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        public PersonIMT(string name, string gender, double age, double height,
               double weight)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        /// <summary>
        /// Рассчет ИМТ и сообщает диагноз (пока только для лиц мужского пола)
        /// </summary>
        /// <returns> Диагноз </returns>
        public string Recomendations()
        {
            double imt = weight / (Math.Pow(height, 2) / 10000);
            if (gender == "m")
            {
                Console.WriteLine($"IMT = {imt} ");
                string result = "normal";
                if (imt < 16)
                {
                    result = "Hypotrophy III level\n";
                }
                else if (imt >= 16 && imt < 17)
                {
                    result = "Hypotrophy II level\n";
                }
                else if (imt >= 17 && imt < 18.5)
                {
                    result = "Hypotrophy I level\n";
                }
                else if (imt >= 18.5 && imt < 20.7)
                {
                    result = "normal weight\n";
                }
                else if (imt >= 20.7 && imt < 23.9)
                {
                    result = "Ideal weight\n";
                }
                else if (imt >= 23.9 && imt < 28.6)
                {
                    result = "Obesity I level\n";
                }
                else if (imt >= 28.6 && imt < 39)
                {
                    result = "Obesity II level\n";
                }
                else if (imt >= 39)
                {
                    result = "Obesity III level\n";
                }
                return result;
            }
            else
                return "IMT = " + imt + ". It's work only for male\n";
        }

    }
}
