using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lorena
{
  public partial class Form1 : Form
  {
    private SalonNode currentNode = null;

    public class SalonNode : TreeNode
    {
      public SalonNode()
      {
      }

      public Salon salon;
    }

    public Form1()
    {
      InitializeComponent();

      if (!DB.Get.prepare())
        Application.Exit();
    }

    private void Form1_Load( object sender, EventArgs e )
    {
      List<Salon> res = DB.Get.execReaderSalon( "SELECT * FROM salon ORDER BY pid ASC" );
      IDictionary<long, SalonNode> nodes = new Dictionary<long, SalonNode>();

      foreach (Salon s in res)
      {
        SalonNode node = new SalonNode();
        node.salon = s;
        node.Text = s.name;

        nodes[ s.id ] = node;

        if (s.pid == 0)
          salonTree.Nodes.Add( node );
        else
          nodes[ s.pid ].Nodes.Add( node );
      }

      salonTree.ExpandAll();
      salonTree.SelectedNode = salonTree.Nodes[0];
      currentNode = (SalonNode) salonTree.Nodes[0];

      List<Results> listResults = DB.Get.execReaderResults( "SELECT * FROM results ORDER BY id ASC" );

      foreach (Results r in listResults)
      {
        int rowNum = dataGridView1.Rows.Add();
        dataGridView1.Rows[ rowNum ].Cells[0].Value = DB.Get.execScalar( "SELECT name FROM salon WHERE id = " + r.sid ).ToString();
        dataGridView1.Rows[ rowNum ].Cells[1].Value = r.price.ToString();
        dataGridView1.Rows[ rowNum ].Cells[2].Value = r.result.ToString();
      }
    }

    private void salonTree_AfterSelect( object sender, TreeViewEventArgs e )
    {
      currentNode = (SalonNode) e.Node;
      Salon s = currentNode.salon;

      name.Text = s.name;
      discount.Text = s.discount.ToString() + " %";
      dep.Text = (s.depend == 1 ? "Да" : "Нет");
      description.Text = s.description;

      price.Text = "";
      price.Focus();
    }

    private void button1_Click( object sender, EventArgs e )
    {
      float val;

      if (float.TryParse( price.Text, out val ))
      {
        float Discount = currentNode.salon.discount;
        float DiscountParent = 0.0F;
        
        if (currentNode.salon.depend == 1)
        {
          long pid = currentNode.salon.id;

          do
          {
            List<Salon> res = DB.Get.execReaderSalon( "SELECT * FROM salon WHERE id = " + pid );
            pid = res[0].pid;
            DiscountParent += res[0].discount;
          }
          while (pid != 0);

          DiscountParent -= currentNode.salon.discount;
        }

        float S = val - (val * ((Discount + DiscountParent) / 100.0F));

        int rowNum = dataGridView1.Rows.Add();
        dataGridView1.Rows[ rowNum ].Cells[0].Value = currentNode.salon.name;
        dataGridView1.Rows[ rowNum ].Cells[1].Value = val.ToString();
        dataGridView1.Rows[ rowNum ].Cells[2].Value = S.ToString();

        DB.Get.execNonQuery( 
          string.Format( 
            "INSERT INTO results (sid, price, result) VALUES ('{0}', {1}, {2})", 
            currentNode.salon.id,
            val.ToString().Replace( ",", "." ),
            S.ToString().Replace( ",", "." )
          ) 
        );
      }
    }
  }
}
