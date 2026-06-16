using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Core
{
    public class Semana04
    {
    }

    public class Semana03
    {
        private readonly int _generic;
        private readonly Semana04 _semana04;

        public Semana03(Semana04 semana04) 
        {
            _generic = 0;
            _semana04 = semana04;
        }

        public void CreateWeek()
        {
            // Performance penalty
            dynamic test = "";

            // strongly typed / fuertemente typeado
            string[] items = new string[7];
            var items2 = new string[4];
            
            // Instancia / instantiate
            var semana02 = new Semana02();
            var result = semana02.GetDetails();            
        }
    }
}
