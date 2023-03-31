namespace RaZem_Photo
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.INPUT = new System.Windows.Forms.GroupBox();
            this.TIMES_CB = new System.Windows.Forms.CheckBox();
            this.Counter_INPOUT_LB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Load_BTN = new System.Windows.Forms.Button();
            this.CAMERA_LX = new System.Windows.Forms.ListBox();
            this.SD_CARD_LX = new System.Windows.Forms.ListBox();
            this.CAMERA_TX = new System.Windows.Forms.TextBox();
            this.SD_CARD_TX = new System.Windows.Forms.TextBox();
            this.Camera_Search_BT = new System.Windows.Forms.Button();
            this.Camera_RB = new System.Windows.Forms.RadioButton();
            this.SD_Card_RB = new System.Windows.Forms.RadioButton();
            this.SD_CARD_SEARCH_BT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UP_CB = new System.Windows.Forms.CheckBox();
            this.COUNTER_OUTPUT_LB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OUTPUT_LX = new System.Windows.Forms.ListBox();
            this.DESTINATION_SEARCH_BT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DESTINATION_TX = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.INPUT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // INPUT
            // 
            this.INPUT.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.INPUT.Controls.Add(this.TIMES_CB);
            this.INPUT.Controls.Add(this.Counter_INPOUT_LB);
            this.INPUT.Controls.Add(this.label3);
            this.INPUT.Controls.Add(this.label2);
            this.INPUT.Controls.Add(this.label1);
            this.INPUT.Controls.Add(this.Load_BTN);
            this.INPUT.Controls.Add(this.CAMERA_LX);
            this.INPUT.Controls.Add(this.SD_CARD_LX);
            this.INPUT.Controls.Add(this.CAMERA_TX);
            this.INPUT.Controls.Add(this.SD_CARD_TX);
            this.INPUT.Controls.Add(this.Camera_Search_BT);
            this.INPUT.Controls.Add(this.Camera_RB);
            this.INPUT.Controls.Add(this.SD_Card_RB);
            this.INPUT.Controls.Add(this.SD_CARD_SEARCH_BT);
            this.INPUT.Location = new System.Drawing.Point(12, 25);
            this.INPUT.Name = "INPUT";
            this.INPUT.Size = new System.Drawing.Size(674, 725);
            this.INPUT.TabIndex = 0;
            this.INPUT.TabStop = false;
            this.INPUT.Text = "INPUT";
            // 
            // TIMES_CB
            // 
            this.TIMES_CB.AutoSize = true;
            this.TIMES_CB.Location = new System.Drawing.Point(529, 686);
            this.TIMES_CB.Name = "TIMES_CB";
            this.TIMES_CB.Size = new System.Drawing.Size(87, 20);
            this.TIMES_CB.TabIndex = 13;
            this.TIMES_CB.Text = "Timer ON";
            this.TIMES_CB.ThreeState = true;
            this.TIMES_CB.UseVisualStyleBackColor = true;
            // 
            // Counter_INPOUT_LB
            // 
            this.Counter_INPOUT_LB.AutoSize = true;
            this.Counter_INPOUT_LB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Counter_INPOUT_LB.Location = new System.Drawing.Point(261, 686);
            this.Counter_INPOUT_LB.Name = "Counter_INPOUT_LB";
            this.Counter_INPOUT_LB.Size = new System.Drawing.Size(0, 24);
            this.Counter_INPOUT_LB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(182, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Counter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path:";
            // 
            // Load_BTN
            // 
            this.Load_BTN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Load_BTN.Location = new System.Drawing.Point(49, 681);
            this.Load_BTN.Name = "Load_BTN";
            this.Load_BTN.Size = new System.Drawing.Size(75, 35);
            this.Load_BTN.TabIndex = 8;
            this.Load_BTN.Text = "Načti";
            this.Load_BTN.UseVisualStyleBackColor = true;
            this.Load_BTN.Click += new System.EventHandler(this.Load_BTN_Click);
            // 
            // CAMERA_LX
            // 
            this.CAMERA_LX.FormattingEnabled = true;
            this.CAMERA_LX.ItemHeight = 16;
            this.CAMERA_LX.Location = new System.Drawing.Point(313, 122);
            this.CAMERA_LX.Name = "CAMERA_LX";
            this.CAMERA_LX.Size = new System.Drawing.Size(355, 548);
            this.CAMERA_LX.TabIndex = 7;
            // 
            // SD_CARD_LX
            // 
            this.SD_CARD_LX.FormattingEnabled = true;
            this.SD_CARD_LX.ItemHeight = 16;
            this.SD_CARD_LX.Location = new System.Drawing.Point(9, 122);
            this.SD_CARD_LX.Name = "SD_CARD_LX";
            this.SD_CARD_LX.Size = new System.Drawing.Size(298, 548);
            this.SD_CARD_LX.TabIndex = 6;
            // 
            // CAMERA_TX
            // 
            this.CAMERA_TX.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CAMERA_TX.Location = new System.Drawing.Point(360, 58);
            this.CAMERA_TX.Name = "CAMERA_TX";
            this.CAMERA_TX.Size = new System.Drawing.Size(308, 22);
            this.CAMERA_TX.TabIndex = 5;
            // 
            // SD_CARD_TX
            // 
            this.SD_CARD_TX.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SD_CARD_TX.Location = new System.Drawing.Point(49, 58);
            this.SD_CARD_TX.Name = "SD_CARD_TX";
            this.SD_CARD_TX.Size = new System.Drawing.Size(258, 22);
            this.SD_CARD_TX.TabIndex = 4;
            // 
            // Camera_Search_BT
            // 
            this.Camera_Search_BT.Location = new System.Drawing.Point(313, 93);
            this.Camera_Search_BT.Name = "Camera_Search_BT";
            this.Camera_Search_BT.Size = new System.Drawing.Size(92, 23);
            this.Camera_Search_BT.TabIndex = 3;
            this.Camera_Search_BT.Text = "...";
            this.Camera_Search_BT.UseVisualStyleBackColor = true;
            this.Camera_Search_BT.Click += new System.EventHandler(this.Camera_Search_BT_Click);
            // 
            // Camera_RB
            // 
            this.Camera_RB.AutoSize = true;
            this.Camera_RB.Location = new System.Drawing.Point(369, 32);
            this.Camera_RB.Name = "Camera_RB";
            this.Camera_RB.Size = new System.Drawing.Size(76, 20);
            this.Camera_RB.TabIndex = 2;
            this.Camera_RB.TabStop = true;
            this.Camera_RB.Text = "Camera";
            this.Camera_RB.UseVisualStyleBackColor = true;
            // 
            // SD_Card_RB
            // 
            this.SD_Card_RB.AutoSize = true;
            this.SD_Card_RB.Location = new System.Drawing.Point(6, 32);
            this.SD_Card_RB.Name = "SD_Card_RB";
            this.SD_Card_RB.Size = new System.Drawing.Size(79, 20);
            this.SD_Card_RB.TabIndex = 1;
            this.SD_Card_RB.TabStop = true;
            this.SD_Card_RB.Text = "SD Card";
            this.SD_Card_RB.UseVisualStyleBackColor = true;
            // 
            // SD_CARD_SEARCH_BT
            // 
            this.SD_CARD_SEARCH_BT.Location = new System.Drawing.Point(6, 93);
            this.SD_CARD_SEARCH_BT.Name = "SD_CARD_SEARCH_BT";
            this.SD_CARD_SEARCH_BT.Size = new System.Drawing.Size(75, 23);
            this.SD_CARD_SEARCH_BT.TabIndex = 0;
            this.SD_CARD_SEARCH_BT.Text = "...";
            this.SD_CARD_SEARCH_BT.UseVisualStyleBackColor = true;
            this.SD_CARD_SEARCH_BT.Click += new System.EventHandler(this.SD_CARD_SEARCH_BT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.UP_CB);
            this.groupBox1.Controls.Add(this.COUNTER_OUTPUT_LB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.OUTPUT_LX);
            this.groupBox1.Controls.Add(this.DESTINATION_SEARCH_BT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DESTINATION_TX);
            this.groupBox1.Location = new System.Drawing.Point(692, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 725);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // UP_CB
            // 
            this.UP_CB.AutoSize = true;
            this.UP_CB.Location = new System.Drawing.Point(345, 646);
            this.UP_CB.Name = "UP_CB";
            this.UP_CB.Size = new System.Drawing.Size(118, 20);
            this.UP_CB.TabIndex = 14;
            this.UP_CB.Text = "UP/DOWN ON";
            this.UP_CB.ThreeState = true;
            this.UP_CB.UseVisualStyleBackColor = true;
            // 
            // COUNTER_OUTPUT_LB
            // 
            this.COUNTER_OUTPUT_LB.AutoSize = true;
            this.COUNTER_OUTPUT_LB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.COUNTER_OUTPUT_LB.Location = new System.Drawing.Point(298, 641);
            this.COUNTER_OUTPUT_LB.Name = "COUNTER_OUTPUT_LB";
            this.COUNTER_OUTPUT_LB.Size = new System.Drawing.Size(0, 24);
            this.COUNTER_OUTPUT_LB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 641);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Counter:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(245, 681);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Vrať vše";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(52, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nakopíruj vše";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OUTPUT_LX
            // 
            this.OUTPUT_LX.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OUTPUT_LX.FormattingEnabled = true;
            this.OUTPUT_LX.ItemHeight = 40;
            this.OUTPUT_LX.Location = new System.Drawing.Point(6, 122);
            this.OUTPUT_LX.Name = "OUTPUT_LX";
            this.OUTPUT_LX.Size = new System.Drawing.Size(457, 484);
            this.OUTPUT_LX.TabIndex = 3;
            // 
            // DESTINATION_SEARCH_BT
            // 
            this.DESTINATION_SEARCH_BT.Location = new System.Drawing.Point(6, 93);
            this.DESTINATION_SEARCH_BT.Name = "DESTINATION_SEARCH_BT";
            this.DESTINATION_SEARCH_BT.Size = new System.Drawing.Size(75, 23);
            this.DESTINATION_SEARCH_BT.TabIndex = 2;
            this.DESTINATION_SEARCH_BT.Text = "...";
            this.DESTINATION_SEARCH_BT.UseVisualStyleBackColor = true;
            this.DESTINATION_SEARCH_BT.Click += new System.EventHandler(this.DESTINATION_SEARCH_BT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Path:";
            // 
            // DESTINATION_TX
            // 
            this.DESTINATION_TX.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DESTINATION_TX.Location = new System.Drawing.Point(52, 55);
            this.DESTINATION_TX.Name = "DESTINATION_TX";
            this.DESTINATION_TX.Size = new System.Drawing.Size(246, 22);
            this.DESTINATION_TX.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 641);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.INPUT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RaZem_PHOTO";
            this.INPUT.ResumeLayout(false);
            this.INPUT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox INPUT;
        private System.Windows.Forms.Button Camera_Search_BT;
        private System.Windows.Forms.RadioButton Camera_RB;
        private System.Windows.Forms.RadioButton SD_Card_RB;
        private System.Windows.Forms.Button SD_CARD_SEARCH_BT;
        private System.Windows.Forms.Button Load_BTN;
        private System.Windows.Forms.ListBox CAMERA_LX;
        private System.Windows.Forms.ListBox SD_CARD_LX;
        private System.Windows.Forms.TextBox CAMERA_TX;
        private System.Windows.Forms.TextBox SD_CARD_TX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Counter_INPOUT_LB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DESTINATION_TX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox OUTPUT_LX;
        private System.Windows.Forms.Button DESTINATION_SEARCH_BT;
        private System.Windows.Forms.Label COUNTER_OUTPUT_LB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox TIMES_CB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox UP_CB;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

