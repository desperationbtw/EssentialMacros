   M S B A M L   `   `   `  ����J  FEssentialMacros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EssentialMacros.PagesEssentialMacros.Pages  5      1clr-namespace:EssentialMacrosEssentialMacros  5      (    "EssentialMacros.Pages.SettingsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      /Pages#clr-namespace:EssentialMacros.Pages  5      )Localclr-namespace:EssentialMacros  5      -   5          N� Title$  Login��5       N� ShowsNavigationUI .  .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   .+�5      �� $��0��6    � 	Resources 5      #   EssentialMacros.SliderControl �� 
TargetType �� Property �� Value��%Y   '        �� 5      "  6   .�5      ��  � ��$ 	12,5,12,0q�63   5      5      .+�5      ��  �� TextAlignment$ Center=�6   $��ОСНОВНОЕ��63   
�������$��5,5,0,0q�6V   $��18(�6g   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$
 White��6+      
BlurRadius$ 10Q�69      ShadowDepth$ 0Q�6I      Opacity$	 0.2Q�6Y   5        5      -   5          Name$
 Sens��5   &   #   EssentialMacros.SliderControl   ValueChanged$ Sens_ValueChanged��64      
SliderText$&  ЧУВСТВИТЕЛЬНОСТЬ��6U   
   Min$	 0.1Q�6s   
   Max$ 2Q�6}      Step$	 0.1Q�6�     5      -   5        $	 Fov��5   &   $ Fov_ValueChanged��63   $! УГОЛ ОБЗОРА (FOV)��6S   $ 70Q�6r   $ 90Q�6{   $	 0.1Q�6�   � 5       .+�5!      � $��Center=�6   .+�5"      �� $��ПРИЦЕЛ��6$   
�������$��5,5,0,0q�6E   $��18(�6V   	 5#        5$   "   $
 White��63   $ 10Q�6A   $ 0Q�6Q   $	 0.2Q�6a   5&      5'      � 5(      $��Right=�6   .+�5)      d� -   5         d�Name$ 	Crosshair��5)   '    d� 	IsChecked$ FalseY�6:   $��0 5 10 0q�6L    (  $MaterialDesignSwitchDarkToggleButton#��[  6^   5*      5+        5,      -   5        $ CrosshairSize��5,   &   $ Fov_ValueChanged��6=   $ РАЗМЕР��6]   $	 0.2Q�6q   $ 1Q�6{   $	 0.1Q�6�     5-      -   5        $ CrosshairOpacity��5-   &   $ Fov_ValueChanged��6@   $ ПРОЗРАЧНОСТЬ��6`   $	 300Q�6z   $	 600Q�6�   $ 1Q�6�     5.      -   5        $ 
CrosshairY��5.   &   $ Fov_ValueChanged��6:   $3 -ГОРИЗОНТАЛЬНОЕ СМЕЩЕНИЕ��6Z   $
 0.01Q�6   $ 1Q�6�   $
 0.01Q�6�   � 5/      .+�50      � $��Center=�6   .+�51      �� $��ОВЕРЛЕЙ��6$   
�������$��5,5,0,0q�6F   $��18(�6W   	 52        53   "   $
 White��63   $ 10Q�6A   $ 0Q�6Q   $	 0.2Q�6a   55      56      � 57      $��Right=�6   .+�58      �� $��0 5 10 0q�6%   $ 
Horizontal=�67   .+�59      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ OverlayInfo��59   6   
��� ����  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 
InfoCircle=�6_   $��0 0 5 0q�6�   $��16��6�   $��16��6�   $��Center=�6�   d� 5:      -	   5        $ Overlay��5:   +   $ FalseY�6<   #��[  6N   5;      5<      5=      � 5>      .+�5?      � $��Center=�6   .+�5@      �� $!��ФИКС ИНВЕНТАРЯ��6$   
�������$��5,5,0,0q�6M   $��18(�6^   	 5A        5B   "   $
 White��63   $ 10Q�6A   $ 0Q�6Q   $	 0.2Q�6a   5D      5E      � 5F      $��Right=�6   .+�5G      �� $��0 5 10 0q�6%   $ 
Horizontal=�67   .+�5H        -
   5        $ InventoryInfo��5H   6   
��� ���$ 
InfoCircle=�6a   $��0 0 5 0q�6�   $��16��6�   $��16��6�   $��Center=�6�   d� 5I      -   5        $ 	Inventory��5I   +   $ FalseY�6>   #��[  6P   5J      5K      5L      !   EssentialMacros.BindControl  5M      -   5          Name$ InventiryBind��5M   $   $	��626��6;      BindText$ ИНВЕНТАРЬ��6G   5N      � 5O       K� ZIndex$
 1000��6   $y�	Collapsed=�6'   ��5P      �� 5Q       �� Color$ Black��6&    �� Opacity$ .5Q�64   5S      � 5T      -   5         �Name$ InfoOverlay��5T      ���	#80000000$	��200��6?   $	��100��6K   $y�Hidden=�6X   .+�5U      �� -   5         ��Name$ InfoOverlayTitle��5U      $��TITLE��62   $��Center=�6B   �� 5V      -   5         ��Name$ InfoOverlayText��5V      $	��200��65   
�������$
��Wrap=�6T   $��Center=�6h   $��Center=�6�   $ Center=�6�   $��SAMPLE��6�   5W      5X      5Y      5Z      