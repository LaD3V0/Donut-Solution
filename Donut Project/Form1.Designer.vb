<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GBDonutChoices = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GBLabels = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBCoffeeChoices = New System.Windows.Forms.GroupBox()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radCapp = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.GBDonutChoices.SuspendLayout()
        Me.GBLabels.SuspendLayout()
        Me.GBCoffeeChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBDonutChoices
        '
        Me.GBDonutChoices.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GBDonutChoices.Controls.Add(Me.radFilled)
        Me.GBDonutChoices.Controls.Add(Me.radChocolate)
        Me.GBDonutChoices.Controls.Add(Me.radSugar)
        Me.GBDonutChoices.Controls.Add(Me.radGlazed)
        Me.GBDonutChoices.Location = New System.Drawing.Point(95, 72)
        Me.GBDonutChoices.Name = "GBDonutChoices"
        Me.GBDonutChoices.Size = New System.Drawing.Size(200, 131)
        Me.GBDonutChoices.TabIndex = 0
        Me.GBDonutChoices.TabStop = False
        Me.GBDonutChoices.Text = "Donut Choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(6, 100)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(103, 20)
        Me.radFilled.TabIndex = 7
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(6, 74)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(131, 20)
        Me.radChocolate.TabIndex = 6
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "&Chocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(6, 48)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(106, 20)
        Me.radSugar.TabIndex = 5
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(6, 21)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(113, 20)
        Me.radGlazed.TabIndex = 4
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnCalculate.Location = New System.Drawing.Point(427, 248)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 35)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnExit.Location = New System.Drawing.Point(427, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GBLabels
        '
        Me.GBLabels.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GBLabels.Controls.Add(Me.Label5)
        Me.GBLabels.Controls.Add(Me.Label6)
        Me.GBLabels.Controls.Add(Me.Label3)
        Me.GBLabels.Controls.Add(Me.Label4)
        Me.GBLabels.Controls.Add(Me.Label2)
        Me.GBLabels.Controls.Add(Me.Label1)
        Me.GBLabels.Location = New System.Drawing.Point(370, 72)
        Me.GBLabels.Name = "GBLabels"
        Me.GBLabels.Size = New System.Drawing.Size(200, 131)
        Me.GBLabels.TabIndex = 3
        Me.GBLabels.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(81, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Due:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(81, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sales Tax:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(81, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal:"
        '
        'GBCoffeeChoices
        '
        Me.GBCoffeeChoices.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GBCoffeeChoices.Controls.Add(Me.radRegular)
        Me.GBCoffeeChoices.Controls.Add(Me.radCapp)
        Me.GBCoffeeChoices.Controls.Add(Me.radNone)
        Me.GBCoffeeChoices.Location = New System.Drawing.Point(95, 248)
        Me.GBCoffeeChoices.Name = "GBCoffeeChoices"
        Me.GBCoffeeChoices.Size = New System.Drawing.Size(200, 131)
        Me.GBCoffeeChoices.TabIndex = 1
        Me.GBCoffeeChoices.TabStop = False
        Me.GBCoffeeChoices.Text = "Coffee Choices"
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(6, 48)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(118, 20)
        Me.radRegular.TabIndex = 9
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radCapp
        '
        Me.radCapp.AutoSize = True
        Me.radCapp.Location = New System.Drawing.Point(6, 74)
        Me.radCapp.Name = "radCapp"
        Me.radCapp.Size = New System.Drawing.Size(142, 20)
        Me.radCapp.TabIndex = 8
        Me.radCapp.TabStop = True
        Me.radCapp.Text = "Ca&ppuccino ($2.75)"
        Me.radCapp.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(6, 21)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(61, 20)
        Me.radNone.TabIndex = 7
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GBCoffeeChoices)
        Me.Controls.Add(Me.GBLabels)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GBDonutChoices)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.GBDonutChoices.ResumeLayout(False)
        Me.GBDonutChoices.PerformLayout()
        Me.GBLabels.ResumeLayout(False)
        Me.GBLabels.PerformLayout()
        Me.GBCoffeeChoices.ResumeLayout(False)
        Me.GBCoffeeChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBDonutChoices As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GBLabels As GroupBox
    Friend WithEvents GBCoffeeChoices As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radCapp As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
