namespace microsoftLearnExercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string data = "12345John Smith          5000  3  ";
            //string updatedData = data.Remove(5, 20);
            //Console.WriteLine(updatedData);

            //string message = "This--is--ex-amp-le--da-ta";
            //message = message.Replace("--", " ");
            //message = message.Replace("-", "");
            //Console.WriteLine(message);

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";


            const string spanStartTag = "<span>";
            const string spanCloseTag = "</span>";

            int spanStartIndex = input.IndexOf(spanStartTag) + spanStartTag.Length;
            int spanCloseIndex = input.IndexOf(spanCloseTag);
            int spanValueLength = spanCloseIndex - spanStartIndex;
            quantity = input.Substring(spanStartIndex, spanValueLength);
            Console.WriteLine($"Quantity:\t{quantity}");

            const string tradeSymbol = "&trade";
            const string regSymbol = "&reg";
            output = input.Replace(tradeSymbol, regSymbol);

            const string openDiv = "<div>";
            int divStart = output.IndexOf(openDiv);
            output = output.Remove(divStart, openDiv.Length);

            const string closeDiv = "</div>";
            int divCloseStart = output.IndexOf(closeDiv);
            output = output.Remove(divCloseStart, closeDiv.Length);



            Console.WriteLine($"Output:\t\t{output}");
        }
    }
}
