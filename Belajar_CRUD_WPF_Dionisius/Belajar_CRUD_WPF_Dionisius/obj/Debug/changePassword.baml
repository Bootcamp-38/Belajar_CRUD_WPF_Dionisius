   M S B A M L   `   `   `  ����U  QBelajar_CRUD_WPF_Dionisius, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Belajar_CRUD_WPF_DionisiusBelajar_CRUD_WPF_Dionisius  5   	   /    )Belajar_CRUD_WPF_Dionisius.changePassword   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   :local(clr-namespace:Belajar_CRUD_WPF_Dionisius     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   $	��450��6   $	��450��6(   .��5      � ���	#FFF9F9F8.+�5   
   �� $	��350��6   $	��250��6    $��Center=�6-   $	��0,0q�6H    �� RadiusY$ 10��6U    �� RadiusX$ 10��6b   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A   	   ShadowDepth$	 1Q�6Y   
   Color$
 	#FFBBBBBB��6i   5      � 5   
   $��Center=�6   $��Center=�6*   $��0 0 0 0q�6G   $	��300��6X   $	��300��6d    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    .+�5"      �� $��0��6   $��Change Password��6%   
���   �$��25(�6O   $E��?/Belajar_CRUD_WPF_Dionisius;component/Assets/#Bahnschrift Light)�6]   $	��Top=�6�   �� 5#      $��1��6   $��USERNAME��6%   
�������65   �� 5$      -   5         ��Name$ textBoxEmail��5$      $��2��6,   
�������
���   �$��20��6d   $��0 0 0 1q�6p   �� 5%      $��3��6   $��TOKEN��6%   
�������62   G� 5&      -   5         G�Name$ textBoxToken��5&      $��4��60   
�������
���   �$��20��6h   $��0 0 0 1q�6t   �� 5'      $��5��6   $��NEW PASSWORD��6%   
�������69   G� 5(      -   5        $ textBoxNewPassword��5(      $��6��66   
�������
���   �$��20��6n   $��0 0 0 1q�6z   �� 5)      $��7��6   $��CONFIRM PASSWORD��6%   
�������6=   G� 5*      -   5        $ textBoxConfirm��5*      $��8��62   
�������
���   �$��20��6j   $��0 0 0 20q�6v   �� 5+      -   5         ��Name$ changePassButton��5+      $��20��5,      $��9��5-      $��0 30 0 0q�6   ���	#FF2672FB
�������$E��?/Belajar_CRUD_WPF_Dionisius;component/Assets/#Bahnschrift Light)�6q   $��10(�6�   ��6G   Z� .��6�   CHANGE PASSWORD6�   5.      5/      50      