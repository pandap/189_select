using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace _189_select
{

       public partial class Form1 : Form
    {

    public class phone
    {
        public string phoneName;
        public string phoneNum;
    }
        string fName;
        string sName;
        List<phone> flist = new List<phone>();
        List<phone> slist = new List<phone>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (fName == null || sName == null)
                MessageBox.Show("未选择完整");
            ///读入xml文件
            StreamReader sr=new StreamReader (fName);
            string sfile = sr.ReadToEnd();
            sr.Close();
            int begin = 0;
            int end = 0;
            int nameIndex=0;
            int nameIndexEnd=0;

            ///转换xml文件
            //while (begin <sfile.Length)
            //{
            //begin = sfile.IndexOf("<Name>",begin);
            //    if (begin <0)
            //        break;
            //end = sfile.IndexOf("</Name>",begin);
            //phoneName = sfile.Substring(begin+6, end-begin-6);
            //if (phoneName != null||phoneName !="")
            //{
            //    flist.Add(phoneName);
            //}
            //begin=end;
            //}

            ///取出来phoneNum
            while (end < sfile.Length)
            {
                end = sfile.IndexOf("</Phone>", begin);
                if (end < 0)
                    break;
                begin = sfile.IndexOf(">", end-20);
                phone myPhone = new phone();
                myPhone.phoneNum = sfile.Substring(begin+1, end-begin-1);
                //直接去除非数字
                myPhone.phoneNum = System.Text.RegularExpressions.Regex.Replace(myPhone.phoneNum, @"[^\d]*", "");
                ///判断+86/-/000
                if (myPhone.phoneNum.IndexOf("86", 0) > 0 && myPhone.phoneNum.IndexOf("86", 0)<3)
                {
                    int head = myPhone.phoneNum.IndexOf("86", 0);
                    myPhone.phoneNum = myPhone.phoneNum.Substring(head+2);
                }
                if (myPhone.phoneNum.IndexOf("-", 0) > 0)
                {
                    myPhone.phoneNum = myPhone.phoneNum.Replace("-", "");
                }
                   if (myPhone.phoneNum != null || myPhone.phoneNum != "")
                {
                    if (begin > 400)
                    {
                        nameIndexEnd = sfile.IndexOf("</Starred>", begin - 250);
                        nameIndex = sfile.IndexOf("<Name>", nameIndexEnd - 70);
                        myPhone.phoneName = sfile.Substring(nameIndex + 6, nameIndexEnd - nameIndex - 33);
                        flist.Add(myPhone);
                    }
                    else
                    {
                        nameIndexEnd = sfile.IndexOf("</Starred>", begin - 170);
                        nameIndex = sfile.IndexOf("<Name>", nameIndexEnd - 70);
                        myPhone.phoneName = sfile.Substring(nameIndex + 6, nameIndexEnd - nameIndex - 33);
                        flist.Add(myPhone);
                    }
                }
              begin = end+1;
            }

            for (int i = 0; i < flist.Count; i++)
            {
                if (ok189(flist[i].phoneNum,1330100,1330139))
                    slist.Add (flist[i]);
                if (ok189(flist[i].phoneNum, 1331100, 1331140))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1331142, 1331159))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1332100, 1332106))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1332108, 1332119))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1333100, 1333119))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1334100, 1334119))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1335740, 1335749))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1336600, 1336699))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1337010, 1337018))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1337160, 1337179))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1338100, 1338149))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1339150, 1338199))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1530000, 1530039))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1530100, 1530139))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1531100, 1531199))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1531300, 1531399))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1532100, 1532199))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1533000, 1533029))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1534000, 1534019))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1890010, 1890019))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1890100, 1890139))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1891000, 1891199))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1800100, 1800139))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1801000, 1801049))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1802000, 1803999))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1804650, 1804659))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1805000, 1809999))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1810000, 1810004))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1810100, 1810139))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1811000, 1813999))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1814450, 1814459))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1814650, 1814659))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1770010, 1770019))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1770100, 1770139))
                    slist.Add(flist[i]);
                if (ok189(flist[i].phoneNum, 1771000, 1771019))
                    slist.Add(flist[i]);

            }
            ///189号找全，再找名字

//            拼接目标文件
            if (slist.Count > 0)
            {
                string nameBlock = sfile.Substring(0, 50);
                for (int i = 0; i < slist.Count; i++)
                {
                    nameBlock += sfile.Substring(50, 31) + slist[i].phoneName + "</Name>" + Environment.NewLine + "        <Starred>0</Starred>" + Environment.NewLine + "        <PhoneList>" + Environment.NewLine + "            <Phone Type=\"2\">" + slist[i].phoneNum + "</Phone>" + Environment.NewLine + "        </PhoneList>" + Environment.NewLine + "        <Account value=\"0\">" + Environment.NewLine + "            <Name></Name>" +Environment.NewLine+ "            <Type></Type>" + Environment.NewLine + "        </Account>" + Environment.NewLine + "    </Contact>";
                }
                nameBlock += Environment.NewLine + "</Contacts>";
                ///写入xml文件
                FileStream fs = new FileStream(sName, FileMode.Append, FileAccess.Write);
                fs.Close();
                StreamWriter sw = File.AppendText(sName);
                sw.Write(nameBlock);
                sw.Flush();
                sw.Close();
                MessageBox.Show("写入成功");
            }
            else
                MessageBox.Show("没有找到北京电信的号码，未生成文件");
        }
           public static bool ok189(string num,int first,int last)
           {
               //如果长度小于7，返回false
               if (num.Length < 7)
                   return false;
               int tem=int.Parse(num.Substring(0, 7).ToString());
                if (first <= int.Parse(num.Substring(0, 7)) && int.Parse(num.Substring(0, 7)) <= last)
                {
                    return true;
                }
                else
                    return false;
           }

        private void textBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择原文件";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            ofd.Filter = "xml|*.xml";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fName = ofd.FileName;
                textBox1.Text = fName;
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml|*.xml";
            sfd.Title = "保存地址";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sName = sfd.FileName;
                textBox2.Text = sName;
            }
        }
    }
}
