   M S B A M L   `   `   `  ����H  DIntCalcu-Grid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:IntCalcu_GridIntCalcu_Grid  5   	       IntCalcu_Grid.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:IntCalcu_Grid     5   	     � Title$  Interest Calculator��5   	   $	��650��6%   $	��800��62   .��5	      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��5* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $
��1.5* �6   �� 5      $
��1.5* �6   �� 5      $��1* �6   .+�5   
   �� $��Interest Calulator��6   $��Center=�6.    �� TextAlignment$ Center=�6I   $��30(�6`   $
��Bold"�6n   $��2��6�   �� 5   
   $��Pricipal Amount��6   $��1��6*   $��0��67   $��20(�6G   $��Center=�6U   �� 5   
   -   5         ��Name$ principalTextBox��5      $��1��6,   $��1��69   $��5q�6I   �� 5   
   $��	Rate (pa)��6   $��2��6$   $��0��61   $��20(�6A   $��Center=�6O   �� 5   
   -   5        $ rateTextBox��5      $��2��6'   $��1��64   $��5q�6D   �� 5    
   $��Period (month)��6   $��3��6)   $��0��66   $��20(�6F   $��Center=�6T   �� 5!   
   -   5        $ periodTextBox��5!      $��3��6)   $��1��66   $��5q�6F   �� 5"   
   -   5        $��4��5"      $��1��6   $��2��6.   $��	Calculate��6B   $��20(�6V   $
��Bold"�6d   
�������$��5q�6�   6�   �� 5#   
   $��Interest��6   $��5��6#   $��0��60   $��20(�6@   $��Center=�6N   �� 5$   
   -   5         ��Name$ interestTextBox��5$   "   $��30(�6   $��5��6;   $��1��6H   �� 5%   
   $��Amount��6   $��6��6!   $��0��6.   $��20(�6>   $��Center=�6L   �� 5&   
   -   5        $ amountTextBox��5&   5   $��30(�6   $��Heavy"�6"   $��6��6L   $��1��6Y   �� 5'   
   -   5         ��Name$ 	statusBar��5'      $��7��6#   $��0��60   $��2��6@   $��20(�6T   $��Center=�6b   
����d�6}   5(      5)      