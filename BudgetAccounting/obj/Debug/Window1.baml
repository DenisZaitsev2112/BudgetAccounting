   M S B A M L   `   `   `  ����  BudgetAccounting*    $BudgetTracker.CreateRecordTypeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Create New Record Type��5   	   $	��150��6(   $	��300��65    � 	Resources 5         PlaceholderTextBox �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name �� Triggers	 ]� 
Conditions
 �� Property �� Value �� 
TargetName��%^  &	        �� 5   
   " ��6+   .�5      ��  � �� 5      �� 5	      " ��6&   .R�5
      �� #��z��6!   #��z��6K   #��z��6w   ._�5      � .+�5   "   �� $ PART_ContentHost��6/   �� 5   "   $ PlaceholderText��6,   $$��Новый тип записи��6E   $y�	Collapsed=�6]   
�������$��5,0,0,0q�6�   $��Center=�6�   5      5       5      ]� 5      	 5   "   �� 5   &   
 �@J�	IsFocused .  6E   �� 5   &   
 � ��$  ��6@   ./�5   "   �� $ PlaceholderText��6)    � y�$ Visible=�6\   5      5      5      5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   .+�5'   
   �� -   5         ��Name$ newTypeTextBox��5'      $��0��6*   $��10q�67   #��[  6C   �� 5+   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5,      �� -   5        $��Сохранить��5,      $��80��6)   64   �� 5-      -   5        $��
Назад��5-      $��80��6%   60   5.      5/      50      