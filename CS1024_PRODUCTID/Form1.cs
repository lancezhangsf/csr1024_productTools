using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using uEnergyTestAPI;
using System.Runtime.InteropServices;

using System.IO.Ports;


namespace CS1024_PRODUCTID
{
    public partial class Form1 : Form
    {

        static int isFirst = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择烧写文件所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                this.filebindir.Text = dialog.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 运行cmd命令
        /// 不显示命令窗口
        /// </summary>
        /// <param name="cmdExe">指定应用程序的完整路径</param>
        /// <param name="cmdStr">执行命令行参数</param>
        static void RunCmd2(string cmdExe, string cmdStr)
        {
            string output = null;
            try
            {
                using (System.Diagnostics.Process myPro = new System.Diagnostics.Process())
                {
                    myPro.StartInfo.FileName = "cmd.exe";
                    myPro.StartInfo.UseShellExecute = false;
                    myPro.StartInfo.RedirectStandardInput = true;
                    myPro.StartInfo.RedirectStandardOutput = true;
                    myPro.StartInfo.RedirectStandardError = true;
                    myPro.StartInfo.CreateNoWindow = true;
                    myPro.Start();
                    //如果调用程序路径中有空格时，cmd命令执行失败，可以用双引号括起来 ，在这里两个引号表示一个引号（转义）
                    //string str = string.Format(@"""{0}"" {1} {2}", cmdExe, cmdStr, "&exit");

                    myPro.StandardInput.WriteLine(cmdStr);
                    myPro.StandardInput.AutoFlush = true;
                    output = myPro.StandardOutput.ReadToEnd();


                    myPro.WaitForExit();//等待程序执行完退出x进程
                    myPro.Close();

                    // result = true;
                }
            }
            catch
            {

            }

        }

        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // this.filebindir
            // this.sdkdi
            string str = Console.ReadLine();
            Cmd c = new Cmd();
            string log = "";
            this.richTextBox1.Text += "正在烧写中,请耐心等几十秒...\r\n";
            Delay(10);
            // first 
            if (String.IsNullOrEmpty(this.filebindir.Text))
            {
                MessageBox.Show("请选择烧写文件目录!", "InFormation", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(this.sdkdir.Text))
            {
                MessageBox.Show("请选择SDK文件目录!", "InFormation", MessageBoxButtons.OK);
                return;
            }
           
            string strcmd = this.sdkdir.Text + "\\tools\\bin\\nvscmd -nvstype SMEM -quiet -norun -trans \"SPITRANS=USB SPIPORT=0\"  erase";
            //string strcmd = "nvscmd -nvstype SMEM -quiet -norun -trans \"SPITRANS=USB SPIPORT=0\"  erase";
            string value = c.RunCmd(strcmd);

            //this.richTextBox1.Text = this.richTextBox1.Text.Insert(0, value);
            log += value;
            //Console.Write(value);

            strcmd = this.sdkdir.Text + "\\tools\\bin\\nvscmd -nvstype MTP -quiet -norun -trans \"SPITRANS=USB SPIPORT=0\"  erase";
            value = c.RunCmd(strcmd);
          //  this.richTextBox1.Text = this.richTextBox1.Text.Insert(1, value);
            log += value;




            string[] filedir = Directory.GetFiles(this.filebindir.Text, "*.mtp.xuv");
            strcmd = this.sdkdir.Text + "\\tools\\bin\\nvscmd -quiet -nvstype MTP -norun -trans \"SPITRANS=USB SPIPORT=0\"  burn " + filedir[0];
            value = c.RunCmd(strcmd);
          //  this.richTextBox1.Text = this.richTextBox1.Text.Insert(2, value);
            log += value;


            //SdkStoreConfig -q -i otp_dev.stores -r  "1715" -m OTP -s D:/WorkSpace/CSR102x_SDK-3.1.0/tools/bin --cmdoptions "-nvstype OTP -norun -usb 0 burn" -x D:/WorkSpace/CSR102x_SDK-3.1.0/tools/lib/CSR102x_A06/early_patch --otpfile otp_dev.stores -w 1  --fwversion A06
            filedir = Directory.GetFiles(this.filebindir.Text, "otp_dev.stores");
            strcmd = this.sdkdir.Text + "\\tools\\bin\\SdkStoreConfig -q -i " + filedir[0] + " -r  \"1715\" -m OTP -s " + this.sdkdir.Text + "\\tools\\bin" + " --cmdoptions \"-nvstype OTP -norun -usb 0 burn\" -x " + this.sdkdir.Text + "\\tools\\lib\\CSR102x_A06\\early_patch" + " --otpfile " + filedir[0] + " -w 1  --fwversion A06";
            value = c.RunCmd(strcmd);
          //  this.richTextBox1.Text = this.richTextBox1.Text.Insert(3, value);
            log += value;


            //nvscmd -nvstype SMEM -norun   burn gatt_server.flash.xuv
            filedir = Directory.GetFiles(this.filebindir.Text, "*.flash.xuv");
            strcmd = this.sdkdir.Text + "\\tools\\bin\\nvscmd -nvstype SMEM -norun   burn " + filedir[0];
            value = c.RunCmd(strcmd);
         //   this.richTextBox1.Text = this.richTextBox1.Text.Insert(4, value);
            log += value;


            //configcmd txt2dev D:/WorkSpace/CSR102x_SDK-3.1.0/tools/lib/CSR102x_A06/sdk_cfg_store.htf MERGE -trans "SPITRANS=USB SPIPORT=0" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database "D:/WorkSpace/CSR102x_SDK-3.1.0/tools/bin/CSR102x.sdb"

            strcmd = this.sdkdir.Text + "\\tools\\bin\\configcmd txt2dev " + this.sdkdir.Text + "\\tools\\lib\\CSR102x_A06\\sdk_cfg_store.htf MERGE -trans \"SPITRANS=USB SPIPORT=0\" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database " + "\"" + this.sdkdir.Text + "\\tools\\bin\\CSR102x.sdb\"";  //filedir[0];
            value = c.RunCmd(strcmd);
         //   this.richTextBox1.Text = this.richTextBox1.Text.Insert(5, value);
            log += value;

            //CreateCSKey --subsystem "ble" -m SMEM -s 0xF -k "<sleep_fosc_freq, 0x04>" -o storeconfigkey.htf
            filedir = Directory.GetFiles(this.filebindir.Text, "storeconfigkey.htf");
            strcmd = this.sdkdir.Text + "\\tools\\bin\\CreateCSKey --subsystem \"ble\" -m SMEM -s 0xF -k \"<sleep_fosc_freq, 0x04>\" -o" + filedir[0];
            value = c.RunCmd(strcmd);
        //    this.richTextBox1.Text = this.richTextBox1.Text.Insert(6, value);
            log += value;


            //configcmd txt2dev storeconfigkey.htf MERGE -trans "SPITRANS=USB SPIPORT=0" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database "D:/WorkSpace/CSR102x_SDK-3.1.0/tools/bin/CSR102x.sdb"
            filedir = Directory.GetFiles(this.filebindir.Text, "storeconfigkey.htf");
            strcmd = this.sdkdir.Text + "\\tools\\bin\\configcmd txt2dev " + filedir[0] + " MERGE -trans \"SPITRANS=USB SPIPORT=0\" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database " + "\"" + this.sdkdir.Text + "\\tools\\bin\\CSR102x.sdb";
            value = c.RunCmd(strcmd);
        //    this.richTextBox1.Text = this.richTextBox1.Text.Insert(7, value);
            log += value;



            //configcmd txt2dev   gatt_server.htf MERGE -trans "SPITRANS=USB SPIPORT=0" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database "D:/WorkSpace/CSR102x_SDK-3.1.0/tools/bin/CSR102x.sdb"
            filedir = Directory.GetFiles(this.filebindir.Text, "*.htf");
            string configfile = null;
            foreach (string file in filedir)
            {
                if (file != "storeconfigkey.htf")
                {
                    configfile = file;
                    break;
                }
            }

            strcmd = this.sdkdir.Text + "\\tools\\bin\\configcmd txt2dev " + configfile + " MERGE -trans \"SPITRANS=USB SPIPORT=0\" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database " + "\"" + this.sdkdir.Text + "\\tools\\bin\\CSR102x.sdb\"";
            value = c.RunCmd(strcmd);
         //   this.richTextBox1.Text = this.richTextBox1.Text.Insert(8, value);
            log += value;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"log.txt", true))
            {
    
                file.Write(log);//直接追加文件末尾，不换行
                //file.WriteLine(line);// 直接追加文件末尾，换行   
            }



