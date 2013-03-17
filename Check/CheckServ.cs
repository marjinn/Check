using System;
using System.Collections.Generic;
using System.Text;

using System.ServiceProcess;

namespace Check
{
    class CheckServ
    {
        

        public CheckServ()
        {
 
        }

      
        /*
        public bool FixStatus(string ServiceName)
        {
            

            foreach (ServiceController service in ServiceController.GetServices())
            {
                string serviceName = service.ServiceName.ToString();
                string serviceDisplayName = service.DisplayName;
                string serviceType = service.ServiceType.ToString();
                string status = service.Status.ToString();

                switch (serviceName)
                {
                    case "VSS" :
                        
                        break;

                    case "wuauserv" :
                        break;

                    case "BITS":
                        break;

                    case "CryptSvc":
                        break;

                    case "PlugPlay":
                        break;
                   
                    case "srservice":
                        break;

                    case "Spooler":
                        break;




                    default:
                        break;

                }




            }

            return true;
        }

         */ 
      

       #region CheckServiceStatus
        public void CheckStatus(
            out string VSS_status,
            out string wuauserv_status,
            out string BITS_status,
            out string CryptSvc_status,
            out string PlugPlay_status,
            
            out string Spooler_status,
            out string srservice_status
            )
        {
                VSS_status = null;
                wuauserv_status = null;
                BITS_status = null;
                CryptSvc_status = null;
                PlugPlay_status = null;
                
                Spooler_status = null;
                srservice_status = null;

            foreach (ServiceController service in ServiceController.GetServices())
            {
                string serviceName = service.ServiceName.ToString();
                string serviceDisplayName = service.DisplayName;
                string serviceType = service.ServiceType.ToString();
                string status = service.Status.ToString();

                switch (serviceName)
                {
                    case "VSS":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
     (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            VSS_status = service.DisplayName  + " : " + service.Status;
                            
                        }
                        else
                        {
                            VSS_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "wuauserv":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
    (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            wuauserv_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            wuauserv_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "BITS":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
    (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            BITS_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            BITS_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "CryptSvc":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
    (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            CryptSvc_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            CryptSvc_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "PlugPlay":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
    (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            PlugPlay_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            PlugPlay_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;


                    case "Spooler":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
    (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            Spooler_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            Spooler_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    default:
                        break;



                    case "srservice":
                        if ((status.Equals(ServiceControllerStatus.Stopped)) ||
    (status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            srservice_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            srservice_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                }




            }


        }


          #endregion



        #region FixServiceStatus
        public void FixStatus(
            out string VSS_status,
            out string wuauserv_status,
            out string BITS_status,
            out string CryptSvc_status,
            out string PlugPlay_status,

            out string Spooler_status,
            out string srservice_status
            )
        {
            VSS_status = null;
            wuauserv_status = null;
            BITS_status = null;
            CryptSvc_status = null;
            PlugPlay_status = null;

            Spooler_status = null;
            srservice_status = null;

            foreach (ServiceController service in ServiceController.GetServices())
            {
                string serviceName = service.ServiceName.ToString();
                //string serviceDisplayName = service.DisplayName;
                string serviceType = service.ServiceType.ToString();
                //string status = service.Status.ToString();

                switch (serviceName)
                {
                    case "VSS":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
     (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            #region StartServ VSS
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */ 
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            VSS_status = service.DisplayName  + " : " + service.Status;

                        }
                        else
                        {
                            VSS_status = service.DisplayName  + " : " + service.Status;

                            /*
                            System.Windows.Forms.MessageBox.Show(
                                    service.DisplayName + Environment.NewLine
                                    + service.Status
                                    );
                             */ 
                        }
                        break;

                    case "wuauserv":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            #region StartServ wuauserv
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            wuauserv_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            wuauserv_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "BITS":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            #region StartServ BITS
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            BITS_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            BITS_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "CryptSvc":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            #region StartServ CryptSvc
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            CryptSvc_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            CryptSvc_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    case "PlugPlay":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {

                            #region StartServ PlugPlay
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            PlugPlay_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            PlugPlay_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;


                    case "Spooler":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            #region StartServ Spooler
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            Spooler_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            Spooler_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                    default:
                        break;



                    case "srservice":
                        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                        {
                            #region StartServ srservice
                            /*
                            System.Windows.Forms.MessageBox.Show("asdadsadsda" +
                                    service.DisplayName + Environment.NewLine 
                                    + service.Status
                                    );
                             */
                            try
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            catch (System.ComponentModel.Win32Exception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    service.DisplayName
                                    + Environment.NewLine
                                    + "An error occurred when accessing a system API."
                                    );
                            }
                            catch (System.InvalidOperationException)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                     service.DisplayName
                                     + Environment.NewLine
                                     + "The service was not found."
                                     );
                            }

                            catch (Exception eXception)
                            {
                                System.Diagnostics.Debug.WriteLine(
                                    eXception.Message
                                    );
                                /*
                                System.Windows.Forms.MessageBox.Show(
                                    eXception.Message
                                    );

                                 */
                            }

                            #endregion

                            srservice_status = service.DisplayName  + " : " + service.Status;
                        }
                        else
                        {
                            srservice_status = service.DisplayName  + " : " + service.Status;
                        }
                        break;

                }




            }


        }


        #endregion



    }


}
