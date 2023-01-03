using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace AliorPesel.Pages
{
    public class IndexModel : PageModel
    {
        // konstuktor klasy ClientInfo
        public ClientInfo clientInfo = new ClientInfo();
        // zmienne wyświetlające komunikaty
        public string errorMessage = "";
        public string successMessage = "";
        public string congratulation = "";

        // metoda wykonująca swoje instrukcje po wprowadzeniu zmian na stronie
        public void OnPost()
        {
            // odnosnik do inputów w kodzie HTML
            clientInfo.name = Request.Form["name"];
            clientInfo.secoundName = Request.Form["secoundName"];
            clientInfo.ID = Request.Form["ID"];

            // sprawdzenie czy klient wpisał wszystkie dane, jeśli nie wyskakuje komunikat
            if (clientInfo.name.Length == 0 || clientInfo.secoundName.Length == 0 ||
               clientInfo.ID.Length == 0)
            {
                errorMessage = "Proszę wypełnić wszystkie pola";
                return;
            }
            // sprawdzenie czy klient poprawnie wprowadził swój pesel, jeśli nie wyskakuje komunikat
            if (clientInfo.ID.Any(char.IsSymbol) ||  clientInfo.ID.Any(char.IsLetter) || clientInfo.ID.Length != 11)
            {
                errorMessage = "Prosze wprowadzić poprawnie swój pesel";
                return;
            }
            // sprawdzenie czy klient poprawnie wprowadził swoje imie i nazwisko, jeśli nie wyskakuje komunikat
            if (clientInfo.name.Any(char.IsSymbol) || clientInfo.name.Any(char.IsDigit) || clientInfo.secoundName.Any(char.IsSymbol) || clientInfo.secoundName.Any(char.IsDigit))
            {
                errorMessage = "Pola z imieniem i nazwiskiem mogą zawierać tylko litery";
                return;
            }
            try
            {
                // pobieranie danych z peselu
                int yearID = Convert.ToInt32(clientInfo.ID.Substring(0, 2));
                int monthID = Convert.ToInt32(clientInfo.ID.Substring(2, 2));
                int dayID = Convert.ToInt32(clientInfo.ID.Substring(4, 2));

                // pobranie dzisiejszej daty
                int yearNow = DateTime.Now.Year;
                int monthNow = DateTime.Now.Month;
                int dayNow = DateTime.Now.Day;

                // warunki sprawdzające w jakim stóleciu urodził się klient, oraz ustala wiek
                int age = 0;
                if (monthID > 80)
                {
                    monthID = monthID - 80;
                    yearID = yearID + 1800;
                }
                else if (monthID <= 12)
                {
                    yearID = yearID + 1900;
                    age = yearNow - yearID;
                }
                else if (monthID > 20 && monthID <= 32)
                {
                    monthID = monthID - 20;
                    yearID = yearID + 2000;
                }
                else if (monthID > 40 && monthID <= 52)
                {
                    monthID = monthID - 40;
                    yearID = yearID + 2100;
                }
                else if (monthID > 60 && monthID <= 72)
                {
                    monthID = monthID - 60;
                    yearID = yearID + 2200;
                }

                age = yearNow - yearID;
                // warunak sprawdza czy w danym roku był już miesiąc urodziń lub czy jest
                if (monthNow <= monthID)
                {
                    // warunek sprawdza czy jest aktualnie miesiac urodzin i czy jest bądz minął dzień urodzin klienta,
                    // jeśli nie to zmienia wartość lat klienta o jeden
                    if (monthID == monthNow && dayNow < dayID)
                    { 
                    }
                    else
                    {
                        age --;
                    }
                }
                successMessage = " Wiek wynosi: " + age + " lat, ";
                // warunki liczące promocje, oraz przypisanie komunikatu w w zależności od płuci klienta
                double promotion = 0;
                if (monthNow == monthID && dayNow == dayID)
                {
                    promotion = 10;
                    if (Convert.ToInt32(clientInfo.ID.Substring(9, 1)) % 2 == 0)
                    {
                        congratulation = "Klientko " + clientInfo.name + " " + clientInfo.secoundName + "! Życzymy Ci sto lat!";

                    }
                    else
                    {
                        congratulation = "Kliencie " + clientInfo.name + " " + clientInfo.secoundName + "! Życzymy Ci sto lat!";
                    }
                }
                else if (monthNow == monthID)
                {
                    promotion = 5;
                }
                else if (monthNow < 2 || monthNow > 9)
                {
                    promotion = 2.5;
                }
                successMessage = successMessage + "promocja wynosi: " + promotion + "%.";
            }
            catch (Exception ex)
            {
                // wyświetlenie informacji w przypadku uruchomienia warunku
                errorMessage = ex.Message;
                return;
            }

            // kasowanie inputów po kliknięciu submit
            clientInfo.name = "";
            clientInfo.secoundName = "";
            clientInfo.ID = "";
        }

        public void OnGet()
        {

        }
    }

    public class ClientInfo
    {
        public string name = "";
        public string secoundName = "";
        public string ID = ""; 
    }
}