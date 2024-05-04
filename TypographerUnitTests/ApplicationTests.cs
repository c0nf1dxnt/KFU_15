using TypographerProject;

namespace TypographerUnitTests
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void TestRule2()
        {
            var inputString = "Привет,     как дела?";

            var expectedString = "Привет, как дела?";

            var form = new TypographerForm();

            var actual = form.ApplyRule2(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestRule3()
        {
            var inputString = "\"Текст в ёлочках\"";

            var expectedString = "«Текст в ёлочках»";

            var form = new TypographerForm();

            var actual = form.ApplyRule3(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestRule5()
        {
            var inputString = "Супер - кот";

            var expectedString = "Супер-кот";

            var form = new TypographerForm();

            var actual = form.ApplyRule5(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestRule9()
        {
            var inputString = "На разработку данного проекта уйдёт +- 5 дней.";

            var expectedString = "На разработку данного проекта уйдёт ± 5 дней.";

            var form = new TypographerForm();

            var actual = form.ApplyRule9(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestRule13()
        {
            var inputString = "Да, это жёстко...";

            var expectedString = "Да, это жёстко…";

            var form = new TypographerForm();

            var actual = form.ApplyRule13(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestAbsurdRule()
        {
            var inputString = "кот";

            var expectedString = "котик";

            var form = new TypographerForm();

            var actual = form.ApplyRetardedButCuteRule(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestCustomRule1()
        {
            var inputString = "Коты крутые. очень";

            var expectedString = "Коты крутые. Очень";

            var form = new TypographerForm();

            var actual = form.ApplyCustomRule1(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestCustomRule2()
        {
            var inputString = "Причины крутости котов:милые, красивые, мягкие";

            var expectedString = "Причины крутости котов: милые, красивые, мягкие";

            var form = new TypographerForm();

            var actual = form.ApplyCustomRule2(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestAllRules()
        {
            var inputString = "-Привет.  как выглядит твой кот? он ведь:мягкий, красивый и милый?";

            var expectedString = "-Привет. Как выглядит твой котик? он ведь: мягкий, красивый и милый?";

            var form = new TypographerForm();

            var actual = form.ApplyTypographerRules(inputString);

            Assert.AreEqual(expectedString, actual);
        }
        [TestMethod]
        public void TestTextChangedEvent()
        {
            var form = new TypographerForm();

            form.inputRichTextBox.Text = "Финальный тест";

            form.ChangedInputRichTextBox(null, EventArgs.Empty);

            Assert.AreEqual(form.outputRichTextBox.Text, form.ApplyTypographerRules(form.inputRichTextBox.Text));
        }
    }
}