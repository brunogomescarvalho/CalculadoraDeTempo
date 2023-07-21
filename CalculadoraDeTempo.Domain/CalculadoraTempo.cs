namespace CalculadoraDeTempo.Domain
{
    public class CalculadoraTempo
    {
        public string ObterTempoString(DateTime data)
        {
            TimeSpan intervaloDeTempo = (DateTime.Now.Subtract(data));

            string tempo;

            if (intervaloDeTempo < TimeSpan.FromMinutes(1))
            {
                tempo = $"{intervaloDeTempo.Seconds} segundos";
            }

            else if (intervaloDeTempo < TimeSpan.FromHours(1))
            {
                tempo = $"{intervaloDeTempo.Minutes} {(intervaloDeTempo.Minutes <= 1 ? "minuto" : "minutos")}";
            }

            else if (intervaloDeTempo < TimeSpan.FromDays(1))
            {
                tempo = $"{intervaloDeTempo.Hours} {(intervaloDeTempo.Hours <= 1 ? "hora" : "horas")}";
            }

            else if (intervaloDeTempo < TimeSpan.FromDays(7))
            {
                tempo = $"{intervaloDeTempo.Days} {(intervaloDeTempo.Days <= 1 ? "dia" : "dias")}";
            }

            else if (intervaloDeTempo < TimeSpan.FromDays(30))
            {
                tempo = ObterSemanas(intervaloDeTempo);
            }

            else
            {
                tempo = ObterMeses(intervaloDeTempo);
            }

            return $"O teste foi realizado a {tempo} atrás";

        }

        private string ObterSemanas(TimeSpan intervaloDeTempo)
        {
            var totalDias = Math.Round(intervaloDeTempo.TotalDays);

            int semana = (int)totalDias / 7;
            int dias = (int)totalDias % 7;

            return $"{semana} {(semana == 1 ? "semana" : "semanas")} {(dias > 0 ? $"e {(dias == 1 ? $"{dias} dia" : $"{dias} dias")}" : "")}";


        }

        private string ObterMeses(TimeSpan intervaloDeTempo)
        {
            var totalDias = Math.Round(intervaloDeTempo.TotalDays);

            long meses = (long)totalDias / 30;
            long semanas = (long)totalDias % 30;

            int semana = (int)semanas / 7;
            int dias = (int)semanas % 7;

            return $"{meses} {(meses == 1 ? "mês" : "meses")} {(semana > 0 ? $"{semana} {(semana == 1 ? "semana" : "semanas")}" : "")} {(dias > 0 ? $"e {(dias == 1 ? $"{dias} dia" : $"{dias} dias")}" : "")}";
        }
    }
}

    
