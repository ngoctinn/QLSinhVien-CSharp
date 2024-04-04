using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QLSinhVien_CSharp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSinhVien_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnSinhVien;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Sinh Viên";
            }
        }

        private void btnSinhVien_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnLopHoc_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnLopHoc;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Lớp học";
            }
        }

        private void btnLopHoc_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnMonHoc_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnMonHoc;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Môn học";
            }
        }

        private void btnMonHoc_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnLopTinChi_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnLopTinChi;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Lớp tín chỉ";
            }
        }

        private void btnLopTinChi_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnDiem_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDiem;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Điểm";
            }
        }

        private void btnDiem_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void btnHocPhi_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDiem;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Học Phí";
            }
        }

        private void btnHocPhi_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnDangKi_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDangKi;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Đăng kí";
            }
        }

        private void btnDangKi_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        
        // End: MenuLeft PopupButton //

        // Start: Button Close | Restore | Minimize 
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        // End: Button Close | Restore | Minimize

        private void btnSinhVien_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/SinhVienPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnLopHoc_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/LopHocPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnMonHoc_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/MonHocPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnLopTinChi_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/LopTinChiPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnDiem_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/DiemPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnHocPhi_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/HocPhiPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnDangKi_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/DangKiPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
