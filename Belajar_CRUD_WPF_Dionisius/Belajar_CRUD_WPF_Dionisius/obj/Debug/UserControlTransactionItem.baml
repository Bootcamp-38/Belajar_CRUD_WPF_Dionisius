   M S B A M L   `   `   `  ����U  QBelajar_CRUD_WPF_Dionisius, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Belajar_CRUD_WPF_DionisiusBelajar_CRUD_WPF_Dionisius  5      ;    5Belajar_CRUD_WPF_Dionisius.UserControlTransactionItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Belajar_CRUD_WPF_Dionisius     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        � 	Resources  5
         dataGridTbl �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  chs1 �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  FocusVisual J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border 	 Button.Disabled.Background 
 Button.Disabled.Border  Button.Disabled.Foreground  RoundedButtonStyle �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%.  &	        &	 X     &	 �     &	 N    &	 q    &	 �    &	 �    &	 �    &	 �    &		      &	
 C    &	 f    &	 �    7  7  7  7 	 7 
 7  �� 5   
   "  6$   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�6;   5      �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5    
   $ 	#FF707070��67   �� 5!   
   $ 	#FFBEE6FD��6>   �� 5"   
   $ 	#FF3C7FB1��6:   �� 5#   
   $ 	#FFC4E5F6��6<   �� 5$   
   $ 	#FF2C628B��68   �� 5%   
   $ 	#FFF4F4F4��6=   �� 5&   
   $ 	#FFADB2B5��69   �� 5'   
   $ 	#FF838383��6=   �� 5(   
   " ��6+   .�5)      ��  �@�FocusVisualStyle8   61   �� 5*       � ��8  6+   �� 5+       � ��8  6,   �� 5,       � ��# � ��6+   �� 5-       � ��$ 0q�60   �� 5.       � ��$ Center=�6;   �� 5/       � ��$ Center=�69   �� 50       � ��$ 1q�6(   �� 51       � �� 52      �� 53      " ��6&   .R�54      �� $ border��6!   $	 5��61   #��z��6B   #��z��6n   #��z��6�    . $��	0,0,-29,0q�6�   ._�55      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  56       57      P� 58       �@��IsDefaulted . . �59   "   �� $ border��6@   # � ��6T    � ��5:      P� 5;       �@J�IsMouseOver . . �5<   "   �� $ border��6?    � �� �#3333336S   �� 5=   "   $ border��6@    � �� �#3333336T   5>      P� 5?       � �� . . �5@   "   �� $ border��6?    � �� �#5555556S   �� 5A   "   $ border��6@    � �� �#5555556T   5B      P� 5C       � {� .  . �5D   "   �� $ border��6?   8   � ��6S   �� 5E   "   $ border��6@   8   � ��6T   �� 5F   "   $ contentPresenter��6K   8   � ��6i   5G      5I      5K      5L      5M      .��5O      � $��Center=�5P   	   $	��380��5Q   	   $��	10 0 10 0q�5R   	    � ColumnDefinitions 5T   
   �� 5U      $��* �6   �� 5V      $��* �6   .+�5Y   
   �� $��Center=�5Z      $��0��5[      .+�5]      � $��	80 0 10 0q�6    5^      �� 5_      $��* �6'   �� 5`      $��4* �6'   .+�5c      �� $��0 0 10 0q�6   $��0��6.   $��ID��6>    �� TextAlignment$
 Left=�6H   $
��Bold"�6]   �� 5d      -   5         ��Name$ 	textBoxId��5d   <   $��0 0 10 0q�6   $��1��6,   ���#eee6O   5e      � 5g      $��
80 30 10 0q�6    5h      �� 5i      $��* �6'   �� 5j      $��4* �6'   .+�5m      �� $��0 0 10 0q�6   $��0��6.   $��Quantity��6>   $
 Left=�6N   $
