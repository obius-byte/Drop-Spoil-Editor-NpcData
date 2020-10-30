/*
 * Created by SharpDevelop.
 * Author: Obius
 * Date: 08.10.2020
 * Time: 19:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;

namespace PTS_Drop_modifier__npcdata_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		protected ResourceManager rs;
		protected string selectedLang = "en";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			loadResource();
			prepareUI();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			CenterToScreen();
		}
		
		void loadResource()
		{
			rs = new ResourceManager("PTS_Drop_modifier__npcdata_.Properties." + selectedLang, Assembly.GetExecutingAssembly());
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			openFile( "npcdata.txt" );
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			openFile( "item_pch.txt" );
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			openFile( "npc_pch.txt" );
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			start();
		}
		
		void TextBoxKeyPressCheckDigit(object sender, KeyPressEventArgs e)
		{
			 char key = e.KeyChar;
 
			 if ( !Char.IsDigit( key ) && key != 8 )
			 {
			    e.Handled = true;
			 }
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			saveAs();
		}
		void РусскийToolStripMenuItemClick(object sender, EventArgs e)
		{
			selectedLang = "ru";
			loadResource();
			prepareUI();
		}
		void EnglishToolStripMenuItemClick(object sender, EventArgs e)
		{
			selectedLang = "en";
			loadResource();
			prepareUI();
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 about = new Form1();
			
			about.Show();
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
