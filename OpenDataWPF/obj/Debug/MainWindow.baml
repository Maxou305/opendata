   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5   	   F BOpenDataWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OpenDataWPFOpenDataWPF 5   	      OpenDataWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   +localclr-namespace:OpenDataWPF     5   	     � Title$  
MainWindow��5
   	   $	��800��6   $
��1000��6)   $	��700��69   $	��800��6I   $
��Auto��6Y    � SizeToContent$ Width=�6f   ��. $
��Auto=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   '   !Microsoft.Maps.MapControl.WPF.Map  $��1��6g   $��0 0 20 0q�6w   $��1��6�   $
��auto��6�   $	��800��6�   $	��500��6�   $
��auto��6�   +   %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT   NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AlQWTZHVbFC09-Jhsa6QI-znVI2tiWCIBLC4cHcWbYN6nwc8Cdo769FFE4S7ejNA 6�      Center 6   �� *	MapCenter+ �� Mode$ TwoWay=�   	ZoomLevel 6:   �� *	ZoomLevel+$ TwoWay=�   Children. 5      3   -Microsoft.Maps.MapControl.WPF.MapItemsControl  ��6    �� *
Pushpins+��5      �� 5      .R�5      +   %Microsoft.Maps.MapControl.WPF.Pushpin  
����  �	   Location	 6$   �� 69   5      5      5      �� 5    
   
 �� Orientation$
 
Horizontal=�6   $
��20pxq�6.   $��0��6<   $��2��6I   .+�5!      �� .��6   Recherche :6!   �� 5"      .��6   	Longitude6   �� 5#      $��150px��6P   $��Center=�6^   ��6   �� *Lon+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5$      .��6   
Latitude6   �� 5%      $��150px��6P   $��Center=�6^   ��6   �� *Lat+$ PropertyChanged=�6�   �� 5&      .��6   Rayon6   �� 5'      $��150px��6S   $��Center=�6a   ��6   �� *Radius+$ PropertyChanged=�6�   �� 5(      $��100px��6   $��20px 0q�6#   $��
Rechercher��6U   ��63   �� *SearchCommand+6l   5)      �� 5+   
   $	��500��6>   $��1��6N   $	��300��6[   $
��auto��6k   $	��810��6y   $
��auto��6�   $��20px 0 20px 20pxq�6�   ��. $
��Auto=�6�   ��6   �� *DataTransportlines+ �� View 5,      �� 5-       �� AllowsColumnReorder . .P�5.      �� $��ID��6I    �� Width$
 auto��6U    �� DisplayMemberBinding 6%   �� *Id+6U   �� 5/      $	��Nom��6K   $
 auto��6X    6%   �� *Name+6g   �� 50      $��	Longitude��6J   $
 auto��6]    6%   �� *Lon+6]   �� 51      $��Latitude��6J   $
 auto��6\    6%   �� *Lat+6\   �� 52      $��Lignes��6L   $
 auto��6\    6%   �� *Lines+6\   53      55      56      57      