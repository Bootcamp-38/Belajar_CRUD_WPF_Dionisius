   M S B A M L   `   `   `  ����U  QBelajar_CRUD_WPF_Dionisius, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Belajar_CRUD_WPF_DionisiusBelajar_CRUD_WPF_Dionisius  5      7    1Belajar_CRUD_WPF_Dionisius.UserControlTransaction   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Belajar_CRUD_WPF_Dionisius     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        � 	Resources  5         dataGridTbl �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  chs1 �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  FocusVisual J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border 	 Button.Disabled.Background 
 Button.Disabled.Border  Button.Disabled.Foreground  RoundedButtonStyle �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%.  &	        &	 X     &	 �     &	 N    &	 q    &	 �    &	 �    &	 �    &	 �    &		      &	
 C    &	 f    &	 �    7  7  7  7 	 7 
 7  �� 5   
   "  6$   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�6;   5      �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5    
   $ 	#FFDDDDDD��6;   �� 5!   
   $ 	#FF707070��67   �� 5"   
   $ 	#FFBEE6FD��6>   �� 5#   
   $ 	#FF3C7FB1��6:   �� 5$   
   $ 	#FFC4E5F6��6<   �� 5%   
   $ 	#FF2C628B��68   �� 5&   
   $ 	#FFF4F4F4��6=   �� 5'   
   $ 	#FFADB2B5��69   �� 5(   
   $ 	#FF838383��6=   �� 5)   
   " ��6+   .�5*      ��  �@�FocusVisualStyle8   61   �� 5+       � ��8  6+   �� 5,       � ��8  6,   �� 5-       � ��# � ��6+   �� 5.       � ��$ 0q�60   �� 5/       � ��$ Center=�6;   �� 50       � ��$ Center=�69   �� 51       � ��$ 1q�6(   �� 52       � �� 53      �� 54      " ��6&   .R�55      �� $ border��6!   $	 5��61   #��z��6B   #��z��6n   #��z��6�    . $��	0,0,-29,0q�6�   ._�56      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  57       58      P� 59       �@��IsDefaulted . . �5:   "   �� $ border��6@   # � ��6T    � ��5;      P� 5<       �@J�IsMouseOver . . �5=   "   �� $ border��6?    � �� �#3333336S   �� 5>   "   $ border��6@    � �� �#3333336T   5?      P� 5@       � �� . . �5A   "   �� $ border��6?    � �� �#5555556S   �� 5B   "   $ border��6@    � �� �#5555556T   5C      P� 5D       � {� .  . �5E   "   �� $ border��6?   8   � ��6S   �� 5F   "   $ border��6@   8   � ��6T   �� 5G   "   $ contentPresenter��6K   8   � ��6i   5H      5J      5L      5M      5N      .��5P      � $��Center=�5Q   	   $	��380��5R   	   $��	10 0 10 0q�5S   	    � ColumnDefinitions 5U   
   �� 5V      $��* �6   �� 5W      $��* �6   .+�5Z   
   �� $��Center=�5[      $��0��5\      .+�5^      � $��	80 0 10 0q�6    5_      �� 5`      $��* �6'   �� 5a      $��4* �6'   .+�5d      �� $��0 0 10 0q�6   $��0��6.   $��ID��6>    �� TextAlignment$
 Left=�6H   $
��Bold"�6]   �� 5e      -   5         ��Name$ 	textBoxId��5e   <   $��0 0 10 0q�6   $��1��6,   ���#eee6O   5f      � 5h      $��
80 30 10 0q�6    5i      �� 5j      $��* �6'   �� 5k      $��4* �6'   .+�5n      �� $��0 0 10 0q�6   $��0��6.   $
��Date��6>   $
 Left=�6J   $
��Bold"�6_   $��Center=�6q   (  "System.Windows.Controls.DatePicker  5o      -   5          Name$ textBoxDate��5o   ?   $��0 0 10 0q�6   $��1��6/   ���#eee6T   5p      � 5s      $��62,40,7.6,20q�6    5t      �� 5u      $��* �6'   �� 5v      $��* �6'   .+�5y      �� -   5         ��Name$ 	btn_input��5y      $��0��6E   $��50��6U   $��50��6`   $��Center=�6l   ��6�   Z� ��6�   Z� .��5z      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Input=�6.   $��50��6;   $��50��6F    � ToolTip 5|      _� 5}      .��6"   
Input Data5      5�      �� 5�      -   5        $ 
btn_update��5�      $��1��6G   $��50��6W   $��50��6b   $��Center=�6n   ��6�   Z� ��6�   Z� .��5�        $ Update=�6.   $��50��6<   $��50��6G    5�      _� 5�      .��6"   Update Data5�      5�      5�      5�        5�   
   -   5          Name$ TableTransaction��5�         
IsReadOnly .    AutoGenerateColumns .  $��1��5�      ���#EEE   AlternatingRowBackground
 �����
�������$��3q�5�      $	��Top=�5�         	RowHeight$ 20Q�5�         GridLinesVisibility$ 
Horizontal=�5�      #���   5�      $��Center=�5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+    ElementStyle  5�      �� 5�      " ��6    .�5�      ��  � ��$ Center=�6D   �� 5�       � ��$ Center=�6B   5�      5�        5�      $ 
Order Date��6%   $ 3* 6v    69   �� *	OrderDate+! �� StringFormat$! {0:dd/MM/yyyy}��  5�      �� 5�      " ��6    .�5�      ��  � ��$ Center=�6D   �� 5�       � ��$ Center=�6B   5�      5�      4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      $ Delete��6)   $ * 69   " 	  CellTemplate" 5�      �� 5�      .R�5�      �� -   5        .��5�   "     $ Delete=�6:    5�   "   _� 5�   &   .��6.   Delete Data5�   '   5�      5�      5�      5�      �� 5�   
   -   5        $ refresh_btn��5�      $��1��5�      $
��Left=�6   $��335.4,-28,-20,0q�68   $	��Top=�6Q   $��75��6i   ��5�      Z� ��6#   Z� .��5�        $ Refresh=�6&   $��20��65   $��20��6@   # J� RenderTransformOrigin$# 1.413,-0.72&�6L   5�      5�      5�      