   M S B A M L   `   `   `  ����B  >Trigger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TriggerTrigger  5   	       Trigger.MultiDataTrigger   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Trigger     5   	     � Title$  MultiDataTrigger��5   	   $	��350��6"   $	��300��6/   .��5	      �� $��Center=�6   $��Center=�6.   .+�5
   
   �� -   5         ��Name$
 cb_1��5
      $��Agree1��6!   �� 5   
   -   5        $
 cb_2��5      $��Agree2��6!   �� 5   
   $��Center=�6   $��20(�6.   $
��Next��6<   $��10q�6K   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � {� �� Value .  62    �� Triggers 5      ^� 5       ^� 
Conditions 5      �� 5   "    �� Binding 6,   ��  �� ElementName$
 cb_1��	 �� Path$	 	IsChecked�
 �� Value
 True6a   �� 5   "    6,   �� $
 cb_2��$	 	IsChecked�
 True6a   .0�5      ��  � {� . 6:   5      5      5      5      5       