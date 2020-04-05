/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.03
 * Time: 17:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Drawing;
using System.Windows.Forms;

namespace ColorSplash
{
	partial class ColorSettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSettingsForm));
            this.richSampleCode = new System.Windows.Forms.RichTextBox();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkKeywordsItalic = new System.Windows.Forms.CheckBox();
            this.btnCommentsColor = new System.Windows.Forms.Button();
            this.chkCommentsItalic = new System.Windows.Forms.CheckBox();
            this.chkCommentsBold = new System.Windows.Forms.CheckBox();
            this.chkStringsBold = new System.Windows.Forms.CheckBox();
            this.chkStringsItalic = new System.Windows.Forms.CheckBox();
            this.btnStringsColor = new System.Windows.Forms.Button();
            this.btnNumbersColor = new System.Windows.Forms.Button();
            this.chkNumbersItalic = new System.Windows.Forms.CheckBox();
            this.chkNumbersBold = new System.Windows.Forms.CheckBox();
            this.chkSymbolsItalic = new System.Windows.Forms.CheckBox();
            this.chkSymbolsBold = new System.Windows.Forms.CheckBox();
            this.chkKeywordsBold = new System.Windows.Forms.CheckBox();
            this.btnSymbolsColor = new System.Windows.Forms.Button();
            this.btnKeywordsColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKeywordsPicker = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCommentsPicker = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSymbolsPicker = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnNumbersPicker = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnStringsPicker = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabSyntax = new System.Windows.Forms.TabPage();
            this.tabEditor = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnEditorPicker = new System.Windows.Forms.Button();
            this.chkEditorItalic = new System.Windows.Forms.CheckBox();
            this.chkEditorBold = new System.Windows.Forms.CheckBox();
            this.btnEditorColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditorBgColor = new System.Windows.Forms.Button();
            this.btnEditorBgPicker = new System.Windows.Forms.Button();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.btnNullPicker = new System.Windows.Forms.Button();
            this.btnNullColor = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnGridBgPicker = new System.Windows.Forms.Button();
            this.btnGridBgColor = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnAlternatePicker = new System.Windows.Forms.Button();
            this.btnAlternateColor = new System.Windows.Forms.Button();
            this.tabBrowser = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnBrowserFontPicker = new System.Windows.Forms.Button();
            this.chkBrowserItalic = new System.Windows.Forms.CheckBox();
            this.chkBrowserBold = new System.Windows.Forms.CheckBox();
            this.btnBrowserFont = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnBrowserBgColor = new System.Windows.Forms.Button();
            this.btnBrowserBgPicker = new System.Windows.Forms.Button();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnErrorBgPicker = new System.Windows.Forms.Button();
            this.btnErrorTxtPicker = new System.Windows.Forms.Button();
            this.btnErrorBgColor = new System.Windows.Forms.Button();
            this.btnErrorTxtColor = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSearchHitPicker = new System.Windows.Forms.Button();
            this.btnSearchHitColor = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnHlightPicker = new System.Windows.Forms.Button();
            this.btnHlightColor = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabSyntax.SuspendLayout();
            this.tabEditor.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabGrid.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabBrowser.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // richSampleCode
            // 
            this.richSampleCode.Location = new System.Drawing.Point(12, 12);
            this.richSampleCode.Name = "richSampleCode";
            this.richSampleCode.ReadOnly = true;
            this.richSampleCode.Size = new System.Drawing.Size(539, 488);
            this.richSampleCode.TabIndex = 0;
            this.richSampleCode.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(728, 477);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(809, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // chkKeywordsItalic
            // 
            this.chkKeywordsItalic.Location = new System.Drawing.Point(6, 39);
            this.chkKeywordsItalic.Name = "chkKeywordsItalic";
            this.chkKeywordsItalic.Size = new System.Drawing.Size(48, 24);
            this.chkKeywordsItalic.TabIndex = 5;
            this.chkKeywordsItalic.Text = "Italic";
            this.chkKeywordsItalic.UseVisualStyleBackColor = true;
            this.chkKeywordsItalic.CheckedChanged += new System.EventHandler(this.ChkKeywordsItalicCheckedChanged);
            // 
            // btnCommentsColor
            // 
            this.btnCommentsColor.Location = new System.Drawing.Point(60, 22);
            this.btnCommentsColor.Name = "btnCommentsColor";
            this.btnCommentsColor.Size = new System.Drawing.Size(38, 38);
            this.btnCommentsColor.TabIndex = 10;
            this.btnCommentsColor.UseVisualStyleBackColor = true;
            this.btnCommentsColor.Click += new System.EventHandler(this.BtnCommentsColorClick);
            // 
            // chkCommentsItalic
            // 
            this.chkCommentsItalic.Location = new System.Drawing.Point(6, 39);
            this.chkCommentsItalic.Name = "chkCommentsItalic";
            this.chkCommentsItalic.Size = new System.Drawing.Size(48, 24);
            this.chkCommentsItalic.TabIndex = 9;
            this.chkCommentsItalic.Text = "Italic";
            this.chkCommentsItalic.UseVisualStyleBackColor = true;
            this.chkCommentsItalic.CheckedChanged += new System.EventHandler(this.ChkCommentsItalicCheckedChanged);
            // 
            // chkCommentsBold
            // 
            this.chkCommentsBold.Location = new System.Drawing.Point(6, 19);
            this.chkCommentsBold.Name = "chkCommentsBold";
            this.chkCommentsBold.Size = new System.Drawing.Size(48, 24);
            this.chkCommentsBold.TabIndex = 8;
            this.chkCommentsBold.Text = "Bold";
            this.chkCommentsBold.UseVisualStyleBackColor = true;
            this.chkCommentsBold.CheckedChanged += new System.EventHandler(this.ChkCommentsBoldCheckedChanged);
            // 
            // chkStringsBold
            // 
            this.chkStringsBold.Location = new System.Drawing.Point(6, 19);
            this.chkStringsBold.Name = "chkStringsBold";
            this.chkStringsBold.Size = new System.Drawing.Size(48, 24);
            this.chkStringsBold.TabIndex = 12;
            this.chkStringsBold.Text = "Bold";
            this.chkStringsBold.UseVisualStyleBackColor = true;
            this.chkStringsBold.CheckedChanged += new System.EventHandler(this.ChkStringsBoldCheckedChanged);
            // 
            // chkStringsItalic
            // 
            this.chkStringsItalic.Location = new System.Drawing.Point(6, 39);
            this.chkStringsItalic.Name = "chkStringsItalic";
            this.chkStringsItalic.Size = new System.Drawing.Size(48, 24);
            this.chkStringsItalic.TabIndex = 13;
            this.chkStringsItalic.Text = "Italic";
            this.chkStringsItalic.UseVisualStyleBackColor = true;
            this.chkStringsItalic.CheckedChanged += new System.EventHandler(this.ChkStringsItalicCheckedChanged);
            // 
            // btnStringsColor
            // 
            this.btnStringsColor.Location = new System.Drawing.Point(60, 19);
            this.btnStringsColor.Name = "btnStringsColor";
            this.btnStringsColor.Size = new System.Drawing.Size(38, 38);
            this.btnStringsColor.TabIndex = 14;
            this.btnStringsColor.UseVisualStyleBackColor = true;
            this.btnStringsColor.Click += new System.EventHandler(this.BtnStringsColorClick);
            // 
            // btnNumbersColor
            // 
            this.btnNumbersColor.Location = new System.Drawing.Point(60, 19);
            this.btnNumbersColor.Name = "btnNumbersColor";
            this.btnNumbersColor.Size = new System.Drawing.Size(38, 38);
            this.btnNumbersColor.TabIndex = 18;
            this.btnNumbersColor.UseVisualStyleBackColor = true;
            this.btnNumbersColor.Click += new System.EventHandler(this.BtnNumbersColorClick);
            // 
            // chkNumbersItalic
            // 
            this.chkNumbersItalic.Location = new System.Drawing.Point(6, 39);
            this.chkNumbersItalic.Name = "chkNumbersItalic";
            this.chkNumbersItalic.Size = new System.Drawing.Size(48, 24);
            this.chkNumbersItalic.TabIndex = 17;
            this.chkNumbersItalic.Text = "Italic";
            this.chkNumbersItalic.UseVisualStyleBackColor = true;
            this.chkNumbersItalic.CheckedChanged += new System.EventHandler(this.ChkNumbersItalicCheckedChanged);
            // 
            // chkNumbersBold
            // 
            this.chkNumbersBold.Location = new System.Drawing.Point(6, 19);
            this.chkNumbersBold.Name = "chkNumbersBold";
            this.chkNumbersBold.Size = new System.Drawing.Size(48, 24);
            this.chkNumbersBold.TabIndex = 16;
            this.chkNumbersBold.Text = "Bold";
            this.chkNumbersBold.UseVisualStyleBackColor = true;
            this.chkNumbersBold.CheckedChanged += new System.EventHandler(this.ChkNumbersBoldCheckedChanged);
            // 
            // chkSymbolsItalic
            // 
            this.chkSymbolsItalic.Location = new System.Drawing.Point(6, 39);
            this.chkSymbolsItalic.Name = "chkSymbolsItalic";
            this.chkSymbolsItalic.Size = new System.Drawing.Size(48, 24);
            this.chkSymbolsItalic.TabIndex = 21;
            this.chkSymbolsItalic.Text = "Italic";
            this.chkSymbolsItalic.UseVisualStyleBackColor = true;
            this.chkSymbolsItalic.CheckedChanged += new System.EventHandler(this.ChkSymbolsItalicCheckedChanged);
            // 
            // chkSymbolsBold
            // 
            this.chkSymbolsBold.Location = new System.Drawing.Point(6, 19);
            this.chkSymbolsBold.Name = "chkSymbolsBold";
            this.chkSymbolsBold.Size = new System.Drawing.Size(48, 24);
            this.chkSymbolsBold.TabIndex = 20;
            this.chkSymbolsBold.Text = "Bold";
            this.chkSymbolsBold.UseVisualStyleBackColor = true;
            this.chkSymbolsBold.CheckedChanged += new System.EventHandler(this.ChkSymbolsBoldCheckedChanged);
            // 
            // chkKeywordsBold
            // 
            this.chkKeywordsBold.Location = new System.Drawing.Point(6, 19);
            this.chkKeywordsBold.Name = "chkKeywordsBold";
            this.chkKeywordsBold.Size = new System.Drawing.Size(48, 24);
            this.chkKeywordsBold.TabIndex = 4;
            this.chkKeywordsBold.Text = "Bold";
            this.chkKeywordsBold.UseVisualStyleBackColor = true;
            this.chkKeywordsBold.CheckedChanged += new System.EventHandler(this.ChkKeywordsBoldCheckedChanged);
            // 
            // btnSymbolsColor
            // 
            this.btnSymbolsColor.Location = new System.Drawing.Point(60, 19);
            this.btnSymbolsColor.Name = "btnSymbolsColor";
            this.btnSymbolsColor.Size = new System.Drawing.Size(38, 38);
            this.btnSymbolsColor.TabIndex = 22;
            this.btnSymbolsColor.UseVisualStyleBackColor = true;
            this.btnSymbolsColor.Click += new System.EventHandler(this.BtnSymbolsColorClick);
            // 
            // btnKeywordsColor
            // 
            this.btnKeywordsColor.Location = new System.Drawing.Point(60, 19);
            this.btnKeywordsColor.Name = "btnKeywordsColor";
            this.btnKeywordsColor.Size = new System.Drawing.Size(38, 38);
            this.btnKeywordsColor.TabIndex = 6;
            this.btnKeywordsColor.UseVisualStyleBackColor = true;
            this.btnKeywordsColor.Click += new System.EventHandler(this.BtnKeywordsColorClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKeywordsPicker);
            this.groupBox2.Controls.Add(this.chkKeywordsBold);
            this.groupBox2.Controls.Add(this.chkKeywordsItalic);
            this.groupBox2.Controls.Add(this.btnKeywordsColor);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 69);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keywords";
            // 
            // btnKeywordsPicker
            // 
            this.btnKeywordsPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnKeywordsPicker.Location = new System.Drawing.Point(104, 19);
            this.btnKeywordsPicker.Name = "btnKeywordsPicker";
            this.btnKeywordsPicker.Size = new System.Drawing.Size(38, 38);
            this.btnKeywordsPicker.TabIndex = 7;
            this.btnKeywordsPicker.UseVisualStyleBackColor = true;
            this.btnKeywordsPicker.Click += new System.EventHandler(this.BtnKeywordsPickerClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCommentsPicker);
            this.groupBox1.Controls.Add(this.chkCommentsBold);
            this.groupBox1.Controls.Add(this.chkCommentsItalic);
            this.groupBox1.Controls.Add(this.btnCommentsColor);
            this.groupBox1.Location = new System.Drawing.Point(162, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 69);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // btnCommentsPicker
            // 
            this.btnCommentsPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnCommentsPicker.Location = new System.Drawing.Point(104, 22);
            this.btnCommentsPicker.Name = "btnCommentsPicker";
            this.btnCommentsPicker.Size = new System.Drawing.Size(38, 38);
            this.btnCommentsPicker.TabIndex = 8;
            this.btnCommentsPicker.UseVisualStyleBackColor = true;
            this.btnCommentsPicker.Click += new System.EventHandler(this.BtnCommentsPickerClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSymbolsPicker);
            this.groupBox4.Controls.Add(this.chkSymbolsBold);
            this.groupBox4.Controls.Add(this.chkSymbolsItalic);
            this.groupBox4.Controls.Add(this.btnSymbolsColor);
            this.groupBox4.Location = new System.Drawing.Point(6, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 69);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Symbols";
            // 
            // btnSymbolsPicker
            // 
            this.btnSymbolsPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnSymbolsPicker.Location = new System.Drawing.Point(104, 19);
            this.btnSymbolsPicker.Name = "btnSymbolsPicker";
            this.btnSymbolsPicker.Size = new System.Drawing.Size(38, 38);
            this.btnSymbolsPicker.TabIndex = 11;
            this.btnSymbolsPicker.UseVisualStyleBackColor = true;
            this.btnSymbolsPicker.Click += new System.EventHandler(this.BtnSymbolsPickerClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnNumbersPicker);
            this.groupBox5.Controls.Add(this.chkNumbersBold);
            this.groupBox5.Controls.Add(this.chkNumbersItalic);
            this.groupBox5.Controls.Add(this.btnNumbersColor);
            this.groupBox5.Location = new System.Drawing.Point(162, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 69);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Numbers";
            // 
            // btnNumbersPicker
            // 
            this.btnNumbersPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnNumbersPicker.Location = new System.Drawing.Point(103, 19);
            this.btnNumbersPicker.Name = "btnNumbersPicker";
            this.btnNumbersPicker.Size = new System.Drawing.Size(38, 38);
            this.btnNumbersPicker.TabIndex = 15;
            this.btnNumbersPicker.UseVisualStyleBackColor = true;
            this.btnNumbersPicker.Click += new System.EventHandler(this.BtnNumbersPickerClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStringsPicker);
            this.groupBox6.Controls.Add(this.chkStringsBold);
            this.groupBox6.Controls.Add(this.chkStringsItalic);
            this.groupBox6.Controls.Add(this.btnStringsColor);
            this.groupBox6.Location = new System.Drawing.Point(6, 81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(150, 69);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Strings";
            // 
            // btnStringsPicker
            // 
            this.btnStringsPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnStringsPicker.Location = new System.Drawing.Point(103, 19);
            this.btnStringsPicker.Name = "btnStringsPicker";
            this.btnStringsPicker.Size = new System.Drawing.Size(38, 38);
            this.btnStringsPicker.TabIndex = 8;
            this.btnStringsPicker.UseVisualStyleBackColor = true;
            this.btnStringsPicker.Click += new System.EventHandler(this.BtnStringsPickerClick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabSyntax);
            this.tabSettings.Controls.Add(this.tabEditor);
            this.tabSettings.Controls.Add(this.tabGrid);
            this.tabSettings.Controls.Add(this.tabBrowser);
            this.tabSettings.Controls.Add(this.tabOther);
            this.tabSettings.Location = new System.Drawing.Point(557, 12);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(331, 259);
            this.tabSettings.TabIndex = 38;
            // 
            // tabSyntax
            // 
            this.tabSyntax.Controls.Add(this.groupBox2);
            this.tabSyntax.Controls.Add(this.groupBox6);
            this.tabSyntax.Controls.Add(this.groupBox4);
            this.tabSyntax.Controls.Add(this.groupBox5);
            this.tabSyntax.Controls.Add(this.groupBox1);
            this.tabSyntax.Location = new System.Drawing.Point(4, 22);
            this.tabSyntax.Name = "tabSyntax";
            this.tabSyntax.Padding = new System.Windows.Forms.Padding(3);
            this.tabSyntax.Size = new System.Drawing.Size(323, 233);
            this.tabSyntax.TabIndex = 1;
            this.tabSyntax.Text = "Syntax";
            this.tabSyntax.UseVisualStyleBackColor = true;
            // 
            // tabEditor
            // 
            this.tabEditor.Controls.Add(this.groupBox8);
            this.tabEditor.Controls.Add(this.groupBox3);
            this.tabEditor.Location = new System.Drawing.Point(4, 22);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditor.Size = new System.Drawing.Size(323, 233);
            this.tabEditor.TabIndex = 0;
            this.tabEditor.Text = "Editor";
            this.tabEditor.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnEditorPicker);
            this.groupBox8.Controls.Add(this.chkEditorItalic);
            this.groupBox8.Controls.Add(this.chkEditorBold);
            this.groupBox8.Controls.Add(this.btnEditorColor);
            this.groupBox8.Location = new System.Drawing.Point(110, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(154, 66);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Font";
            // 
            // btnEditorPicker
            // 
            this.btnEditorPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnEditorPicker.Location = new System.Drawing.Point(108, 19);
            this.btnEditorPicker.Name = "btnEditorPicker";
            this.btnEditorPicker.Size = new System.Drawing.Size(38, 38);
            this.btnEditorPicker.TabIndex = 31;
            this.btnEditorPicker.UseVisualStyleBackColor = true;
            this.btnEditorPicker.Click += new System.EventHandler(this.BtnEditorPickerClick);
            // 
            // chkEditorItalic
            // 
            this.chkEditorItalic.Location = new System.Drawing.Point(10, 39);
            this.chkEditorItalic.Name = "chkEditorItalic";
            this.chkEditorItalic.Size = new System.Drawing.Size(48, 19);
            this.chkEditorItalic.TabIndex = 26;
            this.chkEditorItalic.Text = "Italic";
            this.chkEditorItalic.UseVisualStyleBackColor = true;
            this.chkEditorItalic.CheckedChanged += new System.EventHandler(this.ChkEditorItalicCheckedChanged);
            // 
            // chkEditorBold
            // 
            this.chkEditorBold.Location = new System.Drawing.Point(10, 19);
            this.chkEditorBold.Name = "chkEditorBold";
            this.chkEditorBold.Size = new System.Drawing.Size(48, 19);
            this.chkEditorBold.TabIndex = 25;
            this.chkEditorBold.Text = "Bold";
            this.chkEditorBold.UseVisualStyleBackColor = true;
            this.chkEditorBold.CheckedChanged += new System.EventHandler(this.ChkEditorBoldCheckedChanged);
            // 
            // btnEditorColor
            // 
            this.btnEditorColor.Location = new System.Drawing.Point(64, 19);
            this.btnEditorColor.Name = "btnEditorColor";
            this.btnEditorColor.Size = new System.Drawing.Size(38, 38);
            this.btnEditorColor.TabIndex = 30;
            this.btnEditorColor.UseVisualStyleBackColor = true;
            this.btnEditorColor.Click += new System.EventHandler(this.BtnEditorColorClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditorBgColor);
            this.groupBox3.Controls.Add(this.btnEditorBgPicker);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 66);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Background";
            // 
            // btnEditorBgColor
            // 
            this.btnEditorBgColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditorBgColor.Location = new System.Drawing.Point(9, 19);
            this.btnEditorBgColor.Name = "btnEditorBgColor";
            this.btnEditorBgColor.Size = new System.Drawing.Size(38, 38);
            this.btnEditorBgColor.TabIndex = 2;
            this.btnEditorBgColor.UseVisualStyleBackColor = true;
            this.btnEditorBgColor.Click += new System.EventHandler(this.BtnEditorBgColorClick);
            // 
            // btnEditorBgPicker
            // 
            this.btnEditorBgPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnEditorBgPicker.Location = new System.Drawing.Point(52, 19);
            this.btnEditorBgPicker.Name = "btnEditorBgPicker";
            this.btnEditorBgPicker.Size = new System.Drawing.Size(38, 38);
            this.btnEditorBgPicker.TabIndex = 28;
            this.btnEditorBgPicker.UseVisualStyleBackColor = true;
            this.btnEditorBgPicker.Click += new System.EventHandler(this.BtnEditorBgPickerClick);
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.groupBox15);
            this.tabGrid.Controls.Add(this.groupBox14);
            this.tabGrid.Controls.Add(this.groupBox13);
            this.tabGrid.Location = new System.Drawing.Point(4, 22);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(323, 233);
            this.tabGrid.TabIndex = 2;
            this.tabGrid.Text = "Grid";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.btnNullPicker);
            this.groupBox15.Controls.Add(this.btnNullColor);
            this.groupBox15.Location = new System.Drawing.Point(110, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(96, 66);
            this.groupBox15.TabIndex = 37;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Null value";
            // 
            // btnNullPicker
            // 
            this.btnNullPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnNullPicker.Location = new System.Drawing.Point(50, 19);
            this.btnNullPicker.Name = "btnNullPicker";
            this.btnNullPicker.Size = new System.Drawing.Size(38, 38);
            this.btnNullPicker.TabIndex = 11;
            this.btnNullPicker.UseVisualStyleBackColor = true;
            this.btnNullPicker.Click += new System.EventHandler(this.btnNullPicker_Click);
            // 
            // btnNullColor
            // 
            this.btnNullColor.Location = new System.Drawing.Point(6, 19);
            this.btnNullColor.Name = "btnNullColor";
            this.btnNullColor.Size = new System.Drawing.Size(38, 38);
            this.btnNullColor.TabIndex = 22;
            this.btnNullColor.UseVisualStyleBackColor = true;
            this.btnNullColor.Click += new System.EventHandler(this.btnNullColor_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnGridBgPicker);
            this.groupBox14.Controls.Add(this.btnGridBgColor);
            this.groupBox14.Location = new System.Drawing.Point(8, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(96, 66);
            this.groupBox14.TabIndex = 37;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Background";
            // 
            // btnGridBgPicker
            // 
            this.btnGridBgPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnGridBgPicker.Location = new System.Drawing.Point(50, 19);
            this.btnGridBgPicker.Name = "btnGridBgPicker";
            this.btnGridBgPicker.Size = new System.Drawing.Size(38, 38);
            this.btnGridBgPicker.TabIndex = 11;
            this.btnGridBgPicker.UseVisualStyleBackColor = true;
            this.btnGridBgPicker.Click += new System.EventHandler(this.btnGridBgPicker_Click);
            // 
            // btnGridBgColor
            // 
            this.btnGridBgColor.Location = new System.Drawing.Point(6, 19);
            this.btnGridBgColor.Name = "btnGridBgColor";
            this.btnGridBgColor.Size = new System.Drawing.Size(38, 38);
            this.btnGridBgColor.TabIndex = 22;
            this.btnGridBgColor.UseVisualStyleBackColor = true;
            this.btnGridBgColor.Click += new System.EventHandler(this.btnGridBgColor_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnAlternatePicker);
            this.groupBox13.Controls.Add(this.btnAlternateColor);
            this.groupBox13.Location = new System.Drawing.Point(212, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(96, 66);
            this.groupBox13.TabIndex = 37;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Alternate row";
            // 
            // btnAlternatePicker
            // 
            this.btnAlternatePicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnAlternatePicker.Location = new System.Drawing.Point(50, 19);
            this.btnAlternatePicker.Name = "btnAlternatePicker";
            this.btnAlternatePicker.Size = new System.Drawing.Size(38, 38);
            this.btnAlternatePicker.TabIndex = 11;
            this.btnAlternatePicker.UseVisualStyleBackColor = true;
            this.btnAlternatePicker.Click += new System.EventHandler(this.btnAlternatePicker_Click);
            // 
            // btnAlternateColor
            // 
            this.btnAlternateColor.Location = new System.Drawing.Point(6, 19);
            this.btnAlternateColor.Name = "btnAlternateColor";
            this.btnAlternateColor.Size = new System.Drawing.Size(38, 38);
            this.btnAlternateColor.TabIndex = 22;
            this.btnAlternateColor.UseVisualStyleBackColor = true;
            this.btnAlternateColor.Click += new System.EventHandler(this.btnAlternateColor_Click);
            // 
            // tabBrowser
            // 
            this.tabBrowser.Controls.Add(this.groupBox10);
            this.tabBrowser.Controls.Add(this.groupBox11);
            this.tabBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser.Size = new System.Drawing.Size(323, 233);
            this.tabBrowser.TabIndex = 3;
            this.tabBrowser.Text = "Browser";
            this.tabBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnBrowserFontPicker);
            this.groupBox10.Controls.Add(this.chkBrowserItalic);
            this.groupBox10.Controls.Add(this.chkBrowserBold);
            this.groupBox10.Controls.Add(this.btnBrowserFont);
            this.groupBox10.Location = new System.Drawing.Point(110, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(154, 66);
            this.groupBox10.TabIndex = 40;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Font";
            // 
            // btnBrowserFontPicker
            // 
            this.btnBrowserFontPicker.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserFontPicker.Image")));
            this.btnBrowserFontPicker.Location = new System.Drawing.Point(108, 19);
            this.btnBrowserFontPicker.Name = "btnBrowserFontPicker";
            this.btnBrowserFontPicker.Size = new System.Drawing.Size(38, 38);
            this.btnBrowserFontPicker.TabIndex = 31;
            this.btnBrowserFontPicker.UseVisualStyleBackColor = true;
            this.btnBrowserFontPicker.Click += new System.EventHandler(this.btnBrowserFontPicker_Click);
            // 
            // chkBrowserItalic
            // 
            this.chkBrowserItalic.Location = new System.Drawing.Point(10, 39);
            this.chkBrowserItalic.Name = "chkBrowserItalic";
            this.chkBrowserItalic.Size = new System.Drawing.Size(48, 19);
            this.chkBrowserItalic.TabIndex = 26;
            this.chkBrowserItalic.Text = "Italic";
            this.chkBrowserItalic.UseVisualStyleBackColor = true;
            // 
            // chkBrowserBold
            // 
            this.chkBrowserBold.Location = new System.Drawing.Point(10, 19);
            this.chkBrowserBold.Name = "chkBrowserBold";
            this.chkBrowserBold.Size = new System.Drawing.Size(48, 19);
            this.chkBrowserBold.TabIndex = 25;
            this.chkBrowserBold.Text = "Bold";
            this.chkBrowserBold.UseVisualStyleBackColor = true;
            // 
            // btnBrowserFont
            // 
            this.btnBrowserFont.Location = new System.Drawing.Point(64, 19);
            this.btnBrowserFont.Name = "btnBrowserFont";
            this.btnBrowserFont.Size = new System.Drawing.Size(38, 38);
            this.btnBrowserFont.TabIndex = 30;
            this.btnBrowserFont.UseVisualStyleBackColor = true;
            this.btnBrowserFont.Click += new System.EventHandler(this.btnBrowserFont_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnBrowserBgColor);
            this.groupBox11.Controls.Add(this.btnBrowserBgPicker);
            this.groupBox11.Location = new System.Drawing.Point(6, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(98, 66);
            this.groupBox11.TabIndex = 39;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Background";
            // 
            // btnBrowserBgColor
            // 
            this.btnBrowserBgColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowserBgColor.Location = new System.Drawing.Point(9, 19);
            this.btnBrowserBgColor.Name = "btnBrowserBgColor";
            this.btnBrowserBgColor.Size = new System.Drawing.Size(38, 38);
            this.btnBrowserBgColor.TabIndex = 2;
            this.btnBrowserBgColor.UseVisualStyleBackColor = true;
            this.btnBrowserBgColor.Click += new System.EventHandler(this.btnBrowserBgColor_Click);
            // 
            // btnBrowserBgPicker
            // 
            this.btnBrowserBgPicker.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserBgPicker.Image")));
            this.btnBrowserBgPicker.Location = new System.Drawing.Point(52, 19);
            this.btnBrowserBgPicker.Name = "btnBrowserBgPicker";
            this.btnBrowserBgPicker.Size = new System.Drawing.Size(38, 38);
            this.btnBrowserBgPicker.TabIndex = 28;
            this.btnBrowserBgPicker.UseVisualStyleBackColor = true;
            this.btnBrowserBgPicker.Click += new System.EventHandler(this.btnBrowserBgPicker_Click);
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.groupBox12);
            this.tabOther.Controls.Add(this.groupBox9);
            this.tabOther.Controls.Add(this.groupBox7);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(323, 233);
            this.tabOther.TabIndex = 4;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnErrorBgPicker);
            this.groupBox12.Controls.Add(this.btnErrorTxtPicker);
            this.groupBox12.Controls.Add(this.btnErrorBgColor);
            this.groupBox12.Controls.Add(this.btnErrorTxtColor);
            this.groupBox12.Location = new System.Drawing.Point(6, 78);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(198, 66);
            this.groupBox12.TabIndex = 41;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Error text and background";
            // 
            // btnErrorBgPicker
            // 
            this.btnErrorBgPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnErrorBgPicker.Location = new System.Drawing.Point(150, 19);
            this.btnErrorBgPicker.Name = "btnErrorBgPicker";
            this.btnErrorBgPicker.Size = new System.Drawing.Size(38, 38);
            this.btnErrorBgPicker.TabIndex = 11;
            this.btnErrorBgPicker.UseVisualStyleBackColor = true;
            this.btnErrorBgPicker.Click += new System.EventHandler(this.btnErrorBgPicker_Click);
            // 
            // btnErrorTxtPicker
            // 
            this.btnErrorTxtPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnErrorTxtPicker.Location = new System.Drawing.Point(50, 19);
            this.btnErrorTxtPicker.Name = "btnErrorTxtPicker";
            this.btnErrorTxtPicker.Size = new System.Drawing.Size(38, 38);
            this.btnErrorTxtPicker.TabIndex = 11;
            this.btnErrorTxtPicker.UseVisualStyleBackColor = true;
            this.btnErrorTxtPicker.Click += new System.EventHandler(this.btnErrorTxtPicker_Click);
            // 
            // btnErrorBgColor
            // 
            this.btnErrorBgColor.Location = new System.Drawing.Point(106, 19);
            this.btnErrorBgColor.Name = "btnErrorBgColor";
            this.btnErrorBgColor.Size = new System.Drawing.Size(38, 38);
            this.btnErrorBgColor.TabIndex = 22;
            this.btnErrorBgColor.UseVisualStyleBackColor = true;
            this.btnErrorBgColor.Click += new System.EventHandler(this.btnErrorBgColor_Click);
            // 
            // btnErrorTxtColor
            // 
            this.btnErrorTxtColor.Location = new System.Drawing.Point(6, 19);
            this.btnErrorTxtColor.Name = "btnErrorTxtColor";
            this.btnErrorTxtColor.Size = new System.Drawing.Size(38, 38);
            this.btnErrorTxtColor.TabIndex = 22;
            this.btnErrorTxtColor.UseVisualStyleBackColor = true;
            this.btnErrorTxtColor.Click += new System.EventHandler(this.btnErrorTxtColor_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSearchHitPicker);
            this.groupBox9.Controls.Add(this.btnSearchHitColor);
            this.groupBox9.Location = new System.Drawing.Point(106, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(98, 66);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Search hit";
            // 
            // btnSearchHitPicker
            // 
            this.btnSearchHitPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnSearchHitPicker.Location = new System.Drawing.Point(50, 19);
            this.btnSearchHitPicker.Name = "btnSearchHitPicker";
            this.btnSearchHitPicker.Size = new System.Drawing.Size(38, 38);
            this.btnSearchHitPicker.TabIndex = 23;
            this.btnSearchHitPicker.UseVisualStyleBackColor = true;
            this.btnSearchHitPicker.Click += new System.EventHandler(this.btnSearchHitPicker_Click);
            // 
            // btnSearchHitColor
            // 
            this.btnSearchHitColor.Location = new System.Drawing.Point(6, 19);
            this.btnSearchHitColor.Name = "btnSearchHitColor";
            this.btnSearchHitColor.Size = new System.Drawing.Size(38, 38);
            this.btnSearchHitColor.TabIndex = 24;
            this.btnSearchHitColor.UseVisualStyleBackColor = true;
            this.btnSearchHitColor.Click += new System.EventHandler(this.btnSearchHitColor_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnHlightPicker);
            this.groupBox7.Controls.Add(this.btnHlightColor);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(94, 66);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Highlight";
            // 
            // btnHlightPicker
            // 
            this.btnHlightPicker.Image = global::ColorSplash.Properties.Resources.picker_icon;
            this.btnHlightPicker.Location = new System.Drawing.Point(50, 19);
            this.btnHlightPicker.Name = "btnHlightPicker";
            this.btnHlightPicker.Size = new System.Drawing.Size(38, 38);
            this.btnHlightPicker.TabIndex = 11;
            this.btnHlightPicker.UseVisualStyleBackColor = true;
            this.btnHlightPicker.Click += new System.EventHandler(this.btnHlightPicker_Click);
            // 
            // btnHlightColor
            // 
            this.btnHlightColor.Location = new System.Drawing.Point(6, 19);
            this.btnHlightColor.Name = "btnHlightColor";
            this.btnHlightColor.Size = new System.Drawing.Size(38, 38);
            this.btnHlightColor.TabIndex = 22;
            this.btnHlightColor.UseVisualStyleBackColor = true;
            this.btnHlightColor.Click += new System.EventHandler(this.btnHlightColor_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(557, 277);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 39;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(638, 277);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 40;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // ColorSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 508);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.richSampleCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSettingsForm";
            this.Text = "ColorSettingsForm";
            this.Load += new System.EventHandler(this.ColorSettingsFormLoad);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSyntax.ResumeLayout(false);
            this.tabEditor.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabGrid.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.tabBrowser.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tabOther.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnNumbersPicker;
		private System.Windows.Forms.Button btnStringsPicker;
		private System.Windows.Forms.Button btnSymbolsPicker;
		private System.Windows.Forms.Button btnCommentsPicker;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnKeywordsPicker;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox chkSymbolsBold;
		private System.Windows.Forms.CheckBox chkSymbolsItalic;
		private System.Windows.Forms.Button btnSymbolsColor;
		private System.Windows.Forms.CheckBox chkNumbersBold;
		private System.Windows.Forms.CheckBox chkNumbersItalic;
		private System.Windows.Forms.Button btnNumbersColor;
		private System.Windows.Forms.CheckBox chkStringsBold;
		private System.Windows.Forms.CheckBox chkStringsItalic;
		private System.Windows.Forms.Button btnStringsColor;
		private System.Windows.Forms.CheckBox chkCommentsBold;
		private System.Windows.Forms.CheckBox chkCommentsItalic;
		private System.Windows.Forms.Button btnCommentsColor;
		private System.Windows.Forms.Button btnKeywordsColor;
		private System.Windows.Forms.CheckBox chkKeywordsItalic;
		private System.Windows.Forms.CheckBox chkKeywordsBold;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.RichTextBox richSampleCode;
        private TabControl tabSettings;
        private TabPage tabEditor;
        private TabPage tabSyntax;
        private Button btnEditorPicker;
        private Button btnEditorColor;
        private CheckBox chkEditorBold;
        private Button btnEditorBgPicker;
        private Button btnEditorBgColor;
        private CheckBox chkEditorItalic;
        private TabPage tabGrid;
        private TabPage tabBrowser;
        private GroupBox groupBox8;
        private GroupBox groupBox3;
        private GroupBox groupBox15;
        private Button btnNullPicker;
        private Button btnNullColor;
        private GroupBox groupBox14;
        private Button btnGridBgPicker;
        private Button btnGridBgColor;
        private GroupBox groupBox13;
        private Button btnAlternatePicker;
        private Button btnAlternateColor;
        private TabPage tabOther;
        private GroupBox groupBox12;
        private Button btnErrorBgPicker;
        private Button btnErrorTxtPicker;
        private Button btnErrorBgColor;
        private Button btnErrorTxtColor;
        private GroupBox groupBox9;
        private Button btnSearchHitPicker;
        private Button btnSearchHitColor;
        private GroupBox groupBox7;
        private Button btnHlightPicker;
        private Button btnHlightColor;
        private GroupBox groupBox10;
        private Button btnBrowserFontPicker;
        private CheckBox chkBrowserItalic;
        private CheckBox chkBrowserBold;
        private Button btnBrowserFont;
        private GroupBox groupBox11;
        private Button btnBrowserBgColor;
        private Button btnBrowserBgPicker;
        private SaveFileDialog saveDialog;
        private Button btnSaveAs;
        private Button btnOpen;
        private OpenFileDialog openDialog;
    }
}
