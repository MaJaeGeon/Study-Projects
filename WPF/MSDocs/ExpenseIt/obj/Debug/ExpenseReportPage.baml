   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5      !    ExpenseIt.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ExpenseIt     5        N� Title$  ExpenseIt - View Expense��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��Center=�6    $��Trebuchet MS)�6;   $
��Bold"�6U   $��18(�6g   ���#0066cc   headerTextStyle#��[  6�   .��6�   Expense Report For:5      � 5   
   $��10q�6   $��1��6   $��1��6+    5      �� 5      �� 5       5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      .+�5%      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�5&      �� $��0,0,0,5q�6   $
��Bold"�6)     
labelStyle#��[ 6;   .��6_   Name:6f   �� 5'      $��0,0,0,5q�6   $
��Bold"�6)   #��[ 6;   ��6_   ��  �� XPath$ @Name��6�   5(      �� 5+      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5,      �� $��0,0,0,5q�6   $
��Bold"�6)   #��[ 6;   .��6_   Department:6l   �� 5-      $��0,0,0,5q�6   $
��Bold"�6)   #��[ 6;   ��6_   �� $ @Department��6�   5.      � 50      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�6\    � 	Resources 52        typeItemTemplate  amountItemTemplate��%�   &	       &	 I     �� 54      .R�55      �� ��6    �� $ @ExpenseType��56      �� 58      .R�59      �� ��6    �� $ @ExpenseAmount��5:      5;      .+�5>      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6A      AutoGenerateColumns .     RowHeaderWidth$ 0Q�6�   ��6   �� $ Expense��	   Columns	 5@      4  .System.Windows.Controls.DataGridTemplateColumn  5A      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ExpenseType��61      CellTemplate# [ 6F     5B      $
 Amount��61   # [ 6A   5E      5F      5G      5H      5I      