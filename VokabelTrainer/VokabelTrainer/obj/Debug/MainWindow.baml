   M S B A M L   `   `   `  ����I  EVokabelTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:VokabelTrainer.ViewModelsVokabelTrainer.ViewModels  5   	       VokabelTrainer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >
viewModels'clr-namespace:VokabelTrainer.ViewModels     5   	   -   5          � Title$  Vocabtrainer��5   	   $	��430��6   $	��525��6+    � DataContext 5	      -   'VokabelTrainer.ViewModels.MainViewModel  5
   
   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��8* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��9* �6   6,   �� 5      $
��233* �6   �� 5      $	��34* �6   6-   �� 5      $
��242* �6   6.   .+�5   
   �� $��Stretch=�6   $	��Top=�60   $��0��6H   $��3��6X   $��3��6e   $��0,0,34,0q�5       $	��208��6q   ��6$   �� *
Categories+ �� SelectedItem 6G   �� *SelectedCategory+6q   o� 5"   
   $��Stretch=�6   $	��Top=�6/   $��0��6G   $��4��6T   $��	0,0,0.4,0q�6h   .@�5#      m� $
��Menu��6   .@�5$      m� $��Import Words��6    m� Command 61   �� *ImportCategory+ �� Mode$ OneWay=�m� 5%      $��Create new category��6    68   �� *CreateCategory+$ OneWay=�m� 5&      -   5        $��ExitItem��5&   )   $
��Exit��6   69   5'      5(      �� 5)   
   $��Italic$�6   $��30��6&   $��Stretch=�65   $��0��6S   
�������$��1��6v   $	��Top=�6�   $	��Top=�6�   $��2��6�   $��0,0.4,69.6,0q�6�   $��22��6   ��6�   �� *
SearchText+6   &   System.Windows.Controls.DataGrid  5*   
   
�������$��Stretch=�6&   $	��Top=�6D   $��3��6\   $��1��6l   $��0,0.4,0.4,0q�6y      AutoGenerateColumns .  $	��262��6�   $��3��6�   ��6�   �� *Words+   Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn	   Header$	 English��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *	Word_en+  5-      $	 German��6%   
 65   �� *	Word_ge+5/      �� 50   
   $��4��6   $��1��6    $��Timemode in seconds��60   $��Center=�6N    d� 	IsChecked 6i   �� *UseTimemode+6�   �� 51   
   $��5��63   $��1��6e   {�6   �� *UseTimemode+ � Value 6@   �� *CurrentSliderValue+ � Minimum 6u   �� *	SliderMin+ � Maximum 6�   �� *	SliderMax+6�   �� 52   
   $��
Start Test��69   
�������$��2q�6f   
���   �$��Stretch=�6�   $��3��6�   $��Stretch=�6�   $��7��6�   $��0,0.4,0.4,-0.2q�6�   ��6   �� *Start+$ OneWay=�6�   �� 53   
   $��Export selected category��6B   
�������$��2q�6}   
���   �$��Stretch=�6�   $��1��6�   $��Stretch=�6�   $��7��6�   $��0,0.4,0.4,-0.2q�6�   ��6   �� *ExportCategory+$ OneWay=�6�   �� 54   
   $
��Bold"�6   $��Categories:��6#   $��Stretch=�69   $��Stretch=�6W   $��0��6s   $��2��6�   $��3��6�   $��
0,0.2,34,0q�6�   �� 55   
   $��10(�6.   $��203.2,0.4,0.6,0.2q�6<   $��6��6W   $��1��6d   ��6   �� *	SliderMax+6d   �� 56   
   $��10(�6.   $��0.2,0.4,203.6,0.2q�6<   $��6��6W   $��1��6d   ��6   �� *	SliderMin+6d   �� 57   
   $��10(�67   $��101.2,1.4,102.6,20.8q�6E   $��6��6c   $��1��6p   $��2��6�   ��6   �� *CurrentSliderValue+6�   �� 58   
   $��2��6A   $��Suchen��6U   $��1��6f   $
��Left=�6v   $��22��6�   $��168.2,0.4,0,0q�6�   $��1��6�   $	��Top=�6�   $��65��6�   ��6   �� *SearchCategory+$ OneWay=�6�   �� 59   
   $��Add new word��6   $
��Left=�6(   $��	0,0.2,0,0q�6C   $	��Top=�6V   $	��113��6n   $��3��6|   $��4��6�   $��26��6�   ��6�   �� *	AddWord+$ OneWay=��� 5:   
   $��English - German��6   $��3��6.   $
��Left=�6>   $��17��6Y   $��0,10,0,0q�6e   $��5��6w   $	��Top=�6�   $	��125��6�    6�   �� *Mode+5<      5=      