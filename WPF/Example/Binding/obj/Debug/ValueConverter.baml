   M S B A M L   `   `   `  ����B  >Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BindingBinding  5   	       Binding.ValueConverter   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Binding     5   	     � Title$  ValueConverter��5   	   $	��350��6    $	��300��6-    � 	Resources 5	         Binding.AgeToBrush   aTb   Binding.HexConverter  HexConverter��%:   &	        &	        5
   
   6     5   
   6   5      .��5      �� .+�5   
   �� $��	One Way :��6   6'   �� 5   
   -   5         ��Name$ txtbox_Input��5      $��20��6(   64   �� 5   
   $��0 0 0 50q�6o   ��6   ��  �� ElementName$ txtbox_Input�� �� Path$
 Text� �� 	Converter# [  6�   �� 5   
   $��	Two Way :��6   6'   �� 5   
   -   5        $ txtbox_decimal��5      $��20��6*   66   �� 5   
   -   5        $ 
txtbox_hex��5      $��20��6&   62   5      5      