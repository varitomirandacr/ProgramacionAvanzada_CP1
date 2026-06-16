using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AP.Core
{
    // access modifiers
    // 

    public class Semana02 : SemanaBase
    {
        // miembros / variables
        private int _num;
        private long _time;
        private float _num2;
        private double _num3;
        private decimal _num4;
        private string _name;
        private DateTime _date;
        private bool _isCorrect;

        // propiedades / publicas 
        // se pueden accesar desde cualquier otra clase
        public int Num 
        { 
            get { return _num; } 
            set { _num = value; } 
        }

        public long Time { get; set; }
        public float Num2 { get; set; }
        public double Num3 { get; set; }
        public decimal Num4 { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsCorrect { get; set; } = true;

        // constructor de la clase
        public Semana02()
        {
           
        }

        // metodos
        // method signature (firma del metodo)
        public int GetNum(int target) 
        { 
            _num = target;
            return _num; 
        }

        public long GetTime() { return _time; }
        public float GetNum2() { return _num2; }
        public double GetNum3() { return _num3; }
        public decimal GetNum4() { return _num4; }
        public string GetName() { return _name; }
        public DateTime GetDate() { return _date; } 
        public bool GetIsCorrect () { return _isCorrect; } 


        public string GetName(string text) 
        { 
            return text.Substring(0, 10);  
        }

        public string GetName(IEnumerable<string> texts, int textsIndex)
        {
            return texts.FirstOrDefault();
        }

        public string GetName(string text, IEnumerable<string> texts, int textsIndex)
        {
            if (!string.IsNullOrEmpty(text))
                return text.Substring(0, 10);

            if (texts != null && texts.Any())
                return texts.ToList()[textsIndex];

            return string.Empty;
        }
    }
}
