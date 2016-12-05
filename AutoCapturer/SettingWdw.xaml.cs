using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace AutoCapturer
{
    /// <summary>
    /// SettingWdw.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SettingWdw : Window
    {
        public SettingWdw()
        {
            InitializeComponent();

            DragBorder.MouseDown += DragBrder_MD;
            DragBorder.MouseUp += DragBrder_MU;
            this.KeyDown += Wdw_KD;
            this.KeyUp += Wdw_KU;
        }
        void DragBrder_MD(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // this prevents win7 aerosnap
                if (this.ResizeMode != System.Windows.ResizeMode.NoResize)
                {
                    this.ResizeMode = System.Windows.ResizeMode.NoResize;
                    this.UpdateLayout();
                }

                DragMove();
                if (this.ResizeMode == System.Windows.ResizeMode.NoResize)
                {
                    // restore resize grips
                    this.ResizeMode = System.Windows.ResizeMode.CanResizeWithGrip;
                    this.UpdateLayout();
                }
            }
        }

        void DragBrder_MU(object sender, MouseButtonEventArgs e)
        {

        }
        
        private void CloseBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }






    }
}
