using System.Globalization;

namespace PraticandoConceitos
{
    public class DataHora
    {
        public void RetornaDias()
        {
            //https://learn.microsoft.com/pt-br/dotnet/api/system.datetime.tostring?view=net-10.0
            //NÃO ESQUECER QUE ESSE RECOLHER DE DATAS E HORAS
            //DEVEM FICAR DENTRO DO METODO, POIS SE NÃO SERÃO ARMAZENADOS NA CRIAÇÃO DO OBJETO.
            DateOnly Dia = new DateOnly(2015, 03, 28);//DIA FIXO 
            string ArmazenaDiaFixo = Dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

            DateTime DiaComHoras = new DateTime(2015, 03, 28, 22, 02, 2);// DIA E HORÁRIO FIXO
            DateTime DiaExato = DateTime.Today;
            DateTime DiaComHorasExatas = DateTime.Now;
            DateTime DiaComUTC = DateTime.UtcNow; //Ele pega o horário atual em UTC (Tempo Universal Coordenado).
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);

            Console.WriteLine($"""
                HOJE = {hoje}
                Dia com Amazenamento fixo: {ArmazenaDiaFixo}
                Dia com horas fixo: {DiaComHoras}
                Dia Exato: {DiaExato}
                Dia com horas exatas do seu computador: {DiaComHorasExatas}
                Dia com precisão UTC:  {DiaComUTC}
                Adiciona dias: {DiaComUTC.AddDays(7)}
                """);
        }

        // This example displays the following output to the console:
        //       d: 6/15/2008
        //       D: Sunday, June 15, 2008
        //       f: Sunday, June 15, 2008 9:15 PM
        //       F: Sunday, June 15, 2008 9:15:07 PM
        //       g: 6/15/2008 9:15 PM
        //       G: 6/15/2008 9:15:07 PM
        //       m: June 15
        //       o: 2008-06-15T21:15:07.0000000
        //       R: Sun, 15 Jun 2008 21:15:07 GMT
        //       s: 2008-06-15T21:15:07
        //       t: 9:15 PM
        //       T: 9:15:07 PM
        //       u: 2008-06-15 21:15:07Z
        //       U: Monday, June 16, 2008 4:15:07 AM
        //       y: June, 2008
        //
        //       'h:mm:ss.ff t': 9:15:07.00 P
        //       'd MMM yyyy': 15 Jun 2008
        //       'dd/MMMM/yyyy': 15/Junho/2008 (CUSTOMIZAVEL!)
        //       'HH:mm:ss.f': 21:15:07.0
        //       'dd MMM HH:mm:ss': 15 Jun 21:15:07
        //       '\Mon\t\h\: M': Month: 6
        //       'HH:mm:ss.ffffzzz': 21:15:07.0000-07:00
    }
}
