   M S B A M L   `   `   `  ����D  @EscolaPro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EscolaPro	EscolaPro  5          EscolaPro.BuscarTurma   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:EscolaPro     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	      $��Stretch=�5
      $��Stretch=�5         MaterialDesignPaper#���   5        MaterialDesignFont#���  5      $��Regular"�5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      .��5      �� $��10,10,10,20q�5   	   $��Stretch=�5   	   $��Stretch=�5   	   .+�5   
   �� $��0,0,0,5q�5      $��Center=�5      $��32(�5      $��Normal"�5      Buscar Turma5      �� 5   
   $
��20,5q�6     PrimaryHueMidBrush#���  6"   � 5    
   $��	20,0,20,2q�5!      $��Center=�5"      $��Stretch=�5#        � ColumnDefinitions  5$      �� 5%      $
��auto �6#   �� 5&      $
��auto �6#   �� 5'      $
��auto �6#   �� 5(      $
��auto �6#   �� 5)      $
��auto �6#    � RowDefinitions 5+      �� 5,      �� 5-      .+�5/      '  !MaterialDesignThemes.Wpf.PackIcon  $��0��50      $��0��51      $��20��52      $��20��53      $��5,5,5,10q�54      $��Bottom=�55        MaterialDesignTextBoxBorder#��[ 56      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�57      �� 58      -   5        $��cbxBuscaNivel��59      $��0��5:      $��1��5;      $	��180��5<      $��
10,10,10,5q�5=      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nível Da Turma��5>         
IsFloating . $��1��5@      �� 5B      $��2��5C      $��5,10,5,5q�5D      $��Center=�5E      $��Center=�5F       �� Orientation$ 
Horizontal=�5G      .+�5H      �� -   5        $��ckbTurmasCurso��5I       d� 	IsChecked$
 TrueY�5K      $��2��5L      �� 5M      $	��120��5N      $��5,15,0,0q�5O      $
��Wrap=�5P      Apenas Turmas em Curso5R      5S      �� 5T      -   5        $��btnPesquisar��5U      $��0��5V      $��4��5W      $��
10,10,10,0q�5X      $��Center=�5Y      $��7��5Z      ��5[      �� 5\      $ 
Horizontal=�6!   .+�5]        $��24��5^      $��24��5_      $ Magnify=�5`      �� 5a      $��Center=�6$   	Pesquisar6K   5b      5d      �� 5f      -   5        $��cbxSemestreAno��5g      $��0��5h      $��3��5i      $	��180��5j      $��
10,10,10,5q�5k      $ Semestre/Ano��5l       . $��4��5n      �� 5o      $y�	Collapsed=�5p      $��1��5q      $��0��5r      $��5��5s      $��Stretch=�5t      .+�5u      �� � 5w      $��0,5,0,5q�5x      $��Center=�5y      $��Stretch=�5z        5{      �� 5|      $
��auto �6+   �� 5}      $
��auto �6+   �� 5~      $
��auto �6+   �� 5      $
��auto �6+    5�      �� 5�      .+�5�      �� -   5        $��cbxBuscaTurma��5�      $��0��5�      $��2��5�      $��2��5�      $	��300��5�      $��
10,10,10,5q�5�      $ Turma��5�       . $��3��5�        5�      $��0��5�      $��0��5�      $��20��5�      $��20��5�      $��5,5,5,10q�5�      $��Bottom=�5�      #��[ 5�      $ AccountMultiple=�5�      �� 5�      $��0��5�      $��1��5�      $��10q�5�      $��Bottom=�5�      Selecione a Turma:5�      5�      5�      5�      �� 5�   
   5�      5�      