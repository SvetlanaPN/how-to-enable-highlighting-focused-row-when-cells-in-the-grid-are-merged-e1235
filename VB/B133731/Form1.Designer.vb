Imports Microsoft.VisualBasic
Imports System
Namespace B133731
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
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New B133731.CarsDBDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHP = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.carsTableAdapter = New B133731.CarsDBDataSetTableAdapters.CarsTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.carsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(774, 485)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colTrademark, Me.colModel, Me.colHP})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.AllowCellMerge = True
'			Me.gridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.gridView1_RowCellStyle);
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colTrademark
			' 
			Me.colTrademark.Caption = "Trademark"
			Me.colTrademark.FieldName = "Trademark"
			Me.colTrademark.Name = "colTrademark"
			Me.colTrademark.Visible = True
			Me.colTrademark.VisibleIndex = 1
			' 
			' colModel
			' 
			Me.colModel.Caption = "Model"
			Me.colModel.FieldName = "Model"
			Me.colModel.Name = "colModel"
			Me.colModel.Visible = True
			Me.colModel.VisibleIndex = 2
			' 
			' colHP
			' 
			Me.colHP.Caption = "HP"
			Me.colHP.FieldName = "HP"
			Me.colHP.Name = "colHP"
			Me.colHP.Visible = True
			Me.colHP.VisibleIndex = 3
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(774, 485)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private carsDBDataSet As CarsDBDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As B133731.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
		Private colModel As DevExpress.XtraGrid.Columns.GridColumn
		Private colHP As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

