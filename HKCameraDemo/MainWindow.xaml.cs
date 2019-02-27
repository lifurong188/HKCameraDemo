using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HKCameraDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        D3DImageSource d3dSource;

        private bool fListenStartFlag = false;    //Flags for the server mode having started.
        private bool fPlaySoundFlag = false;    //Flags for playing sound file
        public UInt32 fTalkID = 0;

        private int FPlayBackCount = 0;
        private bool FOutputStartFlag = false;


        private bool m_bInitSDK = false;
        private Int32 m_lUserID = -1;
        private Int32 m_lRealHandle = -1;
        private uint iLastErr = 0;
        private Int32 m_lPort = -1;
        private IntPtr m_ptrRealHandle = IntPtr.Zero;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        private CHCNetSDK.REALDATACALLBACK RealData = null;
        private PlayCtrl.DECCBFUN m_fDisplayFun = null;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
