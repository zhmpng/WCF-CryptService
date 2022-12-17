using System;
using System.Windows.Forms;

namespace Client
{
    partial class CryptographyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptographyForm));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.HashLabel = new System.Windows.Forms.Label();
            this.MethodsCollection = new System.Windows.Forms.ComboBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnection = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SendResult = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            resources.ApplyResources(this.InputTextBox, "InputTextBox");
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // InputLabel
            // 
            resources.ApplyResources(this.InputLabel, "InputLabel");
            this.InputLabel.Name = "InputLabel";
            // 
            // HashLabel
            // 
            resources.ApplyResources(this.HashLabel, "HashLabel");
            this.HashLabel.Name = "HashLabel";
            // 
            // MethodsCollection
            // 
            this.MethodsCollection.FormattingEnabled = true;
            resources.ApplyResources(this.MethodsCollection, "MethodsCollection");
            this.MethodsCollection.Name = "MethodsCollection";
            this.MethodsCollection.SelectedIndexChanged += new System.EventHandler(this.MethodsCollection_SelectedIndexChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойстваToolStripMenuItem});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connection,
            this.Disconnection,
            this.About});
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            resources.ApplyResources(this.свойстваToolStripMenuItem, "свойстваToolStripMenuItem");
            // 
            // Connection
            // 
            this.Connection.Name = "Connection";
            resources.ApplyResources(this.Connection, "Connection");
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // Disconnection
            // 
            this.Disconnection.Name = "Disconnection";
            resources.ApplyResources(this.Disconnection, "Disconnection");
            this.Disconnection.Click += new System.EventHandler(this.Disconnection_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            resources.ApplyResources(this.About, "About");
            // 
            // ResultLabel
            // 
            resources.ApplyResources(this.ResultLabel, "ResultLabel");
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.Name = "ResultLabel";
            // 
            // ClientLabel
            // 
            resources.ApplyResources(this.ClientLabel, "ClientLabel");
            this.ClientLabel.Name = "ClientLabel";
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.ResultBox, "ResultBox");
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            // 
            // SendResult
            // 
            resources.ApplyResources(this.SendResult, "SendResult");
            this.SendResult.Name = "SendResult";
            this.SendResult.UseVisualStyleBackColor = true;
            this.SendResult.Click += new System.EventHandler(this.SendResult_Click);
            // 
            // CryptographyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.SendResult);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.MethodsCollection);
            this.Controls.Add(this.HashLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ResultLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "CryptographyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.ComboBox MethodsCollection;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Connection;
        private System.Windows.Forms.ToolStripMenuItem Disconnection;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button SendResult;
    }
}

