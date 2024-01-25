using System;
using System.Drawing;
using System.Windows.Forms;

namespace prjSportnetKinda.View
{
    public partial class ButtonControls : Button
    {
        ToolTip tooltip1 = new ToolTip();
        //properties
        private Image NormaalFoto;
        private Image HoverFoto;
        private Color NormaalKleur;
        private Color HoverKleur;
        private string Tooltip;
        public ButtonControls()
        {
            InitializeComponent();
        }

        public Image NormaalFoto1 
        { get => NormaalFoto; set => NormaalFoto = value; }
        public Image HoverFoto1 
        { get => HoverFoto; set => HoverFoto = value; }
        public Color NormaalKleur1 
        { get => NormaalKleur; set => NormaalKleur = value; }
        public Color HoverKleur1 
        { get => HoverKleur; set => HoverKleur = value; }
        public string Tooltip1 
        { get => Tooltip; set => Tooltip = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void ButtonControls_MouseEnter(object sender, EventArgs e)
        {
            Image = HoverFoto;
            ForeColor = HoverKleur;
            tooltip1.Show(Tooltip,this);
        }

        private void ButtonControls_MouseLeave(object sender, EventArgs e)
        {
            Image = NormaalFoto;
            ForeColor = NormaalKleur;
            tooltip1.Show(Tooltip, this);
        }
        //https://www.youtube.com/watch?v=yFkopO3A8GM&t=175s
    }
}
