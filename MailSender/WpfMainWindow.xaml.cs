using System;
using System.Net;
using System.Windows;
using System.Net.Mail;
using MailSenderLib;

namespace MailSender
{
	partial class WpfMainWindow : Window
    {
		public WpfMainWindow() => InitializeComponent();

	    void Button_Click(object sender, RoutedEventArgs e)
	    {
		    try
		    {
			    var mailSender = new EmailSender();
                mailSender.SendMail(UserNameTextBox.Text, PasswordEdit.Password);
		    }
		    catch (Exception exception)
		    {
			    var dialog = new MessageSendCompletedDlg(exception.Message);
                dialog.ShowDialog();
		    }
	    }
	} 
}

