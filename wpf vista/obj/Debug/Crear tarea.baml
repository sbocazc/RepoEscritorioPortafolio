   M S B A M L   `   `   `  ����D  @wpf vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:wpf_vista	wpf_vista  5   	       wpf_vista.Crear_tarea   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:wpf_vista     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   
�������$��Medium"�5   	   $��14(�5   	     � Title$  Crear_tarea��5   	   $��415.34��6   $��581.064��6-   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   � $
��Left=�6   $	��384��6*   $	��Top=�67   $	��571��6O   $��2,0,0,0q�6[   .+�5      �� $��Nombre tarea:��6   $
��Left=�6,   $��	10,90,0,0q�6G   $	��Top=�6Z   �� 5      -   5         ��Name$ txt_nombre_tarea��5      $
��Left=�60   $��23��6K   $��
136,90,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5      $��Descripcion de la tarea:��6   $
��Left=�67   $��
10,121,0,0q�6R   $	��Top=�6f   $	��159��6~   �� 5      -   5        $ txt_descripcion��5      $
��Left=�6/   $��23��6J   $��169,121,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5      $��Fecha inicio:��6   $
��Left=�6,   $��
10,170,0,0q�6G   $	��Top=�6[   $��89��6s   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ date_ini��5      $
��Left=�6+   $��136,170,0,0q�6F   $	��Top=�6[   $	��103��6s   �� 5      $��Fecha termino:��6   $
��Left=�6-   $��
10,236,0,0q�6H   $	��Top=�6\   $	��102��6t     5      -   5        $ date_ter��5      $
��Left=�6+   $��136,236,0,0q�6F   $	��Top=�6[   $	��103��6s   �� 5      -   5         ��Name$ btn_crear_tarea��5      $
��Left=�6.   $��362,170,0,0q�6I   $	��Top=�6^   $	��108��6v   $��69��6�   ��5      �� 5      .��5      �� -   5         ��Name$ 	img_tarea��5      $
��Left=�6+   $��42��6F   $	��Top=�6R   $��40��6j   $��/fotos/tarea.png��6u   5      �� 5      -   5        $ 
btn_volver��5      $
��Left=�6)   $��445,323,0,0q�6D   $	��Top=�6Y   $	��126��6q   $��61��6�   ��5       �� 5!      .��5#      �� -   5        $ 
img_volver��5#      $
��Left=�6,   $��42��6G   $	��Top=�6S   $��40��6k   $��/fotos/atras.png��6v   5$      �� 5%      -	   5         ��Name$ 	cboPriori��5%      $
��Left=�6*   $��
156,64,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5&      $��Nombre responsable:��6   $
��Left=�62   $��
10,295,0,0q�6M   $	��Top=�6a   $	��149��6y   �� 5'      -
   5        $ cboResponsable��5'       �� SelectedIndex$ 0��6/   $
��Left=�6A   $��169,294,0,0q�6\   $	��Top=�6q   $	��120��6�   ��5(      -  'System.Windows.Data.CompositeCollection  5)      �� 5*      .��6'   Seleccione funcionario5,      5-      5/      �� 50      $��0,0,497,316q�6   $.��(67eacb4a-76bb-4bf7-9512-da44b221230b.jpg��6)   $
��Fill=�6[   �� 51      $��
Prioridad:��6   $
��Left=�6)   $��	81,58,0,0q�6D   $	��Top=�6W   52      54      55      