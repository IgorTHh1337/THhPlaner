using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace Planer
{
    public partial class Planer : Form
    {
        DataGridView _grid;
        string _theme = "";
        public Planer()
        {
            InitializeComponent();
        }
        private void Planer_Load(object sender, EventArgs e)
        {
            _grid = planerGrid;
            LoadSettings();
            LoadTheme();
            DrawData();
            DrawPeople();
            DrawReport();
            CheckDeadLines();
        }

        private void Planer_Closing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            SaveData();
            SavePeople();
            SaveReport();
        }

        public static class IniFile
        {
            private static string path = "settings.ini";

            public static string Read(string key)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith(key + "="))
                            {
                                return line.Substring(key.Length + 1);
                            }
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    return "";
                }

                return "";
            }

            public static void Write(string key, string value)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(key + "=" + value);
                }
            }
        }

        private void LoadSettings()
        {
            _theme = IniFile.Read("Theme");
            emaillogin.Text = IniFile.Read("EmailLogin");
            emailpass.Text = IniFile.Read("EmailPass");
        }

        private void SaveSettings()
        {
            using (StreamWriter sw = new StreamWriter("settings.ini", false))
            {
                sw.WriteLine("Theme=" + _theme);
                sw.WriteLine("EmailLogin=" + emaillogin.Text);
                sw.WriteLine("EmailPass=" + emailpass.Text);
            }
        }

        private Color getColor(string hex)
        {
            return System.Drawing.ColorTranslator.FromHtml(hex);
        }

        private void updateTheme()
        {
            if (_theme == "")
            {
                _theme = "dark";
                loadDarkTheme();
            }

            if (_theme == "blue")
            {
                _theme = "dark";
                loadDarkTheme();
            }
            else if (_theme == "dark")
            {
                _theme = "blue";
                loadBlueTheme();
            }
        }

        private void LoadTheme()
        {
            if (_theme == "dark")
            {
                loadDarkTheme();
            }
            else if (_theme == "blue")
            {
                loadBlueTheme();
            }
        }

        private void loadDarkTheme()
        {
            Color darkBackground = getColor("#2e2e2e");
            Color darkForeground = getColor("#d4d4d4");
            Color darkGridBackground = getColor("#8f8f8f");

            this.BackColor = darkBackground;
            tabPage1.BackColor = darkBackground;
            tabPage2.BackColor = darkBackground;
            tabPage3.BackColor = darkBackground;
            tabPage4.BackColor = darkBackground;
            label1.ForeColor = darkForeground;
            label2.ForeColor = darkForeground;
            label3.ForeColor = darkForeground;
            label4.ForeColor = darkForeground;
            label5.ForeColor = darkForeground;
            label6.ForeColor = darkForeground;
            label7.ForeColor = darkForeground;
            label8.ForeColor = darkForeground;
            label9.ForeColor = darkForeground;
            Report1.ForeColor = darkForeground;
            Report2.ForeColor = darkForeground;
            Report3.ForeColor = darkForeground;
            Report4.ForeColor = darkForeground;
            Report5.ForeColor = darkForeground;
            ReportYear1.ForeColor = darkForeground;
            ReportYear2.ForeColor = darkForeground;
            ReportYear3.ForeColor = darkForeground;
            ReportYear4.ForeColor = darkForeground;
            ReportYear5.ForeColor = darkForeground;
            planerGrid.BackgroundColor = darkGridBackground;
            planerCompletedGrid.BackgroundColor = darkGridBackground;
            PeoplesGrid.BackgroundColor = darkGridBackground;
            reportGrid.BackgroundColor = darkGridBackground;
        }

        private void loadBlueTheme()
        {
            Color blueBackground = getColor("#274790");
            Color blueForeground = getColor("#ffffff");
            Color blueGridBackground = getColor("#788daf");

            this.BackColor = blueBackground;
            tabPage1.BackColor = blueBackground;
            tabPage2.BackColor = blueBackground;
            tabPage3.BackColor = blueBackground;
            tabPage4.BackColor = blueBackground;
            label1.ForeColor = blueForeground;
            label2.ForeColor = blueForeground;
            label3.ForeColor = blueForeground;
            label4.ForeColor = blueForeground;
            label5.ForeColor = blueForeground;
            label6.ForeColor = blueForeground;
            label7.ForeColor = blueForeground;
            label8.ForeColor = blueForeground;
            label9.ForeColor = blueForeground;
            Report1.ForeColor = blueForeground;
            Report2.ForeColor = blueForeground;
            Report3.ForeColor = blueForeground;
            Report4.ForeColor = blueForeground;
            Report5.ForeColor = blueForeground;
            ReportYear1.ForeColor = blueForeground;
            ReportYear2.ForeColor = blueForeground;
            ReportYear3.ForeColor = blueForeground;
            ReportYear4.ForeColor = blueForeground;
            ReportYear5.ForeColor = blueForeground;
            planerGrid.BackgroundColor = blueGridBackground;
            planerCompletedGrid.BackgroundColor = blueGridBackground;
            PeoplesGrid.BackgroundColor = blueGridBackground;
            reportGrid.BackgroundColor = blueGridBackground;
        }

        private void UpdateReportLabels()
        {
            int addCount = 0;
            int editCount = 0;
            int deleteCount = 0;
            int yearAddCount = 0;
            int yearEditCount = 0;
            int yearDeleteCount = 0;
            int doneCount = 0;
            int violationCount = 0;
            int yearDoneCount = 0;
            int yearViolationCount = 0;

            DateTime currentDate = DateTime.Now;
            DateTime oneYearAgo = currentDate.AddYears(-1);
            DateTime startOfPreviousYear = new DateTime(oneYearAgo.Year, 1, 1);
            DateTime endOfPreviousYear = new DateTime(oneYearAgo.Year, 12, 31);

            foreach (DataGridViewRow row in reportGrid.Rows)
            {
                string action = row.Cells["action"].Value.ToString();
                DateTime actionDate = Convert.ToDateTime(row.Cells["DateOfAction"].Value);

                if (actionDate >= startOfPreviousYear && actionDate <= endOfPreviousYear)
                {
                    switch (action)
                    {
                        case "Добавление":
                            addCount++;
                            yearAddCount++;
                            break;
                        case "Изменение":
                            editCount++;
                            yearEditCount++;
                            break;
                        case "Удаление":
                            deleteCount++;
                            yearDeleteCount++;
                            break;
                        case "Выполнено":
                            doneCount++;
                            yearDoneCount++;
                            break;
                        case "Выполнено с нарушениями":
                            violationCount++;
                            yearViolationCount++;
                            break;
                        default:
                            break;
                    }
                }
            }

            if (yearAddCount == 0 && yearEditCount == 0 && yearDeleteCount == 0 && yearDoneCount == 0 && yearViolationCount == 0)
            {
                yearAddCount = addCount;
                yearEditCount = editCount;
                yearDeleteCount = deleteCount;
                yearDoneCount = doneCount;
                yearViolationCount = violationCount;
            }

            Report1.Text = "Добавлено записей (всего): " + addCount.ToString();
            Report2.Text = "Изменено записей (всего): " + editCount.ToString();
            Report3.Text = "Удалено записей (всего): " + deleteCount.ToString();
            Report4.Text = "Выполненных записей (всего): " + doneCount.ToString();
            Report5.Text = "Выполненных с нарушениями (всего): " + violationCount.ToString();
            ReportYear1.Text = "Добавлено записей (за год): " + yearAddCount.ToString();
            ReportYear2.Text = "Изменено записей (за год): " + yearEditCount.ToString();
            ReportYear3.Text = "Удалено записей (за год): " + yearDeleteCount.ToString();
            ReportYear4.Text = "Выполненных записей (за год): " + yearDoneCount.ToString();
            ReportYear5.Text = "Выполненных с нарушениями (за год): " + yearViolationCount.ToString();
        }

        private void DrawData()
        {
            clearGrids();
            ImportData();
        }

        private void DrawPeople()
        {
            clearPplGrid();
            ImportPeople();
        }

        private void DrawReport()
        {
            clearRprtGrid();
            ImportReport();
        }

        private void ImportPeople()
        {
            PeoplesGrid.Rows.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("peopleData.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    object[] data = new object[PeoplesGrid.ColumnCount];
                    for (int i = 0; i < xnode.ChildNodes.Count; i++)
                    {
                        data[i] = xnode.ChildNodes[i].InnerText;
                    }
                    PeoplesGrid.Rows.Add(data);
                }
            }
        }

        private void ImportReport()
        {
            reportGrid.Rows.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("reportData.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    object[] data = new object[reportGrid.ColumnCount];
                    for (int i = 0; i < xnode.ChildNodes.Count; i++)
                    {
                        if (i == 2)
                        {
                            data[i] = DateTime.Parse(xnode.ChildNodes[i].InnerText);
                        }
                        else
                        {
                            data[i] = xnode.ChildNodes[i].InnerText;
                        }
                    }
                    reportGrid.Rows.Add(data);
                    UpdateReportLabels();
                }
            }
        }

        private void ImportData()
        {
            planerGrid.Rows.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("planerData.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    DataGridView grid = planerCompletedGrid;
                    object[] data = new object[planerGrid.ColumnCount];
                    for (int i = 0; i < xnode.ChildNodes.Count; i++)
                    {
                        if (i == planerGrid.ColumnCount - 1)
                        {
                            if (xnode.ChildNodes[i].InnerText == "true")
                            {
                                data[i] = true;
                                grid = planerCompletedGrid;
                            }
                            else
                            {
                                data[i] = false;
                                grid = planerGrid;
                            }
                        }
                        else if (i == 1)
                        {
                            data[i] = DateTime.Parse(xnode.ChildNodes[i].InnerText);
                        }
                        else
                        {
                            data[i] = xnode.ChildNodes[i].InnerText;
                        }
                    }
                    grid.Rows.Add(data);
                }
            }
        }

        private void CheckDeadLines()
        {
            if (planerGrid.RowCount > 0)
            {
                for (int i = 0; i < planerGrid.RowCount; i++)
                {
                    string date = planerGrid.Rows[i].Cells["deadline"].Value.ToString();
                    DateTime deadline = DateTime.Parse(date);
                    TimeSpan timeLeft = deadline.Date - DateTime.Now.Date;
                    if (timeLeft.Days <= 7 && timeLeft.Days >= -1)
                    {
                        string text = "\r\nВид документа: " + planerGrid.Rows[i].Cells["type"].Value.ToString() +
                                      "\r\nОтветственные за подготовку: " + planerGrid.Rows[i].Cells["responsible"].Value.ToString() +
                                      "\r\nКуда подается: " + planerGrid.Rows[i].Cells["send"].Value.ToString() +
                                      "\r\nДата подачи: " + date;
                        string daysText = (timeLeft.Days == 1) ? "день" : "дней";


                        if (timeLeft.Days == 0)
                        {
                            MessageBox.Show("Событие #" + (i + 1) + " наступает сегодня" + text, "Оповещение о событии");
                        }
                        else
                        {
                            MessageBox.Show("Событие #" + (i + 1) + " наступит через " + (timeLeft.Days) + " " + daysText + text, "Оповещение о событии");
                        }
                    }
                }
            }
        }

        private void clearGrids()
        {
            planerGrid.Rows.Clear();
            planerCompletedGrid.Rows.Clear();
        }

        private void clearPplGrid()
        {
            PeoplesGrid.Rows.Clear();
        }

        private void clearRprtGrid()
        {
            reportGrid.Rows.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearGrids();
            SaveData();
        }

        private void PeoplesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PplCellClick(e.RowIndex);
        }

        private void planerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _grid = planerGrid;
            cellClick(e.RowIndex);
        }

        private void planerCompletedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _grid = planerCompletedGrid;
            cellClick(e.RowIndex);
        }

        private void SaveData()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("planer");
            xmlDoc.AppendChild(rootNode);

            DataGridView[] grids = new DataGridView[] { planerGrid, planerCompletedGrid };

            for (int g = 0; g < grids.Length; g++)
            {
                if (grids[g].RowCount > 0)
                {
                    for (int i = 0; i < grids[g].RowCount; i++)
                    {
                        XmlNode action = xmlDoc.CreateElement("action");
                        for (int j = 0; j < grids[g].ColumnCount; j++)
                        {
                            XmlNode element = xmlDoc.CreateElement(grids[g].Columns[j].Name);
                            DataGridViewCell cell = grids[g].Rows[i].Cells[j];
                            if (j == grids[g].ColumnCount - 1)
                            {
                                if (cell.Value == null)
                                {
                                    element.InnerText = "false";
                                }
                                else
                                {
                                    if ((bool)cell.Value)
                                    {
                                        element.InnerText = "true";
                                    }
                                    else
                                    {
                                        element.InnerText = "false";
                                    }
                                }
                            }
                            else
                            {
                                if (cell.Value == null)
                                {
                                    element.InnerText = "";
                                }
                                else
                                {
                                    element.InnerText = cell.Value.ToString();
                                }
                            }
                            action.AppendChild(element);
                        }
                        rootNode.AppendChild(action);
                    }
                }
            }

            xmlDoc.Save("planerData.xml");
            DrawData();
        }

        private void SavePeople()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("people");
            xmlDoc.AppendChild(rootNode);

            DataGridView grid = PeoplesGrid;

            if (grid.RowCount > 0)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    XmlNode person = xmlDoc.CreateElement("person");
                    for (int j = 0; j < grid.ColumnCount; j++)
                    {
                        XmlNode element = xmlDoc.CreateElement(grid.Columns[j].Name);
                        DataGridViewCell cell = grid.Rows[i].Cells[j];
                        if (cell.Value == null)
                        {
                            element.InnerText = "";
                        }
                        else
                        {
                            element.InnerText = cell.Value.ToString();
                        }
                        person.AppendChild(element);
                    }
                    rootNode.AppendChild(person);
                }
            }

            xmlDoc.Save("peopleData.xml");
            DrawPeople();
        }

        private void SaveReport()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode reportNode = xmlDoc.CreateElement("report");
            xmlDoc.AppendChild(reportNode);

            if (reportGrid.RowCount > 0)
            {
                for (int i = 0; i < reportGrid.RowCount; i++)
                {
                    XmlNode action = xmlDoc.CreateElement("action");
                    for (int j = 0; j < reportGrid.ColumnCount; j++)
                    {
                        XmlNode element = xmlDoc.CreateElement(reportGrid.Columns[j].Name);
                        DataGridViewCell cell = reportGrid.Rows[i].Cells[j];
                        if (cell.Value == null)
                        {
                            element.InnerText = "";
                        }
                        else
                        {
                            element.InnerText = cell.Value.ToString();
                        }
                        action.AppendChild(element);
                    }
                    reportNode.AppendChild(action);
                }
            }
            xmlDoc.Save("reportData.xml");
            DrawReport();
        }

        private void cellClick(int row)
        {
            try
            {
                for (int i = 0; i < _grid.SelectedRows.Count; i++)
                {
                    _grid.SelectedRows[i].Selected = false;
                }

                _grid.Rows[row].Selected = true;
                typeBox.Text = _grid.Rows[row].Cells[0].Value.ToString();
                dateBox.Value = DateTime.Parse(_grid.Rows[row].Cells[1].Value.ToString());
                usersBox.Text = _grid.Rows[row].Cells[2].Value.ToString();
                toBox.Text = _grid.Rows[row].Cells[3].Value.ToString();
                if (_grid.Rows[row].Cells[4].Value == null)
                {
                    completedBox.Checked = false;
                }
                else
                {
                    if ((bool)_grid.Rows[row].Cells[4].Value)
                    {
                        completedBox.Checked = true;
                    }
                    else
                    {
                        completedBox.Checked = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void PplCellClick(int row)
        {
            try
            {
                for (int i = 0; i < PeoplesGrid.SelectedRows.Count; i++)
                {
                    PeoplesGrid.SelectedRows[i].Selected = false;
                }

                PeoplesGrid.Rows[row].Selected = true;
                nameBox.Text = PeoplesGrid.Rows[row].Cells[0].Value.ToString();
                emailBox.Text = PeoplesGrid.Rows[row].Cells[1].Value.ToString();
            }
            catch (Exception) { }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count > 0)
            {
                _grid.Rows.Remove(_grid.SelectedRows[0]);

                typeBox.Text = "";
                dateBox.Value = DateTime.Now;
                usersBox.Text = "";
                toBox.Text = "";
                completedBox.Checked = false;
                MessageBox.Show("Запись удалена");
                SaveData();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            object[] data = new object[5];
            data[0] = typeBox.Text;
            data[1] = dateBox.Value.ToString("dd.MM.yyyy");
            data[2] = usersBox.Text;
            data[3] = toBox.Text;
            data[4] = completedBox.Checked;
            planerGrid.Rows.Add(data);

            object[] reportData = new object[3];
            reportData[0] = "Добавление";
            reportData[1] = typeBox.Text;
            reportData[2] = DateTime.Now.ToString("dd.MM.yyyy");
            reportGrid.Rows.Add(reportData);

            MessageBox.Show("Запись добавлена");
            SaveData();
            SaveReport();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count > 0)
            {
                _grid.SelectedRows[0].Cells[0].Value = typeBox.Text;
                _grid.SelectedRows[0].Cells[1].Value = dateBox.Value.ToString("dd.MM.yyyy");
                _grid.SelectedRows[0].Cells[2].Value = usersBox.Text;
                _grid.SelectedRows[0].Cells[3].Value = toBox.Text;
                _grid.SelectedRows[0].Cells[4].Value = completedBox.Checked;

                object[] reportData = new object[3];
                reportData[0] = "Изменение";
                reportData[1] = typeBox.Text;
                reportData[2] = DateTime.Now.ToString("dd.MM.yyyy");

                if (completedBox.Checked)
                {
                    DateTime currentDate = DateTime.Now.Date;
                    DateTime selectedDate = dateBox.Value.Date;

                    if (currentDate > selectedDate)
                    {
                        reportData[1] = "Выполнено с нарушениями";
                    }
                    else
                    {
                        reportData[1] = "Выполнено";
                    }
                }
                reportGrid.Rows.Add(reportData);

                MessageBox.Show("Изменения сохранены");
                SaveData();
                SaveReport();
            }
        }

        private void delPplBtn_Click(object sender, EventArgs e)
        {
            if (PeoplesGrid.SelectedRows.Count > 0)
            {
                PeoplesGrid.Rows.Remove(PeoplesGrid.SelectedRows[0]);

                nameBox.Text = "";
                emailBox.Text = "";

                object[] reportData = new object[3];
                reportData[0] = "Удаление";
                reportData[1] = typeBox.Text;
                reportData[2] = DateTime.Now.ToString("dd.MM.yyyy");
                reportGrid.Rows.Add(reportData);

                MessageBox.Show("Запись удалена");
                SaveData();
                SaveReport();
            }
        }

        private void addPplBtn_Click(object sender, EventArgs e)
        {
            object[] data = new object[2];
            data[0] = nameBox.Text;
            string email = emailBox.Text;

            if (IsValidEmail(email))
            {
                data[1] = email;
                PeoplesGrid.Rows.Add(data);
                MessageBox.Show("Запись добавлена");
                SavePeople();
            }
            else
            {
                MessageBox.Show("Введите корректный адрес электронной почты");
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void changePplBtn_Click(object sender, EventArgs e)
        {
            if (PeoplesGrid.SelectedRows.Count > 0)
            {
                PeoplesGrid.SelectedRows[0].Cells[0].Value = nameBox.Text;
                PeoplesGrid.SelectedRows[0].Cells[1].Value = emailBox.Text;
                MessageBox.Show("Изменения сохранены");
                SavePeople();
            }
        }

        private void clearPplBtn_Click(object sender, EventArgs e)
        {
            clearPplGrid();
            SavePeople();
        }

        private void changeTheme_Click(object sender, EventArgs e)
        {
            updateTheme();
        }

        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            if (PeoplesGrid.SelectedRows.Count > 0 && planerGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedPerson = PeoplesGrid.SelectedRows[0];
                DataGridViewRow selectedPlaner = planerGrid.SelectedRows[0];

                string smtp_account = emaillogin.Text;
                string smtp_password = emailpass.Text;

                if (selectedPerson.Cells["personemail"].Value != null)
                {
                    string smtp_reciever = selectedPerson.Cells["personemail"].Value.ToString();

                    var from_email = new MailAddress(smtp_account);
                    var to_email = new MailAddress(smtp_reciever);
                    var message = new MailMessage(from_email, to_email);
                    string type = selectedPlaner.Cells["type"].Value.ToString();
                    string deadline = selectedPlaner.Cells["deadline"].Value.ToString();
                    string responsible = selectedPlaner.Cells["responsible"].Value.ToString();
                    string send = selectedPlaner.Cells["send"].Value.ToString();
                    message.Subject = "Напоминание о событии";
                    message.Body = "Вид документа: " + type + "\nОтветственные лица: " + responsible + "\nКуда подается: " + send + "\nСрок подачи: " + deadline;

                    SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(from_email.Address, smtp_password);

                    try
                    {
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось отправить письмо: " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Не выбран адрес электронной почты для получателя");
                }
            }
            else
            {
                MessageBox.Show("Не выбраны строки в таблицах");
            }
        }
    }
}
