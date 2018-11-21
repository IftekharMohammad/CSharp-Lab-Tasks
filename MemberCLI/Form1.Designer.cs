namespace ClubC
{
    partial class MainWindow
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.radioButtonInactive = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelExeShow = new System.Windows.Forms.Label();
            this.labelRegShow = new System.Windows.Forms.Label();
            this.labelExeName = new System.Windows.Forms.Label();
            this.labelExeAddress = new System.Windows.Forms.Label();
            this.labelExePosition = new System.Windows.Forms.Label();
            this.labelExeNameShow = new System.Windows.Forms.Label();
            this.labelExeAddressShow = new System.Windows.Forms.Label();
            this.labelExePositionShow = new System.Windows.Forms.Label();
            this.labelRegStatusShow = new System.Windows.Forms.Label();
            this.labelRegAddressShow = new System.Windows.Forms.Label();
            this.labelRegNameShow = new System.Windows.Forms.Label();
            this.labelRegStatus = new System.Windows.Forms.Label();
            this.labelRegAddress = new System.Windows.Forms.Label();
            this.labelRegName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(14, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Club Committee Management System";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(50, 134);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(50, 186);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(50, 322);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(50, 243);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(65, 20);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Position";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(170, 134);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(241, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(170, 186);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(241, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "President",
            "Secretary",
            "Manager"});
            this.comboBoxPosition.Location = new System.Drawing.Point(170, 242);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(241, 21);
            this.comboBoxPosition.TabIndex = 8;
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoCheck = false;
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonActive.Location = new System.Drawing.Point(170, 318);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(70, 24);
            this.radioButtonActive.TabIndex = 9;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Active";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            // 
            // radioButtonInactive
            // 
            this.radioButtonInactive.AutoCheck = false;
            this.radioButtonInactive.AutoSize = true;
            this.radioButtonInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInactive.Location = new System.Drawing.Point(329, 318);
            this.radioButtonInactive.Name = "radioButtonInactive";
            this.radioButtonInactive.Size = new System.Drawing.Size(82, 24);
            this.radioButtonInactive.TabIndex = 10;
            this.radioButtonInactive.TabStop = true;
            this.radioButtonInactive.Text = "Inactive";
            this.radioButtonInactive.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(170, 389);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 33);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(325, 389);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(86, 33);
            this.buttonShow.TabIndex = 12;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(957, 473);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(454, 50);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(239, 371);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(709, 48);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(236, 371);
            // 
            // labelExeShow
            // 
            this.labelExeShow.AutoSize = true;
            this.labelExeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExeShow.Location = new System.Drawing.Point(529, 60);
            this.labelExeShow.Name = "labelExeShow";
            this.labelExeShow.Size = new System.Drawing.Size(86, 20);
            this.labelExeShow.TabIndex = 14;
            this.labelExeShow.Text = "Executive";
            // 
            // labelRegShow
            // 
            this.labelRegShow.AutoSize = true;
            this.labelRegShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegShow.Location = new System.Drawing.Point(802, 60);
            this.labelRegShow.Name = "labelRegShow";
            this.labelRegShow.Size = new System.Drawing.Size(72, 20);
            this.labelRegShow.TabIndex = 15;
            this.labelRegShow.Text = "Regular";
            // 
            // labelExeName
            // 
            this.labelExeName.AutoSize = true;
            this.labelExeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExeName.Location = new System.Drawing.Point(459, 134);
            this.labelExeName.Name = "labelExeName";
            this.labelExeName.Size = new System.Drawing.Size(50, 16);
            this.labelExeName.TabIndex = 16;
            this.labelExeName.Text = "Name";
            // 
            // labelExeAddress
            // 
            this.labelExeAddress.AutoSize = true;
            this.labelExeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExeAddress.Location = new System.Drawing.Point(459, 190);
            this.labelExeAddress.Name = "labelExeAddress";
            this.labelExeAddress.Size = new System.Drawing.Size(67, 16);
            this.labelExeAddress.TabIndex = 17;
            this.labelExeAddress.Text = "Address";
            // 
            // labelExePosition
            // 
            this.labelExePosition.AutoSize = true;
            this.labelExePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExePosition.Location = new System.Drawing.Point(459, 242);
            this.labelExePosition.Name = "labelExePosition";
            this.labelExePosition.Size = new System.Drawing.Size(65, 16);
            this.labelExePosition.TabIndex = 18;
            this.labelExePosition.Text = "Position";
            // 
            // labelExeNameShow
            // 
            this.labelExeNameShow.AutoSize = true;
            this.labelExeNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExeNameShow.Location = new System.Drawing.Point(530, 134);
            this.labelExeNameShow.Name = "labelExeNameShow";
            this.labelExeNameShow.Size = new System.Drawing.Size(45, 16);
            this.labelExeNameShow.TabIndex = 19;
            this.labelExeNameShow.Text = "Name";
            this.labelExeNameShow.Visible = false;
            // 
            // labelExeAddressShow
            // 
            this.labelExeAddressShow.AutoSize = true;
            this.labelExeAddressShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExeAddressShow.Location = new System.Drawing.Point(530, 190);
            this.labelExeAddressShow.Name = "labelExeAddressShow";
            this.labelExeAddressShow.Size = new System.Drawing.Size(59, 16);
            this.labelExeAddressShow.TabIndex = 20;
            this.labelExeAddressShow.Text = "Address";
            this.labelExeAddressShow.Visible = false;
            // 
            // labelExePositionShow
            // 
            this.labelExePositionShow.AutoSize = true;
            this.labelExePositionShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExePositionShow.Location = new System.Drawing.Point(530, 242);
            this.labelExePositionShow.Name = "labelExePositionShow";
            this.labelExePositionShow.Size = new System.Drawing.Size(56, 16);
            this.labelExePositionShow.TabIndex = 21;
            this.labelExePositionShow.Text = "Position";
            this.labelExePositionShow.Visible = false;
            // 
            // labelRegStatusShow
            // 
            this.labelRegStatusShow.AutoSize = true;
            this.labelRegStatusShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegStatusShow.Location = new System.Drawing.Point(791, 242);
            this.labelRegStatusShow.Name = "labelRegStatusShow";
            this.labelRegStatusShow.Size = new System.Drawing.Size(45, 16);
            this.labelRegStatusShow.TabIndex = 27;
            this.labelRegStatusShow.Text = "Status";
            this.labelRegStatusShow.Visible = false;
            // 
            // labelRegAddressShow
            // 
            this.labelRegAddressShow.AutoSize = true;
            this.labelRegAddressShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegAddressShow.Location = new System.Drawing.Point(791, 190);
            this.labelRegAddressShow.Name = "labelRegAddressShow";
            this.labelRegAddressShow.Size = new System.Drawing.Size(59, 16);
            this.labelRegAddressShow.TabIndex = 26;
            this.labelRegAddressShow.Text = "Address";
            this.labelRegAddressShow.Visible = false;
            // 
            // labelRegNameShow
            // 
            this.labelRegNameShow.AutoSize = true;
            this.labelRegNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegNameShow.Location = new System.Drawing.Point(791, 134);
            this.labelRegNameShow.Name = "labelRegNameShow";
            this.labelRegNameShow.Size = new System.Drawing.Size(45, 16);
            this.labelRegNameShow.TabIndex = 25;
            this.labelRegNameShow.Text = "Name";
            this.labelRegNameShow.Visible = false;
            // 
            // labelRegStatus
            // 
            this.labelRegStatus.AutoSize = true;
            this.labelRegStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegStatus.Location = new System.Drawing.Point(720, 242);
            this.labelRegStatus.Name = "labelRegStatus";
            this.labelRegStatus.Size = new System.Drawing.Size(52, 16);
            this.labelRegStatus.TabIndex = 24;
            this.labelRegStatus.Text = "Status";
            // 
            // labelRegAddress
            // 
            this.labelRegAddress.AutoSize = true;
            this.labelRegAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegAddress.Location = new System.Drawing.Point(720, 190);
            this.labelRegAddress.Name = "labelRegAddress";
            this.labelRegAddress.Size = new System.Drawing.Size(67, 16);
            this.labelRegAddress.TabIndex = 23;
            this.labelRegAddress.Text = "Address";
            // 
            // labelRegName
            // 
            this.labelRegName.AutoSize = true;
            this.labelRegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegName.Location = new System.Drawing.Point(720, 134);
            this.labelRegName.Name = "labelRegName";
            this.labelRegName.Size = new System.Drawing.Size(50, 16);
            this.labelRegName.TabIndex = 22;
            this.labelRegName.Text = "Name";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 473);
            this.Controls.Add(this.labelRegStatusShow);
            this.Controls.Add(this.labelRegAddressShow);
            this.Controls.Add(this.labelRegNameShow);
            this.Controls.Add(this.labelRegStatus);
            this.Controls.Add(this.labelRegAddress);
            this.Controls.Add(this.labelRegName);
            this.Controls.Add(this.labelExePositionShow);
            this.Controls.Add(this.labelExeAddressShow);
            this.Controls.Add(this.labelExeNameShow);
            this.Controls.Add(this.labelExePosition);
            this.Controls.Add(this.labelExeAddress);
            this.Controls.Add(this.labelExeName);
            this.Controls.Add(this.labelRegShow);
            this.Controls.Add(this.labelExeShow);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.radioButtonInactive);
            this.Controls.Add(this.radioButtonActive);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "Club Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.RadioButton radioButtonInactive;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label labelExeShow;
        private System.Windows.Forms.Label labelRegShow;
        private System.Windows.Forms.Label labelExeName;
        private System.Windows.Forms.Label labelExeAddress;
        private System.Windows.Forms.Label labelExePosition;
        private System.Windows.Forms.Label labelExeNameShow;
        private System.Windows.Forms.Label labelExeAddressShow;
        private System.Windows.Forms.Label labelExePositionShow;
        private System.Windows.Forms.Label labelRegStatusShow;
        private System.Windows.Forms.Label labelRegAddressShow;
        private System.Windows.Forms.Label labelRegNameShow;
        private System.Windows.Forms.Label labelRegStatus;
        private System.Windows.Forms.Label labelRegAddress;
        private System.Windows.Forms.Label labelRegName;
    }
}

