   M S B A M L   `   `   `  ����O  KWebAPI_Patron_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebAPI_Patron_ClientWebAPI_Patron_Client  5   	   /    )WebAPI_Patron_Client.SearchForBooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebAPI_Patron_Client     5   	     � Title$  SearchForBooksWindow��5      $	��607��6%   $
��1200��62   .��5	      � ���	#FF315659.+�5
   
   � $
��Left=�6   $	��561��6*   $	��Top=�67   $
��1194��6O    � RowDefinitions 5      �� 5      $
��106* �6    �� 5      $	��65* �6    �� 5      $
��338* �6    �� 5      $	��62* �6    .+�5      � $
��Left=�6   $	��110��6.   $	��Top=�6;   $
��1194��6S   $��2��6`    � ColumnDefinitions 5      �� 5      $
��600* �6'   �� 5      $
��600* �6'   .+�5      �� -   5         ��Name$ TitleTextBox��5   �   $��Center=�6   $��0,0,0,5q�67    �� TextWrapping$
 Wrap=�6H   $��Bottom=�6\   $��Lucida Console)�6w   $��36(�6�   $	��317��6�   ���#253031���#C6E0FF �� TextAlignment$ Center=�6�   .��6   � 	Resources 5       �� 
TargetType �� Property	 �� Value��%_   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$	 10��6=   5      5      .��6)   5      �� 5      -   5        $ AuthorTextBox��5   �   $��Center=�6   $��0,0,0,5q�67   $
 Wrap=�6H   $��Bottom=�6\   $��Lucida Console)�6w   $��36(�6�   $	��317��6�   $��1��6�   ���#253031���#C6E0FF$ Center=�6�   .��6   5      ��%_   '��       �� 5      " ��6    .�5       ��  �@��CornerRadius$	 10��6=   5!      5"      .��6)   5#      �� 5$      $��Title:��6   $��Center=�6)   $��0,0,0,20q�6F   $��Center=�6X   
������ ���#C6E0FF$��Lucida Console)�6�   $��24(�6�   �� 5%      $��Author:��6   $��Center=�6*   $��0,0,0,20q�6G   $��Center=�6Y   
������ ���#C6E0FF$��Lucida Console)�6�   $��24(�6�   $��1��6�   $	��108��6�   5&      �� 5'      -   5        
 ��Name$
 Search��5'      $��Search��6%   $��Center=�66   $��472,8,472,7q�6S   $��Center=�6h   $��Lucida Console)�6�   $��28(�6�   $	��250��6�   $��50��6�   ���	#FF253031���#C6E0FF J� RenderTransformOrigin$ 0.5,0.5&�6�   $��10q�6  $��1��6   5(      ��%_   '��       �� 5)      " ��6   .�5*      ��  �@��CornerRadius$	 30��69   5+      5,      5-      �� 5.      -   5         ��Name$ BookListBox��5.       �� SelectionMode$ Single=�6+   $
��Left=�6B   $	��339��6]   $��2��6j   $	��Top=�6w   $
��1194��6�   ���	#FF253031$��Lucida Console)�6�   $��24(�6�   ���	#FFC6E0FF$��2��6�   5/      51      52      