;#DropDB XafFileDataLoadingEasyTest

#Application XafFileDataLoadingWin
#Application XafFileDataLoadingWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef XafFileDataLoadingWin

*Action About...
 
*Action OK

#EndIf

#IfDef XafFileDataLoadingWeb
*Action Navigation(My Details)
#EndIf
