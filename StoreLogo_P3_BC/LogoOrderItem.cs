using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StoreLogo_P3_BC
{
    internal class LogoOrderItem
    {
        private bool _hasLogo;
        private string _itemType;
        private int _numColors;
        private int _numItems;
        private string _text;

        public bool HasLogo
        {
            get { return _hasLogo; }

            set { _hasLogo = value; Calc(); }
        }

        public string itemType
        {
            get { return _itemType; }

            set { _itemType = value; Calc(); }
        }

        public int NumColors
        {
            get { return _numColors; }

            set { _numColors = value; Calc(); }
        }


        public int NumItems
        {
            get { return _numItems; }

            set { _numItems = value; Calc(); }
        }

        public string Text
        {
            get { return _text; }

            set { _text = value; Calc(); }
        }

        public int ItemID { get; private set; } = -1;

        public decimal Price { get; private set; }


        public LogoOrderItem(bool HasLogo, string Text) : this(HasLogo, " ", 0, 0, Text)
        {
        }

        public LogoOrderItem() : this(false, " ", 0, 0, "")
        {
        }

        public LogoOrderItem(bool hasLogo, string itemType, int numColors, int numItems, string text)
        {

            _hasLogo = hasLogo;
            _itemType = itemType;
            _numColors = numColors;
            _numItems = numItems;
            _text = text;
            Calc();

        }

        private void Calc()
        {

            Price = 10.00M;

        }

        public override string ToString()
        {
            string summary =
                $"Item Type: {itemType}, Number of Colors: {NumColors}, " +
                $"Number of Items: {NumItems}, Text: {Text}, Total Price: ${Price:0.##}";

            return summary;

        }
    }
}
