namespace SesameApiClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.tbSesameToken = new System.Windows.Forms.TextBox();
            this.tbSesameApiUrl = new System.Windows.Forms.TextBox();
            this.lblSesameToken = new System.Windows.Forms.Label();
            this.lblSesameApiUrl = new System.Windows.Forms.Label();
            this.gbDeviceList = new System.Windows.Forms.GroupBox();
            this.lbDeviceList = new System.Windows.Forms.ListBox();
            this.btnGetDeviceList = new System.Windows.Forms.Button();
            this.btnControlSync = new System.Windows.Forms.Button();
            this.btnControlUnlock = new System.Windows.Forms.Button();
            this.btnControlLock = new System.Windows.Forms.Button();
            this.btnGetDeviceStatus = new System.Windows.Forms.Button();
            this.tbNickName = new System.Windows.Forms.TextBox();
            this.tbSerialNo = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.gbTaskHistory = new System.Windows.Forms.GroupBox();
            this.tbTaskDateTime = new System.Windows.Forms.TextBox();
            this.tbTaskCommand = new System.Windows.Forms.TextBox();
            this.tbTaskId = new System.Windows.Forms.TextBox();
            this.btnQueryTaskResult = new System.Windows.Forms.Button();
            this.lblTaskDateTime = new System.Windows.Forms.Label();
            this.lblTaskCommand = new System.Windows.Forms.Label();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lbTaskHistory = new System.Windows.Forms.ListBox();
            this.gbDeviceStatus = new System.Windows.Forms.GroupBox();
            this.tbBattery = new System.Windows.Forms.TextBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.cbResponsive = new System.Windows.Forms.CheckBox();
            this.cbLocked = new System.Windows.Forms.CheckBox();
            this.gbTaskResult = new System.Windows.Forms.GroupBox();
            this.tbTaskError = new System.Windows.Forms.TextBox();
            this.tbTaskStatus = new System.Windows.Forms.TextBox();
            this.lblTaskError = new System.Windows.Forms.Label();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.cbTaskSuccessful = new System.Windows.Forms.CheckBox();
            this.tbInformation = new System.Windows.Forms.TextBox();
            this.gbConnection.SuspendLayout();
            this.gbDeviceList.SuspendLayout();
            this.gbTaskHistory.SuspendLayout();
            this.gbDeviceStatus.SuspendLayout();
            this.gbTaskResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.tbSesameToken);
            this.gbConnection.Controls.Add(this.tbSesameApiUrl);
            this.gbConnection.Controls.Add(this.lblSesameToken);
            this.gbConnection.Controls.Add(this.lblSesameApiUrl);
            this.gbConnection.Location = new System.Drawing.Point(12, 10);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(456, 68);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // tbSesameToken
            // 
            this.tbSesameToken.Location = new System.Drawing.Point(94, 40);
            this.tbSesameToken.Name = "tbSesameToken";
            this.tbSesameToken.Size = new System.Drawing.Size(335, 19);
            this.tbSesameToken.TabIndex = 13;
            // 
            // tbSesameApiUrl
            // 
            this.tbSesameApiUrl.Location = new System.Drawing.Point(94, 16);
            this.tbSesameApiUrl.Name = "tbSesameApiUrl";
            this.tbSesameApiUrl.Size = new System.Drawing.Size(232, 19);
            this.tbSesameApiUrl.TabIndex = 11;
            // 
            // lblSesameToken
            // 
            this.lblSesameToken.AutoSize = true;
            this.lblSesameToken.Location = new System.Drawing.Point(12, 43);
            this.lblSesameToken.Name = "lblSesameToken";
            this.lblSesameToken.Size = new System.Drawing.Size(76, 12);
            this.lblSesameToken.TabIndex = 12;
            this.lblSesameToken.Text = "SesameToken";
            // 
            // lblSesameApiUrl
            // 
            this.lblSesameApiUrl.AutoSize = true;
            this.lblSesameApiUrl.Location = new System.Drawing.Point(12, 19);
            this.lblSesameApiUrl.Name = "lblSesameApiUrl";
            this.lblSesameApiUrl.Size = new System.Drawing.Size(27, 12);
            this.lblSesameApiUrl.TabIndex = 11;
            this.lblSesameApiUrl.Text = "URL";
            // 
            // gbDeviceList
            // 
            this.gbDeviceList.Controls.Add(this.btnControlSync);
            this.gbDeviceList.Controls.Add(this.lbDeviceList);
            this.gbDeviceList.Controls.Add(this.btnControlUnlock);
            this.gbDeviceList.Controls.Add(this.btnGetDeviceList);
            this.gbDeviceList.Controls.Add(this.gbDeviceStatus);
            this.gbDeviceList.Controls.Add(this.lblDeviceId);
            this.gbDeviceList.Controls.Add(this.btnControlLock);
            this.gbDeviceList.Controls.Add(this.tbDeviceId);
            this.gbDeviceList.Controls.Add(this.tbNickName);
            this.gbDeviceList.Controls.Add(this.lblSerialNo);
            this.gbDeviceList.Controls.Add(this.tbSerialNo);
            this.gbDeviceList.Controls.Add(this.lblNickName);
            this.gbDeviceList.Location = new System.Drawing.Point(12, 96);
            this.gbDeviceList.Name = "gbDeviceList";
            this.gbDeviceList.Size = new System.Drawing.Size(679, 195);
            this.gbDeviceList.TabIndex = 1;
            this.gbDeviceList.TabStop = false;
            this.gbDeviceList.Text = "Device List";
            // 
            // lbDeviceList
            // 
            this.lbDeviceList.FormattingEnabled = true;
            this.lbDeviceList.ItemHeight = 12;
            this.lbDeviceList.Location = new System.Drawing.Point(14, 47);
            this.lbDeviceList.Name = "lbDeviceList";
            this.lbDeviceList.Size = new System.Drawing.Size(264, 136);
            this.lbDeviceList.TabIndex = 1;
            this.lbDeviceList.SelectedIndexChanged += new System.EventHandler(this.lbDeviceList_SelectedIndexChanged);
            // 
            // btnGetDeviceList
            // 
            this.btnGetDeviceList.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGetDeviceList.Location = new System.Drawing.Point(14, 18);
            this.btnGetDeviceList.Name = "btnGetDeviceList";
            this.btnGetDeviceList.Size = new System.Drawing.Size(62, 23);
            this.btnGetDeviceList.TabIndex = 0;
            this.btnGetDeviceList.Text = "Get List";
            this.btnGetDeviceList.UseVisualStyleBackColor = true;
            this.btnGetDeviceList.Click += new System.EventHandler(this.btnGetDeviceList_Click);
            // 
            // btnControlSync
            // 
            this.btnControlSync.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnControlSync.Location = new System.Drawing.Point(429, 158);
            this.btnControlSync.Name = "btnControlSync";
            this.btnControlSync.Size = new System.Drawing.Size(47, 23);
            this.btnControlSync.TabIndex = 10;
            this.btnControlSync.Text = "Sync";
            this.btnControlSync.UseVisualStyleBackColor = true;
            this.btnControlSync.Click += new System.EventHandler(this.btnControlSync_Click);
            // 
            // btnControlUnlock
            // 
            this.btnControlUnlock.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnControlUnlock.Location = new System.Drawing.Point(360, 158);
            this.btnControlUnlock.Name = "btnControlUnlock";
            this.btnControlUnlock.Size = new System.Drawing.Size(61, 23);
            this.btnControlUnlock.TabIndex = 9;
            this.btnControlUnlock.Text = "Unlock";
            this.btnControlUnlock.UseVisualStyleBackColor = true;
            this.btnControlUnlock.Click += new System.EventHandler(this.btnControlUnlock_Click);
            // 
            // btnControlLock
            // 
            this.btnControlLock.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnControlLock.Location = new System.Drawing.Point(305, 158);
            this.btnControlLock.Name = "btnControlLock";
            this.btnControlLock.Size = new System.Drawing.Size(47, 23);
            this.btnControlLock.TabIndex = 8;
            this.btnControlLock.Text = "Lock";
            this.btnControlLock.UseVisualStyleBackColor = true;
            this.btnControlLock.Click += new System.EventHandler(this.btnControlLock_Click);
            // 
            // btnGetDeviceStatus
            // 
            this.btnGetDeviceStatus.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGetDeviceStatus.Location = new System.Drawing.Point(12, 107);
            this.btnGetDeviceStatus.Name = "btnGetDeviceStatus";
            this.btnGetDeviceStatus.Size = new System.Drawing.Size(80, 23);
            this.btnGetDeviceStatus.TabIndex = 2;
            this.btnGetDeviceStatus.Text = "Get Status";
            this.btnGetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnGetDeviceStatus.Click += new System.EventHandler(this.btnGetDeviceStatus_Click);
            // 
            // tbNickName
            // 
            this.tbNickName.Location = new System.Drawing.Point(384, 62);
            this.tbNickName.Name = "tbNickName";
            this.tbNickName.ReadOnly = true;
            this.tbNickName.Size = new System.Drawing.Size(110, 19);
            this.tbNickName.TabIndex = 7;
            // 
            // tbSerialNo
            // 
            this.tbSerialNo.Location = new System.Drawing.Point(384, 38);
            this.tbSerialNo.Name = "tbSerialNo";
            this.tbSerialNo.ReadOnly = true;
            this.tbSerialNo.Size = new System.Drawing.Size(110, 19);
            this.tbSerialNo.TabIndex = 5;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(302, 65);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(61, 12);
            this.lblNickName.TabIndex = 4;
            this.lblNickName.Text = "Nick Name";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(302, 41);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(52, 12);
            this.lblSerialNo.TabIndex = 2;
            this.lblSerialNo.Text = "Serial No";
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(302, 18);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(55, 12);
            this.lblDeviceId.TabIndex = 1;
            this.lblDeviceId.Text = "Device ID";
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(384, 15);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(250, 19);
            this.tbDeviceId.TabIndex = 0;
            // 
            // gbTaskHistory
            // 
            this.gbTaskHistory.Controls.Add(this.tbTaskDateTime);
            this.gbTaskHistory.Controls.Add(this.gbTaskResult);
            this.gbTaskHistory.Controls.Add(this.tbTaskCommand);
            this.gbTaskHistory.Controls.Add(this.tbTaskId);
            this.gbTaskHistory.Controls.Add(this.lblTaskDateTime);
            this.gbTaskHistory.Controls.Add(this.lblTaskCommand);
            this.gbTaskHistory.Controls.Add(this.lblTaskId);
            this.gbTaskHistory.Controls.Add(this.lbTaskHistory);
            this.gbTaskHistory.Location = new System.Drawing.Point(12, 297);
            this.gbTaskHistory.Name = "gbTaskHistory";
            this.gbTaskHistory.Size = new System.Drawing.Size(679, 235);
            this.gbTaskHistory.TabIndex = 3;
            this.gbTaskHistory.TabStop = false;
            this.gbTaskHistory.Text = "Task History";
            // 
            // tbTaskDateTime
            // 
            this.tbTaskDateTime.Location = new System.Drawing.Point(228, 62);
            this.tbTaskDateTime.Name = "tbTaskDateTime";
            this.tbTaskDateTime.ReadOnly = true;
            this.tbTaskDateTime.Size = new System.Drawing.Size(125, 19);
            this.tbTaskDateTime.TabIndex = 13;
            // 
            // tbTaskCommand
            // 
            this.tbTaskCommand.Location = new System.Drawing.Point(228, 38);
            this.tbTaskCommand.Name = "tbTaskCommand";
            this.tbTaskCommand.ReadOnly = true;
            this.tbTaskCommand.Size = new System.Drawing.Size(47, 19);
            this.tbTaskCommand.TabIndex = 12;
            // 
            // tbTaskId
            // 
            this.tbTaskId.Location = new System.Drawing.Point(228, 15);
            this.tbTaskId.Name = "tbTaskId";
            this.tbTaskId.ReadOnly = true;
            this.tbTaskId.Size = new System.Drawing.Size(227, 19);
            this.tbTaskId.TabIndex = 11;
            // 
            // btnQueryTaskResult
            // 
            this.btnQueryTaskResult.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnQueryTaskResult.Location = new System.Drawing.Point(11, 94);
            this.btnQueryTaskResult.Name = "btnQueryTaskResult";
            this.btnQueryTaskResult.Size = new System.Drawing.Size(135, 23);
            this.btnQueryTaskResult.TabIndex = 2;
            this.btnQueryTaskResult.Text = "Query Task Result";
            this.btnQueryTaskResult.UseVisualStyleBackColor = true;
            this.btnQueryTaskResult.Click += new System.EventHandler(this.btnQueryTaskResult_Click);
            // 
            // lblTaskDateTime
            // 
            this.lblTaskDateTime.AutoSize = true;
            this.lblTaskDateTime.Location = new System.Drawing.Point(161, 65);
            this.lblTaskDateTime.Name = "lblTaskDateTime";
            this.lblTaskDateTime.Size = new System.Drawing.Size(54, 12);
            this.lblTaskDateTime.TabIndex = 9;
            this.lblTaskDateTime.Text = "DateTime";
            // 
            // lblTaskCommand
            // 
            this.lblTaskCommand.AutoSize = true;
            this.lblTaskCommand.Location = new System.Drawing.Point(161, 41);
            this.lblTaskCommand.Name = "lblTaskCommand";
            this.lblTaskCommand.Size = new System.Drawing.Size(55, 12);
            this.lblTaskCommand.TabIndex = 4;
            this.lblTaskCommand.Text = "Command";
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Location = new System.Drawing.Point(161, 18);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(45, 12);
            this.lblTaskId.TabIndex = 8;
            this.lblTaskId.Text = "Task ID";
            // 
            // lbTaskHistory
            // 
            this.lbTaskHistory.FormattingEnabled = true;
            this.lbTaskHistory.ItemHeight = 12;
            this.lbTaskHistory.Location = new System.Drawing.Point(7, 18);
            this.lbTaskHistory.Name = "lbTaskHistory";
            this.lbTaskHistory.Size = new System.Drawing.Size(135, 208);
            this.lbTaskHistory.TabIndex = 4;
            this.lbTaskHistory.SelectedIndexChanged += new System.EventHandler(this.lbTaskHistory_SelectedIndexChanged);
            // 
            // gbDeviceStatus
            // 
            this.gbDeviceStatus.Controls.Add(this.tbBattery);
            this.gbDeviceStatus.Controls.Add(this.lblBattery);
            this.gbDeviceStatus.Controls.Add(this.cbResponsive);
            this.gbDeviceStatus.Controls.Add(this.btnGetDeviceStatus);
            this.gbDeviceStatus.Controls.Add(this.cbLocked);
            this.gbDeviceStatus.Location = new System.Drawing.Point(517, 47);
            this.gbDeviceStatus.Name = "gbDeviceStatus";
            this.gbDeviceStatus.Size = new System.Drawing.Size(140, 136);
            this.gbDeviceStatus.TabIndex = 4;
            this.gbDeviceStatus.TabStop = false;
            this.gbDeviceStatus.Text = "Device Status";
            // 
            // tbBattery
            // 
            this.tbBattery.Location = new System.Drawing.Point(57, 18);
            this.tbBattery.Name = "tbBattery";
            this.tbBattery.ReadOnly = true;
            this.tbBattery.Size = new System.Drawing.Size(35, 19);
            this.tbBattery.TabIndex = 11;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(11, 21);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(43, 12);
            this.lblBattery.TabIndex = 11;
            this.lblBattery.Text = "Battery";
            // 
            // cbResponsive
            // 
            this.cbResponsive.AutoSize = true;
            this.cbResponsive.Enabled = false;
            this.cbResponsive.Location = new System.Drawing.Point(12, 63);
            this.cbResponsive.Name = "cbResponsive";
            this.cbResponsive.Size = new System.Drawing.Size(83, 16);
            this.cbResponsive.TabIndex = 0;
            this.cbResponsive.Text = "Responsive";
            this.cbResponsive.UseVisualStyleBackColor = true;
            // 
            // cbLocked
            // 
            this.cbLocked.AutoSize = true;
            this.cbLocked.Enabled = false;
            this.cbLocked.Location = new System.Drawing.Point(12, 41);
            this.cbLocked.Name = "cbLocked";
            this.cbLocked.Size = new System.Drawing.Size(60, 16);
            this.cbLocked.TabIndex = 0;
            this.cbLocked.Text = "Locked";
            this.cbLocked.UseVisualStyleBackColor = true;
            // 
            // gbTaskResult
            // 
            this.gbTaskResult.Controls.Add(this.tbTaskError);
            this.gbTaskResult.Controls.Add(this.tbTaskStatus);
            this.gbTaskResult.Controls.Add(this.lblTaskError);
            this.gbTaskResult.Controls.Add(this.btnQueryTaskResult);
            this.gbTaskResult.Controls.Add(this.lblTaskStatus);
            this.gbTaskResult.Controls.Add(this.cbTaskSuccessful);
            this.gbTaskResult.Location = new System.Drawing.Point(164, 98);
            this.gbTaskResult.Name = "gbTaskResult";
            this.gbTaskResult.Size = new System.Drawing.Size(291, 125);
            this.gbTaskResult.TabIndex = 5;
            this.gbTaskResult.TabStop = false;
            this.gbTaskResult.Text = "Task Result";
            // 
            // tbTaskError
            // 
            this.tbTaskError.Location = new System.Drawing.Point(54, 61);
            this.tbTaskError.Name = "tbTaskError";
            this.tbTaskError.ReadOnly = true;
            this.tbTaskError.Size = new System.Drawing.Size(113, 19);
            this.tbTaskError.TabIndex = 16;
            // 
            // tbTaskStatus
            // 
            this.tbTaskStatus.Location = new System.Drawing.Point(54, 39);
            this.tbTaskStatus.Name = "tbTaskStatus";
            this.tbTaskStatus.ReadOnly = true;
            this.tbTaskStatus.Size = new System.Drawing.Size(113, 19);
            this.tbTaskStatus.TabIndex = 14;
            // 
            // lblTaskError
            // 
            this.lblTaskError.AutoSize = true;
            this.lblTaskError.Location = new System.Drawing.Point(10, 64);
            this.lblTaskError.Name = "lblTaskError";
            this.lblTaskError.Size = new System.Drawing.Size(30, 12);
            this.lblTaskError.TabIndex = 15;
            this.lblTaskError.Text = "Error";
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.Location = new System.Drawing.Point(10, 42);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(38, 12);
            this.lblTaskStatus.TabIndex = 14;
            this.lblTaskStatus.Text = "Status";
            // 
            // cbTaskSuccessful
            // 
            this.cbTaskSuccessful.AutoSize = true;
            this.cbTaskSuccessful.Enabled = false;
            this.cbTaskSuccessful.Location = new System.Drawing.Point(11, 18);
            this.cbTaskSuccessful.Name = "cbTaskSuccessful";
            this.cbTaskSuccessful.Size = new System.Drawing.Size(80, 16);
            this.cbTaskSuccessful.TabIndex = 6;
            this.cbTaskSuccessful.Text = "Successful";
            this.cbTaskSuccessful.UseVisualStyleBackColor = true;
            // 
            // tbInformation
            // 
            this.tbInformation.Location = new System.Drawing.Point(12, 547);
            this.tbInformation.Multiline = true;
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.ReadOnly = true;
            this.tbInformation.Size = new System.Drawing.Size(679, 163);
            this.tbInformation.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 725);
            this.Controls.Add(this.tbInformation);
            this.Controls.Add(this.gbTaskHistory);
            this.Controls.Add(this.gbDeviceList);
            this.Controls.Add(this.gbConnection);
            this.Name = "MainForm";
            this.Text = "SesameApiClient";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbDeviceList.ResumeLayout(false);
            this.gbDeviceList.PerformLayout();
            this.gbTaskHistory.ResumeLayout(false);
            this.gbTaskHistory.PerformLayout();
            this.gbDeviceStatus.ResumeLayout(false);
            this.gbDeviceStatus.PerformLayout();
            this.gbTaskResult.ResumeLayout(false);
            this.gbTaskResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.GroupBox gbDeviceList;
        private System.Windows.Forms.GroupBox gbTaskHistory;
        private System.Windows.Forms.ListBox lbDeviceList;
        private System.Windows.Forms.Button btnGetDeviceList;
        private System.Windows.Forms.TextBox tbNickName;
        private System.Windows.Forms.TextBox tbSerialNo;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.Button btnQueryTaskResult;
        private System.Windows.Forms.Label lblTaskDateTime;
        private System.Windows.Forms.Label lblTaskCommand;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.ListBox lbTaskHistory;
        private System.Windows.Forms.Button btnControlSync;
        private System.Windows.Forms.Button btnControlUnlock;
        private System.Windows.Forms.Button btnControlLock;
        private System.Windows.Forms.Button btnGetDeviceStatus;
        private System.Windows.Forms.TextBox tbTaskDateTime;
        private System.Windows.Forms.TextBox tbTaskCommand;
        private System.Windows.Forms.TextBox tbTaskId;
        private System.Windows.Forms.GroupBox gbDeviceStatus;
        private System.Windows.Forms.CheckBox cbResponsive;
        private System.Windows.Forms.CheckBox cbLocked;
        private System.Windows.Forms.TextBox tbBattery;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.GroupBox gbTaskResult;
        private System.Windows.Forms.Label lblTaskError;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.CheckBox cbTaskSuccessful;
        private System.Windows.Forms.TextBox tbTaskError;
        private System.Windows.Forms.TextBox tbTaskStatus;
        private System.Windows.Forms.TextBox tbInformation;
        private System.Windows.Forms.TextBox tbSesameToken;
        private System.Windows.Forms.TextBox tbSesameApiUrl;
        private System.Windows.Forms.Label lblSesameToken;
        private System.Windows.Forms.Label lblSesameApiUrl;
    }
}

