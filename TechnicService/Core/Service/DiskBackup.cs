using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace TechnicService.Core.Service
{
    public class DiskBackup
    {
        public void BackupByDisk(string diskName)
        {
            string server = @"(localdb)\MSSQLLocalDB";
            string backupPath = diskName + @":\Yedekler/TechicService_" + DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year + ".bak";
            string backupFolder = diskName + ":\\Yedekler";
            System.IO.Directory.CreateDirectory(backupFolder);
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(backupFolder);
            System.IO.FileInfo[] fis = di.GetFiles("*.bak");
            if (fis.Length == 0 || (DateTime.Now - fis.Max(d => d.CreationTime)).TotalDays >= 5)
            {
                Server dbServer = new Server(new ServerConnection(server));
                Backup dbBackup = new Backup();
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = "TechnicService";
                dbBackup.Devices.AddDevice(backupPath, DeviceType.File);
                dbBackup.Initialize = false;
                dbBackup.Complete += DbBackupOnComplete;
                dbBackup.SqlBackup(dbServer);

                MessageBox.Show(diskName + " " + "diskine veriler yedeklendi","Veri Yedekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void DbBackupOnComplete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
