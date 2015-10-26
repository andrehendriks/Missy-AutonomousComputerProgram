using System;
using System.Collections.Generic;
using System.Text;

namespace AIMLbot
{
    public class SearchResult
    {
        public string url;
        public string title;
        public string content;
        public FindingEngine engine;

        

        
        

        public enum FindingEngine { google };

        public SearchResult(string url, string title, string content, FindingEngine engine)
        {
            this.url = url;
            this.title = title;
            this.content = content;
            this.engine = engine;

            
        }

       
    }

}
