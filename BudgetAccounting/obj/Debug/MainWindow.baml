   M S B A M L   `   `   `  ����  BudgetAccounting    BudgetTracker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Budget Tracker��5   	   $	��400��6    $	��600��6-    � 	Resources 5         PlaceholderTextBox �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name �� Triggers	 ]� 
Conditions
 �� Property �� Value �� 
TargetName��%S  &	        �� 5   
   " ��6+   .�5      ��  � �� 5      �� 5	      " ��6&   .R�5
      �� #��z��6!   #��z��6K   #��z��6w   ._�5      � .+�5   "   �� $ PART_ContentHost��6/   �� 5   "   $ PlaceholderText��6,   $��Имя записи��6E   $y�	Collapsed=�6W   
�������$��5,0,0,0q�6�   $��Center=�6�   5      5       5      ]� 5      	 5   "   �� 5   &   
 �@J�	IsFocused .  6E   �� 5   &   
 � ��$  ��6@   ./�5   "   �� $ PlaceholderText��6)    � y�$ Visible=�6\   5      5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $��* �6   �� 5%      $
��Auto �6   .+�5)   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5*      (  "System.Windows.Controls.DatePicker  -   5          Name$ 
datePicker��5*      $��10q�6-   5+      �� 5.   
   -   5         ��Name$ recordTypesComboBox��5.      $��1��60   $��10q�6=   50      �� 53   
   $��2��6   $ 
Horizontal=�6"   $��10q�6;   .+�55      �� $��Имя записи:��6   $��Center=�6+   $��0,0,10,0q�6F   �� 56      -   5         ��Name$ entryNameTextBox��56      $	��150��60   #��[  6<   $��0,0,10,0q�6h   �� 57      -   5        $3��-Создать новый тип записи��57      68   58      �� 5;   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5<      �� -   5        $!��Создать запись��5<      $��0,0,10,0q�6.   6@   �� 5=      -   5        $#��Изменить запись��5=      $��0,0,10,0q�6/   6A   �� 5>      -   5        $!��Удалить запись��5>      6.   �� 5?      $��2��6   $ 
Horizontal=�6&   $��10q�6?   .+�5@      �� $��Money:��6   $��Center=�6*   $��0,0,10,0q�6E   �� 5A      -   5        $ moneyTextBox��5A      $	��150��60   $��0,0,10,0q�6<   5B      5C      �� 5H   
   -	   5         ��Name$ recordsListView��5H      $��4��6,   $��10q�69    �� View 5I      �� 5J      .P�5K      �� $��Запись��6%    �� Width$	 400��65    �� DisplayMemberBinding 6A   �� 5L      5N      �� 5O   
   $��5��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5P      �� $��
Итог: ��6   �� 5Q      -
   5        $ totalTextBlock��5Q      $��Center=�60   5R      5S      5T      