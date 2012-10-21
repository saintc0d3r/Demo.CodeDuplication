using System.Drawing;
using System.Windows.Forms;

using Demo.Duplication.WinForm.Properties;
using Demo.Duplication.WinForm.MaintenanceForms;

namespace Demo.Duplication.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormOnLoad( object sender, System.EventArgs e )
        {
            setupMainTreeView();
        }

        private void setupMainTreeView()
        {
            mainTreeview.Nodes[ "rootNode" ].Text = System.Environment.MachineName;

            buildReferencesTreeNodes();

            mainTreeview.ExpandAll();
        }

        private void buildReferencesTreeNodes()
        {
            TreeNode parentNode = mainTreeview.Nodes[ "rootNode" ].Nodes[ "ReferencesNode" ];

            buildChildNode( parentNode, "Employment Status", Resources.Employees, new EmploymentStatusMaintenanceForm() );

            #region Copy-pasted from prior block and its few lines are modified resulting to duplications

            //child = new TreeNode( "Department" );
            //nodesImageList.Images.Add( Resources.Departments );
            //child.ImageIndex = nodesImageList.Images.Count - 1;
            //child.SelectedImageIndex = nodesImageList.Images.Count - 1;
            //child.Tag = new DepartmentMaintenanceForm();
            //parentNode.Nodes.Add( child );

            //child = new TreeNode( "Section" );
            //nodesImageList.Images.Add( Resources.Sections );
            //child.ImageIndex = nodesImageList.Images.Count - 1;
            //child.SelectedImageIndex = nodesImageList.Images.Count - 1;
            //child.Tag = new SectionMaintenanceForm();
            //parentNode.Nodes.Add( child );

            //child = new TreeNode( "Position" );
            //nodesImageList.Images.Add( Resources.Positions );
            //child.ImageIndex = nodesImageList.Images.Count - 1;
            //child.SelectedImageIndex = nodesImageList.Images.Count - 1;
            //child.Tag = new PositionMaintenanceForm();
            //parentNode.Nodes.Add( child );

            //child = new TreeNode( "WorkSchedule" );
            //nodesImageList.Images.Add( Resources.WorkSchedule );
            //child.ImageIndex = nodesImageList.Images.Count - 1;
            //child.SelectedImageIndex = nodesImageList.Images.Count - 1;
            //child.Tag = new WorkScheduleMaintenanceForm();
            //parentNode.Nodes.Add( child );

            #endregion

            #region Refactored prior duplications

            buildChildNode( parentNode, "Department", Resources.Employees, new EmploymentStatusMaintenanceForm() );
            
            // And the rest goes here. Duplications are minimised and parameterised.
            #endregion
        }

        private void buildChildNode( TreeNode parentNode, string nodeTitle, Icon icon, object nodeTag )
        {
            TreeNode child = new TreeNode( nodeTitle );
            nodesImageList.Images.Add( icon );
            child.ImageIndex = nodesImageList.Images.Count - 1;
            child.SelectedImageIndex = nodesImageList.Images.Count - 1;
            child.Tag = nodeTag;
            parentNode.Nodes.Add( child );
        }

        private void mainTreeview_NodeMouseDoubleClick( object sender, TreeNodeMouseClickEventArgs e )
        {
            Form nodeForm = e.Node.Tag as Form;
            if (nodeForm != null)
            {
                nodeForm.MdiParent = this;
                nodeForm.Show();
                nodeForm.Activate();
            }
        }
    }
}
