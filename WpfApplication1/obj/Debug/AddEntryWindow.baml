   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	   $    WpfApplication1.AddEntryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  AddEntryWindow��5   	   $	��180��6    $	��300��6-   .��5	      � $��5q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��Name:��6/   �� 5   
   $��Center=�6   $
��Age:��6/   $��1��6;   �� 5   
   $��Center=�6   $��Address:��6/   $��2��6?   �� 5   
   -   5         ��Name$ EntryNameTbx��5      $��1��6C   $��5q�6S   ��6(   ��  �� Path$
 Name�6S   �� 5   
   -   5        $ EntryAgeTbx��5      $��1��6A   $��5q�6Q   $��1��6\   ��6'   �� $	 Age�6\   �� 5   
   -   5        $ EntryAddressTbx��5      $��1��6I   $��5q�6Y   $��2��6d   ��6+   �� $ Address�6d   �� 5   
   $��Bottom=�6   $��7��60   $��2��6=    �� Orientation$ 
Horizontal=�6Q   $��Center=�6j   .+�5      �� -   5        $	��Add��5   +   $��5q�69   $	��100��6D   �� 5      -   5        $��Cancel��5   -   $��5q�6>   $	��100��6I   5       5!      5"      