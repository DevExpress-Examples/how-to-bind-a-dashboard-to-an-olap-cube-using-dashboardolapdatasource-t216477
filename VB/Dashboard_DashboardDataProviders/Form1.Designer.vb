﻿Namespace Dashboard_OlapDataProvider
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.dashboardDesigner1 = New DevExpress.DashboardWin.DashboardDesigner()
            Me.SuspendLayout()
            ' 
            ' dashboardDesigner1
            ' 
            Me.dashboardDesigner1.CustomDBSchemaProvider = Nothing
            Me.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardDesigner1.Location = New System.Drawing.Point(0, 0)
            Me.dashboardDesigner1.Name = "dashboardDesigner1"
            Me.dashboardDesigner1.PrintingOptions.FontInfo.GdiCharSet = (CByte(0))
            Me.dashboardDesigner1.PrintingOptions.FontInfo.Name = Nothing
            Me.dashboardDesigner1.Size = New System.Drawing.Size(1236, 616)
            Me.dashboardDesigner1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1236, 616)
            Me.Controls.Add(Me.dashboardDesigner1)
            Me.Name = "Form1"
            Me.Text = "Dashboard Designer"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dashboardDesigner1 As DevExpress.DashboardWin.DashboardDesigner
    End Class
End Namespace

