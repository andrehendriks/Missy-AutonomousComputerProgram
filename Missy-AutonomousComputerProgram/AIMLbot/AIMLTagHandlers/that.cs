using System;
using System.Globalization;
using System.Text;
using System.Xml;

namespace AIMLbot.AIMLTagHandlers
{
    /// <summary>
    /// The template-side that element indicates that an AIML interpreter should substitute the 
    /// contents of a previous bot output. 
    /// 
    /// The template-side that has an optional index attribute that may contain either a single 
    /// integer or a comma-separated pair of integers. The minimum value for either of the integers 
    /// in the index is "1". The index tells the AIML interpreter which previous bot output should be 
    /// returned (first dimension), and optionally which "sentence" (see [8.3.2.]) of the previous bot
    /// output (second dimension). 
    /// 
    /// The AIML interpreter should raise an error if either of the specified index dimensions is 
    /// invalid at run-time. 
    /// 
    /// An unspecified index is the equivalent of "1,1". An unspecified second dimension of the index 
    /// is the equivalent of specifying a "1" for the second dimension. 
    /// 
    /// The template-side that element does not have any content. 
    /// </summary>
    public class that : AIMLbot.Utils.AIMLTagHandler
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="bot">The bot involved in this request</param>
        /// <param name="user">The user making the request</param>
        /// <param name="query">The query that originated this node</param>
        /// <param name="request">The request inputted into the system</param>
        /// <param name="result">The result to be passed to the user</param>
        /// <param name="templateNode">The node to be processed</param>
        public that(AIMLbot.Bot bot,
                        AIMLbot.User user,
                        AIMLbot.Utils.SubQuery query,
                        AIMLbot.Request request,
                        AIMLbot.Result result,
                        XmlNode templateNode)
            : base(bot, user, query, request, result, templateNode)
        {
        }

        protected override string ProcessChange()
        {
            if (this.templateNode.Name.ToLower(CultureInfo.CurrentCulture) == "that")
            {
                if (this.templateNode.Attributes.Count == 0)
                {
                    return this.user.getThat();
                }
                else if (this.templateNode.Attributes.Count == 1)
                {
                    if (this.templateNode.Attributes[0].Name.ToLower(CultureInfo.CurrentCulture) == "index")
                    {
                        if (this.templateNode.Attributes[0].Value.Length > 0)
                        {
                            try
                            {
                                // see if there is a split
                                string[] dimensions = this.templateNode.Attributes[0].Value.Split(",".ToCharArray());
                                if (dimensions.Length == 2)
                                {
                                    int result = Convert.ToInt32(dimensions[0].Trim(),CultureInfo.CurrentCulture);
                                    int sentence = Convert.ToInt32(dimensions[1].Trim(),CultureInfo.CurrentCulture);
                                    if ((result > 0) & (sentence > 0))
                                    {
                                        return this.user.getThat(result - 1, sentence - 1);
                                    }
                                    else
                                    {
                                        this.bot.writeToLog(Properties.Resource.String36 + this.templateNode.Attributes[0].Value + Properties.Resource.String37 + this.request.rawInput);
                                    }
                                }
                                else
                                {
                                    int result = Convert.ToInt32(this.templateNode.Attributes[0].Value.Trim(),CultureInfo.CurrentCulture);
                                    if (result > 0)
                                    {
                                        return this.user.getThat(result - 1);
                                    }
                                    else
                                    {
                                        this.bot.writeToLog(Properties.Resource.String38 + this.templateNode.Attributes[0].Value + Properties.Resource.String39 + this.request.rawInput);
                                    }
                                }
                            }
                            catch
                            {
                                this.bot.writeToLog(Properties.Resource.String40 + this.templateNode.Attributes[0].Value + Properties.Resource.String41 + this.request.rawInput);
                            }
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
