using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
namespace EmployeeManagement
{
    partial class AuthorInfoAboutBox : Form
    {
        public AuthorInfoAboutBox()
        {
            InitializeComponent();
            Text = "Информация";
            labelProductName.Text = "Мениджър на служители";
            labelVersion.Text = "Версия 1.0";
            labelCopyright.Text = "Авторско право © Пловдивски Университет, 2024";
            labelCompanyName.Text = "Пловдивски Университет \"Паисий Хилендарски\"";
            textBoxDescription.Text = "Автор: Мария Илиева\r\nСтудент в 1-ви курс\r\nСпециалност СТД, задочно обучение";
        }
    }
}
