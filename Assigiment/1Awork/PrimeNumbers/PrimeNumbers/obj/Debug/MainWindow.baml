   M S B A M L   `   `   `  ����G  CPrimeNumbers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PrimeNumbersPrimeNumbers  5   	       PrimeNumbers.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PrimeNumbers     5   	     � Title$  Prime Numbers��5
   	   $	��450��6   $	��800��6,   .��5      � ��5   
   �� 5       �� ImageSource$ 1.jpg��6    j� Stretch$ UniformToFill=�6-    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��ShowPrimeNumbers��5   L      GlassButton#���   6   $��65,10,65,10q�67   $��25(�6x   ��5      �� 5      $
��Wrap=�6    �� TextAlignment$ Center=�60   " Show prime numbers from 1 to 1006i   5      �� 5    
   -   5        $��NumbersList��5    3   $��1��6   $��3��6"   $��60,20,60,20q�6F   .@�5!      �� 6   5"      �� 5$   
   -   5        $��HidePrimeNumbers��5$   Y   $��1��6   #���   6   $��65,10,65,10q�6D   .��6�   Hide all numbers6�   �� 5&   
   -   5        $��2��5&      #���   6   $��65,10,65,10q�6D   ��5'      �� 5(      $
��Wrap=�6   $ Center=�60   $	��230��6G   Check if the number is prime:6r   5*      �� 5+   
   -   5        $��	TheNumber��5+   4   $��3��6   $��65,20,65,20q�6   6H   �� 5,   
   -   5        $��	TheResult��5,   B   $��3��6   $��1��6   $��60,20,60,20q�6-   6U   5-      5.      