   M S B A M L   `   `   `  ����U  QBelajar_CRUD_WPF_Dionisius, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Belajar_CRUD_WPF_DionisiusBelajar_CRUD_WPF_Dionisius  5   	   ,    &Belajar_CRUD_WPF_Dionisius.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Belajar_CRUD_WPF_Dionisius     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � Title$  LoginWindow��5	   	   $	��500��6   $	��350��6*    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $E��?/Belajar_CRUD_WPF_Dionisius;component/Assets/#Bahnschrift Light)�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?�6%   �� 5      $u opack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Indigo.xaml?�6%   %    5      .��5      � -   5         �Name$ BG��5      .+�5   
   �� $	��250��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 #dcdcdc��6#   � 5      $
 #778899��6#    � Offset$	 0.5Q�63   � 5       $
 #778899��6#   $ 0.546Q�63   5!      5#      �� 5%   
   $	��280��6   $	��240��6    $��Center=�6-   $	��0,0q�6H    �� RadiusY$ 10��6U    �� RadiusX$ 10��6b   
������� J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'         
BlurRadius$ 20Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5)      � 5*   
   $��Bottom=�6   $��45,130q�6*   $	��240��6:   .+�5+      �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��0 0 0 0q�6Y   
�������$��Black"�6|   $��30(�6�   �� 5,      $��Center=�6   $��15q�64   .+�5-      �� -   5         ��Name$ emailTextBox��5-      $
��0,10q�60   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ email��6>    %  !MaterialDesignFloatingHintTextBox#��[  6e   $E��?/Belajar_CRUD_WPF_Dionisius;component/Assets/#Bahnschrift Light)�6�   $��18(�6�   G� 5.      -   5         G�Name$ passwordTextBox��5.      $
��0,10q�67   $ password��6E    ) %MaterialDesignFloatingHintPasswordBox#��[ 6o   $E��?/Belajar_CRUD_WPF_Dionisius;component/Assets/#Bahnschrift Light)�6�   $��18(�6�   5/      50      �� 51   
   -   5         ��Name$ 	login_btn��51      $	��150��52      $��Center=�6   $��Bottom=�66   $
��0,65q�6Q   $��LOGIN��6_   $
��Bold"�6o   
�������
������ 55      �� 56   
   -   5        $��Right=�56      $	��Top=�6-   $��50��6r   $��50��6}   ��6E   Z� ��6[   Z� .��57      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   $��30��63   $��30��6>   $��Center=�6J   $��Center=�6e   58      � 5:   
   $��Bottom=�6   $��Center=�6*   $��0 0 0 30q�6G    � ColumnDefinitions 5;      �� 5<      $��2* �6#   �� 5=      $��* �6#   .+�5?      �� -   5        $ 
forgot_btn��5?      $��0��5@      $��Center=�6!   $��Center=�6<   $��12(�6Y   $��25��6g   
���   ���6s   Z� ��6�   Z� .��6�   Forgot Password?6�   5A      �� 5B   
   -   5         ��Name$ RememberMeCheckBox��5B      $��Remember Me???��6/   
�������$��Oblique$�6Z   $
��Left=�6n   $	��Top=�6�   $��
60,330,0,0q�6�   5E      5F      