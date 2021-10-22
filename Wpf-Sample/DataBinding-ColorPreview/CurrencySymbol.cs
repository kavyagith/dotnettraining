using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace DataBinding_ColorPreview
{
    public class CurrencySymbol : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return string.Format("{0} {1}", Symbol, Value); //return this value to whoever ask.
        }

        public string currency;
        public string Value
        {
            get
            {
                return currency.ToString();
            }
            set
            {
                currency = value;
            }
        }

        public string Symbol { get; set; }
        
        public CurrencySymbol()
        {
            Symbol = "₹";
            currency = "2000";
        }

    }
}
