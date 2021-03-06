using System.IO;
using System;
class ArrayPrinter
{
    #region Declarations

    static bool isLeftAligned = false;
    const string cellLeftTop = "┌";
    const string cellRightTop = "┐";
    const string cellLeftBottom = "└";
    const string cellRightBottom = "┘";
    const string cellHorizontalJointTop = "┬";
    const string cellHorizontalJointbottom = "┴";
    const string cellVerticalJointLeft = "├";
    const string cellTJoint = "┼";
    const string cellVerticalJointRight = "┤";
    const string cellHorizontalLine = "─";
    const string cellVerticalLine = "│";

    #endregion

    #region Private Methods

    private static int[] GetMaxCellWidths(string[,] arrValues)
    {
        int columns = arrValues.GetLength(1);
        int[] result = new int[columns];

        for (int i = 0; i < arrValues.GetLength(1); i++)
        {
            for (int j = 0; j < arrValues.GetLength(0); j++)
            {
                int length = arrValues[j, i].Length;
                if (arrValues[j, i].StartsWith("#"))
                {
                    length = length - 2;
                }
                if (length > result[i])
                {
                    result[i] = length;
                }
            }
        }

        return result;
    }

    private static string GetDataInTableFormat(string[,] arrValues)
    {
        string formattedString = string.Empty;

        if (arrValues == null)
            return formattedString;

        int dimension1Length = arrValues.GetLength(0);
        int dimension2Length = arrValues.GetLength(1);

        int[] maxCellWidths = GetMaxCellWidths(arrValues);

        int width = dimension2Length + 2;
        for (int i = 0; i < dimension2Length; i++)
        {
            width += maxCellWidths[i];
        }

        //if (width > Console.WindowWidth)
        //  Console.WindowWidth = width;

        try
        {
            if (width > Console.BufferWidth)
                Console.BufferWidth = width;
        }
        catch { }//Some consoles does not accept that parameter

        int indentLength = width - 3;

        Console.ForegroundColor = ConsoleColor.Yellow;
        string headerAsterisk = "*".PadRight(width, '*');
        string tableTitle = "Test Results:".PadLeft(width / 2, ' ');
        tableTitle = tableTitle.PadRight(width - 2, ' ');
        Console.WriteLine(headerAsterisk);
        Console.WriteLine("*" + tableTitle + "*");
        Console.WriteLine(headerAsterisk);

        Console.ResetColor();

        //printing top line;
        Console.Write(string.Format("{0}{1}{2}{3}", cellLeftTop, Indent(indentLength), cellRightTop, System.Environment.NewLine));
        formattedString = string.Format("{0}{1}{2}{3}", cellLeftTop, Indent(indentLength), cellRightTop, System.Environment.NewLine);

        for (int i = 0; i < dimension1Length; i++)
        {
            string lineWithValues = cellVerticalLine;
            Console.Write(cellVerticalLine);
            string line = cellVerticalJointLeft;
            for (int j = 0; j < dimension2Length; j++)
            {
                string value = arrValues[i, j];
                if (value.Contains("#"))
                {
                    int pos = value.IndexOf("#");
                    if (value[pos + 1] == 'r')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        value = value.Replace("#r", "");
                    }
                    else if (value[pos + 1] == 'g')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        value = value.Replace("#g", "");
                    }
                    else if (value[pos + 1] == 'y')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        value = value.Replace("#y", "");
                    }
                    else
                        Console.ResetColor();
                }
                else
                    Console.ResetColor();

                value = (isLeftAligned) ? value.PadRight(maxCellWidths[j], ' ') : value.PadLeft(maxCellWidths[j], ' ');

                Console.Write(value);
                Console.ResetColor();
                Console.Write(cellVerticalLine);

                lineWithValues += string.Format("{0}{1}", value, cellVerticalLine);
                line += Indent(maxCellWidths[j]);
                if (j < (dimension2Length - 1))
                {
                    line += cellTJoint;
                }
            }
            line += cellVerticalJointRight;
            Console.WriteLine();
            formattedString += string.Format("{0}{1}", lineWithValues, System.Environment.NewLine);
            if (i < (dimension1Length - 1))
            {
                Console.WriteLine(line);
                formattedString += string.Format("{0}{1}", line, System.Environment.NewLine);
            }
        }

        //printing bottom line
        Console.ResetColor();
        formattedString += string.Format("{0}{1}{2}{3}", cellLeftBottom, Indent(indentLength), cellRightBottom, System.Environment.NewLine);
        Console.WriteLine(string.Format("{0}{1}{2}{3}", cellLeftBottom, Indent(indentLength), cellRightBottom, System.Environment.NewLine));
        return formattedString;
    }

    private static string Indent(int count)
    {
        return string.Empty.PadLeft(count, '─');
    }

    #endregion

    #region Public Methods

    public static void PrintToStream(string[,] arrValues, StreamWriter writer)
    {
        if (arrValues == null)
            return;

        if (writer == null)
            return;

        writer.Write(GetDataInTableFormat(arrValues));
    }

    public static void PrintToConsole(string[,] arrValues)
    {
        if (arrValues == null)
            return;

        GetDataInTableFormat(arrValues);
    }

    #endregion

    //static void Main(string[] args)
    //{
    //    int value = 997;
    //    string[,] arrValues = new string[5, 5];
    //    for (int i = 0; i < arrValues.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < arrValues.GetLength(1); j++)
    //        {
    //            value++;
    //            arrValues[i, j] = value.ToString();
    //        }
    //    }
    //    ArrayPrinter.PrintToConsole(arrValues);
    //    Console.ReadLine();
    //}
}