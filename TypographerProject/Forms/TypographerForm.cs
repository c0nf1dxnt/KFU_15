using System.Text.RegularExpressions;

namespace TypographerProject
{
    public partial class TypographerForm : Form
    {
        #region Методы
        /// <summary>
        /// Методя для применения к тексту всех существующих правил
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyTypographerRules(string inputText)
        {
            inputText = ApplyRule2(inputText);
            inputText = ApplyRule3(inputText);
            inputText = ApplyRule9(inputText);
            inputText = ApplyRule13(inputText);
            inputText = ApplyRule16(inputText);

            inputText = ApplyRetardedButCuteRule(inputText);
            inputText = ApplyCustomRule1(inputText);
            inputText = ApplyCustomRule2(inputText);


            return inputText;
        }
        /// <summary>
        /// Метод, реализующий правило №2.
        /// Нельзя писать подряд более одного пробела.
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyRule2(string inputText)
        {
            return Regex.Replace(inputText, @"\s+", " ");
        }
        /// <summary>
        /// Метод, реализующий правило №3.
        /// Ни в коем случае нельзя использовать в качестве кавычек, т. н. кавычки программистов «"».
        /// В русском языке этик кавычек нет. Вместо них нужно использовать кавычки «ёлочки». Создаются они так: «Ёлочки»
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyRule3(string inputText)
        {
            return Regex.Replace(inputText, "\"(.*?)\"", "«$1»");
        }
        /// <summary>
        /// Метод, реализующий правило №9.
        /// Символ «плюс-минус» задаётся так: ± не нужно использовать конструкции типа «(+,−)».
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyRule9(string inputText)
        {
            return inputText.Replace("+-", "±");
        }
        /// <summary>
        /// Метод, реализующий правило №13.
        /// Везде где имеется троеточие, его следует писать не тремя точками, а знаком...
        /// Например: чтобы получить «Молчат...нет ответа...» нужно писать «Молчат...нет ответа...»
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyRule13(string inputText)
        {
            return inputText.Replace("...", "…");
        }
        /// <summary>
        /// Метод, реализующий правило №16.
        /// Между тире и предыдущим словом желательно всегда ставитьнепереносимый пробел,
        /// чтобы не было ситуаций, когда новая строка начинается с тире.
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyRule16(string inputText)
        {
            return Regex.Replace(inputText, @"\s+-\s+", "-");
        }
        /// <summary>
        /// Метод, реализующий абсурдное правило.
        /// Правило: слово кот запрещено использовать, оно всегда заменяется на котик.
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyRetardedButCuteRule(string inputText)
        {
            return Regex.Replace(inputText,@"\bкот\b", "котик", RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// Метод, реализующий уникальное правило №1.
        /// Правило: слова после точки с пробелом должны начинаться с большой буквы
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyCustomRule1(string inputText)
        {
            return Regex.Replace(inputText, @"(?<=\.\s)\p{Ll}", m => m.Value.ToUpper());
        }
        /// <summary>
        /// Метод, реализующий уникальное правило №2.
        /// Правило: после двоеточия всегда должен быть пробел
        /// </summary>
        /// <param name="inputText">Текст</param>
        /// <returns>Исправленный текст</returns>
        public string ApplyCustomRule2(string inputText)
        {
            return Regex.Replace(inputText, @":(?!\s)", ": ");
        }
        #endregion

        #region События
        public void ChangedInputRichTextBox(object sender, EventArgs e)
        {
            var inputText = inputRichTextBox.Text;

            outputRichTextBox.Text = ApplyTypographerRules(inputText);

            numberOfSymbolsLabel.Text = $"Количество символов: {inputRichTextBox.Text.Count()}";
        }

        private void PasteTextIntoInputRichTextBox(object sender, MouseEventArgs e)
        {
            inputRichTextBox.Paste();
        }

        private void CopyTextFromOutputRichTextBox(object sender, MouseEventArgs e)
        {
            outputRichTextBox.Copy();
        }
        #endregion

        #region Конструкторы
        public TypographerForm()
        {
            InitializeComponent();
        }
        #endregion

    }
}
