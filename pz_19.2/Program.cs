using System.Text.RegularExpressions;

namespace pz_19._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "213.180.195.231 - - [29/Jan/2007:00:07:17 +0000] \"GET /excel/lsn015.html HTTP/1.1\" 200 18918 \"-\r\n\" \"YaDirectBot/1.0\"\r\n" +
               "74.6.71.37 - - [29/Jan/2007:00:13:03 +0000] \"GET /eralash HTTP/1.0\" 301 317 \"-\" \"Mozilla/5.0\r\n(compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)\"\r\n" +
               "74.6.71.37 - - [29/Jan/2007:00:13:06 +0000] \"GET /eralash/ HTTP/1.0\" 200 12234 \"-\" \"Mozilla/5.0\r\n(compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)\"\r\n" +
               "213.186.116.166 - - [29/Jan/2007:00:26:51 +0000] \"GET /eralash/soft/speed.zip HTTP/1.0\" 200\r\n217872 \"-\" \"Wget/1.10.2 (Red Hat modified)\"\r\n" +
               "213.180.207.25 - - [29/Jan/2007:00:27:14 +0000] \"GET /robots.txt HTTP/1.1\" 200 54 \"-\"\r\n\"Yandex/1.01.001 (compatible; Win16; I)\"";

            File.AppendAllText("D:\\connects.txt", s);

            string file = @"D:\connects.txt";

            string pattern = @"\d{3}.\d{3}.\d{3}.\d{3}";
            Regex regex = new Regex(pattern);

            foreach (Match m in regex.Matches(file))
            {
                Console.WriteLine("IP: " + m.Value);
            }

            string pattern2 = @"\d{2}/\w+/\d{4}";
            Regex regex2 = new Regex(pattern2);

            foreach (Match m in regex2.Matches(file))
            {
                Console.WriteLine("Date: " + m.Value);
            }
        }
    }
}