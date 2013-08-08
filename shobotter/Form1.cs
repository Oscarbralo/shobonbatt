using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace shobotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TwitterService service;
        OAuthRequestToken requestToken;
        string verifier;
        OAuthAccessToken access;
        string BattInfo_old = "";
        string BattInfo = "";
        string AccessToken = "";
        string AccessTokenSecret = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAuthWindowAndAuth();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string code = webBrowser1.DocumentText;
            if (0 < code.IndexOf("<code>"))
            {
                timer1.Enabled = false;
                webBrowser1.Visible = false;
                int loc = code.IndexOf("<code>");
                verifier = code.Substring(loc, 13);
                verifier = verifier.Replace("<code>", "");
                GetToken();
                main();
            }
            
        }

        private void ShowAuthWindowAndAuth()
        {
            webBrowser1.Visible = true;
            service = new TwitterService("glgfOYZS9vwZC8vhhIwcFw", "a4postZMEDzgGeXT1qWvSkmV8z5XySEOk0FcWwPsyQU");
            requestToken = service.GetRequestToken();
            Uri uri = service.GetAuthenticationUrl(requestToken);
            webBrowser1.Url = uri;
            timer1.Enabled = true;
        }

        private void GetToken()
        {
            access = service.GetAccessToken(requestToken, verifier);
            AccessToken = access.Token;
            AccessTokenSecret = access.TokenSecret;
            service.AuthenticateWith(access.Token, access.TokenSecret);
        }


        private void SendTweet(string strTweet)
        {
            service.SendTweet(new SendTweetOptions { Status = strTweet });
        }

        private void main()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void mainRe()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void timerbatt_Tick(object sender, EventArgs e)
        {
            BattInfo_old = BattInfo;
            BattInfo = "";
            PowerStatus ps = SystemInformation.PowerStatus;
            //ハードネーム
            if (cbHardName.Checked)
            {
                BattInfo += tbHardName.Text + "\n";
            }

            //電源に接続されているか
            if (cbPowerLine.Checked)
            {
                switch (ps.PowerLineStatus)
                {
                    case PowerLineStatus.Online:
                        BattInfo += "ACに接続されています\n";
                        break;
                    case PowerLineStatus.Offline:
                        BattInfo += "バッテリーを使用しています\n";
                        break;
                    case PowerLineStatus.Unknown:
                        BattInfo += "電源ステータスは不明です\n";
                        break;
                }
            }

            //バッテリー残量
            if (cbBattLife.Checked)
            {
                try
                {
                    String strbattw = ps.BatteryLifePercent.ToString();
                    double doublebattw = double.Parse(strbattw);
                    double doublebattper = doublebattw * 100;
                    BattInfo += "バッテリー残量:" + doublebattper.ToString() + "%\n";
                }
                catch
                {
                    BattInfo += "残量取得に失敗しました.\n";
                }
            }

            //バッテリーステータス
            if (cbBattStatus.Checked)
            {
                switch (ps.BatteryChargeStatus)
                {
                    case BatteryChargeStatus.High:
                        BattInfo += "バッテリー残量は十分あります\n";
                        break;
                    case BatteryChargeStatus.Low:
                        BattInfo += "バッテリー残量が少ないです\n";
                        break;
                    case BatteryChargeStatus.Critical:
                        BattInfo += "バッテリー残量が少なすぎです\n";
                        break;
                    case BatteryChargeStatus.Charging:
                        BattInfo += "充電中です\n";
                        break;
                    case BatteryChargeStatus.NoSystemBattery:
                        BattInfo += "バッテリーを使用していません\n";
                        break;
                    case BatteryChargeStatus.Unknown:
                        BattInfo += "バッテリー状態は不明です\n";
                        break;

                }
            }
            if (BattInfo != BattInfo_old)
            {
                lblBattStatus.Text = BattInfo;
                SendTweet(BattInfo + "\n\n#ShobonBattery");
            }
        }


        private void cbbatt_CheckedChanged(object sender, EventArgs e)
        {
            timerbatt.Enabled = false
            if (cbbatt.Checked)
            {
                timerbatt.Enabled = true;
            }
        }

        private void btnReSign_Click(object sender, EventArgs e)
        {
            cbbatt.Checked = false;
            mainRe();
            ShowAuthWindowAndAuth();
        }
        
    }
}
