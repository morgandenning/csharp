   M S B A M L   `   `   `  ����   SimpleRPGGame    SimpleRPGGame.GameWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��GameWindowXAML��.��� .+��� $
��Left=�$��86,1,0,0q�$	��Top=�$y�Visible=����� *heroObject.sName+�� $
��Left=�$��	86,21,0,0q�$	��Top=�$y�Visible=����� *heroObject.heroClass.Title+��   �� ContentStringFormat$  	Level {0}��$
��Left=�$��	86,41,0,0q�$	��Top=�$y�Visible=����� *heroObject.iLevel+�� $  Gold {0}��$
��Left=�$��	86,61,0,0q�$	��Top=�$y�Visible=����� *heroObject.iGold+�� -   $��HeroPortrait��$
��Left=�$��64��$	��Top=�$��64��$��	10,10,0,0q����� *heroObject.RacePortraitImage+� -   $��HeroHealthProgress��$
��Left=�$��10��$��	10,92,0,0q�$	��Top=�$	��100��
���  �� � Value$	 100Q��� -   $��HeroHealthNumeric��$��50/50��$
��Left=�$��12��$��
120,90,0,0q�$	��Top=�$��10(�
������ $��91��$��0q�� -   $��HeroStaminaProgress��$
��Left=�$��10��$��
10,104,0,0q�$	��Top=�$	��100�� � Cursor$  ��$	 100Q����� *#!heroObject.heroClass.StaminaColor+�� -   $��HeroStaminaNumeric��$��50/50��$
��Left=�$��12��$��120,102,0,0q�$	��Top=�$��10(�
������ $��91��$��0q�� -   $��HeroExpProgress��$
��Left=�$��10��$��
10,116,0,0q�$	��Top=�$	��100��
��� ����� -   $��HeroExpNumeric��$��0/100��$
��Left=�$��12��$��120,113,0,0q�$	��Top=�$��10(�
������ $��91��$��0q��� $
��Left=�$��
285,10,0,0q�$	��Top=����� *!heroObject.CurrentLocation.Name+�� $
��Left=�$��30��$��
285,41,0,0q�$	��Top=�$	��205�� �� 
IsReadOnly . . �/� .T�J� .*�.*��� ��� *(&heroObject.CurrentLocation.Description+�� -	   $��FeedbackMessages��$
��Left=�$	��180��$��
285,76,0,0q�$	��Top=�$	��205�� . . �/� .T�J� .*�.*��� ��� *heroObject.FeedbackMessages+�� $
��Left=�$	��334��$��
10,156,0,0q�$	��Top=�$	��236��.@��� $��	Inventory��.��� ���	#FFE5E5E5.+��� �� $��Quests��.��� ���	#FFE5E5E5.+��� �� -
   $��	MoveNorth��$��North��$
��Left=�$��348,273,0,0q�$	��Top=�$��75��y��� *heroObject.MoveNorthVisible+�� -   $��	MoveSouth��$��South��$
��Left=�$��348,333,0,0q�$	��Top=�$��75���� -   $��MoveEast��$
��East��$
��Left=�$��408,303,0,0q�$	��Top=�$��75���� -   $��MoveWest��$
��West��$
��Left=�$��288,303,0,0q�$	��Top=�$��75���� $
��Left=�$��261,380,0,0q�$	��Top=�$	��120��.@��� $��{Item Placeholder}��$
��Left=�$	��118���� $
��Left=�$��261,417,0,0q�$	��Top=�$	��120��.@��� $��{Item Placeholder}��$
��Left=�$	��118���� $
��Left=�$��261,454,0,0q�$	��Top=�$	��120��.@��� $��{Item Placeholder}��$
��Left=�$	��118��