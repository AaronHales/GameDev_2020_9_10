using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list
{
    public partial class to_do_list : Form
    {
        LinkedList<String> todoList = new LinkedList<String>();

        public to_do_list()
        {
            InitializeComponent();
            display_List();
        }

        private void to_do_list_Load(object sender, EventArgs e)
        {
            
        }

        private void display_List()
        {
            item_txt_box.Text = "";
            to_do_list_box.Items.Clear();
            foreach (String x in todoList)
            {
                to_do_list_box.Items.Add(x);
            }
        }

        private void add_front_bttn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == add_front_bttn)
            {
                if (item_txt_box.Text != "")
                {
                    todoList.AddFirst(item_txt_box.Text);
                    display_List();
                }
            }
            else if (button == add_back_bttn)
            {
                if (item_txt_box.Text != "")
                {
                    todoList.AddLast(item_txt_box.Text);
                    display_List();
                }
            }
            else if (button == add_after_bttn)
            {
                if (to_do_list_box.SelectedItem != null)
                {
                    if (item_txt_box.Text != "")
                    {
                        String add_after_item = to_do_list_box.SelectedItem.ToString();
                        LinkedListNode<String> selected_item = todoList.Find(add_after_item);
                        todoList.AddAfter(selected_item, item_txt_box.Text);
                        display_List();
                    }
                    else
                    {
                        MessageBox.Show("Must enter new item into item text box");
                    }
                }
                else
                {
                    MessageBox.Show("Must select an item to add new item after");
                }
            }
            else if (button == clear_bbtn)
            {
                todoList.Clear();
                display_List();
            }
            else if (button == remove_bttn)
            {
                if (to_do_list_box.SelectedItem != null)
                {
                    String remove_item = to_do_list_box.SelectedItem.ToString();
                    todoList.Remove(remove_item);
                    display_List();
                }
                else
                {
                    MessageBox.Show("Must select an item to remove");
                }
            }
        }
    }
}
