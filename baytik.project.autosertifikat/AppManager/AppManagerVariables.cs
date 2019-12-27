﻿using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace CompleteApp
{
    public partial class AppManager
    {
        public readonly string configFileName = "config.txt";
        public static string fileNamePattern = "CompanyName";
        public static bool isConfigFileFind = false;

        public MetroStyleManager metroStyleManager;
        public TextBox cellPage;
        public TextBox cellBegin;
        public TextBox cellEnd;
        public MetroProgressBar progressBar;
        public RichTextBox richText;
        public TextBox cellColumn1TextBox;
        public TextBox cellColumn2TextBox;
        public TextBox cellColumn3TextBox;
        public MetroCheckBox activeBoxB;
        public MetroCheckBox activeBoxC;

        public int backgroundTeam = 1;
        public int backgroundHead = 0;
        public string keyword;
        public string adress;

        private StreamReader _sr;
        private StreamWriter _sw;
        private static List<string> _names;
        private int _cellBegin = 1;
        private int _cellEnd = 1;
        private int _cellPage = 1;
        private string _abc = "A";
        private static Excel.Application _objExcel;
        private static Excel.Workbook _objWorkBook;
        private static Excel.Worksheet _objWorkSheet;
    }
}