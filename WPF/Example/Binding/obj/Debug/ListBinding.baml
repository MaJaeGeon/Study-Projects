   M S B A M L   `   `   `  ����B  >Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BindingBinding  5   	       Binding.ListBinding   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Binding     5   	     � Title$  ListBinding��5   	   $	��350��6   $	��350��6*    � 	Resources 5	         Binding.ProfileList   profileList   Binding.Profile   Name
   Age   Birth��%=  &	          5
   
     5      $ 	신형만��6   $ 10��6'   $ 
2000-05-17��60     5      $ 	신짱구��6   $ 12��6'   $ 
2001-06-18��60     5      $ 	신짱아��6   $ 14��6'   $ 
2002-07-19��60     5      $ 	봉미선��6   $ 15��6'   $ 
2003-08-20��60   5      5      .��5      ��  � DataContext# [  6   .+�5   
   �� $��Name :��6   6$   �� 5   
   ��6   �� *Name+6*   �� 5   
   $��Age :��6   6#   �� 5   
   ��6   �� *Age+6)   �� 5   
   $��Birth :��6   6%   �� 5   
   ��6   �� *Birth+ �� ConverterCulture$ ko-KR��6E   �� 5   
   -   5        $��Click��5   &   � 5   
    � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $��* �6#   .+�5$      �� -   5         ��Name$ btnPre��5$   %   $��0��6   $	��Pre��6J   $��10, 2q�6X   �� 5%      -   5        $ btnNext��5%   %   $��1��6   $
��Next��6L   $��10, 2q�6[   5&      �� 5(   
   	 �� DisplayMemberPath$
	 Name��6g   
 �� SelectedValuePath$	
 Age��6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    6   ��  �� Source# [  ��6O   ��  �� SelectedValue 6�   ��  �� Path$	 Age�5*      �� 5,   
   -   5        $��lb_Profiles��5,      $	��150��6%   $
 TrueY�6J   $
	 Name��6o   $

 Name��6�   ��62   �� 5.      5/      50      