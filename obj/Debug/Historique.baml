   M S B A M L   `   `   `  ����C  ?JeuPendu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JeuPenduJeuPendu  5   	       JeuPendu.Historique   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:JeuPendu     5   	   -   5          � Title$  
Historique��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�6L   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFCDEDFD��6    � Offset$ 0Q�61   � 5      $ 	#FFFFEC82��6   $
 0.37Q�61   � 5      $ 	#FFFFCFD2��6   $ 1Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgHistorique��5      $
��Left=�6)   $	��295��6D   $��	69,60,0,0q�6Q   $	��Top=�6d   $	��684��6|      AutoGenerateColumns .  ���	#FF688CAF��6�   �� ��6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 Mot��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *mot+  5      $	 Pointage��6%   
 67   �� *score+  5      $	 Erreurs��6%   
 66   �� *	erreurs+  5      $
	 Date��6%   
 63   �� *date+  5      $	 Temps��6%   
 64   �� *temps+  5      $	 Temps��6%   
 64   �� *reussi+5      �� 5   
   -   5         ��Name$ bnt_accueil��5      $��Accueil��6&   $
��Left=�68   $��447,383,0,0q�6S   $	��Top=�6h   $	��118��6�   6�   �� 5   
   -   5        $ bnt_quit��5      $��Quitter��6#   $
��Left=�65   $��612,383,0,0q�6P   $	��Top=�6e   $	��118��6}   6�   5      5      