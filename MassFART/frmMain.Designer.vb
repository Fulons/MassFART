﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoCtrlZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoCtrlYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameFiletypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaseCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameFiletypeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiletypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedFoldersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscardFiletypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreate = New MassFART.ccButton()
        Me.btnDelete = New MassFART.ccButton()
        Me.Button1 = New MassFART.ccButton()
        Me.fbdFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnRename = New MassFART.ccButton()
        Me.dgwFolders = New System.Windows.Forms.DataGridView()
        Me.FullPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderPic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New MassFART.ccButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteFiletype1 = New MassFART.DeleteFiletype()
        Me.ccFileExtensionEditor = New MassFART.FileExtensionEditor()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgwFolders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(868, 23)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator6, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoCtrlZToolStripMenuItem, Me.RedoCtrlYToolStripMenuItem, Me.ToolStripSeparator1, Me.RenameFiletypeToolStripMenuItem, Me.CopyCtrlVToolStripMenuItem, Me.PaseCtrlVToolStripMenuItem, Me.DelToolStripMenuItem, Me.ToolStripSeparator2, Me.FindToolStripMenuItem, Me.ToolStripSeparator3, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator4, Me.RenameFiletypeToolStripMenuItem1, Me.DiscardFiletypesToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 19)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoCtrlZToolStripMenuItem
        '
        Me.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem"
        Me.UndoCtrlZToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoCtrlZToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.UndoCtrlZToolStripMenuItem.Text = "Undo                  "
        '
        'RedoCtrlYToolStripMenuItem
        '
        Me.RedoCtrlYToolStripMenuItem.Name = "RedoCtrlYToolStripMenuItem"
        Me.RedoCtrlYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoCtrlYToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RedoCtrlYToolStripMenuItem.Text = "Redo                   "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'RenameFiletypeToolStripMenuItem
        '
        Me.RenameFiletypeToolStripMenuItem.Name = "RenameFiletypeToolStripMenuItem"
        Me.RenameFiletypeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RenameFiletypeToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RenameFiletypeToolStripMenuItem.Text = "Cut           "
        '
        'CopyCtrlVToolStripMenuItem
        '
        Me.CopyCtrlVToolStripMenuItem.Name = "CopyCtrlVToolStripMenuItem"
        Me.CopyCtrlVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyCtrlVToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CopyCtrlVToolStripMenuItem.Text = "Copy "
        '
        'PaseCtrlVToolStripMenuItem
        '
        Me.PaseCtrlVToolStripMenuItem.Name = "PaseCtrlVToolStripMenuItem"
        Me.PaseCtrlVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.PaseCtrlVToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PaseCtrlVToolStripMenuItem.Text = "Paste"
        '
        'DelToolStripMenuItem
        '
        Me.DelToolStripMenuItem.Name = "DelToolStripMenuItem"
        Me.DelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DelToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DelToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.FindToolStripMenuItem.Text = "Find..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(196, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(196, 6)
        '
        'RenameFiletypeToolStripMenuItem1
        '
        Me.RenameFiletypeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiletypeToolStripMenuItem})
        Me.RenameFiletypeToolStripMenuItem1.Name = "RenameFiletypeToolStripMenuItem1"
        Me.RenameFiletypeToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.RenameFiletypeToolStripMenuItem1.Text = "Advanced Rename"
        '
        'FiletypeToolStripMenuItem
        '
        Me.FiletypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentFolderToolStripMenuItem, Me.SelectedFoldersToolStripMenuItem})
        Me.FiletypeToolStripMenuItem.Name = "FiletypeToolStripMenuItem"
        Me.FiletypeToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.FiletypeToolStripMenuItem.Text = "Filetype"
        '
        'CurrentFolderToolStripMenuItem
        '
        Me.CurrentFolderToolStripMenuItem.Name = "CurrentFolderToolStripMenuItem"
        Me.CurrentFolderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CurrentFolderToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CurrentFolderToolStripMenuItem.Text = "Current Folder"
        '
        'SelectedFoldersToolStripMenuItem
        '
        Me.SelectedFoldersToolStripMenuItem.Name = "SelectedFoldersToolStripMenuItem"
        Me.SelectedFoldersToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.SelectedFoldersToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SelectedFoldersToolStripMenuItem.Text = "Selected Folders"
        '
        'DiscardFiletypesToolStripMenuItem
        '
        Me.DiscardFiletypesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.DiscardFiletypesToolStripMenuItem.Name = "DiscardFiletypesToolStripMenuItem"
        Me.DiscardFiletypesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.DiscardFiletypesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DiscardFiletypesToolStripMenuItem.Text = "Delete Filetype"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.ToolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 19)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(124, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnCreate.borderColor = System.Drawing.Color.Empty
        Me.btnCreate.disabledBackColor = System.Drawing.Color.Empty
        Me.btnCreate.disabledBorderColor = System.Drawing.Color.Empty
        Me.btnCreate.disabledForeColor = System.Drawing.Color.Empty
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.ForeColor = System.Drawing.Color.DarkGray
        Me.btnCreate.Location = New System.Drawing.Point(18, 72)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(105, 27)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Folder"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkGray
        Me.btnDelete.Location = New System.Drawing.Point(18, 115)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 27)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete Folder"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(18, 516)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Rename Parent Folder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.ForeColor = System.Drawing.Color.DarkGray
        Me.btnRename.Location = New System.Drawing.Point(18, 158)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(105, 27)
        Me.btnRename.TabIndex = 10
        Me.btnRename.Text = "Rename All"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'dgwFolders
        '
        Me.dgwFolders.AllowUserToAddRows = False
        Me.dgwFolders.AllowUserToDeleteRows = False
        Me.dgwFolders.AllowUserToResizeRows = False
        Me.dgwFolders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dgwFolders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwFolders.ColumnHeadersHeight = 26
        Me.dgwFolders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullPath, Me.FolderPic, Me.OldName, Me.NewName})
        Me.dgwFolders.Location = New System.Drawing.Point(141, 41)
        Me.dgwFolders.Name = "dgwFolders"
        Me.dgwFolders.Size = New System.Drawing.Size(397, 545)
        Me.dgwFolders.TabIndex = 0
        '
        'FullPath
        '
        Me.FullPath.HeaderText = ""
        Me.FullPath.Name = "FullPath"
        Me.FullPath.Visible = False
        '
        'FolderPic
        '
        Me.FolderPic.HeaderText = "O"
        Me.FolderPic.Name = "FolderPic"
        Me.FolderPic.Width = 20
        '
        'OldName
        '
        Me.OldName.HeaderText = "Old"
        Me.OldName.Name = "OldName"
        Me.OldName.ReadOnly = True
        '
        'NewName
        '
        Me.NewName.HeaderText = "New"
        Me.NewName.Name = "NewName"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(18, 559)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 27)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Save List as txt"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(549, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 30)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Controls"
        '
        'DeleteFiletype1
        '
        Me.DeleteFiletype1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DeleteFiletype1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteFiletype1.Location = New System.Drawing.Point(546, 261)
        Me.DeleteFiletype1.Name = "DeleteFiletype1"
        Me.DeleteFiletype1.Size = New System.Drawing.Size(313, 174)
        Me.DeleteFiletype1.TabIndex = 13
        '
        'ccFileExtensionEditor
        '
        Me.ccFileExtensionEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ccFileExtensionEditor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccFileExtensionEditor.Location = New System.Drawing.Point(546, 81)
        Me.ccFileExtensionEditor.Name = "ccFileExtensionEditor"
        Me.ccFileExtensionEditor.Size = New System.Drawing.Size(313, 174)
        Me.ccFileExtensionEditor.TabIndex = 12
        Me.ccFileExtensionEditor.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DeleteFiletype1)
        Me.Controls.Add(Me.ccFileExtensionEditor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgwFolders)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgwFolders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fbdFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents dgwFolders As DataGridView
    Friend WithEvents FullPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolderPic As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoCtrlZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoCtrlYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RenameFiletypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaseCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RenameFiletypeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FiletypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedFoldersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents DiscardFiletypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ccFileExtensionEditor As MassFART.FileExtensionEditor
    Friend WithEvents DeleteFiletype1 As DeleteFiletype
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnCreate As ccButton
End Class
