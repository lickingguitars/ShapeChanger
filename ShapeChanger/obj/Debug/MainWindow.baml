   M S B A M L   `   `   `  ����G  CShapeChanger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ShapeChangerShapeChanger  5   	   A%clr-namespace:ShapeChanger.ViewModelsShapeChanger.ViewModels  5   	   7 clr-namespace:ShapeChanger.ViewsShapeChanger.Views  5   	       ShapeChanger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ShapeChanger     5   	   <
viewmodels%clr-namespace:ShapeChanger.ViewModels     5   	   2views clr-namespace:ShapeChanger.Views     5   	     � Title$  
MainWindow��5
   	   $	��500��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � 	Resources 5       �� DataType-   'ShapeChanger.ViewModels.CircleViewModel#   ShapeChanger.Views.CircleView � DataContext-   'ShapeChanger.ViewModels.SquareViewModel#   ShapeChanger.Views.SquareView/   )ShapeChanger.ViewModels.TriangleViewModel%   ShapeChanger.Views.TriangleView��%V  (��       5   3   *, +)(�� W     5   3   *, +)(�� �     5   +   *, +)�� 5   
   CircleViewTemplate��"  63   .R�5         6   �� 5      �� 5   
   SquareViewTemplate��"  63   .R�5         6   �� 5      �� 5   
   TriangleViewTemplate��"  5   +   .R�5         6!   �� 5      5      .��5      �  � ColumnDefinitions 5   
   �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%       � RowDefinitions 5'   
   �� 5(      �� 5)      �� 5*      �� 5+      .+�5/   
   ]� -   5         ]�Name$ WindowPanel��5/      
�������$��0��6@   $��0��6P   $��4��6]   $��2��6n   .+�50      �� $��0��6   $��0��6*   .+�52      �� $��Shape��6   $��20(�6(   $
��Bold"�66   $��0,2,0,0q�6H   �� 53      -   5         ��Name$ CircleButon��53      $��Circle��6K   $��18(�6\   $��0,2,0,0q�6j   �� 54      -   5        $ SquareButton��54      $��Square��6M   $��18(�6^   $��0,2,0,0q�6l   �� 55      -   5        $ TriangleButton��55      $��Triangle��6P   $��18(�6c   $��0,2,0,0q�6q   �� 58      $��Colour��6   $��20(�6)   $
��Bold"�67   $��0,5,0,0q�6I   �� 59      -   5        $ 
BlueButton��59      $
��Blue��6B   $��18(�6Q   $��0,2,0,0q�6_   �� 5:      -   5        $ GreenButton��5:      $��Green��6D   $��18(�6T   $��0,2,0,0q�6b   �� 5;      -   5        $ 	RedButton��5;      $	��Red��6@   $��18(�6N   $��0,2,0,0q�6\   �� 5<      -   5        $ YellowButton��5<      $��Yellow��6F   $��18(�6W   $��0,2,0,0q�6e   �� 5?      $
��Size��6   $��20(�6'   $
��Bold"�65   $��0,5,0,0q�6G   �� 5@      -	   5        	 ��Name$	 
SizeSlider��5@      
 � LargeChange$
 25Q�5A       � Maximum$	 500Q�5B       � Value 6'   �� *Size+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�]� 5D      .+�5E      �� $��0��6   $
��Left=�6(   �� 5F      $��75,0,0,0q�65   $��Center=�6G   ��6   �� *Size+6G   �� 5G      $	��500��6   $��Right=�6*   5H      �� 5K      $��Opacity��6   $��20(�6*   $
��Bold"�68   $��0,5,0,0q�6J   �� 5L      -
   5        $	 OpacitySlider��5L      $

 0.25Q�5M      $ 1Q�5N       5O      �� *	Opacity+$ TwoWay=�$ PropertyChanged=�]� 5Q      .+�5R      �� $��0��6   $
��Left=�6(   �� 5S      $��75,0,0,0q�68   $��Center=�6J   ��6   �� *	Opacity+6J   �� 5T      $	��1.0��6   $��Right=�6*   5U      5V      5W      �� 5Z   
   -   5         ��Name$ ViewPane��5Z      $��2��5\      $��4��5]      $��0��5^      $��4��5_      ��5[      �� 5_      5a      5b      