<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btn_tijeras = New Button()
        btn_papel = New Button()
        btn_piedra = New Button()
        lb_maquina = New Label()
        lb_racha = New Label()
        lb_puntajeActual = New Label()
        SuspendLayout()
        ' 
        ' btn_tijeras
        ' 
        btn_tijeras.BackColor = Color.Transparent
        btn_tijeras.BackgroundImage = My.Resources.Resources.tijeras
        btn_tijeras.BackgroundImageLayout = ImageLayout.Zoom
        btn_tijeras.Cursor = Cursors.Hand
        btn_tijeras.FlatStyle = FlatStyle.Flat
        btn_tijeras.Location = New Point(569, 194)
        btn_tijeras.Name = "btn_tijeras"
        btn_tijeras.Size = New Size(120, 120)
        btn_tijeras.TabIndex = 0
        btn_tijeras.UseVisualStyleBackColor = False
        ' 
        ' btn_papel
        ' 
        btn_papel.BackColor = Color.Transparent
        btn_papel.BackgroundImage = CType(resources.GetObject("btn_papel.BackgroundImage"), Image)
        btn_papel.BackgroundImageLayout = ImageLayout.Zoom
        btn_papel.Cursor = Cursors.Hand
        btn_papel.FlatStyle = FlatStyle.Flat
        btn_papel.Location = New Point(371, 194)
        btn_papel.Name = "btn_papel"
        btn_papel.Size = New Size(120, 120)
        btn_papel.TabIndex = 1
        btn_papel.UseVisualStyleBackColor = False
        ' 
        ' btn_piedra
        ' 
        btn_piedra.BackColor = Color.Transparent
        btn_piedra.BackgroundImage = My.Resources.Resources.piedra
        btn_piedra.BackgroundImageLayout = ImageLayout.Zoom
        btn_piedra.Cursor = Cursors.Hand
        btn_piedra.FlatStyle = FlatStyle.Flat
        btn_piedra.Location = New Point(143, 194)
        btn_piedra.Name = "btn_piedra"
        btn_piedra.Size = New Size(120, 120)
        btn_piedra.TabIndex = 2
        btn_piedra.UseVisualStyleBackColor = False
        ' 
        ' lb_maquina
        ' 
        lb_maquina.AutoSize = True
        lb_maquina.BackColor = Color.Transparent
        lb_maquina.Font = New Font("MS UI Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_maquina.Location = New Point(174, 60)
        lb_maquina.Name = "lb_maquina"
        lb_maquina.Size = New Size(480, 37)
        lb_maquina.TabIndex = 3
        lb_maquina.Text = "PIEDRA, PAPEL O TIJERAS"
        ' 
        ' lb_racha
        ' 
        lb_racha.AutoSize = True
        lb_racha.BackColor = Color.LightGray
        lb_racha.Font = New Font("MS UI Gothic", 27.75F, FontStyle.Bold)
        lb_racha.ForeColor = Color.Black
        lb_racha.Location = New Point(12, 404)
        lb_racha.Name = "lb_racha"
        lb_racha.Size = New Size(294, 37)
        lb_racha.TabIndex = 5
        lb_racha.Text = "Puntaje mas alto"
        ' 
        ' lb_puntajeActual
        ' 
        lb_puntajeActual.AutoSize = True
        lb_puntajeActual.BackColor = Color.LightGray
        lb_puntajeActual.Font = New Font("MS UI Gothic", 27.75F, FontStyle.Bold)
        lb_puntajeActual.ForeColor = Color.Black
        lb_puntajeActual.Location = New Point(12, 352)
        lb_puntajeActual.Name = "lb_puntajeActual"
        lb_puntajeActual.RightToLeft = RightToLeft.No
        lb_puntajeActual.Size = New Size(256, 37)
        lb_puntajeActual.TabIndex = 6
        lb_puntajeActual.Text = "Puntaje actual"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.wallpaper
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 450)
        Controls.Add(lb_puntajeActual)
        Controls.Add(lb_racha)
        Controls.Add(lb_maquina)
        Controls.Add(btn_piedra)
        Controls.Add(btn_papel)
        Controls.Add(btn_tijeras)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_tijeras As Button
    Friend WithEvents btn_papel As Button
    Friend WithEvents btn_piedra As Button
    Friend WithEvents lb_maquina As Label
    Friend WithEvents lb_racha As Label
    Friend WithEvents lb_puntajeActual As Label

End Class
