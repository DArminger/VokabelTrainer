   M S B A M L   `   `   `  ����I  EVokabelTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VokabelTrainerVokabelTrainer  5   	   )    #VokabelTrainer.CreateCategoryDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:VokabelTrainer     5   	     � Title$  CreateCategory��5   	   $	��150��6    $	��300��6-   .��5	      � $��15q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��lblTitel��5      $��1��6    .��60   New Category Name:6D   �� 5   
   -   5        $��txtNewCategory��5      $��1��6(   $��1��68   $	��250��6E   6V   � 5   
   $��2��6   $��2��6!   $��Right=�65   $��0,15,0,0q�6Q   .+�5      �� -   5        $��OkBtn��5       �� 	IsDefault . $��60��63   $��0,0,10,0q�6A   .��6g   _Ok6l   �� 5      -   5        $��	CancelBtn��5       �� IsCancel . $��60��66   .��6\   	_Cancel6e   5      5      5      