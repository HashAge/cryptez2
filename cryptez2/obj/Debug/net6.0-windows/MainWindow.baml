   M S B A M L   `   `   `  ����C  ?cryptez2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:cryptez2cryptez2  5   	       cryptez2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:cryptez2     5   	     � Title$  Cryptez2��5   	   $	��321��6   $	��478��6'   .��5	      � .+�5   
   �� -   5         ��Name$	 btn��5      $��Generate��6   $
��Left=�61   $��	4,115,0,0q�6L   $	��Top=�6_   �� 5   
   -   5         ��Name$ 
stackPanel��5      $��0,0,355,205q�6)   .+�5      	� -   5         	�Name$ ces_btn��5       	� 	GroupName$ cipherGroup��6+   $��Cesaer cipher��6C   	� 5      -   5        $ vig_btn��5      $ cipherGroup��6+   $��Vigenere cipher��6C   	� 5      -   5        $ atb_btn��5      $ cipherGroup��6+   $��Atbash cipher��6C   	� 5      -   5        $ bas_btn��5      $ cipherGroup��6+   $��BASE32 cipher��6C   	� 5      -   5        $ afn_btn��5      $ cipherGroup��6+   $��Affine cipher��6C   5      �� 5   
   -   5         ��Name$ pln_tbx��5      $
��Left=�6$   $��
74,115,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $��enter plain text��6g   $	��Top=�6   $	��170��6�    J� RenderTransformOrigin$ 
0.28,0.203&�6�   $y�Visible=�6�   �� 5   
   -	   5        $��argument_list��5      $��4,142,336,102q�6(   $��0q�6?   $��0q�6S   $
��Auto��6_   .��5      � $��16��6   .+�5      �� -
   5        $ 	afn_tbx_a��5      $
 Wrap=�6-   $��11��6A   $��45��6K   $y�Hidden=�6V   �� 5      -   5        $ 	afn_tbx_b��5      $
 Wrap=�6-   $��7��6A   $��44��6J   $y�Hidden=�6U   �� 5      -   5        $ vig_tbx��5      $
 Wrap=�6+   $��lemon��6?   $	��141��6L   $y�Hidden=�6X   �� 5      -   5        $ ces_tbx��5      $
 Wrap=�6+   $��5��6?   $��40��6H   $y�Hidden=�6S   5      5      5      5      