            if (log.Contains("Fail") || log.Contains("fail") || log.Contains("fail"))
            {
                this.richTextBox1.Text += "烧写失败,请查看烧写文件及烧写目录是否正确后,再次尝试烧写. \r\n";
                return;
            }
            else {

                this.richTextBox1.Text += "烧写成功 \r\n";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择SDK所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {

                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                this.sdkdir.Text = dialog.SelectedPath;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(this.filebindir.Text))
            {
                MessageBox.Show("请选择烧写文件目录......!", "InFormation", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(this.mac1.Text) || String.IsNullOrEmpty(this.mac2.Text) || String.IsNullOrEmpty(this.mac3.Text))
            {
                MessageBox.Show("请填写Mac地址!", "InFormation", MessageBoxButtons.OK);
                return;
            }

            if ((this.mac1.Text.Length > 4) || (this.mac2.Text.Length > 4) || (this.mac3.Text.Length > 4)) {

                MessageBox.Show("请正确填写Mac地址,如0x1122,0x2233,0x3344!", "InFormation", MessageBoxButtons.OK);
                return;           
            }


            MessageBox.Show("请再次确认输入的为16进制的数据,如0xaabb,0x2233,0x3344!", "InFormation", MessageBoxButtons.OK);


            string[] filedir = Directory.GetFiles(this.filebindir.Text, "*.htf");
            string configfile = null;
            foreach (string file in filedir)
            {
                if (file != "storeconfigkey.htf")
                {
                    configfile = file;
                    break;
                }
            }


            int iLnTmp = 0; //记录文件行数
            string sText = "";
            {
                using (StreamReader sr = new StreamReader(configfile))
                {
                    while (!sr.EndOfStream)
                    {

                        iLnTmp++;
                        string lines = sr.ReadLine();    //记录当前行
                        if ((!lines.Contains("#")) && (!lines.Contains("//")) && (!lines.Contains("\\")))
                        {
                            string[] line = lines.Split('=');
                            if (line.Length > 1)
                            {
                                System.Console.WriteLine("key:{0},value:{1}", line[0], line[1]);
                            }
                            if (line[0].IndexOf("bdaddr") == 0)
                            {
                                sText += "bdaddr  = ";
                                sText += "{ 0x"+this.mac1.Text+", 0x"+ this.mac2.Text + ", 0x"+  this.mac3.Text+ "}\r\n";  
                            }
                            else
                            {
                                sText += lines + "\r\n";
                            }
                        }
                        else
                        {

                            sText += lines + "\r\n";

                        }
                    }
                }
                //保存文件
                using (StreamWriter sw = new StreamWriter(configfile, false))
                {
                    sw.Write(sText);
                    System.Console.Write(sText);
                    sw.Flush();
                }
            }

            string str = Console.ReadLine();
            Cmd c = new Cmd();



            string strcmd = this.sdkdir.Text + "\\tools\\bin\\configcmd txt2dev " + configfile + " MERGE -trans \"SPITRANS=USB SPIPORT=0\" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database " + "\"" + this.sdkdir.Text + "\\tools\\bin\\CSR102x.sdb\"";
            string value = c.RunCmd(strcmd);

            System.Console.Write(value);
            if (value.Contains("reading") && value.Contains("writing") && value.Contains("Success"))
            {
                this.richTextBox1.Text += "设置MAC地址成功! \r\n";
            }
            else
            {

                this.richTextBox1.Text += "设置MAC地址失败,请重新对设备上电(掉电时长>20秒)或者重新烧写后进行尝试!\r\n";
            }


            /*     
                 const UInt16 BD_ADDR_CS_ID = 1;

                 ushort mac1 = Convert.ToUInt16( this.mac1.Text);

                 ushort mac2 = Convert.ToUInt16(this.mac2.Text);

                 ushort mac3 = Convert.ToUInt16(this.mac3.Text);

                 UInt16 CFG_STORE_ID = 123;
                 char CS_ID_STR_SEPARATOR = ':';
                 string CS_DB_FILE = "CSR102x.sdb:fht_SDK_3_1_0_315_A06_ROM_1707201539";

                 IntPtr handle = IntPtr.Zero;
                 Int32 retVal = uEnergyTest.uetOpen("SPITRANS=USB SPIPORT=0", CS_DB_FILE, out handle);

                 if (retVal == 0)
                 {
                     ushort[] bdAddrValue= new ushort[3];
                     // Qualcomm default values used
                     bdAddrValue[0] = mac1;
                     bdAddrValue[1] = mac2;
                     bdAddrValue[2] = mac3;

                     ushort length = 3;
                     string id = null;
                     id = BD_ADDR_CS_ID.ToString() + CS_ID_STR_SEPARATOR.ToString() + CFG_STORE_ID.ToString();
                     retVal = uEnergyTest.uetCsWriteItem(handle, id, bdAddrValue, out length);
                     if (retVal != 0)
                     {
                         //cout << "Error writing Bluetooth address value to CS: " << uetGetLastError(handle) << endl;

                         string error = Marshal.PtrToStringAnsi( uEnergyTest.uetGetLastError(handle));
                    
                         MessageBox.Show(" Error writing Bluetooth address value to CS:"+error, "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        // Marshal.FreeHGlobal(errors);
                     }

                 }
                 else 
                 {
                     IntPtr errors = IntPtr.Zero;
                     errors = uEnergyTest.uetGetLastError(handle);
                     MessageBox.Show(" Error starting open device:"+Marshal.PtrToStringAnsi(errors),"ERROR!" , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
                 }
                 if(retVal == 0)
                     MessageBox.Show("设置成功！", "INFORMATION!", MessageBoxButtons.OKCancel);

                 uEnergyTest.uetClose(handle);
     */

        }

        private void freq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.filebindir.Text)) 
            {
                MessageBox.Show("请选择烧写文件目录!","InFormation", MessageBoxButtons.OK);
                return;
            }

            if (String.IsNullOrEmpty(this.freq.Text))
            {
                MessageBox.Show("请填写已经计算好的频偏值!", "InFormation", MessageBoxButtons.OK);
                return;
            }
            string[] filedir = Directory.GetFiles(this.filebindir.Text, "*.htf");
            string configfile = null;
            foreach (string file in filedir)
            {
                if (file != "storeconfigkey.htf")
                {
                    configfile = file;
                    break;
                }
            }


            int iLnTmp = 0; //记录文件行数
            int char_number = 0;
            string sText = "";
            var rst="";

            {
                // Dictionary<string, string> dic = new Dictionary<string, string>();
                using (StreamReader sr = new StreamReader(configfile))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string lines = sr.ReadLine();    //记录当前行

                        iLnTmp++;
                        if ((!lines.Contains("#")) && (!lines.Contains("//")) && (!lines.Contains("\\")))
                        {
                            string[] line = lines.Split('=');
                            if (line.Length > 1)
                            {
                                System.Console.WriteLine("key:{0},value:{1}", line[0], line[1]);
                                if (line[0].IndexOf("bdaddr")==0)
                                {
                                    char_number = iLnTmp;
                                }
                                
                            }
                        }

                        if (lines.Contains("xtal_board_offset"))
                        {
                            sText += "xtal_board_offset = ";
                            sText += this.freq.Text + "\r\n";  //将值插入
                        }
                        else {
                            sText += lines + "\r\n";                   
                        }
                    }

                }



                if (!sText.Contains("xtal_board_offset"))
                {

                    string sTmp = "";
                    sTmp += "xtal_board_offset = ";
                    sTmp += this.freq.Text + "\r\n";  //将值插入
                    rst = sText.Insert(sText.IndexOf("bdaddr"), sTmp);

                    // System.Console.Write(rst);

                    //保存文件
                    using (StreamWriter sw = new StreamWriter(configfile, false))
                    {
                        sw.Write(rst);
                        System.Console.Write(rst);
                        sw.Flush();
                    }

                }
                else {


                    //保存文件
                    using (StreamWriter sw = new StreamWriter(configfile, false))
                    {
                        sw.Write(sText);
                        System.Console.Write(sText);
                        sw.Flush();
                    }

                }

                string str = Console.ReadLine();
                Cmd c = new Cmd();



                string  strcmd = this.sdkdir.Text + "\\tools\\bin\\configcmd txt2dev " + configfile + " MERGE -trans \"SPITRANS=USB SPIPORT=0\" -system fht_SDK_3_1_0_315_A06_ROM_1707201539 -database " + "\"" + this.sdkdir.Text + "\\tools\\bin\\CSR102x.sdb\"";
                string  value = c.RunCmd(strcmd);

                System.Console.Write(value);
                if (value.Contains("reading") && value.Contains("writing") && value.Contains("Success"))
                {
                    this.richTextBox1.Text += "设置频偏成功! \r\n";
                }
                else {

                    this.richTextBox1.Text += "设置频偏失败,请重新对设备上电(掉电时长>20秒)或者重新烧写后进行尝试!\r\n";
                }
            }


            /*

                       Int32 freq = Convert.ToInt32(this.freq.Text);

                       string CS_DB_FILE = "CSR102x.sdb:fht_SDK_3_1_0_315_A06_ROM_1707201539";

                       UInt16 CHANNEL_0_FREQ_MHZ = 2402;
                       Byte XTAL_CAL_CHANNEL = 19;
                       UInt16 CRYSTAL_PCB_OFFSET_CS_ID = 0x67;
                       UInt16 CFG_STORE_ID = 123;
                       char CS_ID_STR_SEPARATOR = ':';

                       IntPtr handle = IntPtr.Zero;

                       uEnergyTest.uetRadStop(handle);
                       uEnergyTest.uetClose(handle);

                       Int32 retVal = uEnergyTest.uetOpen("SPITRANS=USB SPIPORT=0", CS_DB_FILE, out handle);

                       if (retVal == 0)
                       {
                           // Measure the frequency
                           if (retVal == 0)
                           {
                               retVal = uEnergyTest.uetRadCwStart(handle, XTAL_CAL_CHANNEL, 0);
                               if (retVal != 0)
                               {
                                   IntPtr errors = IntPtr.Zero;
                                   errors = uEnergyTest.uetGetLastError(handle);
                                   MessageBox.Show(" Error starting CW:" + Marshal.PtrToStringAnsi(errors), "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                               }
                           }

                           if (retVal == 0)
                           {
                               // Calculate offset value (ppm)
                               Double nominalFreqMhz = CHANNEL_0_FREQ_MHZ +
                                                              (2 * XTAL_CAL_CHANNEL);

                               // Example measured value (50kHz offset) - in a real
                               // application this value would be obtained using a spectrum
                               // analyser or other suitable equipment.
                               Double measuredFreqMhz = nominalFreqMhz + 0.05;
                               Int16 offsetPpm;
                               retVal = uEnergyTest.uetRadCalcXtalOffset(handle, nominalFreqMhz,
                                                             measuredFreqMhz, out offsetPpm);

                               if (retVal == 0)
                               {
                                   // Write the offset CS value


                                   string id = null;


                                   ushort length = 1;
                                   ushort[] value = new ushort[1];
                                  // value[0] = (ushort)offsetPpm;
                                   value[0] = (ushort)freq;


                                   UInt16 memDevType = 2;
                                   id = CRYSTAL_PCB_OFFSET_CS_ID.ToString() + CS_ID_STR_SEPARATOR.ToString() + CFG_STORE_ID.ToString() + CS_ID_STR_SEPARATOR.ToString() + memDevType.ToString();
                                   retVal = uEnergyTest.uetCsReadItem(handle, id, value, out length);
                                   if (retVal != 0)
                                   {
                                       IntPtr errors = IntPtr.Zero;
                                       errors = uEnergyTest.uetGetLastError(handle);
                                       MessageBox.Show("Error reading XTAL offset value to CS:" + Marshal.PtrToStringAnsi(errors), "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
             
                                   }



                                   id = CRYSTAL_PCB_OFFSET_CS_ID.ToString() + CS_ID_STR_SEPARATOR.ToString() + CFG_STORE_ID.ToString();

                                   retVal = uEnergyTest.uetCsWriteItem(handle, id, value, out length);
                                   if (retVal != 0)
                                   {
                                       IntPtr errors = IntPtr.Zero;
                                       errors = uEnergyTest.uetGetLastError(handle);
                                       MessageBox.Show("Error writing XTAL offset value to CS:" + Marshal.PtrToStringAnsi(errors), "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
         
                                   }

                               }
                               else
                               {

                                   IntPtr errors = IntPtr.Zero;
                                   errors = uEnergyTest.uetGetLastError(handle);
                                   MessageBox.Show("Error calculating frequency offset value:" + Marshal.PtrToStringAnsi(errors), "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                               }
                           }
                       }
                       else {
                           IntPtr errors = IntPtr.Zero;
                           errors = uEnergyTest.uetGetLastError(handle);
                           MessageBox.Show("Open failure!", "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
    
            
                       }

                       // Stop CW
                       if (retVal == 0)
                       {
                           retVal = uEnergyTest.uetRadStop(handle);
                           MessageBox.Show("设置成功！", "INFORMATION!", MessageBoxButtons.OKCancel);
                       }
         
                       uEnergyTest.uetClose(handle);
             */






        }

        private void test_Click(object sender, EventArgs e)
        {


            string comName = this.com.Text;

            UInt32 bandRate = Convert.ToUInt32(this.bandrate.Text);

            const byte TX_PIO = 8;
            const byte RX_PIO = 9;
            MessageBox.Show("确认连接串口的脚PIO8,PIO9?", "INFORMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            IntPtr handle = IntPtr.Zero;
            int retVal = uEnergyTest.uetOpen("SPITRANS=USB SPIPORT=0", null, out handle);
            if (retVal == 0)
            {
                retVal = uEnergyTest.uetUartLbConfigurableTest(handle, comName, bandRate,
                                                   TX_PIO, RX_PIO, 0, 0, 0);
                if (retVal == 0)
                {
                    MessageBox.Show("UART Loopback test PASSED");
                }
                else if (retVal == -5)
                {
                    MessageBox.Show("UART Loopback test FAILED!");
                }
                else
                {
                    IntPtr errors = IntPtr.Zero;
                    errors = uEnergyTest.uetGetLastError(handle);
                    MessageBox.Show("ERROR during UART test::" + Marshal.PtrToStringAnsi(errors), "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }


            uEnergyTest.uetClose(handle);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string vPortName in SerialPort.GetPortNames())
            {
                this.com.Items.Add(vPortName);
            }

        }

        private void com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bandrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void mac1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input1_keypress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
