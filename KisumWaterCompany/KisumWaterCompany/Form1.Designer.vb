<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTop_Header = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAc_Type = New System.Windows.Forms.GroupBox()
        Me.rbtnUnMetered = New System.Windows.Forms.RadioButton()
        Me.rbtnMetered = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTo_Pay = New System.Windows.Forms.Button()
        Me.lbltest = New System.Windows.Forms.Label()
        Me.lstbData = New System.Windows.Forms.ListBox()
        Me.gbAc_Type.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTop_Header
        '
        Me.lblTop_Header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTop_Header.AutoSize = True
        Me.lblTop_Header.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop_Header.Location = New System.Drawing.Point(138, 11)
        Me.lblTop_Header.Name = "lblTop_Header"
        Me.lblTop_Header.Size = New System.Drawing.Size(279, 25)
        Me.lblTop_Header.TabIndex = 0
        Me.lblTop_Header.Text = "KISUMU WATER SYSTEMS"
        Me.lblTop_Header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digital & Secure Way to Pay Bills"
        '
        'gbAc_Type
        '
        Me.gbAc_Type.Controls.Add(Me.rbtnUnMetered)
        Me.gbAc_Type.Controls.Add(Me.rbtnMetered)
        Me.gbAc_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAc_Type.Location = New System.Drawing.Point(139, 81)
        Me.gbAc_Type.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbAc_Type.Name = "gbAc_Type"
        Me.gbAc_Type.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbAc_Type.Size = New System.Drawing.Size(284, 58)
        Me.gbAc_Type.TabIndex = 2
        Me.gbAc_Type.TabStop = False
        Me.gbAc_Type.Text = "Acount Type"
        '
        'rbtnUnMetered
        '
        Me.rbtnUnMetered.AutoSize = True
        Me.rbtnUnMetered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUnMetered.Location = New System.Drawing.Point(177, 23)
        Me.rbtnUnMetered.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtnUnMetered.Name = "rbtnUnMetered"
        Me.rbtnUnMetered.Size = New System.Drawing.Size(101, 19)
        Me.rbtnUnMetered.TabIndex = 1
        Me.rbtnUnMetered.TabStop = True
        Me.rbtnUnMetered.Text = "Un-Metered"
        Me.rbtnUnMetered.UseVisualStyleBackColor = True
        '
        'rbtnMetered
        '
        Me.rbtnMetered.AutoSize = True
        Me.rbtnMetered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMetered.Location = New System.Drawing.Point(5, 23)
        Me.rbtnMetered.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtnMetered.Name = "rbtnMetered"
        Me.rbtnMetered.Size = New System.Drawing.Size(70, 19)
        Me.rbtnMetered.TabIndex = 0
        Me.rbtnMetered.TabStop = True
        Me.rbtnMetered.Text = "Meterd"
        Me.rbtnMetered.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Number:"
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(257, 174)
        Me.txtIdNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(160, 21)
        Me.txtIdNumber.TabIndex = 4
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(155, 225)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(81, 15)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Units Used:"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(257, 223)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(160, 21)
        Me.txtUnits.TabIndex = 6
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(139, 409)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(257, 409)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(371, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTo_Pay
        '
        Me.btnTo_Pay.Location = New System.Drawing.Point(191, 463)
        Me.btnTo_Pay.Name = "btnTo_Pay"
        Me.btnTo_Pay.Size = New System.Drawing.Size(204, 26)
        Me.btnTo_Pay.TabIndex = 11
        Me.btnTo_Pay.Text = "Proced To Pay"
        Me.btnTo_Pay.UseVisualStyleBackColor = True
        '
        'lbltest
        '
        Me.lbltest.AutoSize = True
        Me.lbltest.Location = New System.Drawing.Point(470, 109)
        Me.lbltest.Name = "lbltest"
        Me.lbltest.Size = New System.Drawing.Size(0, 16)
        Me.lbltest.TabIndex = 12
        '
        'lstbData
        '
        Me.lstbData.FormattingEnabled = True
        Me.lstbData.ItemHeight = 16
        Me.lstbData.Items.AddRange(New Object() {"thfd"})
        Me.lstbData.Location = New System.Drawing.Point(158, 262)
        Me.lstbData.Name = "lstbData"
        Me.lstbData.Size = New System.Drawing.Size(259, 132)
        Me.lstbData.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 548)
        Me.Controls.Add(Me.lstbData)
        Me.Controls.Add(Me.lbltest)
        Me.Controls.Add(Me.btnTo_Pay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtIdNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbAc_Type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTop_Header)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.gbAc_Type.ResumeLayout(False)
        Me.gbAc_Type.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTop_Header As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbAc_Type As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnUnMetered As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMetered As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTo_Pay As System.Windows.Forms.Button
    Friend WithEvents lbltest As System.Windows.Forms.Label
    Friend WithEvents lstbData As System.Windows.Forms.ListBox

End Class
