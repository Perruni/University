using System.Globalization;

namespace Tester
{
    public class UnitTest1
    {
        [Fact]
        public void birthday_test()
        {
            DateTime miNacimiento = new DateTime(2001, 12, 1);

            string mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(miNacimiento.Month);
            mes = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mes);

            string texto = ("Mi cumpleaños es el");            

            string miCumple = $"{texto} {miNacimiento.ToString("dddd dd/MMMM 'de' yyyy")}";

            miCumple = miCumple.Replace(miNacimiento.ToString("MMMM"), mes);

            Assert.Equal("Mi cumpleaños es el sábado 01/Diciembre de 2001", miCumple);

        }
    }
}