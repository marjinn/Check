using System;
using System.Collections.Generic;
using System.Text;

using Check.sutherlandsmbpov;

namespace Check
{
    class Consume
    {
        public Consume()
        {
        }

        private void AddC()
        {
            insertObjectC _insertObjectC = new insertObjectC();


            ////get Service status 

            CheckServ _checkServ = new CheckServ();
            string VSS_status;
            string wuauserv_status;
            string BITS_status;
            string CryptSvc_status;
            string PlugPlay_status;

            string Spooler_status;
            string srservice_status;

            //calling service Check

            _checkServ.CheckStatus(
                out VSS_status,
            out wuauserv_status,
           out BITS_status,
           out CryptSvc_status,
             out PlugPlay_status,
             out Spooler_status,
           out srservice_status
           );


            _insertObjectC.U_background_intelligent = BITS_status;
            _insertObjectC.U_system_restore_service = VSS_status;
            _insertObjectC.U_plug_and_play_service  = PlugPlay_status;
            _insertObjectC.U_print_spooler_service = Spooler_status;
            _insertObjectC.U_cryptographic_service = CryptSvc_status;
            _insertObjectC.U_windows_update_service = wuauserv_status;


            //OS Version

            GetSystemInfo _GetSystemInfo =
                new GetSystemInfo();

            _insertObjectC.U_os_version_and_service_pack = 
                _GetSystemInfo.getOSVersion();


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

            _insertObjectC.U_temporary_files_folders_size =
                TotalSize.ToString();

            //Scan ID ---

            Random _random = new Random();

            _insertObjectC.U_scan_id = _random.Next().ToString();


            //MAC ID

            _insertObjectC.U_mac_id = _GetSystemInfo.GetMacAddress();

            //DriveFreeSpace



            _insertObjectC.U_hard_disk_space = _GetSystemInfo.SystemDriveFreeSpace().ToString();


            //IE Version

            _insertObjectC.U_ie_version = _GetSystemInfo.GetIEVersion();

          //event Type

            _insertObjectC.U_event_type = "Scan";

            //system uptime

            _insertObjectC.U_system_uptime =
                _GetSystemInfo.getSystemUptime();





        }

        public void JealousServ()
        {
            //instantiate myService to webreference

            sutherlandsmbpov.ServiceNow_u_poc_snf
                _service = new ServiceNow_u_poc_snf();


            //adding login credentials

            System.Net.NetworkCredential _credentials =
                new System.Net.NetworkCredential();

            _credentials.UserName = "admin";
            _credentials.Password = "admin";

            _service.Credentials = _credentials;

            //instantiate the object to call which will be a
            //function in the webservice I intent
            //to use

            sutherlandsmbpov.insert _objinsert =
                new insert();






        }




    }
}
