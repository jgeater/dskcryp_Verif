using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace dskcryp_Verif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //get the current bitlocker ver and stastus
            Process BLINFO = new Process();
            BLINFO.StartInfo.FileName = "manage-BDE.exe";
            BLINFO.StartInfo.Arguments = "-status c:";
            BLINFO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            BLINFO.StartInfo.UseShellExecute = false;
            BLINFO.StartInfo.RedirectStandardOutput = true;
            BLINFO.StartInfo.RedirectStandardInput = true;
            BLINFO.StartInfo.RedirectStandardError = true;
            BLINFO.StartInfo.CreateNoWindow = true;
            BLINFO.Start();
            string BLoutput = BLINFO.StandardOutput.ReadToEnd();
            string[] result = BLoutput.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            BLINFO.WaitForExit();

            //Clean up the strings
            String cur_BLver = (result[5]);
            cur_BLver = cur_BLver.Replace(" ", "\t");
            String Cur_BLstat = (result[9]);
            Cur_BLstat = Cur_BLstat.Replace(" ", "\t");

            //display the Bitlocker status info in the UI
            if (Cur_BLstat.Contains("On"))
            {
                cur_BLStat.BackColor = Color.LawnGreen;
                cur_BLStat.Text = "ON";
            }

            if (Cur_BLstat.Contains("Off"))
            {
                cur_BLStat.BackColor = Color.Red;
                cur_BLStat.Text = "OFF";
                fixIt_Btn.Enabled = true;
            }

            //Display the bitlocker ver in the UI

            if (cur_BLver.Contains("2.0"))
            {
                SHO_BL_VER.BackColor = Color.LawnGreen;
                SHO_BL_VER.Text = "2.0";
            }

            if (Cur_BLstat.Contains("1.2"))
            {
                SHO_BL_VER.BackColor = Color.LawnGreen;
                SHO_BL_VER.Text = "1.2";
            }

            //Now Gather and Set the TPM information
            Process TPMINFO = new Process();
            TPMINFO.StartInfo.FileName = "powershell";
            TPMINFO.StartInfo.Arguments = "get-tpm";
            TPMINFO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            TPMINFO.StartInfo.UseShellExecute = false;
            TPMINFO.StartInfo.RedirectStandardOutput = true;
            TPMINFO.StartInfo.RedirectStandardInput = true;
            TPMINFO.StartInfo.RedirectStandardError = true;
            TPMINFO.StartInfo.CreateNoWindow = true;
            TPMINFO.Start();
            string TPMoutput = TPMINFO.StandardOutput.ReadToEnd();
            string[] TPM_result = TPMoutput.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            TPMINFO.WaitForExit();

            String TPM_READY = (TPM_result[1]);
            //String TPM_LockedOut = (TPM_result[8]);

            if (TPM_READY.Contains ("True"))
            {
                TPM_Redy_State.BackColor = Color.LawnGreen;
                TPM_Redy_State.Text = "Ready";
                //Delete reg key flag if it exists

            }

            if (TPM_READY.Contains("False"))
            {
                TPM_Redy_State.BackColor = Color.Red;
                TPM_Redy_State.Text = "Not Ready";
                fixIt_Btn.Enabled = true;
                //create reg flag key if it doesnt exist

            }

            //get and display the TPM locked out value
            Process TPM_LO = new Process();
            TPM_LO.StartInfo.FileName = "powershell";
            TPM_LO.StartInfo.Arguments = "$tpm_LO = get-tpm ; $tpm_lo.LockedOut";
            TPM_LO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            TPM_LO.StartInfo.UseShellExecute = false;
            TPM_LO.StartInfo.RedirectStandardOutput = true;
            TPM_LO.StartInfo.RedirectStandardInput = true;
            TPM_LO.StartInfo.RedirectStandardError = true;
            TPM_LO.StartInfo.CreateNoWindow = true;
            TPM_LO.Start();
            string TPMLOoutput = TPM_LO.StandardOutput.ReadToEnd();
            string[] TPMLO_result = TPMLOoutput.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            TPMINFO.WaitForExit();



            if (TPMLO_result.Contains("False"))
            {
                TPM_Cur_Lock_Stat.BackColor = Color.LawnGreen;
                TPM_Cur_Lock_Stat.Text = "No";
            }

            if (TPMLO_result.Contains("True"))
            {
                TPM_Cur_Lock_Stat.BackColor = Color.Red;
                TPM_Cur_Lock_Stat.Text = "YES";
            }

            
            //get and populate the recovery key
            Process RecINFO = new Process();
            RecINFO.StartInfo.FileName = "manage-BDE.exe";
            RecINFO.StartInfo.Arguments = "C: -protectors -get -type RecoveryPassword";
            RecINFO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            RecINFO.StartInfo.UseShellExecute = false;
            RecINFO.StartInfo.RedirectStandardOutput = true;
            RecINFO.StartInfo.RedirectStandardInput = true;
            RecINFO.StartInfo.RedirectStandardError = true;
            RecINFO.StartInfo.CreateNoWindow = true;
            RecINFO.Start();
            string rKeyOutput = RecINFO.StandardOutput.ReadToEnd();
            string[] cur_Rkey = rKeyOutput.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            RecINFO.WaitForExit();
            //clean up and display the recovery key
            //String my_Rkey = cur_Rkey[11];
            String my_Rkey = cur_Rkey[7];
            my_Rkey = my_Rkey.TrimStart();
            //need a better way, loop thorugh the results and if the length is 63 then it is a recovery key. there could be more than one

            cur_RecKey.Text = (my_Rkey);



        }

        private void exit_Btn_Click (object sender, EventArgs e)
        {
            Environment.Exit(0);           
        }

        private void fixIt_Btn_Click(object sender, EventArgs e)
        {
            // disable Bitlocker
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.FileName = "Manage-bde";
            p.StartInfo.Arguments = "-protectors -disable c:";
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();

            //clear the TPM
            Process Clr_TPM = new Process();
            Clr_TPM.StartInfo.FileName = "powershell";
            Clr_TPM.StartInfo.Arguments = "$oTPM = gwmi -Class Win32_TPM -Namespace root\\CIMV2\\Security\\MicrosoftTpm ;$oTPM.SetPhysicalPresenceRequest(22)";
            Clr_TPM.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Clr_TPM.StartInfo.UseShellExecute = false;
            Clr_TPM.StartInfo.RedirectStandardOutput = true;
            Clr_TPM.StartInfo.RedirectStandardInput = true;
            Clr_TPM.StartInfo.RedirectStandardError = true;
            Clr_TPM.StartInfo.CreateNoWindow = true;
            Clr_TPM.Start();
            Clr_TPM.WaitForExit();
            
            //reboot the computer
            Process Shutdwn = new Process();
            Shutdwn.StartInfo.UseShellExecute = false;
            Shutdwn.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Shutdwn.StartInfo.RedirectStandardOutput = false;
            Shutdwn.StartInfo.FileName = "cmd";
            Shutdwn.StartInfo.Arguments = "/C shutdown -f -r -t 5";
            Shutdwn.StartInfo.RedirectStandardInput = false;
            Shutdwn.Start();
            Shutdwn.WaitForExit();


            



        }
    }
}