��Bold"�6c   �� 5n      -   5        $ textBoxQuantity��5p   %   $��0 0 10 0q�5o      $��1��5p      ���#eee6>   5q      � 5s      $��
80 20 10 0q�6    5t      �� 5u      $��* �6'   �� 5v      $��4* �6'   .+�5y      �� $��0 0 10 0q�6   $��0��6.   $��Item Id��6>   $
 Left=�6M   $
��Bold"�6b   �� 5{      -   5         ��Name$ comboBoxItemId��5{   =   $��0 0 10 0q�6   $��1��6-   ���#eee �� DisplayMemberPath$
 Name��6�    �� SelectedValuePath$ Id��6�   ��6g   �� *Item+6�   5|      � 5~      $��
80 20 10 0q�6    5      �� 5�      $��* �6'   �� 5�      $��4* �6'   .+�5�      �� $��0 0 10 0q�6   $��0��6.   $��Trans.��6>   $
 Left=�6L   $
��Bold"�6a   �� 5�      -   5        $ comboBoxTransactionId��5�   >   $��	1,0,9,0.4q�6   $��1��6.   ���#eee$ 	OrderDate��6�   $ Id��6�    �� ItemStringFormat$ 
dd/MM/yyyy��6�   ��6o   �� *Transaction+6  5�      � 5�      $��62,40,7.6,20q�6    5�      �� 5�      $��* �6'   �� 5�      $��* �6'   .+�5�      �� -   5         ��Name$ 	btn_input��5�      $��0��6E   $��50��6U   $��50��6`   $��Center=�6l   ��6�   Z� ��6�   Z� .��5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Input=�6.   $��50��6;   $��50��6F    � ToolTip 5�      _� 5�      .��6"   
Input Data5�      5�      �� 5�      -   5        $ 
btn_update��5�      $��1��6G   $��50��6W   $��50��6b   $��Center=�6n   ��6�   Z� ��6�   Z� .��5�        $ Update=�6.   $��50��6<   $��50��6G    5�      _� 5�      .��6"   Update Data5�      5�      5�      5�        5�   
   -   5          Name$ TableTi��5�         
IsReadOnly .    AutoGenerateColumns .  $��1��5�      ���#EEE   AlternatingRowBackground
 �����
�������$��3q�5�      $	��Top=�5�         	RowHeight$ 20Q�5�         GridLinesVisibility$ 
Horizontal=�5�      #���   5�      $��Center=�5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn    Header$  Id��6%   !   Width5  /System.Windows.Controls.DataGridLengthConverter$! * 6H   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 61   �� *Id+#   ElementStyle# 5�      �� 5�      " ��6    .�5�      ��  � ��$ Center=�6D   �� 5�       � ��$ Center=�6B   5�      5�        5�      $  Quantity��6%   $! * 6R   " 67   �� *Number+# 5�      �� 5�      " ��6    .�5�      ��  � ��$ Center=�6D   �� 5�       � ��$ Center=�6B   5�      5�        5�      $
  Item��6%   $! * 6Q   " 63   �� *	Item.Name+# 5�      �� 5�      " ��6    .�5�      ��  � ��$ Center=�6D   �� 5�       � ��$ Center=�6B   5�      5�        5�      $  Transaction��6%   $! * 6�   " 6:   �� *Transaction.OrderDate+$ �� StringFormat$$ {0:dd/MM/yyyy}��# 5�      �� 5�      " ��6    .�5�      ��  � ��$ Center=�6D   �� 5�       � ��$ Center=�6B   5�      5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $  Delete��6)   $! * 69   %   CellTemplate% 5�      �� 5�      .R�5�      �� -   5        .��5�   "     $ Delete=�6:    5�   "   _� 5�   &   .��6.   Delete Data5�   '   5�      5�      5�      5�      �� 5�   
   -	   5        $ refresh_btn��5�      $��1��5�      $
��Left=�6   $��335.4,-28,-20,0q�68   $	��Top=�6Q   $��75��6i   ��5�      Z� ��6#   Z� .��5�        $ Refresh=�6&   $��20��65   $��20��6@   & J� RenderTransformOrigin$& 1.413,-0.72&�6L   5�      5�      5�      