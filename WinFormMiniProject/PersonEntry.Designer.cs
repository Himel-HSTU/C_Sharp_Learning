namespace WinFormMiniProject
{
    partial class PersonEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            firstNameText = new TextBox();
            lastNameLabel = new Label();
            lastNameText = new TextBox();
            isYou = new CheckBox();
            isYouLabel = new Label();
            addressList = new ListBox();
            addressListLabel = new Label();
            addNewAddress = new Button();
            saveRecord = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AllowDrop = true;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(31, 32);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(125, 30);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.Click += this.firstNameLabel_Click;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(162, 32);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(331, 35);
            firstNameText.TabIndex = 1;
            firstNameText.TextChanged += this.firstNameText_TextChanged;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AllowDrop = true;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(31, 82);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(122, 30);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.Click += this.firstNameLabel_Click;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(162, 82);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(331, 35);
            lastNameText.TabIndex = 1;
            lastNameText.TextChanged += this.firstNameText_TextChanged;
            // 
            // isYou
            // 
            isYou.AutoSize = true;
            isYou.Location = new Point(176, 157);
            isYou.Name = "isYou";
            isYou.Size = new Size(15, 14);
            isYou.TabIndex = 2;
            isYou.UseVisualStyleBackColor = true;
            // 
            // isYouLabel
            // 
            isYouLabel.AllowDrop = true;
            isYouLabel.AutoSize = true;
            isYouLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isYouLabel.Location = new Point(31, 148);
            isYouLabel.Name = "isYouLabel";
            isYouLabel.Size = new Size(104, 30);
            isYouLabel.TabIndex = 0;
            isYouLabel.Text = "Is Yours ?";
            isYouLabel.Click += this.firstNameLabel_Click;
            // 
            // addressList
            // 
            addressList.FormattingEnabled = true;
            addressList.Location = new Point(162, 247);
            addressList.Name = "addressList";
            addressList.Size = new Size(331, 184);
            addressList.TabIndex = 3;
            // 
            // addressListLabel
            // 
            addressListLabel.AllowDrop = true;
            addressListLabel.AutoSize = true;
            addressListLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressListLabel.Location = new Point(31, 198);
            addressListLabel.Name = "addressListLabel";
            addressListLabel.Size = new Size(106, 30);
            addressListLabel.TabIndex = 0;
            addressListLabel.Text = "Address ?";
            addressListLabel.Click += this.firstNameLabel_Click;
            // 
            // addNewAddress
            // 
            addNewAddress.Location = new Point(360, 200);
            addNewAddress.Name = "addNewAddress";
            addNewAddress.Size = new Size(133, 41);
            addNewAddress.TabIndex = 4;
            addNewAddress.Text = "Add !";
            addNewAddress.UseVisualStyleBackColor = true;
            // 
            // saveRecord
            // 
            saveRecord.Location = new Point(256, 452);
            saveRecord.Name = "saveRecord";
            saveRecord.Size = new Size(149, 52);
            saveRecord.TabIndex = 5;
            saveRecord.Text = "Save";
            saveRecord.UseVisualStyleBackColor = true;
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 538);
            Controls.Add(saveRecord);
            Controls.Add(addNewAddress);
            Controls.Add(addressList);
            Controls.Add(isYou);
            Controls.Add(lastNameText);
            Controls.Add(addressListLabel);
            Controls.Add(isYouLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameText);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "PersonEntry";
            Text = "Person Entry Form by pcBhai";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private CheckBox isYou;
        private Label isYouLabel;
        private ListBox addressList;
        private Label addressListLabel;
        private Button addNewAddress;
        private Button saveRecord;
    }
}
