   M S B A M L   `   `   `  ����H  DSplitWisemvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SplitWisemvvmSplitWisemvvm  5   	   A%clr-namespace:SplitWisemvvm.ViewModelSplitWisemvvm.ViewModel  5   	       SplitWisemvvm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SplitWisemvvm     5   	   ;	viewmodel%clr-namespace:SplitWisemvvm.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      0   *SplitWisemvvm.ViewModel.SplitWiseViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � 
�������$��6q�6&    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     5      �� 5      $
��Auto �6#   �� 5      .+�5!      �� $��Name : ��6   $��0��6&   $��0��63   �� 5"      $��0��6   $��1��6#   $��5q�63   ��6>   �� *Name+�� 5#      $��Spent : ��6   $��1��6'   $��0��64   �� 5$      $��1��6   $��1��6#   $��5q�63   ��6?   �� *Spent+�� 5%      $��Share :��6   $��2��6&   $��0��63   �� 5&      $��2��6   $��1��6#   $��5q�63   ��6?   �� *Share+�� 5'      $��3��63   $��1��6@   $��Right=�6P   ��6   �� *	AddPerson+.��6l   
Add Person6x   �� 5(      $��4��63   $��1��6@   $��Right=�6P   ��6   �� *	Calculate+.��6l   Group Calculation6   �� 5)      $��5��63   $��1��6@   $��Right=�6P   ��6   �� *
NewGroup+.��6l   	New Group6w   �� 5*      $��6��61   $��1��6>   $��Right=�6N   ��6   �� *Remove+.��6j   Remove6r   5+      &   System.Windows.Controls.DataGrid  5,   
   $��0��6d   $��1��6q   ��6   ��  �� Path$ _person� �� SelectedItem 69   �� $ ItemSelected�6q   5-      5.      