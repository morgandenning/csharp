   M S B A M L   `   `   `  ����  SimpleRPGGame!    SimpleRPGGame.NewGameWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $��NewGameWindowXAML��5   7   .��5      � .+�5
   
   �� -   5        $��HumanPortraitBorder��5
      
������ $��1q�6F   $	��128��6Z   $	��128��6f   $
��Left=�6s   $	��Top=�6�   $��	10,10,0,0q�6�   ._�5      �� -   5        $��HumanPortrait��5      $E��?/Engine;component/Assets/Images/Icons/Portraits/human_m_128.png��6)   $	��128��6r   $	��128��6~   $��Center=�6�   $��Center=�6�   
  � Tag$  Human��6�   5      �� 5   
   -   5        $��DwarfPortraitBorder��5      
������ $��1q�6F   $	��128��6Z   $	��128��6f   $
��Left=�6s   $	��Top=�6�   $��
270,10,0,0q�6�   ._�5      �� -   5        $��DwarfPortrait��5      $E��?/Engine;component/Assets/Images/Icons/Portraits/dwarf_m_128.png��6)   $	��128��6r   $	��128��6~   $��Center=�6�   $��Center=�6�   $  Dwarf��6�   5      �� 5   
   -   5        $��GnomePortraitBorder��5      
������ $��1q�6F   $	��128��6Z   $	��128��6f   $
��Left=�6s   $	��Top=�6�   $��
400,10,0,0q�6�   ._�5      �� -   5        $��GnomePortrait��5      $E��?/Engine;component/Assets/Images/Icons/Portraits/gnome_m_128.png��6)   $	��128��6r   $	��128��6~   $��Center=�6�   $��Center=�6�   $  Gnome��6�   5      �� 5   
   -   5        $��ElfPortraitBorder��5      
������ $��1q�6D   $	��128��6X   $	��128��6d   $
��Left=�6q   $	��Top=�6�   $��
140,10,0,0q�6�   ._�5      �� -	   5        $��ElfPortrait��5      $C��=/Engine;component/Assets/Images/Icons/Portraits/elf_m_128.png��6'   $	��128��6n   $	��128��6z   $��Center=�6�   $��Center=�6�   $	  Elf��6�   5      �� 5   
   -
   5        $��WarriorPortraitBorder��5      
������ $��1q�6H   $	��128��6\   $	��128��6h   $
��Left=�6u   $	��Top=�6�   $��
10,160,0,0q�6�   ._�5      �� -   5        $��WarriorPortrait��5      $7��1/Engine;component/Assets/Images/Icons/128/axe.png��6+   $	��128��6f   $	��128��6r   $��Center=�6   $��Center=�6�   $  Warrior��6�   5      �� 5   
   -   5        $��RangerPortraitBorder��5      
������ $��1q�6G   $	��128��6[   $	��128��6g   $
��Left=�6t   $	��Top=�6�   $��140,160,0,0q�6�   ._�5      �� -   5        $��RangerPortrait��5      $7��1/Engine;component/Assets/Images/Icons/128/bow.png��6*   $	��128��6e   $	��128��6q   $��Center=�6~   $��Center=�6�   $  Ranger��6�   5       �� 5"   
   -   5        $��RoguePortraitBorder��5"      
������ $��1q�6F   $	��128��6Z   $	��128��6f   $
��Left=�6s   $	��Top=�6�   $��270,160,0,0q�6�   ._�5#      �� -   5        $��RoguePortrait��5#      $:��4/Engine;component/Assets/Images/Icons/128/dagger.png��6)   $	��128��6g   $	��128��6s   $��Center=�6�   $��Center=�6�   $  Rogue��6�   5$      �� 5&   
   -   5        $��WizardPortraitBorder��5&      
������ $��1q�6G   $	��128��6[   $	��128��6g   $
��Left=�6t   $	��Top=�6�   $��400,160,0,0q�6�   ._�5'      �� -   5        $��WizardPortrait��5'      $8��2/Engine;component/Assets/Images/Icons/128/wand.png��6*   $	��128��6f   $	��128��6r   $��Center=�6   $��Center=�6�   $  Wizard��6�   5(      �� 5*   
   -   5        $��
START GAME��5*      $
��Left=�6&   $��
10,431,0,0q�6A   $	��Top=�6U   $��75��6m   6x   �� 5,   
   $��	Hero Name��6   $
��Left=�6$   $��
10,338,0,0q�6?   $	��Top=�6S   �� 5-   
   -   5        $��NewGameHeroName��5-      $
��Left=�6)   $��23��6D   $��115,338,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5/   
   $
��Race��6   $
��Left=�6   $��
10,370,0,0q�6:   $	��Top=�6N   �� 50   
   -   5        $��SelectedRace��50      $
��Left=�6D   $��115,370,0,0q�6_   $	��Top=�6t   ��6$   �� *NewGameRace+6t   �� 52   
   $��Class��6   $
��Left=�6    $��
10,400,0,0q�6;   $	��Top=�6O   �� 53   
   -   5        $��SelectedClass��53      $
��Left=�6F   $��115,400,0,0q�6a   $	��Top=�6v   ��6%   �� *NewGameClass+6v   55      56      