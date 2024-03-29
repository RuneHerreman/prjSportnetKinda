﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace prjSportnetKinda.View
{
    public partial class ButtonControls : Button
    {
        ToolTip tooltip1 = new ToolTip();

        //properties
        private Image NormaalFoto;
        private Image HoverFoto;
        private string Tooltip;
        public ButtonControls()
        {
            InitializeComponent();
        }
        [Category("HoverButtons")]

        public Image NormaalFoto1 
        { get => NormaalFoto; set => NormaalFoto = value; }
        [Category("HoverButtons")]
        public Image HoverFoto1 
        { get => HoverFoto; set => HoverFoto = value; }
        [Category("HoverButtons")]
        public string Tooltip1 
        { get => Tooltip; set => Tooltip = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        //importeren 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //entry point --> naam om code te activeren (wordt geëxecute)
        private static extern IntPtr CreateRoundRectRgn
            (
            //opgeslagen waarden
                int lr,
                int tr,
                int rr,
                int br,
                int we,
                int he
            );

        private void ButtonControls_MouseEnter(object sender, EventArgs e)
        {
            //hover --> hoverfoto | tooltip tonen
            Image = HoverFoto;
            tooltip1.Show(Tooltip,this);
        }

        private void ButtonControls_MouseLeave(object sender, EventArgs e)
        {
            //niet meer hover --> normale foto | tooltip verstoppen
            Image = NormaalFoto;
            tooltip1.Hide(this);
        }

        private void ButtonControls_Paint(object sender, PaintEventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
    }
}
