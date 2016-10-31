using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace DirectXTest
{
    public partial class Form1 : Form
    {
        private Device dev = null;

        public Form1()
        {
            InitializeComponent();
            InitD3D();
        }

        public void InitD3D()
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            dev = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, pp);
            // this를 넣으면 폼 전체에 렌더링되고 다른 컨트롤을 넣으면 그 컨트롤에 렌더링된다.
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dev.Clear(ClearFlags.Target, Color.Blue, 1.0f, 0);
            dev.Present();
        }
    }
}
