using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Check
{
    public partial class Check : Form
    { 
        Consume _consume = new Consume();
        public Check()
        {
           
            InitializeComponent();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            updateScanlabel();
            System.Threading.Thread T = new Thread(_consume.JealousSCANServ);
            T.Name = "_consume.JealousSCANServ";
            T.Start();
            

        }

        private void Fix_Click(object sender, EventArgs e)
        {
            updateFixlabel();
            System.Threading.Thread T = new Thread(_consume.JealousFIXServ);
            T.Name = "_consume.JealousFIXServ";
            T.Start();

            
        }


        #region updateScanlabel
        private void updateScanlabel()
        {
            CheckServ servistatus = new CheckServ();

            string VSS_status;
            string wuauserv_status;
            string BITS_status;
            string CryptSvc_status;
            string PlugPlay_status;

            string Spooler_status;
            string srservice_status;

            //calling service Check

            servistatus.CheckStatus(
                out VSS_status,
            out wuauserv_status,
           out BITS_status,
           out CryptSvc_status,
             out PlugPlay_status,
             out Spooler_status,
           out srservice_status
           );



            //temp dir Size;

            DirSize nu = new DirSize();

            //for %temp%
            System.IO.DirectoryInfo path =
                new System.IO.DirectoryInfo(System.IO.Path.GetTempPath());
            nu.WalkDirectoryTree(path);

            // Console.WriteLine("Dir: " + System.IO.Path.GetTempPath() +
            //  Environment.NewLine + "Size: " + nu.Number / (1000 * 1000) + " MB ");

            long tempDirSize = nu.Number;

            //for Windows Temp
            nu.Number = 0;

            System.IO.DirectoryInfo NUpath =
                new System.IO.DirectoryInfo(System.IO.Path.GetPathRoot(
               Environment.SystemDirectory) + @"Windows\Temp");
            nu.WalkDirectoryTree(NUpath);

            //  Console.WriteLine("Dir: "
            //  + System.IO.Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\Temp"
            //     + Environment.NewLine
            //    + "Size: " + nu.Number / (1000 * 1000) + " MB ");

            long _tempDirSize = nu.Number;


            long TotalSize = (tempDirSize + _tempDirSize) / (1024 * 1024);

            //OS Version

            GetSystemInfo _GetSystemInfo =
                new GetSystemInfo();

            _GetSystemInfo.getOSVersion();



            this.ResultLabel.Text =
                "EventType :                Scan" + Environment.NewLine
                + VSS_status + "\n"
            + wuauserv_status + "\n"
           + BITS_status + "\n"
            + CryptSvc_status + "\n"
             + PlugPlay_status + "\n"
            + Spooler_status + "\n"
           + srservice_status + "\n"
                //+ System.IO.Path.GetTempPath() + "    " + tempDirSize + "\n"
                //+ System.IO.Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\Temp" + "    " + _tempDirSize
            + "\n" + "Total Temp Dir Size : " + TotalSize + " MB " + "\n"
            + "System Drive Free Space " + "[" + System.IO.Path.GetPathRoot(Environment.SystemDirectory) + "]" + " : " + nu.SystemDriveFreeSpace() + @" % " + "\n"
            + "IE Version : " + nu.GetIEVersion() + Environment.NewLine
            + "OS Version : " + Environment.NewLine + _GetSystemInfo.getOSVersion().ToString() + Environment.NewLine
            + "MAC Address : " + _GetSystemInfo.GetMacAddress().ToString() + Environment.NewLine
            + "System Uptime : " + _GetSystemInfo.getSystemUptime() + Environment.NewLine
            + "Date : " + DateTime.Now + Environment.NewLine 


            ;
        }
        #endregion

        #region updateFixlabel
        private void updateFixlabel()
        {
            CheckServ servistatus = new CheckServ();

            string VSS_status;
            string wuauserv_status;
            string BITS_status;
            string CryptSvc_status;
            string PlugPlay_status;

            string Spooler_status;
            string srservice_status;

            //calling service Check

            servistatus.FixStatus(
                out VSS_status,
            out wuauserv_status,
           out BITS_status,
           out CryptSvc_status,
             out PlugPlay_status,
             out Spooler_status,
           out srservice_status
           );



            //temp dir Size;

            DirSize nu = new DirSize();

            //for %temp%
            System.IO.DirectoryInfo path =
                new System.IO.DirectoryInfo(System.IO.Path.GetTempPath());
            nu.WalkDirectoryTree(path);

            // Console.WriteLine("Dir: " + System.IO.Path.GetTempPath() +
            //  Environment.NewLine + "Size: " + nu.Number / (1000 * 1000) + " MB ");

            long tempDirSize = nu.Number;

            //for Windows Temp
            nu.Number = 0;

            System.IO.DirectoryInfo NUpath =
                new System.IO.DirectoryInfo(System.IO.Path.GetPathRoot(
               Environment.SystemDirectory) + @"Windows\Temp");
            nu.WalkDirectoryTree(NUpath);

            //  Console.WriteLine("Dir: "
            //  + System.IO.Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\Temp"
            //     + Environment.NewLine
            //    + "Size: " + nu.Number / (1000 * 1000) + " MB ");

            long _tempDirSize = nu.Number;


            long TotalSize = (tempDirSize + _tempDirSize) / (1024 * 1024);

            //OS Version

            GetSystemInfo _GetSystemInfo =
                new GetSystemInfo();

            _GetSystemInfo.getOSVersion();



            this.Fixlabel.Text =
            "EventType : Fix " + Environment.NewLine
            + VSS_status + "\n"
        + wuauserv_status + "\n"
       + BITS_status + "\n"
        + CryptSvc_status + "\n"
         + PlugPlay_status + "\n"
        + Spooler_status + "\n"
       + srservice_status + "\n"
                //+ System.IO.Path.GetTempPath() + "    " + tempDirSize + "\n"
                //+ System.IO.Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\Temp" + "    " + _tempDirSize
        + "\n" + "Total Temp Dir Size : " + TotalSize + " MB " + "\n"
        + "System Drive Free Space " + "[" + System.IO.Path.GetPathRoot(Environment.SystemDirectory) + "]" + " : " + nu.SystemDriveFreeSpace() + @" % " + "\n"
        + "IE Version: " + nu.GetIEVersion() + Environment.NewLine
        + "OS Version: " + Environment.NewLine + _GetSystemInfo.getOSVersion().ToString() + Environment.NewLine
            + "MAC Address : " + _GetSystemInfo.GetMacAddress().ToString() + Environment.NewLine
            + "System Uptime : " + _GetSystemInfo.getSystemUptime() + Environment.NewLine
            + "Date : " + DateTime.Now + Environment.NewLine 
        ;
        }
        #endregion
    }
}
