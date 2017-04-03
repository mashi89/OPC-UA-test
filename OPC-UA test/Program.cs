using Hylasoft.Opc.Common;
using Hylasoft.Opc.Ua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Date: 15.3.2017
// Author: Markus Hirvonen, InSolution Oy, Tampere, Finland

namespace OPC_UA_test
{
    static class Program
    {
        public static List<string> opcNodes = new List<string>();
        public static BindingList<string> opcNodeItems = new BindingList<string>();
        public static string clientAddress = "";
        public static string nodeToFind = "MTConnect Device.MTConnect WebDevice";
        public static string nodeChildren = "";
        public static string nodeGrandChildren = "";

        // Set OPC UA server address
        public static UaClient client = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Connect()
        {
            // Connect to OPC UA Server
            try
            {
                client = new UaClient(new Uri(clientAddress));
                client.Connect();
            } catch (Opc.Ua.ServiceResultException e)
            {
                throw e;
            }
        }
        
        public static List<string> FindNodeChildren(string requestedNode)
        {
            List<string> nodeList = new List<string>();
            nodeToFind = requestedNode;
            var node = client.FindNode(nodeToFind);
            IEnumerable<Node> children = client.ExploreFolder(node.Tag);
            foreach (Node n in children)
            {
                try
                {
                    try
                    {
                        nodeList.Add(n.Name + ": " + client.Read<string>(n.Tag));
                    }
                    catch (InvalidCastException)
                    {
                        nodeList.Add(n.Name + ": " + client.Read<double>(n.Tag));
                    }
                }
                catch (OpcException)
                {
                    nodeList.Add(n.Name + ": No data");
                }
            }
            return nodeList;
        }

        public static List<string> SelectNode(string nodeName)
        {
            // Handle selected node
            List<string> nodeList = new List<string>();
            var selectedNode = client.FindNode(nodeToFind);

            if (nodeChildren != "")
            {
                nodeGrandChildren = nodeChildren + "." + nodeName;
                selectedNode = client.FindNode(nodeGrandChildren);
            }
            else
            {
                nodeChildren = nodeToFind + "." + nodeName;
                selectedNode = client.FindNode(nodeChildren);
            }

            IEnumerable<Node> children = client.ExploreFolder(selectedNode.Tag);

            // Populate list
            foreach (Node n in children)
            {
                try
                {
                    try
                    {
                        nodeList.Add(n.Name + ": " + client.Read<string>(n.Tag));
                    }
                    catch (InvalidCastException)
                    {
                        try
                        {
                            nodeList.Add(n.Name + ": " + client.Read<double>(n.Tag));
                        }
                        catch (InvalidCastException)
                        {
                            try
                            {
                                nodeList.Add(n.Name + ": " + client.Read<uint>(n.Tag));
                            }
                            catch (InvalidCastException)
                            {
                                throw;
                            }
                        }
                    }
                }
                catch (OpcException)
                {
                    nodeList.Add(n.Name + ": No data");
                }
            }
            return nodeList;
        }
        public static void ShowValues(string nodeName)
        {
            // Handle selected node
            var selectedNode = client.FindNode(nodeGrandChildren + "." + nodeName);
            IEnumerable<Node> snchildren = client.ExploreFolder(selectedNode.Tag);

            //IEnumerable<Node> sngrandChildren = snchildren.SelectMany(m => client.ExploreFolder(m.Tag));

            opcNodeItems.Clear();

            // Populate list
            var nodeID = selectedNode.NodeId;
            int firstChar = nodeID.IndexOf(";") + 1;
            string valueType = nodeID.Substring(firstChar, 1);

            try
            {
                switch (valueType)
                {
                    case "i":
                        opcNodeItems.Add(selectedNode.Name + ": " + client.Read<int>(selectedNode.ToString()));
                        break;
                    case "s":
                        try {
                            opcNodeItems.Add(selectedNode.Name + ": " + client.Read<string>(selectedNode.ToString()));
                        }
                        catch (InvalidCastException) {
                            opcNodeItems.Add(selectedNode.Name + ": " + client.Read<double>(selectedNode.ToString()));
                        }
                        break;
                    case "g":
                        opcNodeItems.Add(selectedNode.Name + ": " + client.Read<Guid>(selectedNode.ToString()));
                        break;
                    case "b":
                        opcNodeItems.Add(selectedNode.Name + " : " + client.Read<string>(selectedNode.ToString()));
                        break;
                }
            }
            catch (OpcException e) {
                opcNodeItems.Add(selectedNode.Name + ": No data");
            }
            
        }
    }

}
