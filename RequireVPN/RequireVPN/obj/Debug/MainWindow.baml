   M S B A M L   `   `   `  ����E  ARequireVPN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RequireVPN
RequireVPN  5   	       RequireVPN.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:RequireVPN     5   	   -   5          � Title$  
RequireVPN��5   	   $	��350��6   $��435.89��6)    � 
ResizeMode$ CanMinimize=�6[    � Icon$ rvpnTray.ico��6t   .��5	      � $��0,0,38,0q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ lbl_process��5      $��Process:��6%   $
��Left=�68   $��	10,58,0,0q�6S   $	��Top=�6f   $��26��6~   $��53��6�   �� 5   
   -   5        $ lbl_adapter��5      $��Network adapter:��6%   $
��Left=�6@   $��
10,114,0,0q�6[   $	��Top=�6o   $��26��6�   $	��102��6�   �� 5   
   -   5         ��Name$ txt_process��5      $
��Left=�6'   $��23��6B   $��
163,61,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $
��none��6v   $	��Top=�6�   $	��215��6�   �� 5   
   -   5        $ txt_adapter��5      $
��Left=�6'   $��23��6B   $��163,117,0,0q�6N   $
 Wrap=�6c   $
��none��6w   $	��Top=�6�   $	��215��6�   �� 5   
   -   5        $ 
lbl_header��5      $��Current configuration:��6$   $
��Left=�6E   $��	10,10,0,0q�6`   $	��Top=�6s   $��16(�6�   $
��Bold"�6�   $��31��6�   $	��178��6�   �� 5   
   -   5         ��Name$ btn_configure��5      $��	Configure��6(   $
��Left=�6<   $��257,228,0,0q�6W   $	��Top=�6l   $	��121��6�   6�   �� 5   
   -   5        $ 	btn_start��5      $��Start watcher��6$   $
��Left=�6<   $��257,265,0,0q�6W   $	��Top=�6l   $	��121��6�   6�   �� 5   
   -	   5        $ 
lbl_status��5      $��Status:��6$   $
��Left=�66   $��
10,164,0,0q�6Q   $	��Top=�6e   $��26��6}   $	��102��6�   �� 5   
   -
   5        $ 
txt_status��5      $
��Left=�6&   $��23��6A   $��163,167,0,0q�6M   $
 Wrap=�6b   $��-��6v   $	��Top=�6   $	��215��6�   5      5      