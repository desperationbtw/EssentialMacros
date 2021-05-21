using System;
using System.Threading;
using System.Windows.Forms;

namespace EssentialMacros
{
    class OffsetWorker
    {
        Thread offsetter;
        public bool MouseIsDown = false;
        public static bool inventoryIsOpen = false;
        public double default_offset = 1;
        public double fov_offset = 1;
        public void MC()
        {
            if (!inventoryIsOpen)
            {
                for (int i = 0; i < Constants.currentWeapon.offsets.Length; i++)
                {
                    if (!MouseIsDown) //Выход из цикла, когда ЛКМ отжата
                        break;
                    string[] CharsArr = Constants.currentWeapon.offsets[i].Split(' '); //Сплит строки на массив

                    if (CharsArr[0] == "Delay") //Обработчик пауз
                        Thread.Sleep(int.Parse(CharsArr[1]));
                    if (CharsArr[0] == "MoveR") //Обработчик смещений
                    {
                        int x = Convert.ToInt32(double.Parse(CharsArr[1]) * (1 / default_offset) * fov_offset);
                        int y = Convert.ToInt32(double.Parse(CharsArr[2]) * (1 / default_offset) * fov_offset);
                        Utils.Move(x, y);
                    } /* Можно поправить в хелп классе клик и добавить обработчик кликов для всяких берданок. Но нахуя? */
                }
            }
        }

        public void MD(object sender, MouseEventArgs e) //Ивент на нажатие ЛКМ
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseIsDown = true;
                if (Constants.currentWeapon != null)
                {
                    offsetter = new Thread(() => MC()); //Новый поток смещающий мышь по офсету
                    offsetter.Start();
                }
                    
            }
        }

        public void MU(object sender, MouseEventArgs e) //Ивент на отжатие ЛКМ
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseIsDown = false;
                if (Constants.currentWeapon != null && offsetter != null)
                    offsetter.Abort();
            }
        }
    }
}
