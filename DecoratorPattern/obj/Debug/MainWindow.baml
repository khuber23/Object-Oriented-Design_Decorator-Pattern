   M S B A M L   `   `   `  ����K  GDecoratorPattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DecoratorPatternDecoratorPattern  5   	   !    DecoratorPattern.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DecoratorPattern     5   	     � Title$  
MainWindow��5   	   $��245.6��6   $��399.2��6+   .��5	      � .+�5
   
   �� $	��Top=�6   $
��Left=�6-   $��5q�6H    �� Orientation$ 
Horizontal=�6S   .+�5      �� $	��Top=�6   $
��Left=�61   .+�5      �� $��Select Coffee Type:��6   68   	� 5      -   5         	�Name$ 
houseBlend��5      $��House Blend��62    	� 	GroupName$ Coffee��6H   $
��Left=�6[   $��5q�6v   $	��Top=�6�   	� 5      -   5        $ 	darkRoast��5      $��
Dark Roast��61   $ Coffee��6F   $
��Left=�6Y   $��5q�6t   $	��Top=�6   	� 5      -   5        $ espresso��5      $��Espresso��60   $ Coffee��6C   $
��Left=�6V   $��5q�6q   $	��Top=�6|   	� 5      -   5        $ decaf��5      $��Decaf��6-   $ Coffee��6=   $
��Left=�6P   $��5q�6k   $	��Top=�6v   �� 5      -   5         ��Name$ orderButton��5      $��Order��6.   $��20��6>   $��
0, 5, 0, 0q�6J   $��80��6^   6�   5      �� 5      $��20, 0, 0, 0q�6   .+�5      �� $��Select Condiments:��6   67   �� 5      -   5         ��Name$ milkCondiment��5      $
��Milk��62   $��5q�6A   �� 5      -   5        $ mochaCondiment��5      $��Mocha��63   $��5q�6C   �� 5      -   5        $ soyCondiment��5      $	��Soy��61   $��5q�6?   6M   �� 5      -	   5        $ whipCondiment��5      $
��Whip��62   $��5q�6A   6N   5      5      �� 5   
   $��Bottom=�6   $
��Left=�60   $ 
Horizontal=�6K   .+�5      �� $��Bottom=�6   $
��Left=�64   .+�5      �� $��Order Description: ��6   68   �� 5      $��Price:��6   6+   5       �� 5!      $	��250��6   .+�5"      �� -
   5         ��Name$ descriptionLabel��5"      $�� ��62   6?   �� 5#      -   5        $ 
priceLabel��5#      $�� ��6,   69   5$      5%      5(      5)      