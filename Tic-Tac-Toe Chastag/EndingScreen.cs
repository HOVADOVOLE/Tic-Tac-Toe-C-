using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Chastag
{
    public partial class EndingScreen : Form
    {
        public EndingScreen()
        {
            InitializeComponent();
        }
        public void Won()
        {
            var text = new Label
            {
                Name = "lblEndText",
                Location = new Point(250, 250),
                Text = "You won",
            };
            this.Controls.Add(text);
        }
        
        public void Lost()
        {
            var text = new Label
            {
                Name = "lblEndText",
                Location = new Point(250, 250),
                Text = "You lost.....looser",
                Font = new Font("Segoe UI", 20),
            };
            this.Controls.Add(text);
        }

        public void Draw()
        {
            var text = new Label
            {
                Name = "lblEndText",
                Location = new Point(250, 250),
                Text = "Draw",
                Font = new Font("Segoe UI", 20),
            };
            this.Controls.Add(text);
        }
    }
}
