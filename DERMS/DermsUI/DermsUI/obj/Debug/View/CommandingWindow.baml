   M S B A M L   `   `   `  ����B  >DermsUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DermsUI.ViewDermsUI.View  5   	   1clr-namespace:dCom.ConvertersdCom.Converters  5      #    DermsUI.View.CommandingWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DermsUI.View     5   	   4
convertersclr-namespace:dCom.Converters     5        � Title$  CommandingWindow��5   	   $	��225��6"   $	��309��6/    � ShowInTaskbar .   � 
ResizeMode$ NoResize=�5	       � WindowStartupLocation$ CenterScreen=�5
       � 	Resources 5      4   .dCom.Converters.PointTypeToVisibilityConverter   PointTypeConverter��%   &	          5   
   64   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� $��Current Value��6   $	��304��6.   .��5      �� ��6   �� *Item.RawValue+5      5      �� 5   
   $ 
Horizontal=�6   $��0��6.   .+�5      �� $	��Gid��6   $	��303��6$   .��5      �� ��6   �� *
Item.Gid+5      5       �� 5!   
   $ 
Horizontal=�6   $��2��6.   $	��290��6;   y�6H   �� *Type+ �� 	Converter# [  .+�5"      �� $��14(�6   $��Commanded Value: ��6"   �� 5#      .��5$      �� $	��100��6   $	��100��6)   $��14(�68   $��Stretch=�5%   ?   ��5$   F   �� *CommandedValue+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=�
 �� ValidatesOnDataErrors
 .  �� ValidatesOnExceptions . .��5%   ]    =� ErrorTemplate 5&      �� 5'      .R�5(      �� $��3q�6%   
���  �� � ToolTip 6K   �� *[0].ErrorContent+._�5)   "   � .+�5*   &   �  � Points' �   �J]��  ����  ����� 
���  ��
���  ��6W   �� 5+   &    ��Name$ textBox��6@   5,   #   5-      5.      .��5/   0   50      51      52      �� 54   
   $��3��6   $��Write��6   $��	55,0,55,1q�6O   $��40��55   ]   $��Bottom=�6i   ��54   .   �� *WriteCommand+y�55      �� *Type+# [  6i   57      58      