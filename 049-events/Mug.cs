using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_events
{
    class Mug
    {
        private string Label { get; set; }
        private Color MugColor { get; set; }
        private string Text { get; set; }
        private Color TextColor { get; set; }

        public Mug(string label, string text, Color mugColor, Color textColor)
        {
            Label = label;
            MugColor = mugColor;
            TextColor = textColor;
            Text = text;
        }

        public Mug(string label, string text)
        {
            Label = label;
            Text = text;
            MugColor = Color.WHITE;
            TextColor = Color.BLACK;
        }

        public Mug(string label)
        {
            Label = label;
            MugColor = Color.WHITE;
            TextColor = Color.BLACK;
        }

        public bool hasText()
        {
            return (Text != null);
        }

        public string mugColorToString()
        {
            return MugColor.ToString().ToLower();
        }

        public string textColorToString()
        {
            return TextColor.ToString().ToLower();
        }

        public string description()
        {
            return "[" + Label + "]: A " + mugColorToString() + " mug with " + textColorToString() + " text reading '" + Text + "'.";
        }

    }
}
