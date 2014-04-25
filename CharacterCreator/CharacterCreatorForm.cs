using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CharacterCreator
{
    public partial class CharacterCreatorForm : Form
    {
        public CharacterCreatorForm()
        {
            InitializeComponent();
            ClassComboBox.DataSource = Enum.GetValues(typeof(Character.ClassType));
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (var SaveDialog = new SaveFileDialog() { Filter = "(*.xml)|*.xml" })
            {
                Console.WriteLine();
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    int ParsedLevel = int.Parse(LevelTextBox.Text);
                    string[] Stats = StatsTextBox.Text.Split(',');
                    if (Stats.Length != 6)
                        MessageBox.Show("Statistiche mal formattate");
                    else if (LevelTextBox.Text == "" && ParsedLevel > 0 && ParsedLevel < 30)
                        MessageBox.Show("Livello non valido");
                    else
                    {
                        new XmlSerializer(typeof(Character)).Serialize(new FileStream(SaveDialog.FileName != "" ? SaveDialog.FileName : "noname.xml", FileMode.Create),
                            new Character()
                            {
                                CharacterClass = (Character.ClassType)ClassComboBox.SelectedItem,
                                Str = Stats[0],
                                Cos = Stats[1],
                                Des = Stats[2],
                                Sag = Stats[3],
                                Inte = Stats[4],
                                Car = Stats[5],
                                Level = int.Parse(LevelTextBox.Text)
                            }, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
                        MessageBox.Show("Personaggio esportato");
                    }
                }
            }
        }
    }
}
