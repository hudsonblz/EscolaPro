   M S B A M L   `   `   `  ����D  @EscolaPro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EscolaPro	EscolaPro  5          EscolaPro.CriarChamada   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:EscolaPro     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��Stretch=�5	      $��Stretch=�5
         MaterialDesignPaper#���   5        MaterialDesignFont#���  5      $��Regular"�5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      .��5      �� $��	5,10,5,10q�5   	   $��Stretch=�5   	   $��Stretch=�5   	   .+�5   
   �� $��0,0,0,5q�5      $��Center=�5      $��32(�5      $��Normal"�5      Fazer Chamada5      �� 5   
   $
��20,5q�6     PrimaryHueMidBrush#���  6"   � 5   
   $��	20,0,20,2q�5      $��Center=�5       $��Stretch=�5!        � ColumnDefinitions  5"      �� 5#      $
��auto �6#   �� 5$      $
��auto �6#   �� 5%      $
��auto �6#   �� 5&      $
��auto �6#   �� 5'      $
��auto �6#   .+�5)      '  !MaterialDesignThemes.Wpf.PackIcon  $��0��5*      $��0��5+      $��20��5,      $��20��5-      $��5,5,5,10q�5.      $��Bottom=�5/        MaterialDesignTextBoxBorder#��[ 50      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ AccountCircle=�51      �� 52      -   5        $��cbxBuscaProfessor��53      $��0��54      $��1��55      $	��180��56      $��
10,10,10,5q�57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Professor��58         
IsFloating . $��1��5:      �� 5;      $��0��5<      $��4��5=      $��
10,10,10,0q�5>      $��Center=�5?      $��4��5@      ��5A      �� 5B       �� Orientation$ 
Horizontal=�6!   .+�5C        $��24��5D      $��24��5E      $ Magnify=�5F      �� 5G      $��5,0,0,0q�6$   $��Center=�65   	Pesquisar6[   5H      5K      �� 5L      -   5        $��cbxBuscaTurma��5M      $��0��5N      $��2��5O      $	��180��5P      $��
10,10,10,5q�5Q      $ Turma��5R       . $��2��5T      5V      �� 5W   
   � 5X   
   $��	20,5,20,2q�5Y      $��Center=�5Z      $��Stretch=�5[        5\      �� 5]      $
��auto �6#   �� 5^      $
��auto �6#   �� 5_      $	��200 �6#   �� 5`      $��20 �6#   �� 5a      $
��auto �6#   �� 5b      $
��auto �6#    � RowDefinitions 5d      �� 5e      $��10 �6    �� 5f      $
��auto �6    �� 5g      $
��auto �6    �� 5h      $
��auto �6    �� 5i      $
��auto �6    �� 5j      $
��auto �6    .+�5l      � $��1��5m      $��4��5n      $��0��5o      $��3��5p      $��5,32,5,5q�5q      $��Stretch=�5r      $��Stretch=�5s        5t      �� 5u      $
��auto �6'   �� 5v      $
��auto �6'   �� 5w      $	��200 �6'   �� 5x      $��20 �6'    5z      �� 5{      $��10 �6$   �� 5|      $
��auto �6$   �� 5}      $
��auto �6$   �� 5~      $
��auto �6$   .+�5�        $��1��5�      $��0��5�      $��20��5�      $��20��5�      $��5q�5�      $��Bottom=�5�      $ CalendarToday=�5�      ��5�      �� *BorderBrush+ �� ElementName$ dtpData��5�      �� 5�      $��1��5�      $��1��5�      $��5q�5�      $��Bottom=�5�      Data:5�      (  "System.Windows.Controls.DatePicker  5�      -   5        $��dtpData��5�      $��1��5�      $��2��5�      $��	15,10,5,5q�5�      $��Stretch=�5�      $��Bottom=�5�      $ Data da Aula��5�       .  � Language$ pt-br�5�      �� 5�      $��2��5�      $��1��5�      $��5q�5�      $��Bottom=�5�      
Professor:5�        5�      $��2��5�      $��0��5�      $��20��5�      $��20��5�      $��5q�5�      $��Bottom=�5�      $ AccountCircle=�5�      ��5�      �� *BorderBrush+$ cbxProfessor��5�      �� 5�      -   5        $��cbxProfessor��5�      $��2��5�      $��2��5�      $��	15,10,5,5q�5�      $��Stretch=�5�      $��Bottom=�5�      $ 	Professor��5�       . $��18��5�        5�      $��3��5�      $��0��5�      $��20��5�      $��20��5�      $��5q�5�      $��Bottom=�5�      #���  5�      $ CheckCircleOutline=�5�      �� 5�      $��3��5�      $��1��5�      $��5q�5�      $��Bottom=�5�      Presença do professor:5�      �� 5�      -   5        $��ckbProfessorPresente��5�      $��3��5�      $��2��5�      $��	15,25,5,5q�5�      $��Bottom=�5�      $��Presente��5�       d� 	IsChecked$
 TrueY�5�      5�      �� 5�      $��1��5�      $��4��5�      $��4��5�      $��5q�5�      .+�5�      �� $
��10,5q�5�      $��Center=�5�      $��Bottom=�5�      	Chamada5�      &   System.Windows.Controls.DataGrid  5�      -   5        $��ltbListaAlunos��5�      $	��250��5�      	   AutoGenerateColumns	 .  
   CanUserAddRows
 .   J� IsManipulationEnabled .     Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Aluno��61      
IsReadOnly .    CellTemplate 5�      �� 5�   "   .R�5�   &   #  MaterialDesignThemes.Wpf.Chip  $
��10,0q�5�   )   ��5�   )   �� *Nome+   Icon 5�   )   �� *Tag+5�   #   5�        5�      $ 	Presença��61    5�      �� 5�   "   .R�5�   &   d� $��20��5�   )   $��20��5�   )   $��2q�5�   )   ���#D50000 $  MaterialDesignActionToggleButton#��[ 5�   )   $��8��5�   )    � ToolTip$ 	Presença��5�   )    5�   )   �� *
Presente+.��5�   *     $��20��5�   -   $��20��5�   -   $ Close=�5�   -   1	  +MaterialDesignThemes.Wpf.ToggleButtonAssist 	  	OnContent 5�   *     5   .   $��20��5  1   $��20��5  1   $��Center=�5  1   $��Center=�5  1   ���#4CAF50$ Check=�5  1   5  '   5	  #   5     5     5     �� 5     $��0��5     $��5��5     $��3��5     $��1��5     $��0,15,0,0q�5     #���  5     $��1q�5      J� Opacity$	 0.7Q�5     �� 5     -   5         ��Name$ 
BtnAlterar��5     $��5��5     $��4��5     $��0,25,5,0q�5     $��Right=�5     $��Center=�5     $��Lançar��5     $��15(�5        MaterialDesignFlatButton#��[ 5!     $��20��5"     �� 5#     -   5        $ BtnCancelar��5$     $��5��5%     $��5��5&     $��5,25,5,0q�5'     $��Center=�5(     $��Cancelar��5)     $��15(�5*     #��[ 5+     $��21��5,     5.     5/     50     