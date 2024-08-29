// Complete a challenge to extract, replace, and remove data from an input string

using System;

class Program
{
    static void Main()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        // Initialize variables
        string quantity = "";
        string output = "";

        // Extract the quantity between <span> and </span>
        int startSpan = input.IndexOf("<span>") + "<span>".Length;
        int endSpan = input.IndexOf("</span>");
        quantity = input.Substring(startSpan, endSpan - startSpan);

        // Remove <div> and </div> tags and replace &trade; with &reg;
        output = input.Replace("<div>", "").Replace("</div>", "");
        output = output.Replace("&trade;", "&reg;");

        // Print the results
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Output: {output}");
    }
}


// Review the solution
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here

// // Extract the "quantity"
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
// int quantityEnd= input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);
// quantity = $"Quantity: {quantity}";

// // Set output to input, replacing the trademark symbol with the registered trademark symbol
// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);

// // Remove the opening <div> tag
// const string openDiv = "<div>";
// int divStart = output.IndexOf(openDiv);
// output = output.Remove(divStart, openDiv.Length);

// // Remove the closing </div> tag and add "Output:" to the beginning
// const string closeDiv = "</div>";
// int divCloseStart = output.IndexOf(closeDiv);
// output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

// Console.WriteLine(quantity);
// Console.WriteLine(output);