﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabContainer = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCrearCertificado = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.txtNombrePersona = New System.Windows.Forms.TextBox()
        Me.txtNombreArchivoCSR = New System.Windows.Forms.TextBox()
        Me.txtNombreArchivoClave = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDirectorioSalida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSeleccionDirectorioSalida = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tabContainer.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabContainer
        '
        Me.tabContainer.Controls.Add(Me.TabPage1)
        Me.tabContainer.Controls.Add(Me.TabPage2)
        Me.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabContainer.Location = New System.Drawing.Point(0, 0)
        Me.tabContainer.Name = "tabContainer"
        Me.tabContainer.SelectedIndex = 0
        Me.tabContainer.Size = New System.Drawing.Size(421, 572)
        Me.tabContainer.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCrearCertificado)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtCuit)
        Me.TabPage1.Controls.Add(Me.txtNombrePersona)
        Me.TabPage1.Controls.Add(Me.txtNombreArchivoCSR)
        Me.TabPage1.Controls.Add(Me.txtNombreArchivoClave)
        Me.TabPage1.Controls.Add(Me.txtNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtDirectorioSalida)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnSeleccionDirectorioSalida)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(413, 546)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCrearCertificado
        '
        Me.btnCrearCertificado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCertificado.Location = New System.Drawing.Point(222, 497)
        Me.btnCrearCertificado.Name = "btnCrearCertificado"
        Me.btnCrearCertificado.Size = New System.Drawing.Size(147, 31)
        Me.btnCrearCertificado.TabIndex = 7
        Me.btnCrearCertificado.Text = "Generar"
        Me.btnCrearCertificado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Datos del certificado (CSR)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(22, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(349, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "_________________________________________________________"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(24, 385)
        Me.txtCuit.MaxLength = 11
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(344, 20)
        Me.txtCuit.TabIndex = 5
        '
        'txtNombrePersona
        '
        Me.txtNombrePersona.Location = New System.Drawing.Point(26, 328)
        Me.txtNombrePersona.Name = "txtNombrePersona"
        Me.txtNombrePersona.Size = New System.Drawing.Size(344, 20)
        Me.txtNombrePersona.TabIndex = 4
        '
        'txtNombreArchivoCSR
        '
        Me.txtNombreArchivoCSR.Location = New System.Drawing.Point(25, 443)
        Me.txtNombreArchivoCSR.Name = "txtNombreArchivoCSR"
        Me.txtNombreArchivoCSR.Size = New System.Drawing.Size(344, 20)
        Me.txtNombreArchivoCSR.TabIndex = 6
        '
        'txtNombreArchivoClave
        '
        Me.txtNombreArchivoClave.Location = New System.Drawing.Point(25, 155)
        Me.txtNombreArchivoClave.Name = "txtNombreArchivoClave"
        Me.txtNombreArchivoClave.Size = New System.Drawing.Size(344, 20)
        Me.txtNombreArchivoClave.TabIndex = 2
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(26, 271)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(344, 20)
        Me.txtNombreEmpresa.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(303, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "CUIT de la empresa o programador (sin guiones)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nombre de archivo del certificado (CSR)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre persona o servidor *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre de archivo de la clave privada"
        '
        'txtDirectorioSalida
        '
        Me.txtDirectorioSalida.Location = New System.Drawing.Point(25, 96)
        Me.txtDirectorioSalida.Name = "txtDirectorioSalida"
        Me.txtDirectorioSalida.ReadOnly = True
        Me.txtDirectorioSalida.Size = New System.Drawing.Size(309, 20)
        Me.txtDirectorioSalida.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre de la empresa *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Carpeta de salida"
        '
        'btnSeleccionDirectorioSalida
        '
        Me.btnSeleccionDirectorioSalida.Location = New System.Drawing.Point(340, 95)
        Me.btnSeleccionDirectorioSalida.Name = "btnSeleccionDirectorioSalida"
        Me.btnSeleccionDirectorioSalida.Size = New System.Drawing.Size(30, 21)
        Me.btnSeleccionDirectorioSalida.TabIndex = 1
        Me.btnSeleccionDirectorioSalida.Text = "..."
        Me.btnSeleccionDirectorioSalida.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Generar certificado AFIP"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(413, 546)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Convertir"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Convertir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Convertir certificado AFIP"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(124, 519)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 31)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        Me.err.Icon = CType(resources.GetObject("err.Icon"), System.Drawing.Icon)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 572)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.tabContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "AfipCert     ⬢ Lógico"
        Me.tabContainer.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabContainer As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents txtDirectorioSalida As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSeleccionDirectorioSalida As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombrePersona As TextBox
    Friend WithEvents txtNombreArchivoCSR As TextBox
    Friend WithEvents txtNombreArchivoClave As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCrearCertificado As Button
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents err As ErrorProvider
End Class
