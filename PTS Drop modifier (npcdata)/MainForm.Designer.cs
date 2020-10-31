/*
 * Created by SharpDevelop.
 * Author: Obius
 * Date: 08.10.2020
 * Time: 19:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PTS_Drop_modifier__npcdata_
{

	partial class MainForm
	{		
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private IContainer components = null;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private RichTextBox richTextBoxResult;

		private Button button3;
		
		private ArrayList selectedItemPch = new ArrayList();
		private ArrayList selectedNpcPch = new ArrayList();
		private ArrayList makeList = new ArrayList();
		
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		
		private Button button1;
		private Button button2;
		private Button button4;
		
		private StatusBarPanel statusBarPanel;
		
		string npcDataContent = string.Empty;
		string newNpcDataContent = string.Empty;
		
		private ListBox listBoxNpcPch;
		private ListBox listBoxItemPch;
		private CheckBox checkBoxSpoil;
		private CheckBox checkBoxDrop;
		private StatusBar statusBar;
		private GroupBox groupBox3;

		private GroupBox groupBox4;
		private TextBox textBoxMinLevel;
		private Label label3;
		private TextBox textBoxMaxLevel;
		private Label label2;
		private Label label1;
		private GroupBox groupBox5;
		private ComboBox comboBoxOperationMin;
		private GroupBox groupBox7;
		private TextBox textBoxOperandChance;
		private ComboBox comboBoxOperationChance;
		private GroupBox groupBox6;
		private TextBox textBoxOperandMax;
		private ComboBox comboBoxOperationMax;
		private TextBox textBoxOperandMin;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button5;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;

		//
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//
		private void InitializeComponent() 
		{
			this.statusBarPanel = new System.Windows.Forms.StatusBarPanel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.textBoxOperandChance = new System.Windows.Forms.TextBox();
			this.comboBoxOperationChance = new System.Windows.Forms.ComboBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.textBoxOperandMax = new System.Windows.Forms.TextBox();
			this.comboBoxOperationMax = new System.Windows.Forms.ComboBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.textBoxOperandMin = new System.Windows.Forms.TextBox();
			this.comboBoxOperationMin = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMaxLevel = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxMinLevel = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBoxDrop = new System.Windows.Forms.CheckBox();
			this.checkBoxSpoil = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBoxNpcPch = new System.Windows.Forms.ListBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.listBoxItemPch = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusBarPanel
			// 
			this.statusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel.Name = "statusBarPanel";
			this.statusBarPanel.Width = 767;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(784, 515);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox7);
			this.tabPage1.Controls.Add(this.groupBox6);
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(776, 489);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "prepare";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.textBoxOperandChance);
			this.groupBox7.Controls.Add(this.comboBoxOperationChance);
			this.groupBox7.Location = new System.Drawing.Point(520, 302);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(186, 75);
			this.groupBox7.TabIndex = 15;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "change chance";
			// 
			// textBoxOperandChance
			// 
			this.textBoxOperandChance.Location = new System.Drawing.Point(6, 46);
			this.textBoxOperandChance.Name = "textBoxOperandChance";
			this.textBoxOperandChance.Size = new System.Drawing.Size(174, 20);
			this.textBoxOperandChance.TabIndex = 1;
			this.textBoxOperandChance.Text = "0";
			// 
			// comboBoxOperationChance
			// 
			this.comboBoxOperationChance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOperationChance.FormattingEnabled = true;
			this.comboBoxOperationChance.Items.AddRange(new object[] {
			"none",
			"addition",
			"subtraction",
			"multiplication",
			"division"});
			this.comboBoxOperationChance.Location = new System.Drawing.Point(6, 19);
			this.comboBoxOperationChance.Name = "comboBoxOperationChance";
			this.comboBoxOperationChance.Size = new System.Drawing.Size(174, 21);
			this.comboBoxOperationChance.TabIndex = 0;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.textBoxOperandMax);
			this.groupBox6.Controls.Add(this.comboBoxOperationMax);
			this.groupBox6.Location = new System.Drawing.Point(520, 223);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(186, 73);
			this.groupBox6.TabIndex = 14;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "change max. amount";
			// 
			// textBoxOperandMax
			// 
			this.textBoxOperandMax.Location = new System.Drawing.Point(6, 46);
			this.textBoxOperandMax.Name = "textBoxOperandMax";
			this.textBoxOperandMax.Size = new System.Drawing.Size(174, 20);
			this.textBoxOperandMax.TabIndex = 1;
			this.textBoxOperandMax.Text = "0";
			// 
			// comboBoxOperationMax
			// 
			this.comboBoxOperationMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOperationMax.FormattingEnabled = true;
			this.comboBoxOperationMax.Items.AddRange(new object[] {
			"none",
			"addition",
			"subtraction",
			"multiplication",
			"division"});
			this.comboBoxOperationMax.Location = new System.Drawing.Point(6, 19);
			this.comboBoxOperationMax.Name = "comboBoxOperationMax";
			this.comboBoxOperationMax.Size = new System.Drawing.Size(174, 21);
			this.comboBoxOperationMax.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.textBoxOperandMin);
			this.groupBox5.Controls.Add(this.comboBoxOperationMin);
			this.groupBox5.Location = new System.Drawing.Point(520, 145);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(186, 72);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "change min. amount";
			// 
			// textBoxOperandMin
			// 
			this.textBoxOperandMin.Location = new System.Drawing.Point(6, 46);
			this.textBoxOperandMin.Name = "textBoxOperandMin";
			this.textBoxOperandMin.Size = new System.Drawing.Size(174, 20);
			this.textBoxOperandMin.TabIndex = 1;
			this.textBoxOperandMin.Text = "0";
			// 
			// comboBoxOperationMin
			// 
			this.comboBoxOperationMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOperationMin.FormattingEnabled = true;
			this.comboBoxOperationMin.Items.AddRange(new object[] {
			"none",
			"addition",
			"subtraction",
			"multiplication",
			"division"});
			this.comboBoxOperationMin.Location = new System.Drawing.Point(6, 19);
			this.comboBoxOperationMin.Name = "comboBoxOperationMin";
			this.comboBoxOperationMin.Size = new System.Drawing.Size(174, 21);
			this.comboBoxOperationMin.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.textBoxMaxLevel);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.textBoxMinLevel);
			this.groupBox4.Location = new System.Drawing.Point(520, 70);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(186, 69);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "condition (level range)";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(85, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "max";
			// 
			// textBoxMaxLevel
			// 
			this.textBoxMaxLevel.Location = new System.Drawing.Point(88, 32);
			this.textBoxMaxLevel.MaxLength = 2;
			this.textBoxMaxLevel.Name = "textBoxMaxLevel";
			this.textBoxMaxLevel.Size = new System.Drawing.Size(24, 20);
			this.textBoxMaxLevel.TabIndex = 3;
			this.textBoxMaxLevel.Text = "99";
			this.textBoxMaxLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressCheckDigit);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(70, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "—";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "min";
			// 
			// textBoxMinLevel
			// 
			this.textBoxMinLevel.Location = new System.Drawing.Point(40, 32);
			this.textBoxMinLevel.MaxLength = 2;
			this.textBoxMinLevel.Name = "textBoxMinLevel";
			this.textBoxMinLevel.Size = new System.Drawing.Size(24, 20);
			this.textBoxMinLevel.TabIndex = 0;
			this.textBoxMinLevel.Text = "0";
			this.textBoxMinLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressCheckDigit);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBoxDrop);
			this.groupBox3.Controls.Add(this.checkBoxSpoil);
			this.groupBox3.Location = new System.Drawing.Point(520, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(186, 57);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "search in";
			// 
			// checkBoxDrop
			// 
			this.checkBoxDrop.Location = new System.Drawing.Point(22, 19);
			this.checkBoxDrop.Name = "checkBoxDrop";
			this.checkBoxDrop.Size = new System.Drawing.Size(73, 24);
			this.checkBoxDrop.TabIndex = 8;
			this.checkBoxDrop.Text = "drop";
			this.checkBoxDrop.UseVisualStyleBackColor = true;
			// 
			// checkBoxSpoil
			// 
			this.checkBoxSpoil.Location = new System.Drawing.Point(101, 19);
			this.checkBoxSpoil.Name = "checkBoxSpoil";
			this.checkBoxSpoil.Size = new System.Drawing.Size(79, 24);
			this.checkBoxSpoil.TabIndex = 9;
			this.checkBoxSpoil.Text = "spoil";
			this.checkBoxSpoil.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button4.Location = new System.Drawing.Point(3, 452);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(770, 34);
			this.button4.TabIndex = 7;
			this.button4.Text = "start";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "choose npcdata.txt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBoxNpcPch);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(264, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(250, 370);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "npc_pch";
			// 
			// listBoxNpcPch
			// 
			this.listBoxNpcPch.FormattingEnabled = true;
			this.listBoxNpcPch.Location = new System.Drawing.Point(6, 47);
			this.listBoxNpcPch.Name = "listBoxNpcPch";
			this.listBoxNpcPch.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxNpcPch.Size = new System.Drawing.Size(238, 316);
			this.listBoxNpcPch.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(238, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "choose";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.listBoxItemPch);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 371);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "item_pch";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(7, 19);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(237, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "choose";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// listBoxItemPch
			// 
			this.listBoxItemPch.FormattingEnabled = true;
			this.listBoxItemPch.Location = new System.Drawing.Point(7, 48);
			this.listBoxItemPch.Name = "listBoxItemPch";
			this.listBoxItemPch.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxItemPch.Size = new System.Drawing.Size(237, 316);
			this.listBoxItemPch.TabIndex = 2;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(776, 489);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "result";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.richTextBoxResult, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 483);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// richTextBoxResult
			// 
			this.richTextBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxResult.Location = new System.Drawing.Point(3, 3);
			this.richTextBoxResult.Name = "richTextBoxResult";
			this.richTextBoxResult.ReadOnly = true;
			this.richTextBoxResult.Size = new System.Drawing.Size(764, 432);
			this.richTextBoxResult.TabIndex = 0;
			this.richTextBoxResult.Text = "";
			this.richTextBoxResult.WordWrap = false;
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button5.Location = new System.Drawing.Point(3, 441);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(764, 39);
			this.button5.TabIndex = 1;
			this.button5.Text = "save as...";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 539);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
			this.statusBarPanel});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(784, 22);
			this.statusBar.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.languageToolStripMenuItem,
			this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.русскийToolStripMenuItem,
			this.englishToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.languageToolStripMenuItem.Text = "Language";
			// 
			// русскийToolStripMenuItem
			// 
			this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
			this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.русскийToolStripMenuItem.Text = "Русский";
			this.русскийToolStripMenuItem.Click += new System.EventHandler(this.РусскийToolStripMenuItemClick);
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.englishToolStripMenuItem.Text = "English";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Drop / Spoil Editor npcdata for mmo-dev.info";
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private void prepareUI()
		{
			fileToolStripMenuItem.Text = rsLang.GetString( "file" );
			exitToolStripMenuItem.Text = rsLang.GetString( "exit" );
			button1.Text = rsLang.GetString( "choose" ) + " npcdata.txt";
			button5.Text = rsLang.GetString( "saveAs" );
			button2.Text = rsLang.GetString( "choose" );
			button3.Text = rsLang.GetString( "choose" );
			button4.Text = rsLang.GetString( "start" );
			languageToolStripMenuItem.Text = rsLang.GetString( "language" );
			
			tabPage1.Text = rsLang.GetString( "prepare" );
			tabPage2.Text = rsLang.GetString( "result" );
			
			groupBox3.Text = rsLang.GetString( "searchIn" );
			checkBoxDrop.Text = rsLang.GetString( "drop" );
			checkBoxSpoil.Text = rsLang.GetString( "spoil" );
			
			groupBox4.Text = rsLang.GetString( "levelRange" );
			
			label1.Text = rsLang.GetString( "min" );
			label3.Text = rsLang.GetString( "max" );
			
			groupBox5.Text = rsLang.GetString( "changeMinAmount" );
			groupBox6.Text = rsLang.GetString( "changeMaxAmount" );
			groupBox7.Text = rsLang.GetString( "changeChance" );
			
			object[] operations = new object[]
			{
				rsLang.GetString( "addition" ),
				rsLang.GetString( "subtraction" ),
				rsLang.GetString( "multiplication" ),
				rsLang.GetString( "division" )
			};
			
			comboBoxOperationMin.Items.Clear();
			comboBoxOperationMin.Items.AddRange( operations );
			
			comboBoxOperationMax.Items.Clear();
			comboBoxOperationMax.Items.AddRange( operations );
			
			comboBoxOperationChance.Items.Clear();
			comboBoxOperationChance.Items.AddRange( operations );
		}
		
		//
		private void openFile( string fileName )
		{
			using( var openFileDialog = new OpenFileDialog() )
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = fileName + "|" + fileName;
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = false;
				
				if ( openFileDialog.ShowDialog() == DialogResult.OK )
				{
					var filePath = openFileDialog.FileName;
					var fileStream = openFileDialog.OpenFile();
					
					statusBarPanel.Text = "processing... " + fileName;
					
					if ( fileName == "npc_pch.txt" )
						listBoxNpcPch.Items.Clear();
					else if ( fileName == "item_pch.txt" )
						listBoxItemPch.Items.Clear();
					
					using ( var reader = new StreamReader( fileStream ) )
					{
						if ( fileName == "item_pch.txt" || fileName == "npc_pch.txt" )
						{
							while ( reader.Peek() >= 0 )
							{
								string line = reader.ReadLine().Trim();
								if ( string.IsNullOrEmpty( line ) )
									continue;
								
								string[] param = line.Split( '=' );
								if ( param.Length < 2 )
									continue;
								
								var id   = param[1].Trim();
								var name = param[0].Trim()
									.Replace( "[", string.Empty )
									.Replace( "]", string.Empty );
								
								if ( fileName == "item_pch.txt" )
									listBoxItemPch.Items.Add( id + "\t" + name );
								else
									listBoxNpcPch.Items.Add( ( Int32.Parse( id ) - 1000000 ) + "\t" + name );
							}
						}
						else
							npcDataContent = reader.ReadToEnd();
					}
					statusBarPanel.Text = "";
				}
			}
		}
		
		private void saveAs()
		{
			string content = richTextBoxResult.Text;
			
			if ( !string.IsNullOrEmpty( content ) )
			{
				try
	  			{
					using ( var saveFileDialog = new SaveFileDialog() )
					{
						saveFileDialog.FileName = "npcdata_new";
						saveFileDialog.DefaultExt = "txt";
		    			saveFileDialog.Title = "Save File As";
		    			saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
		    			
		    			DialogResult result = saveFileDialog.ShowDialog();
		    			
		    			if ( result == DialogResult.OK )
		        		{
		    				using ( var streamWriter = new StreamWriter( saveFileDialog.FileName, false, Encoding.Unicode ) )
		    				{
		    					streamWriter.Write( content );
		    				}
		    			}
					}
				}
				catch ( Exception errorMsg )
	    		{
	      			MessageBox.Show(errorMsg.Message);
	    		}
			}
		}

		private void messageWarning( string text )
		{
			MessageBox.Show( text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
		}
		
		//
		private void start()
		{
			if ( string.IsNullOrEmpty( npcDataContent ) )
			{
				messageWarning( "npcdata.txt " + rsLang.GetString( "notSelected" ) );
				return;
			}
			
			if ( !checkBoxDrop.Checked && !checkBoxSpoil.Checked )
			{
				messageWarning( rsLang.GetString( "needSelectTypeList" ) );
				return;
			}
			
			if ( ( string.IsNullOrEmpty( comboBoxOperationMin.Text ) || comboBoxOperationMin.Text == "none" ) 
			    && ( string.IsNullOrEmpty( comboBoxOperationMax.Text ) || comboBoxOperationMax.Text == "none" ) 
			    && ( string.IsNullOrEmpty( comboBoxOperationChance.Text ) || comboBoxOperationChance.Text == "none" ) )
			{
				messageWarning( rsLang.GetString( "needSelectTypeOperation" ) );
				return;
			}
			
			if ( ( !string.IsNullOrEmpty( comboBoxOperationMin.Text ) && comboBoxOperationMin.Text != "none" ) 
			    && ( string.IsNullOrWhiteSpace( textBoxOperandMin.Text ) || textBoxOperandMin.Text == "0" ) )
			{
				textBoxOperandMin.Focus();
				textBoxOperandMin.SelectAll();
				messageWarning( rsLang.GetString( "specifyValue" ) + " " + rsLang.GetString( "minAmount" ) );
				return;
			}
			
			if ( ( !string.IsNullOrEmpty( comboBoxOperationMax.Text ) && comboBoxOperationMax.Text != "none" ) 
			    && ( string.IsNullOrWhiteSpace( textBoxOperandMax.Text ) || textBoxOperandMax.Text == "0" ) )
			{
				textBoxOperandMax.Focus();
				textBoxOperandMax.SelectAll();
				messageWarning( rsLang.GetString( "specifyValue" ) + " " + rsLang.GetString( "maxAmount" ) );
				return;
			}
			
			if ( ( !string.IsNullOrEmpty( comboBoxOperationChance.Text ) && comboBoxOperationChance.Text != "none" ) 
			    && ( string.IsNullOrWhiteSpace( textBoxOperandChance.Text ) || textBoxOperandChance.Text == "0" ) )
			{
				textBoxOperandChance.Focus();
				textBoxOperandChance.SelectAll();
				messageWarning( rsLang.GetString( "specifyValue" ) + " " + rsLang.GetString( "chance" ) );
				return;
			}
			
			double operandMin = 0;
			if ( !string.IsNullOrWhiteSpace( textBoxOperandMin.Text ) && textBoxOperandMin.Text != "0" )
			{
				if ( !double.TryParse( textBoxOperandMin.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out operandMin ) )
				{
					textBoxOperandMin.Focus();
					textBoxOperandMin.SelectAll();
					messageWarning( rsLang.GetString( "incorrectValue" ) + " " + rsLang.GetString( "minAmount" ) );
					return;
				}
			}
			
			double operandMax = 0;
			if ( !string.IsNullOrWhiteSpace( textBoxOperandMax.Text ) && textBoxOperandMax.Text != "0" )
			{
				if ( !double.TryParse( textBoxOperandMax.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out operandMax ) )
				{
					textBoxOperandMax.Focus();
					textBoxOperandMax.SelectAll();
					messageWarning( rsLang.GetString( "incorrectValue" ) + " " + rsLang.GetString( "maxAmount" ) );
					return;
				}
			}
			
			double operandChance = 0;
			if ( !string.IsNullOrWhiteSpace( textBoxOperandChance.Text ) && textBoxOperandChance.Text != "0" )
			{
				if ( !double.TryParse( textBoxOperandChance.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out operandChance ) )
				{
					textBoxOperandChance.Focus();
					textBoxOperandChance.SelectAll();
					messageWarning( rsLang.GetString( "incorrectValue" ) + " " + rsLang.GetString( "chance" ) );
					return;
				}
			}
			
			if ( listBoxItemPch.SelectedItems.Count == 0 && listBoxNpcPch.SelectedItems.Count == 0 )
			{
				DialogResult dialogResult = MessageBox.Show( rsLang.GetString( "npcAndItemsNotSelected" ), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );
				
				if ( dialogResult == DialogResult.Cancel )
					return;
			}

			this.Enabled = false;
			
			statusBarPanel.Text = "processing...";
			selectedItemPch.Clear();
			if ( listBoxItemPch.SelectedItems.Count > 0 )
			{
				foreach ( var item in listBoxItemPch.SelectedItems )
				{
					var name = item.ToString().Split( '\t' )[1];
					selectedItemPch.Add( name );
				}
			}
			
			selectedNpcPch.Clear();
			if ( listBoxNpcPch.SelectedItems.Count > 0 )
			{
				foreach ( var item in listBoxNpcPch.SelectedItems )
				{
					var name = item.ToString().Split( '\t' )[1];
					selectedNpcPch.Add( "[" + name + "]" );
				}
			}
			
			Operation operationMin = Operation.none;
			if ( !string.IsNullOrEmpty( comboBoxOperationMin.Text ) && comboBoxOperationMin.Text != "none" )
				operationMin = ( Operation ) Enum.Parse( typeof( Operation ), comboBoxOperationMin.Text );
			
			Operation operationMax = Operation.none;
			if ( !string.IsNullOrEmpty( comboBoxOperationMax.Text ) && comboBoxOperationMax.Text != "none" )
				operationMax = ( Operation ) Enum.Parse( typeof( Operation ), comboBoxOperationMax.Text );
			
			Operation operationChance = Operation.none;
			if ( !string.IsNullOrEmpty( comboBoxOperationChance.Text ) && comboBoxOperationChance.Text != "none" )
				operationChance = ( Operation ) Enum.Parse( typeof( Operation ), comboBoxOperationChance.Text );

			makeList.Clear();
			if ( checkBoxDrop.Checked )
				makeList.Add( "additional_make_multi_list=" );
			
			if ( checkBoxSpoil.Checked )
				makeList.Add( "corpse_make_list=" );;
			
			int conditionMinLevel = 0;
			if ( !string.IsNullOrEmpty( textBoxMinLevel.Text ) )
				conditionMinLevel = Int32.Parse( textBoxMinLevel.Text );
			
			int conditionMaxLevel = 99;
			if ( !string.IsNullOrEmpty( textBoxMaxLevel.Text ) )
				conditionMaxLevel = Int32.Parse( textBoxMaxLevel.Text );
			
			string[] lines = npcDataContent.Split( '\n' );
			var newLines = new ArrayList();
			richTextBoxResult.Clear();
			
			int lineNumber = 0;			
			foreach ( string line in lines )
			{
				string newLine = line;
				if ( string.IsNullOrEmpty( line ) || line.StartsWith( "//" ) )
				{
					newLines.Add( newLine );
					lineNumber++;
					continue;
				}
				
				string[] tabs = line.Split( '\t' );
				
				if ( selectedNpcPch.Count > 0 )
				{
					if ( selectedNpcPch.Contains( tabs[3] ) )
					{
						goto continueProcessing;
					}
					
					newLines.Add( newLine );
					lineNumber++;
					continue;
				}
				
				continueProcessing: ;
				
				foreach ( string tab in tabs )
				{
					if ( tab.StartsWith( "level=" ) )
					{
						string[] levelParam = tab.Split( '=' );
						int level = Int32.Parse( levelParam[1] );
						
						if ( level < conditionMinLevel || level > conditionMaxLevel )
							goto continueLinesLoop;
					}
					
					if ( makeList.Count > 0 )
					{
						foreach ( string makeListName in makeList )
						{	
							if ( tab.StartsWith( makeListName ) && !tab.EndsWith( "{}" ) )
							{
								string pattern = string.Empty;
								
								if ( selectedItemPch.Count > 0 )
								{
									foreach ( string selectedItem in selectedItemPch )
									{
										pattern = string.Concat( @"\[" + selectedItem + @"\];(\d*\.?\d*);(\d*\.?\d*);(\d*\.?\d*)" );
										
										foreach ( Match match in Regex.Matches( tab, pattern ) )
										{
											string search = match.Groups[0].Value;
											
											int min = Int32.Parse( match.Groups[1].Value );
											if ( operationMin != Operation.none )
												min = mathOperation( operationMin, min, operandMin );

											int max = Int32.Parse( match.Groups[2].Value );
											if ( operationMax != Operation.none )
												max = mathOperation( operationMax, max, operandMax );
											
											double chance = double.Parse( match.Groups[3].Value, CultureInfo.InvariantCulture );
											if ( operationChance != Operation.none )
												chance = mathOperation( operationChance, chance, operandChance );
											
											string replace = "[" + selectedItem + "];" + min + ";" + max + ";" + chance.ToString( CultureInfo.InvariantCulture );
											
											// TODO: diff highlight???
											// f1f8ff - blue
											// ffeef0 = red
											// e6ffed = green

											newLine = newLine.Replace( search, replace );
										}
									}
								}
								else
								{
									// \[[a-z0-9_]*\];(\d*\.?\d*);(\d*\.?\d*);(\d*\.?\d*)
									pattern = @"\[(\w+)\];(\d*\.?\d*);(\d*\.?\d*);(\d*\.?\d*)";
									
									foreach ( Match match in Regex.Matches( tab, pattern ) )
									{
										string search = match.Groups[0].Value;										
										string item = match.Groups[1].Value;
											
										int min = Int32.Parse( match.Groups[2].Value );
										if ( operationMin != Operation.none )
											min = mathOperation( operationMin, min, operandMin );

										int max = Int32.Parse( match.Groups[3].Value );
										if ( operationMax != Operation.none )
											max = mathOperation( operationMax, max, operandMax );
											
										double chance = double.Parse( match.Groups[4].Value, CultureInfo.InvariantCulture );
										if ( operationChance != Operation.none )
											chance = mathOperation( operationChance, chance, operandChance );
										
										string replace = "[" + item + "];" + min + ";" + max + ";" + chance.ToString( CultureInfo.InvariantCulture );
										
										newLine = newLine.Replace( search, replace );
									}
								}							
							}
					
						}
					}
				}
				
				continueLinesLoop: ;
				newLines.Add( newLine );
				lineNumber++;
			}
			
			foreach ( string line in newLines )
			{
				richTextBoxResult.AppendText( line );
			}
			newLines.Clear();
			
			tabControl1.SelectedIndex = 1;
			
			statusBarPanel.Text = "";
			
			this.Enabled = true;
		}

		enum Operation
		{
			none,
			addition,
			сложение,
			subtraction,
			вычитание,
			multiplication,
			умножение,
			division,
			деление
		}
		
		private int mathOperation( Operation op, int value, double operand )
		{
			double result = -1;
			
			switch (op) 
			{
				case Operation.addition:
				case Operation.сложение:
					result = value + operand;
					break;
				case Operation.subtraction:
				case Operation.вычитание:
					result = value - operand;
					break;
				case Operation.multiplication:
				case Operation.умножение:
					result = value * operand;
					break;
				case Operation.division:
				case Operation.деление:
					result = value / operand;
					break;
			}
			
			// TODO: check for zero?

			return ( int ) Math.Round( result );
		}
		
		private double mathOperation( Operation op, double value, double operand )
		{
			switch (op) 
			{
				case Operation.addition:
				case Operation.сложение:
					value = value + operand;
					break;
				case Operation.subtraction:
				case Operation.вычитание:
					value = value - operand;
					break;
				case Operation.multiplication:
				case Operation.умножение:
					value = value * operand;
					break;
				case Operation.division:
				case Operation.деление:
					value = value / operand;
					break;
			}

			return value;
		}
		
		private void debug( string message )
		{
			System.Diagnostics.Debug.WriteLine( message );
		}
		
	}
}
