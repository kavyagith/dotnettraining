   M S B A M L   `   `   `  ����G  CColorPreview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ColorPreviewColorPreview  5   	       ColorPreview.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ColorPreview     5   	     � Title$  Color Preview��5   	   $	��450��6   $	��800��6,   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��5* �6    � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��10q�6   $��0��6    $��0��6-   $��2��6=   $��Color Preview��6Q   $
��Bold"�6f   $��40(�6x    �� TextAlignment$ Center=�6�   �� 5   
   $��
Color Name��6   $��0��6&   $��1��66   $��Center=�6C   $��20(�6^   $ Center=�6l   �� 5   
   -   5         ��Name$ colorTextBox��5   1   $��10,10,40,10q�6G   $��1��6\   $��1��6i   A� 5   
   $��1��6   $��2��6&   $��10q�63   .+�5      �� -   5         ��Name$ applyButton��5      $��Apply��6E   $��20(�6U   �� 5      -   5         ��Name$ checkbox��5      $	��Top=�6W   $��0,21,0,0q�6o   .��6�   Auto Preview6�   5      �� 5   
   -   5         ��Name$ previewBlock��5      $��Preview��6*   $��1��69   $��3��6I   $��40(�6V   $ Center=�6d   $��
20,0,40,20q�6{   5      5      