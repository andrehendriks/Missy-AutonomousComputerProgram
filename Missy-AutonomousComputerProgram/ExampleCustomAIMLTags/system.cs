using System;
using System.Text;
using AIMLbot.Utils;
using System.Globalization;

namespace ExampleCustomAIMLTags
{
    [CustomTag]
    public class system : AIMLTagHandler
    {
        public system()
        {
            this.inputString = "testtag";
        }

        protected override string ProcessChange()
        {
            if (this.templateNode.Name.ToLower(CultureInfo.CurrentCulture) == "system")
            {
                return "Override default tag implementation works correctly";
            }
            return string.Empty;
        }
    }
}
