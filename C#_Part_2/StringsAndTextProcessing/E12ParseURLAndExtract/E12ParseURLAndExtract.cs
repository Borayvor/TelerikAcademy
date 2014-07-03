using System;
using System.Text.RegularExpressions;

class E12ParseURLAndExtract
{
    static void Main ()
    {
        // Write a program that parses an URL address given in the format:
        // [protocol]://[server]/[resource]
        // and extracts from it the [protocol], [server] and [resource] elements. For example from the 
        // URL http://www.devbg.org/forum/index.php the following information should be extracted:
        // [protocol] = "http"
		// [server] = "www.devbg.org"
		// [resource] = "/forum/index.php"

        string url = "http://eurosport.yahoo.com/news/snooker-selby-trounces-murphy-reach-masters-final-172132169--spt.html";

        var fragments = Regex.Match (url, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine ("[protocol] = {0}", fragments[1]);
        Console.WriteLine ("[server] = {0}", fragments[2]);
        Console.WriteLine ("[resource] = {0}", fragments[3]);
    }
}
