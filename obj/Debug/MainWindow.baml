   M S B A M L   `   `   `  ����J  FEssentialMacros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EssentialMacrosEssentialMacros  5   	        EssentialMacros.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   )localclr-namespace:EssentialMacros  5   	   -   5        $��Regular"�5	   	   $0��*/EssentialMacros;component/Fonts/#Code Pro)�6*     � Topmost  . $��13(�6�   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�6�      TextRenderingMode$
 Auto=�6�    � Title$ Essential Macros��6�   $	��360��6  $	��650��6   � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�63  $��0q�6I  
������ .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   � -   5        ���	#FF26262b$��36��5   A   $	��Top=�6M   .+�5      �� $
��16,0q�6    �� Orientation$ 
Horizontal=�6'   $
��Left=�6@   .+�5      �� -   5         ��Name$ 	TitleText��5   $   $�� ��6   $��0q�67   
�������$��18(�6U   $��Center=�6c   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� $��36��6      MaterialDesignFlatButton#��[  6%   ���	#FFD4D4D4+  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 0��6n   .��6�   ГЛАВНАЯ5      �� 5      -   5        
 ��Name$
 BindsButton��5      $��36��6H   #��[  6T   ���	#FFD4D4D4$	 0��6�   .��6�   
БИНДЫ5      �� 5      -   5        $
 SettingsButton��5      $��36��6N   #��[  6Z   ���	#FFD4D4D4$	 0��6�   .��6�   НАСТРОЙКИ5      �� 5      -   5        $��7,0,5,0q�5      $��26��6A   $��26��6L   $��0q�6X   
������ ��6}   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
��������  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�6A   $	��0,7q�6W   $��24��6d   $��24��6p   5      �� 5       -   5        $��0,0,5,0q�5       $��26��6=   $��26��6H   $��0q�6T   ���	#FFd32f2f��6w   Z� .��5!        
�������$ Close=�6A   $��26��6N   $��26��6Z   5"      5#      5$      � 5&   
    � RowDefinitions 5'      �� 5(      $��* �6    �� 5)      $��* �6    5+      � 5,   
   $��0��6   ���	#FF28282e J� Opacity$
 0.92Q�63   $��0,36,0,0q�6B   � 5-   
   $��0��6   $��0,36,0,0q�6   .+�5/       � -   5        $��	MainFrame��5/        � NavigationUIVisibility$ Hidden=�6%   51      � 53   
   .+�58      � -	   5        $��loopProgress��58       � IsIndeterminate .  $��Bottom=�6F   
��� ���
������ $��0q�6�   59      5:      5;      