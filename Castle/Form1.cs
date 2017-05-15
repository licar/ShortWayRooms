using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Room room1 = new Room("1");
            Room room2 = new Room("2");
            Room room3 = new Room("3");
            Room room4 = new Room("4");

            room1.addConnectedObject(room2);
            room1.addConnectedObject(room3);
            room2.addConnectedObject(room1);
            room3.addConnectedObject(room1);
            room1.addConnectedObject(room4);
            room4.addConnectedObject(room1);

            room2.addConnectedObject(room3);
            room3.addConnectedObject(room2);
            
            room2.addConnectedObject(room4);
            room4.addConnectedObject(room2);

            room3.addConnectedObject(room4);
            room4.addConnectedObject(room3);

            List<CastleObject> castleObjects = new List<CastleObject>();
            castleObjects.Add(room1);
            castleObjects.Add(room2);
            castleObjects.Add(room3);
            castleObjects.Add(room4);

            IGuide guide = new Guide(castleObjects);
            List<Room> way = guide.paiwWay(room1, room4);
        }
    }
}
