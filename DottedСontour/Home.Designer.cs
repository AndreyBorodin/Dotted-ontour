
namespace DottedСontour
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDownloadXML = new System.Windows.Forms.Button();
            this.panelСontrol = new System.Windows.Forms.Panel();
            this.buttonCleaning = new System.Windows.Forms.Button();
            this.buttonСancel = new System.Windows.Forms.Button();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonPolygon = new System.Windows.Forms.RadioButton();
            this.labelInfoPoint = new System.Windows.Forms.Label();
            this.panelСontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDownloadXML
            // 
            this.buttonDownloadXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDownloadXML.Location = new System.Drawing.Point(16, 12);
            this.buttonDownloadXML.Name = "buttonDownloadXML";
            this.buttonDownloadXML.Size = new System.Drawing.Size(123, 54);
            this.buttonDownloadXML.TabIndex = 1;
            this.buttonDownloadXML.Text = "Загрузить полигон";
            this.buttonDownloadXML.UseVisualStyleBackColor = false;
            this.buttonDownloadXML.Click += new System.EventHandler(this.buttonDownloadXML_Click);
            // 
            // panelСontrol
            // 
            this.panelСontrol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelСontrol.Controls.Add(this.buttonCleaning);
            this.panelСontrol.Controls.Add(this.buttonСancel);
            this.panelСontrol.Controls.Add(this.buttonSaveXML);
            this.panelСontrol.Controls.Add(this.radioButtonPoint);
            this.panelСontrol.Controls.Add(this.radioButtonPolygon);
            this.panelСontrol.Controls.Add(this.buttonDownloadXML);
            this.panelСontrol.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelСontrol.Location = new System.Drawing.Point(844, 0);
            this.panelСontrol.Name = "panelСontrol";
            this.panelСontrol.Size = new System.Drawing.Size(151, 647);
            this.panelСontrol.TabIndex = 0;
            // 
            // buttonCleaning
            // 
            this.buttonCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCleaning.Location = new System.Drawing.Point(16, 283);
            this.buttonCleaning.Name = "buttonCleaning";
            this.buttonCleaning.Size = new System.Drawing.Size(94, 27);
            this.buttonCleaning.TabIndex = 6;
            this.buttonCleaning.Text = "Очистка";
            this.buttonCleaning.UseVisualStyleBackColor = false;
            this.buttonCleaning.Click += new System.EventHandler(this.buttonCleaning_Click);
            // 
            // buttonСancel
            // 
            this.buttonСancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonСancel.Location = new System.Drawing.Point(17, 234);
            this.buttonСancel.Name = "buttonСancel";
            this.buttonСancel.Size = new System.Drawing.Size(94, 27);
            this.buttonСancel.TabIndex = 5;
            this.buttonСancel.Text = "Отмена";
            this.buttonСancel.UseVisualStyleBackColor = false;
            this.buttonСancel.Click += new System.EventHandler(this.buttonСancel_Click);
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveXML.Location = new System.Drawing.Point(16, 89);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(123, 54);
            this.buttonSaveXML.TabIndex = 4;
            this.buttonSaveXML.Text = "Сохранить полигон";
            this.buttonSaveXML.UseVisualStyleBackColor = false;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(17, 195);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPoint.TabIndex = 3;
            this.radioButtonPoint.Text = "Точка";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButtonPoint_CheckedChanged);
            // 
            // radioButtonPolygon
            // 
            this.radioButtonPolygon.AutoSize = true;
            this.radioButtonPolygon.Checked = true;
            this.radioButtonPolygon.Location = new System.Drawing.Point(17, 162);
            this.radioButtonPolygon.Name = "radioButtonPolygon";
            this.radioButtonPolygon.Size = new System.Drawing.Size(68, 17);
            this.radioButtonPolygon.TabIndex = 2;
            this.radioButtonPolygon.TabStop = true;
            this.radioButtonPolygon.Text = "Полигон";
            this.radioButtonPolygon.UseVisualStyleBackColor = true;
            this.radioButtonPolygon.CheckedChanged += new System.EventHandler(this.radioButtonPolygon_CheckedChanged);
            // 
            // labelInfoPoint
            // 
            this.labelInfoPoint.AutoSize = true;
            this.labelInfoPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoPoint.Location = new System.Drawing.Point(12, 12);
            this.labelInfoPoint.Name = "labelInfoPoint";
            this.labelInfoPoint.Size = new System.Drawing.Size(204, 25);
            this.labelInfoPoint.TabIndex = 5;
            this.labelInfoPoint.Text = "Точка не указана";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(995, 647);
            this.Controls.Add(this.labelInfoPoint);
            this.Controls.Add(this.panelСontrol);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AutoSizeChanged += new System.EventHandler(this.Home_ResizeBegin);
            this.ResizeBegin += new System.EventHandler(this.Home_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Home_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Home_MouseClick);
            this.panelСontrol.ResumeLayout(false);
            this.panelСontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownloadXML;
        private System.Windows.Forms.Panel panelСontrol;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.RadioButton radioButtonPolygon;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Label labelInfoPoint;
        private System.Windows.Forms.Button buttonCleaning;
        private System.Windows.Forms.Button buttonСancel;
    }
}

