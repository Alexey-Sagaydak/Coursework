﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public class AuthorizationFormViewModel
    {
        public Authorization authorization;

        public bool CheckWorker(string login, string password)
        {
            return authorization.CheckWorker(login, password);
        }

        public AuthorizationFormViewModel()
        {
            try
            {
                authorization = new Authorization();
            }
            catch (FileNotFoundException ex) {

                MessageBox.Show(ex.Message, "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
