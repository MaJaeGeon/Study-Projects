   M S B A M L   `   `   `  ����G  CDataTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DataTemplateDataTemplate  5   	       DataTemplate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DataTemplate     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��300��6)    � 	Resources 5	         DataTemplate.ProfileList   profileList   DataTemplate.Profile   Name
   Age   Birth��%=  &	          5
   
     5      $ 	신형만��6   $ 10��6'   $ 
2000-05-17��60     5      $ 	신짱구��6   $ 12��6'   $ 
2001-06-18��60     5      $ 	신짱아��6   $ 14��6'   $ 
2002-07-19��60     5      $ 	봉미선��6   $ 15��6'   $ 
2003-08-20��60   5      5      .��5      �� -   5         ��Name$ lb_profiles��5      #��[  6#   $��Stretch=�6N   ��5   
   �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5      �� $��0��6   $
��50px��6,   $����http://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg��6:   �� 5      $��1��6     �� TextAlignment$ Center=�6K   $��Center=�6b   $��Center=�6   ��60   ��  �� Path$
 Name�6   �� 5      -   5        $��2��5      $��Delete��6-   6>   5      5       5"      5#      