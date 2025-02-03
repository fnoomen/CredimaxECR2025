// Decompiled with JetBrains decompiler
// Type: CredimaxECR.frmDosetup
// Assembly: CredimaxECR, Version=2.0.3.5, Culture=neutral, PublicKeyToken=b43258113e35a86c
// MVID: A3E1DCA5-F709-47AF-B692-BED8AD8A56FE
// Assembly location: C:\Users\User\Downloads\Compressed\ECR DLL 2.0.3.5\CredimaxECR.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace CredimaxECR
{
  [DesignerGenerated]
  internal class frmDosetup : Form
  {
    private IContainer components;
    private comCMXECR.Setting Settings;

    public frmDosetup()
    {
      this.Load += new EventHandler(this.frmDosetup_Load);
      this.Settings = new comCMXECR.Setting();
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.butSave = new Button();
      this.butClose = new Button();
      this.grpSettings = new GroupBox();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.txtTimeout = new TextBox();
      this.cmbPort = new ComboBox();
      this.Label2 = new Label();
      this.cmbBaudRate = new ComboBox();
      this.Label1 = new Label();
      this.grpGeneral = new GroupBox();
      this.chkTxnLog = new CheckBox();
      this.chkWaitRes = new CheckBox();
      this.chkAPACS = new CheckBox();
      this.Label9 = new Label();
      this.Label13 = new Label();
      this.chkDelay = new CheckBox();
      this.chkTrace = new CheckBox();
      this.txtDelayTimeout = new TextBox();
      this.Label7 = new Label();
      this.txtTxnTimeout = new TextBox();
      this.Label4 = new Label();
      this.cmdTracePath = new Button();
      this.Label11 = new Label();
      this.Label8 = new Label();
      this.txtTracePath = new TextBox();
      this.txtUploadTimeout = new TextBox();
      this.grpSettings.SuspendLayout();
      this.grpGeneral.SuspendLayout();
      this.SuspendLayout();
      this.butSave.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.butSave.Location = new Point(145, 230);
      this.butSave.Name = "butSave";
      this.butSave.Size = new Size(85, 37);
      this.butSave.TabIndex = 0;
      this.butSave.Text = "&Save";
      this.butSave.UseVisualStyleBackColor = true;
      this.butClose.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.butClose.Location = new Point(321, 230);
      this.butClose.Name = "butClose";
      this.butClose.Size = new Size(85, 37);
      this.butClose.TabIndex = 0;
      this.butClose.Text = "&Close";
      this.butClose.UseVisualStyleBackColor = true;
      this.grpSettings.BackColor = Color.Transparent;
      this.grpSettings.Controls.Add((Control) this.Label5);
      this.grpSettings.Controls.Add((Control) this.Label6);
      this.grpSettings.Controls.Add((Control) this.txtTimeout);
      this.grpSettings.Controls.Add((Control) this.cmbPort);
      this.grpSettings.Controls.Add((Control) this.Label2);
      this.grpSettings.Controls.Add((Control) this.cmbBaudRate);
      this.grpSettings.Controls.Add((Control) this.Label1);
      this.grpSettings.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grpSettings.Location = new Point(17, 20);
      this.grpSettings.Name = "grpSettings";
      this.grpSettings.Size = new Size(517, 54);
      this.grpSettings.TabIndex = 2;
      this.grpSettings.TabStop = false;
      this.grpSettings.Text = "Port";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Brown;
      this.Label5.Location = new Point(440, 25);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(49, 14);
      this.Label5.TabIndex = 10;
      this.Label5.Text = "seconds";
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(336, 23);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(59, 14);
      this.Label6.TabIndex = 9;
      this.Label6.Text = "Timeout :";
      this.txtTimeout.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTimeout.Location = new Point(398, 20);
      this.txtTimeout.MaxLength = 2;
      this.txtTimeout.Name = "txtTimeout";
      this.txtTimeout.Size = new Size(39, 20);
      this.txtTimeout.TabIndex = 8;
      this.cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPort.FormattingEnabled = true;
      this.cmbPort.Location = new Point(58, 19);
      this.cmbPort.Name = "cmbPort";
      this.cmbPort.Size = new Size(97, 22);
      this.cmbPort.TabIndex = 0;
      this.Label2.AutoSize = true;
      this.Label2.Location = new Point(19, 23);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(36, 14);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "Port :";
      this.cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBaudRate.FormattingEnabled = true;
      this.cmbBaudRate.Items.AddRange(new object[8]
      {
        (object) "300",
        (object) "600",
        (object) "1200",
        (object) "2400",
        (object) "4800",
        (object) "9600",
        (object) "19200",
        (object) "115200"
      });
      this.cmbBaudRate.Location = new Point(235, 19);
      this.cmbBaudRate.Name = "cmbBaudRate";
      this.cmbBaudRate.Size = new Size(85, 22);
      this.cmbBaudRate.TabIndex = 0;
      this.Label1.AutoSize = true;
      this.Label1.Location = new Point(165, 23);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(67, 14);
      this.Label1.TabIndex = 6;
      this.Label1.Text = "Baud Rate :";
      this.grpGeneral.BackColor = Color.Transparent;
      this.grpGeneral.Controls.Add((Control) this.chkTxnLog);
      this.grpGeneral.Controls.Add((Control) this.chkWaitRes);
      this.grpGeneral.Controls.Add((Control) this.chkAPACS);
      this.grpGeneral.Controls.Add((Control) this.Label9);
      this.grpGeneral.Controls.Add((Control) this.Label13);
      this.grpGeneral.Controls.Add((Control) this.chkDelay);
      this.grpGeneral.Controls.Add((Control) this.chkTrace);
      this.grpGeneral.Controls.Add((Control) this.txtDelayTimeout);
      this.grpGeneral.Controls.Add((Control) this.Label7);
      this.grpGeneral.Controls.Add((Control) this.txtTxnTimeout);
      this.grpGeneral.Controls.Add((Control) this.Label4);
      this.grpGeneral.Controls.Add((Control) this.cmdTracePath);
      this.grpGeneral.Controls.Add((Control) this.Label11);
      this.grpGeneral.Controls.Add((Control) this.Label8);
      this.grpGeneral.Controls.Add((Control) this.txtTracePath);
      this.grpGeneral.Controls.Add((Control) this.txtUploadTimeout);
      this.grpGeneral.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grpGeneral.Location = new Point(17, 88);
      this.grpGeneral.Name = "grpGeneral";
      this.grpGeneral.Size = new Size(517, (int) sbyte.MaxValue);
      this.grpGeneral.TabIndex = 3;
      this.grpGeneral.TabStop = false;
      this.grpGeneral.Text = "General";
      this.chkTxnLog.AutoSize = true;
      this.chkTxnLog.Location = new Point(263, 93);
      this.chkTxnLog.Name = "chkTxnLog";
      this.chkTxnLog.Size = new Size(70, 18);
      this.chkTxnLog.TabIndex = 14;
      this.chkTxnLog.Text = "Txn Log";
      this.chkTxnLog.UseVisualStyleBackColor = true;
      this.chkWaitRes.AutoSize = true;
      this.chkWaitRes.Location = new Point(349, 93);
      this.chkWaitRes.Name = "chkWaitRes";
      this.chkWaitRes.Size = new Size(103, 18);
      this.chkWaitRes.TabIndex = 13;
      this.chkWaitRes.Text = "Wait Message";
      this.chkWaitRes.UseVisualStyleBackColor = true;
      this.chkAPACS.AutoSize = true;
      this.chkAPACS.Location = new Point(180, 93);
      this.chkAPACS.Name = "chkAPACS";
      this.chkAPACS.Size = new Size(73, 18);
      this.chkAPACS.TabIndex = 12;
      this.chkAPACS.Text = "Non DCC";
      this.chkAPACS.UseVisualStyleBackColor = true;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.Brown;
      this.Label9.Location = new Point(117, 97);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(49, 14);
      this.Label9.TabIndex = 10;
      this.Label9.Text = "seconds";
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.Brown;
      this.Label13.Location = new Point(153, 28);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(49, 14);
      this.Label13.TabIndex = 10;
      this.Label13.Text = "seconds";
      this.chkDelay.AutoSize = true;
      this.chkDelay.Location = new Point(18, 91);
      this.chkDelay.Name = "chkDelay";
      this.chkDelay.Size = new Size(61, 18);
      this.chkDelay.TabIndex = 11;
      this.chkDelay.Text = "Delay :";
      this.chkDelay.UseVisualStyleBackColor = true;
      this.chkTrace.AutoSize = true;
      this.chkTrace.Location = new Point(436, 22);
      this.chkTrace.Name = "chkTrace";
      this.chkTrace.Size = new Size(56, 18);
      this.chkTrace.TabIndex = 11;
      this.chkTrace.Text = "Trace";
      this.chkTrace.UseVisualStyleBackColor = true;
      this.txtDelayTimeout.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDelayTimeout.Location = new Point(82, 91);
      this.txtDelayTimeout.MaxLength = 2;
      this.txtDelayTimeout.Name = "txtDelayTimeout";
      this.txtDelayTimeout.Size = new Size(32, 20);
      this.txtDelayTimeout.TabIndex = 8;
      this.Label7.AutoSize = true;
      this.Label7.Location = new Point(14, 25);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(82, 14);
      this.Label7.TabIndex = 9;
      this.Label7.Text = "Txn Timeout :";
      this.txtTxnTimeout.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTxnTimeout.Location = new Point(99, 22);
      this.txtTxnTimeout.MaxLength = 5;
      this.txtTxnTimeout.Name = "txtTxnTimeout";
      this.txtTxnTimeout.Size = new Size(51, 20);
      this.txtTxnTimeout.TabIndex = 8;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Brown;
      this.Label4.Location = new Point(372, 28);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(49, 14);
      this.Label4.TabIndex = 7;
      this.Label4.Text = "seconds";
      this.cmdTracePath.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdTracePath.ForeColor = Color.Brown;
      this.cmdTracePath.Location = new Point(456, 54);
      this.cmdTracePath.Name = "cmdTracePath";
      this.cmdTracePath.Size = new Size(42, 22);
      this.cmdTracePath.TabIndex = 4;
      this.cmdTracePath.Text = "...";
      this.cmdTracePath.UseVisualStyleBackColor = true;
      this.Label11.AutoSize = true;
      this.Label11.Location = new Point(17, 57);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(70, 14);
      this.Label11.TabIndex = 9;
      this.Label11.Text = "Trace Path :";
      this.Label8.AutoSize = true;
      this.Label8.Location = new Point(217, 24);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(99, 14);
      this.Label8.TabIndex = 6;
      this.Label8.Text = "Upload Timeout :";
      this.txtTracePath.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTracePath.Location = new Point(91, 55);
      this.txtTracePath.MaxLength = 250;
      this.txtTracePath.Name = "txtTracePath";
      this.txtTracePath.Size = new Size(354, 20);
      this.txtTracePath.TabIndex = 3;
      this.txtUploadTimeout.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtUploadTimeout.Location = new Point(319, 22);
      this.txtUploadTimeout.MaxLength = 5;
      this.txtUploadTimeout.Name = "txtUploadTimeout";
      this.txtUploadTimeout.Size = new Size(51, 20);
      this.txtUploadTimeout.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 14f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(550, 279);
      this.Controls.Add((Control) this.grpGeneral);
      this.Controls.Add((Control) this.grpSettings);
      this.Controls.Add((Control) this.butClose);
      this.Controls.Add((Control) this.butSave);
      this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (frmDosetup);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "DLL Configuration";
      this.grpSettings.ResumeLayout(false);
      this.grpSettings.PerformLayout();
      this.grpGeneral.ResumeLayout(false);
      this.grpGeneral.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Button butSave
    {
      get => this._butSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.butSave_Click);
        Button butSave1 = this._butSave;
        if (butSave1 != null)
          butSave1.Click -= eventHandler;
        this._butSave = value;
        Button butSave2 = this._butSave;
        if (butSave2 == null)
          return;
        butSave2.Click += eventHandler;
      }
    }

    internal virtual Button butClose
    {
      get => this._butClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.butClose_Click);
        Button butClose1 = this._butClose;
        if (butClose1 != null)
          butClose1.Click -= eventHandler;
        this._butClose = value;
        Button butClose2 = this._butClose;
        if (butClose2 == null)
          return;
        butClose2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpSettings")]
    internal virtual GroupBox grpSettings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cmbBaudRate")]
    internal virtual ComboBox cmbBaudRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtTimeout
    {
      get => this._txtTimeout;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTimeout_KeyPress);
        TextBox txtTimeout1 = this._txtTimeout;
        if (txtTimeout1 != null)
          txtTimeout1.KeyPress -= pressEventHandler;
        this._txtTimeout = value;
        TextBox txtTimeout2 = this._txtTimeout;
        if (txtTimeout2 == null)
          return;
        txtTimeout2.KeyPress += pressEventHandler;
      }
    }

    [field: AccessedThroughProperty("cmbPort")]
    internal virtual ComboBox cmbPort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpGeneral")]
    internal virtual GroupBox grpGeneral { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdTracePath
    {
      get => this._cmdTracePath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdTracePath_Click);
        Button cmdTracePath1 = this._cmdTracePath;
        if (cmdTracePath1 != null)
          cmdTracePath1.Click -= eventHandler;
        this._cmdTracePath = value;
        Button cmdTracePath2 = this._cmdTracePath;
        if (cmdTracePath2 == null)
          return;
        cmdTracePath2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTracePath")]
    internal virtual TextBox txtTracePath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtUploadTimeout
    {
      get => this._txtUploadTimeout;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTimeout_KeyPress);
        TextBox txtUploadTimeout1 = this._txtUploadTimeout;
        if (txtUploadTimeout1 != null)
          txtUploadTimeout1.KeyPress -= pressEventHandler;
        this._txtUploadTimeout = value;
        TextBox txtUploadTimeout2 = this._txtUploadTimeout;
        if (txtUploadTimeout2 == null)
          return;
        txtUploadTimeout2.KeyPress += pressEventHandler;
      }
    }

    [field: AccessedThroughProperty("chkTrace")]
    internal virtual CheckBox chkTrace { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtTxnTimeout
    {
      get => this._txtTxnTimeout;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTimeout_KeyPress);
        TextBox txtTxnTimeout1 = this._txtTxnTimeout;
        if (txtTxnTimeout1 != null)
          txtTxnTimeout1.KeyPress -= pressEventHandler;
        this._txtTxnTimeout = value;
        TextBox txtTxnTimeout2 = this._txtTxnTimeout;
        if (txtTxnTimeout2 == null)
          return;
        txtTxnTimeout2.KeyPress += pressEventHandler;
      }
    }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDelayTimeout
    {
      get => this._txtDelayTimeout;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTimeout_KeyPress);
        TextBox txtDelayTimeout1 = this._txtDelayTimeout;
        if (txtDelayTimeout1 != null)
          txtDelayTimeout1.KeyPress -= pressEventHandler;
        this._txtDelayTimeout = value;
        TextBox txtDelayTimeout2 = this._txtDelayTimeout;
        if (txtDelayTimeout2 == null)
          return;
        txtDelayTimeout2.KeyPress += pressEventHandler;
      }
    }

    internal virtual CheckBox chkDelay
    {
      get => this._chkDelay;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkDelay_CheckedChanged);

        CheckBox chkDelay1 = this._chkDelay;

        if (chkDelay1 != null)
          chkDelay1.CheckedChanged -= eventHandler;

        this._chkDelay = value;
        CheckBox chkDelay2 = this._chkDelay;

        if (chkDelay2 == null)
          return;
        chkDelay2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chkAPACS")]
    internal virtual CheckBox chkAPACS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkWaitRes")]
    internal virtual CheckBox chkWaitRes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkTxnLog")]
    internal virtual CheckBox chkTxnLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void frmDosetup_Load(object sender, EventArgs e)
    {
      try
      {
        this.Settings = new comCMXECR().GetSettings();
        this.Findports();
        this.LoadSettings();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }

    private void LoadSettings()
    {
      try
      {
        this.txtTimeout.Text = Conversions.ToString((int) this.Settings.Timeout);
        this.txtTxnTimeout.Text = Conversions.ToString((int) this.Settings.TxnTimeout);
        this.txtTracePath.Text = this.Settings.TracePath;
        this.txtUploadTimeout.Text = Conversions.ToString((int) this.Settings.UploadTimeout);
        this.chkTrace.Checked = this.Settings.Trace;
        this.txtDelayTimeout.Text = Conversions.ToString((int) this.Settings.DelayTimeout);
        this.chkDelay.Checked = this.Settings.Delay;
        this.chkAPACS.Checked = this.Settings.flgAPACS;
        this.chkWaitRes.Checked = this.Settings.flgWaitRes;
        this.chkTxnLog.Checked = this.Settings.flgTxnLog;
        this.cmbPort.SelectedItem = (object) this.Settings.PortName;
        this.cmbBaudRate.SelectedItem = (object) this.Settings.BaudRate.ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }

    private void Findports()
    {
      try
      {
        string[] portNames = SerialPort.GetPortNames();
        Array.Sort<string>(portNames);
        string[] strArray = portNames;
        int index = 0;
        while (index < strArray.Length)
        {
          this.cmbPort.Items.Add((object) strArray[index]);
          checked { ++index; }
        }
        if (this.cmbPort.Items.Count <= 0)
          return;
        this.cmbPort.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void butSave_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.cmbPort.SelectedIndex < 0)
          this.cmbPort.SelectedIndex = 0;
        this.Settings.PortName = this.cmbPort.Text;
        if (this.cmbBaudRate.SelectedIndex < 0)
          this.cmbBaudRate.SelectedIndex = 0;
        this.Settings.BaudRate = Conversions.ToInteger(this.cmbBaudRate.Text);
        if (Operators.CompareString(this.txtTimeout.Text, "", false) == 0 | Conversion.Val(this.txtTimeout.Text) <= 0.0)
          this.txtTimeout.Text = Conversions.ToString(40);
        this.Settings.Timeout = checked ((short) Conversions.ToInteger(this.txtTimeout.Text));
        if (Operators.CompareString(this.txtTxnTimeout.Text, "", false) == 0 | Conversion.Val(this.txtTxnTimeout.Text) <= 0.0)
          this.txtTxnTimeout.Text = Conversions.ToString(120);
        this.Settings.TxnTimeout = checked ((short) Conversions.ToInteger(this.txtTxnTimeout.Text));
        if (Operators.CompareString(this.txtUploadTimeout.Text, "", false) == 0 | Conversion.Val(this.txtUploadTimeout.Text) <= 0.0)
          this.txtUploadTimeout.Text = Conversions.ToString(300);
        this.Settings.UploadTimeout = checked ((short) Conversions.ToInteger(this.txtUploadTimeout.Text));
        if (Operators.CompareString(this.txtTracePath.Text, "", false) == 0)
          this.txtTracePath.Text = Application.StartupPath;
        this.Settings.TracePath = this.txtTracePath.Text;
        this.Settings.Trace = this.chkTrace.Checked;
        this.Settings.Delay = this.chkDelay.Checked;
        if (Operators.CompareString(this.txtDelayTimeout.Text, "", false) == 0 | Conversion.Val(this.txtDelayTimeout.Text) < 0.0)
          this.txtDelayTimeout.Text = Conversions.ToString(5);
        this.Settings.DelayTimeout = checked ((short) Conversions.ToInteger(this.txtDelayTimeout.Text));
        this.Settings.flgAPACS = this.chkAPACS.Checked;
        this.Settings.flgWaitRes = this.chkWaitRes.Checked;
        this.Settings.flgTxnLog = this.chkTxnLog.Checked;
        new comCMXECR().SaveFile(this.Settings);
        int num = (int) MessageBox.Show("System Configuration Saved Successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.DialogResult = DialogResult.Yes;
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.DialogResult = DialogResult.No;
        ProjectData.ClearProjectError();
      }
    }

    private void butClose_Click(object sender, EventArgs e)
    {
      try
      {
        this.DialogResult = DialogResult.No;
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdTracePath_Click(object sender, EventArgs e)
    {
      try
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.SelectedPath = this.txtTracePath.Text;
        int num = (int) folderBrowserDialog.ShowDialog();
        this.txtTracePath.Text = folderBrowserDialog.SelectedPath;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int num1 = (int) MessageBox.Show(exception.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        int num2 = (int) MessageBox.Show(exception.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }

    private void txtTimeout_KeyPress(object sender, KeyPressEventArgs e)
    {
      try
      {
        if (!(!Versioned.IsNumeric((object) e.KeyChar) & Strings.Asc(e.KeyChar) != 8))
          return;
        e.Handled = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void chkDelay_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkDelay.Checked)
        this.txtDelayTimeout.Enabled = true;
      else
        this.txtDelayTimeout.Enabled = false;
    }
  }
}
