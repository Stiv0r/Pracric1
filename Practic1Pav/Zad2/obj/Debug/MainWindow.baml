   M S B A M L   `   `   `  ����?  ;Zad2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Practic1PavishinPractic1Pavishin  5   	       Practic1Pavishin.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Practic1Pavishin     5   	     � Title$  Window1��5   	   
��� ���$	��450��6-   $	��800��6:   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $;��5Координаты первой точки (x1, y1)��6   $��0��6;   $��0��6H   $��5q�6X   �� 5   
   -   5         ��Name$ 	x1TextBox��5      $�� ��6%   $��0��6-   $��1��6:   $��	5,5,326,5q�6J   �� 5   
   -   5        $ 	y1TextBox��5      $�� ��6%   $��1��6-   $��
275,5,56,5q�6=   �� 5   
   $;��5Координаты второй точки (x2, y2)��6   $��2��6;   $��0��6H   $��5q�6X   �� 5   
   -   5        $ 	x2TextBox��5      $�� ��6%   $��2��6-   $��
5,0,326,10q�6:   $��1��6N   �� 5   
   -   5        $ 	y2TextBox��5      $�� ��6%   $��2��6-   $��1��6:   $��275,0,56,10q�6J   �� 5   
   -   5        $%��Найти расстояние��5      $��3��6A   $��300,226,5,5q�6N   $��1��6c   �� 5   
   -   5         ��Name$ resultLabel��5      $��Ответ:��6%   $��3��66   $��10,10,5,178q�6C   $��1��6X   $��18(�6h   5      5      