   M S B A M L   `   `   `  ����S  ODigitalLibrary.Interface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DigitalLibrary.InterfaceDigitalLibrary.Interface  5   	   W0clr-namespace:DigitalLibrary.Interface.VievModel"DigitalLibrary.Interface.VievModel  5   	   )    #DigitalLibrary.Interface.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:DigitalLibrary.Interface     5   	   F	viewmodel0clr-namespace:DigitalLibrary.Interface.VievModel     5   	     � Title$  Digital Library��5	   	   $	��800��6"   $	��500��61   .��5
      �  � DataContext 5   
   9   3DigitalLibrary.Interface.VievModel.LibraryViewModel  5      .+�5   
   �� -   5         ��Name$ 
tabControl��5      $��Stretch=�6)   $��Stretch=�6G   .@�5      �� $��Список книг��6   $
��Auto��6,   .��5      � ���	#FFE5E5E5$
��Left=�60    J� InputBindings 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ myGrd��5      $��Stretch=�6.   $
��Auto��6J      AutoGenerateColumns .     
IsReadOnly . $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   ��6s   �� *libraryEntities+ �� SelectedItem 6�   �� 	 �� Path$	 selectedItem� 5      d� 5      
 d� MouseAction$
 LeftDoubleClicke�5   !    �� Command 5   !   �� $	 loadEntityByID� �� CommandParameter 5   !   ��  �� ElementName$ myGrd��$	 SelectedItem�   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61      Header$ Название��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� $
	 Name�6n     5#      $ * 61   $ 
Автор��6;    6J   �� $	 Author�6l     5$      $ * 61   $ Код��6;    6H   �� $
	 Code�6h     5%      $ * 61   $ Страниц��6;    6L   �� $	 Pages�6m     5&      $ * 61   $ Год��6;    6H   �� $
	 Year�6h     5'      $ * 61   $ Язык��6;    6I   �� $	 Language�6m     5(      $ * 61   $ Тип��6;    6H   �� $
	 Type�6h     5)      $ * 61   $ Категория��6;    6N   �� $	 Category�6r   5-      5/      50      �� 51      $��TabItem��6   $��Right=�6'   .��53      � ���	#FFE5E5E56   54      55      58      59      