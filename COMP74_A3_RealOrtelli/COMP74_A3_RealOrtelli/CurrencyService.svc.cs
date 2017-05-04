using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;


namespace COMP74_A3_RealOrtelli
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CurrencyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CurrencyService.svc or CurrencyService.svc.cs at the Solution Explorer and start debugging.
    public class CurrencyService : ICurrencyService
    {
        Excel.Application excelApp = null;
        Excel._Worksheet workSheet = null;
        Excel._Workbook workBook = null;
        Excel.Range countriesRange;
        Excel.Range currencyRange;
        Excel.Range currencyCodeRange;
        string[] countries = null;
        string[] currency = null;
        string[] currencyCode = null;

        public CurrencyService()
        {
            excelApp = new Excel.Application();
            excelApp.Visible = false;
        }

        public string[] getCurrencies()
        {
            try
            {
                workBook = excelApp.Workbooks.Open(@"C:\Users\rortelli27\Desktop\COMP74A3RealOrtelli\COMP74_A3_RealOrtelli\currency.xlsx");

                workSheet = workBook.Sheets["data"];
                currencyRange = workSheet.Range["B3", "B168"];

                currency = new string[currencyRange.Count];

                for (int i = 0; i < currencyRange.Count; i++)
                {
                    currency[i] = currencyRange.get_Item(i).Text;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (workBook != null) workBook.Close(0);
                if (excelApp != null) excelApp.Quit();
            }

            return currency;
        }

        public string[] getCountries()
        {
            try
            {
                workBook = excelApp.Workbooks.Open(@"C:\Users\rortelli27\Desktop\COMP74A3RealOrtelli\COMP74_A3_RealOrtelli\currency.xlsx");

                workSheet = workBook.Sheets["data"];

                countriesRange = workSheet.Range["A3", "A168"];

                countries = new string[countriesRange.Count];

                for (int i = 0; i < countries.Length; i++)
                {
                    countries[i] = countriesRange.get_Item(i).Text;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (workBook != null) workBook.Close(0);
                if (excelApp != null) excelApp.Quit();
            }

            return countries;
        }

        public string[] getCurrencyCodes()
        {
            try
            {
                workBook = excelApp.Workbooks.Open(@"C:\Users\rortelli27\Desktop\COMP74A3RealOrtelli\COMP74_A3_RealOrtelli\currency.xlsx");

                workSheet = workBook.Sheets["data"];

                currencyCodeRange = workSheet.Range["C3","C168"];

                currencyCode = new string[currencyCodeRange.Count];

                for (int i = 0; i < currencyCode.Length; i++)
                {
                    currencyCode[i] = currencyCodeRange.get_Item(i).Text;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (workBook != null) workBook.Close(0);
                if (excelApp != null) excelApp.Quit();
            }

            return currencyCode;
        }

        private void close()
        {
            workBook.Close();
            excelApp.Quit();
        }

    }
}
