﻿
namespace eAutobus.WinUI
{
    partial class frmPocetna
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.autobusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoVoziloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorsnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKarataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasporedVoznjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRasporedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuLinijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cjenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuKartuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izdajKartuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autobusiToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.karteToolStripMenuItem,
            this.rasporedVoznjiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(633, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // autobusiToolStripMenuItem
            // 
            this.autobusiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.novoVoziloToolStripMenuItem});
            this.autobusiToolStripMenuItem.Name = "autobusiToolStripMenuItem";
            this.autobusiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.autobusiToolStripMenuItem.Text = "Autobusi";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // novoVoziloToolStripMenuItem
            // 
            this.novoVoziloToolStripMenuItem.Name = "novoVoziloToolStripMenuItem";
            this.novoVoziloToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.novoVoziloToolStripMenuItem.Text = "Novo vozilo";
            this.novoVoziloToolStripMenuItem.Click += new System.EventHandler(this.novoVoziloToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.noviKorsnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // noviKorsnikToolStripMenuItem
            // 
            this.noviKorsnikToolStripMenuItem.Name = "noviKorsnikToolStripMenuItem";
            this.noviKorsnikToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.noviKorsnikToolStripMenuItem.Text = "Novi korsnik";
            this.noviKorsnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorsnikToolStripMenuItem_Click);
            // 
            // karteToolStripMenuItem
            // 
            this.karteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKarataToolStripMenuItem,
            this.izdajKartuToolStripMenuItem});
            this.karteToolStripMenuItem.Name = "karteToolStripMenuItem";
            this.karteToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.karteToolStripMenuItem.Text = "Karte";
            // 
            // pregledKarataToolStripMenuItem
            // 
            this.pregledKarataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cjenovnikToolStripMenuItem,
            this.dodajNovuKartuToolStripMenuItem});
            this.pregledKarataToolStripMenuItem.Name = "pregledKarataToolStripMenuItem";
            this.pregledKarataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledKarataToolStripMenuItem.Text = "Pregled karata";
            this.pregledKarataToolStripMenuItem.Click += new System.EventHandler(this.pregledKarataToolStripMenuItem_Click);
            // 
            // rasporedVoznjiToolStripMenuItem
            // 
            this.rasporedVoznjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRasporedaToolStripMenuItem,
            this.dodajNovuLinijuToolStripMenuItem});
            this.rasporedVoznjiToolStripMenuItem.Name = "rasporedVoznjiToolStripMenuItem";
            this.rasporedVoznjiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.rasporedVoznjiToolStripMenuItem.Text = "Raspored voznji";
            this.rasporedVoznjiToolStripMenuItem.Click += new System.EventHandler(this.rasporedVoznjiToolStripMenuItem_Click);
            // 
            // pregledRasporedaToolStripMenuItem
            // 
            this.pregledRasporedaToolStripMenuItem.Name = "pregledRasporedaToolStripMenuItem";
            this.pregledRasporedaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pregledRasporedaToolStripMenuItem.Text = "Pregled rasporeda ";
            this.pregledRasporedaToolStripMenuItem.Click += new System.EventHandler(this.pregledRasporedaToolStripMenuItem_Click);
            // 
            // dodajNovuLinijuToolStripMenuItem
            // 
            this.dodajNovuLinijuToolStripMenuItem.Name = "dodajNovuLinijuToolStripMenuItem";
            this.dodajNovuLinijuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dodajNovuLinijuToolStripMenuItem.Text = "Dodaj novu liniju";
            this.dodajNovuLinijuToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuLinijuToolStripMenuItem_Click);
            // 
            // cjenovnikToolStripMenuItem
            // 
            this.cjenovnikToolStripMenuItem.Name = "cjenovnikToolStripMenuItem";
            this.cjenovnikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cjenovnikToolStripMenuItem.Text = "Cjenovnik";
            this.cjenovnikToolStripMenuItem.Click += new System.EventHandler(this.cjenovnikToolStripMenuItem_Click);
            // 
            // dodajNovuKartuToolStripMenuItem
            // 
            this.dodajNovuKartuToolStripMenuItem.Name = "dodajNovuKartuToolStripMenuItem";
            this.dodajNovuKartuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajNovuKartuToolStripMenuItem.Text = "Dodaj novu kartu";
            // 
            // izdajKartuToolStripMenuItem
            // 
            this.izdajKartuToolStripMenuItem.Name = "izdajKartuToolStripMenuItem";
            this.izdajKartuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izdajKartuToolStripMenuItem.Text = "Izdaj kartu";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(633, 449);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPocetna";
            this.Text = "frmPocetna";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem autobusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoVoziloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorsnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasporedVoznjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKarataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRasporedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuLinijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cjenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuKartuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdajKartuToolStripMenuItem;
    }
}



