   M S B A M L   `   `   `  ����  OutfitPicker    OutfitPicker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��700��6)   .��5      � .+�5   
   �� B@Outfit Picker: Stores outfits during occassions you want to wear6V   �� 5   
   $	��200��6   $
��Left=�6!   $��0,32,0,6q�6<   .+�5	      �� .��6   	Occassion6   �� 5
      -   5         ��Name$ AddOccassion��5
      $	��160��6,   $��	0,0, 30,0q�68   6s   �� 5      .��6   
OutfitName6    �� 5      -   5        $ AddOutfitName��5      $	��160��6U   $��	0,0, 30,0q�6a   6v   �� 5      .��6   Note6   �� 5      -   5        $ AddNote��5      $	��160��6I   $��	0,0, 30,0q�6U   6j   �� 5      .��6   OutfitImagePath6%   �� 5      -   5        $ AddOutfitImagePath��5      $��OutfitImagePath��62   $	��160��6I   $��	0,0, 30,0q�6U   6j   �� 5      $��60��6   $	��160��6    $��0,0,20,0q�6,   6@   �� 5      -   5        $��20��5      $	��Add��6!   $��
10,0,135,0q�6/   6C   �� 5      $��60��6   $��22��6    $
��Edit��6,   $��10,-20, 0 ,0q�6;   6S   �� 5      $��60��6   $��22��6    $��Delete��6,   $��130,-20,0, 0q�6=   6U   5      �� 5   
   $	��400��6   $��Right=�6!   $��0,32,0,6q�6=   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
outfitList��5         AutoGenerateColumns .  6I   5      5      5      