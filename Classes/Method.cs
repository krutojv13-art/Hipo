using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Hipo.Classes
{
    internal class Method
    {
        public static void LoadList(ListView targetListView)
        {
            targetListView.Items.Clear();
            DriveInfo[] alldrive = DriveInfo.GetDrives();
            foreach (DriveInfo drive in alldrive)
            {
                if (drive.IsReady)
                {
                    long freespace = drive.AvailableFreeSpace / (1024 * 1024 * 1024);
                    long totalspace = drive.TotalSize / (1024 * 1024 * 1024);
                    long usedspace = totalspace - freespace;
                    int usedPercentage = (int)((usedspace * 100) / totalspace);

                    ListViewItem item = new ListViewItem(drive.Name);
                    item.SubItems.Add(totalspace.ToString() + "ГБ");
                    item.SubItems.Add(freespace.ToString() + "ГБ");
                    item.SubItems.Add(usedPercentage.ToString() + "%");

                    if (usedPercentage > 90)
                    {
                        item.BackColor = System.Drawing.Color.LightCoral;
                    }

                    targetListView.Items.Add(item);


                }
            }
            foreach (ColumnHeader column in targetListView.Columns)
            {
                column.Width = -2;
            }

        }
        public static string GetSelectedFile(ListView targetlist)
        {
            if (targetlist.SelectedItems.Count == 0) return null;
            return targetlist.SelectedItems[0].SubItems.Count > 2
                ? targetlist.SelectedItems[0].SubItems[2].Text
                : targetlist.SelectedItems[0].Text;
        }

    }
}
