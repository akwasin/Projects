using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_7
{
    class Va
    {
        private string questionMark;
        private double inflection;

        public double Inflection
        {
            get
            {
                return inflection;
            }

            set
            {
                var validValue = value >= 3.0 && value <= 17.00;
                if (validValue)
                    inflection = value;
                else
                    throw new Exception("wrong value");
            }
        }

        public string QuestionMark
        {
            get
            {
                return questionMark;
            }

            set
            {
                var firstCharIsUppercase = value[0].ToString().ToUpper() == value[0].ToString();
                var endsWithQuestionmark = value[value.Length - 1] == '?';
                var validValue = value != null &&
                    firstCharIsUppercase &&
                    endsWithQuestionmark;
                if (validValue)
                {
                    questionMark = value;
                }
                else
                {
                    throw new Exception("QuestionMark got an invalid value!");
                }
            }
        }

        public Va()
        {
            QuestionMark = questionMark;
            Inflection = 8.0;
        }

        public Va(string questionmark)
        {
            QuestionMark = questionMark;
            Inflection = 8.0;
        }

        public Va(string questionmark, double inflection)
        {
            QuestionMark = questionMark;
            Inflection = inflection;
        }

        public override string ToString()
        {
            return $"Questionmark: {QuestionMark} Inflection: {Inflection}";
        }
    }
}
