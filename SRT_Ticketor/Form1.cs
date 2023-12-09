using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace SRT_Ticketor
{
    public partial class Form1 : Form
    {
        #region Fields
        private string id;
        private string passwd;
        private string stDeparture, stArrival;
        private int startHour, startMin;
        private int endHour, endMin;
        private DateTime dtReserve;
        private TimeSpan tsStartTime, tsEndTime;
        private bool chkVIP, chkNormal;

        private static bool stopThread = false;
        protected System.Threading.Thread runThread = null;
        private IWebDriver webDriver = null;

        #endregion

        #region Properties
        public string ID { get => id; set { id = value; } }
        public string Password { get => passwd; set { passwd = value; } }
        public string DepartureStation { get => stDeparture; set { stDeparture = value; } }
        public string ArrivalStation { get => stArrival; set { stArrival = value; } }

        public int StartHour { get => startHour; set { startHour = value; } }
        public int StartMin { get => startMin; set { startMin = value; } }
        public int EndHour { get => endHour; set { endHour = value; } }
        public int EndMin { get => endMin; set { endMin = value; } }

        public DateTime ReserveDate { get => dtReserve; set { dtReserve = value; } }
        public TimeSpan ReserveStartTime { get => tsStartTime; set { tsStartTime = value; } }
        public TimeSpan ReserveEndTime { get => tsEndTime; set { tsEndTime = value; } }
        public IWebDriver WebDriver { get=>webDriver; set => webDriver = value; }

        public bool BookVIP { get => chkVIP; set { chkVIP = value; } }
        public bool BookNormal { get => chkNormal; set { chkNormal = value; } }
        #endregion
        private void btnChangeStation_Click(object sender, EventArgs e)
        {
            string swap = tbDepart.Text;
            tbDepart.Text = tbArrival.Text;
            tbArrival.Text = swap;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopThread = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtPicker.Value = DateTime.Now;

            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now.AddHours(1);
        }

        public IWebDriver openBrowser()
        {
            string[] week_days = { "(일)", "(월)", "(화)", "(수)", "(목)", "(금)", "(토)"};
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Url = "https://etk.srail.kr/cmc/01/selectLoginForm.do";
                // 대기 설정. (find로 객체를 찾을 때까지 검색이 되지 않으면 대기하는 시간 초단위)
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

                driver.FindElement(By.XPath("//*[@id=\"srchDvCd3\"]")).Click();

                driver.FindElement(By.Id("srchDvNm03")).SendKeys(ID);
                driver.FindElement(By.Id("hmpgPwdCphd03")).SendKeys(Password);
                var element = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/fieldset/div[1]/div[1]/div[4]/div/div[2]/input"));
                element.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
                System.Threading.Thread.Sleep(10);

                driver.Url = "https://etk.srail.kr/hpg/hra/01/selectScheduleList.do?pageId=TK0101010000";
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(By.Id("dptRsStnCdNm")).Clear();
                driver.FindElement(By.Id("dptRsStnCdNm")).SendKeys(DepartureStation);

                driver.FindElement(By.Id("arvRsStnCdNm")).Clear();
                driver.FindElement(By.Id("arvRsStnCdNm")).SendKeys(ArrivalStation);

                //string date = dtReserve.ToString("yyyy'/'MM'/'dd") + week_days[(int)dtReserve.DayOfWeek];
                string date = dtReserve.ToString("yyyyMMdd");

                SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("dptDt")));//.SendKeys(date);
                dropDown.SelectByValue(date);
                
                string searchHour = $"{((StartHour % 2 != 0) ? (StartHour - 1) : StartHour).ToString("00")}0000";
                driver.FindElement(By.Id("dptTm")).SendKeys(searchHour);

                element = driver.FindElement(By.XPath("//*[@id='search_top_tag']/input"));
                element.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex) 
            {
                driver.Quit();
                MessageBox.Show(ex.Message );
                return null; 
            }

            return driver;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ID = Regex.Replace(tbID.Text, @"(\d{3})(\d{4})(\d{4})", "$1-$2-$3");
            Password = tbPW.Text;
            DepartureStation = tbDepart.Text;
            ArrivalStation = tbArrival.Text;
            ReserveDate = dtPicker.Value.Date;
            StartHour = dtStart.Value.Hour;
            StartMin = dtStart.Value.Minute;
            EndHour = dtEnd.Value.Hour;
            EndMin = dtEnd.Value.Minute;
            BookVIP = cbVIPRoom.Checked;
            BookNormal = cbNormalRoom.Checked;

            ReserveStartTime = new TimeSpan(StartHour, StartMin, 0);
            ReserveEndTime = new TimeSpan(EndHour, EndMin, 0);

            stopThread = false;
            WebDriver = openBrowser();

            if (WebDriver != null)
            {
                runThread = new System.Threading.Thread(new System.Threading.ThreadStart(OnRunThreadWorker));
                runThread.Start();
            }

            //driver.Close();
        }

        protected void OnRunThreadWorker()
        {
            var table = WebDriver.FindElement(By.XPath("//*[@id=\"result-form\"]/fieldset/div[6]/table"));
            var tbody = table.FindElement(By.TagName("tbody"));
            var trs = tbody.FindElements(By.TagName("tr"));

            int idxStart = -1, idxEnd = -1;

            for (int i = 0; i < trs.Count; i++)
            {
                var tds = trs[i].FindElements(By.TagName("td"));

                DateTime tm = Convert.ToDateTime(tds[3].FindElement(By.ClassName("time")).Text);
                TimeSpan timespan = new TimeSpan(tm.Hour, tm.Minute, tm.Second);
                if (((timespan - ReserveStartTime).TotalMinutes > 0) && ((timespan - ReserveEndTime).TotalMinutes < 0))
                {
                    if (idxStart == -1) { idxStart = i; }

                    idxEnd = i;
                }
            }

            if( (idxStart==-1) && (idxEnd==-1) )
            {
                WebDriver.Quit();
                MessageBox.Show("출발시간을 재설정하세요");
                return;
            }

            bool isReserved = false;
            while (true)
            {
                if (stopThread)
                {
                    WebDriver.Quit();
                    break;
                }

                System.Threading.Thread.Sleep(200);
                table = WebDriver.FindElement(By.XPath("//*[@id=\"result-form\"]/fieldset/div[6]/table"));
                tbody = table.FindElement(By.TagName("tbody"));
                trs = tbody.FindElements(By.TagName("tr"));

                for (int i = idxStart; i <= idxEnd; i++)
                {
                    var tds = trs[i].FindElements(By.TagName("td"));
                    if (BookVIP)
                    {
                        if (tds[5].FindElement(By.TagName("a")).FindElement(By.TagName("span")).Text == "예약하기")
                        {
                            tds[5].FindElement(By.TagName("a")).Click();
                            isReserved = true;
                            break;
                        }
                    }

                    if (BookNormal)
                    {
                        if (tds[6].FindElement(By.TagName("a")).FindElement(By.TagName("span")).Text == "예약하기")
                        {
                            tds[6].FindElement(By.TagName("a")).Click();
                            isReserved = true;
                            break;
                        }
                    }
                }

                if (isReserved)
                {
                    if (isAlertPresent())
                    {
                        WebDriver.SwitchTo().Alert().Accept();
                    }
                    System.Threading.Thread.Sleep(2000);
                    WebDriver.Quit();
                    MessageBox.Show("예약 완료!");
                    break;
                }
                else
                {
                    WebDriver.Navigate().Refresh();
                    WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
                }
                Thread.Sleep(10);
            }
        }

        public bool isAlertPresent()
        {
            try
            {
                WebDriver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException Ex)
            {
                return false;
            }
        }
    }
}
