   M S B A M L   `   `   `  ����E  ARequireVPN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RequireVPN
RequireVPN  5   	       RequireVPN.SetupWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:RequireVPN     5   	     � Title$  Configuration��5   	   $��401.226��6   $��545.705��60    � 
ResizeMode$ NoResize=�6@    � WindowStartupLocation$ CenterOwner=�6V    � Icon$ rvpnTray.ico��6z   .��5	      � $��0,0,2,8q�6   .+�5
   
   �� -   5         ��Name$ btn_refreshProcesses��5
      $��Refresh list��6/   $
��Left=�6F   $��396,35,-217,0q�6a   $	��Top=�6x   $	��113��6�   $��20��6�   6�   �� 5   
   -   5        $ btn_bindProcesses��5      $��Bind to process��6,   $
��Left=�6F   $��396,60,-217,0q�6a   $	��Top=�6x   $	��113��6�    J� RenderTransformOrigin$ 0.807,3&�6�   $��20��6�   6�   �� 5   
   -   5        $ btn_refreshAdapters��5      $��Refresh list��6.   $
��Left=�6E   $��398,178,0,0q�6`   $	��Top=�6u   $	��113��6�   $��20��6�   6�   �� 5   
   -   5         ��Name$ lst_processes��5      $
��Left=�6)   $	��100��6D   $��10,35,-86,0q�6Q   $	��Top=�6f   $	��368��6~   �� 5   
   -   5         ��Name$ lbl_processes��5      $��
Processes:��6'   $
��Left=�6<   $��
10,4,-86,0q�6W   $	��Top=�6k   $	��368��6�   $��26��6�   �� 5   
   -   5        $ lst_adapters��5      $
��Left=�6(   $	��100��6C   $��
10,178,0,0q�6P   $	��Top=�6d   $	��368��6|   �� 5   
   -   5        $ lbl_adapters��5      $��Network adapters:��6&   $
��Left=�6B   $��
10,147,0,0q�6]   $	��Top=�6q   $	��368��6�   $��26��6�   �� 5   
   -   5        $ btn_bindAdapter��5      $��Bind to adapter��6*   $
��Left=�6D   $��398,203,0,0q�6_   $	��Top=�6t   $	��113��6�   $ 0.807,3&�6�   $��20��6�   6�   �� 5   
   -	   5        $ btn_Save��5      $��Save configuration��6#   $
��Left=�6@   $��398,329,0,0q�6[   $	��Top=�6p   $	��113��6�   $��20��6�   6�   5      5      