   M S B A M L   `   `   `  ����I  EVokabelTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VokabelTrainerVokabelTrainer  5   	   !    VokabelTrainer.Wordstrainer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:VokabelTrainer     5   	     � Title$  Wordstrainer��5   	   $	��300��6   $	��300��6+   .��5
      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��3* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� 
�������$��Stretch=�6j   $��Stretch=�6�   $��Center=�6�   $��2��6�   $��3��6�   ��6%   �� *TranslatedWord+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Stretch=�6[   $��Stretch=�6y   $��1��6�   $��Center=�6�   $��3��6�   ��6   �� *UntranslatedWord+$ PropertyChanged=�6�   �� 5   
   $��Stretch=�6[   $��Stretch=�6y   $��Center=�6�   $��3��6�   ��6   �� *TranslationFromTo+$ PropertyChanged=�6�   �� 5   
   $��Right=�6V   $��Stretch=�6r   $��5��6�   $��2��6�   ��6   �� *AmountOfWord+$ PropertyChanged=�6�   �� 5   
   $��Right=�6U   $��Stretch=�6q   $��5��6�   $��1��6�   ��6   �� *CurrentTime+$ PropertyChanged=�6�   �� 5   
   $
��Skip��68   
�������$��2q�6_   
���   �$��Stretch=�6�   $��Stretch=�6�   $��3��6�   $��0��6�   ��6   �� *Skip+ �� Mode$ OneWay=�6�   �� 5   
   $
��Show��67   
�������$��2q�6^   
���   �$��Stretch=�6�   $��Stretch=�6�   $��3��6�   $��1��6�   ��6   �� *Show+$ OneWay=�6�   �� 5    
   $��Check��68   
�������$��2q�6`   
���   �$��Stretch=�6�   $��Stretch=�6�   $��3��6�   $��2��6�   ��6   �� *Check+$ OneWay=�6�   �� 5!   
   $��Stretch=�6O   $��Stretch=�6m   $��1��6�   $��4��6�   ��6   �� *Image+$ PropertyChanged=�6�   �� 5"   
   $��Cancel Training��6�   
�������$��2q�6�   
���   �$��Stretch=�6�   $��Stretch=�6  $��5��6'  $��0��64  ��6   �� *Cancel+$ OneWay=���69   ��  �� RelativeSource ��  �� AncestorType" �64  5$      5%      