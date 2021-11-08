using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(entry11.Text);
        b = Convert.ToInt32(entry13.Text);
        c = a + b;
        entry15.Text = c.ToString();
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(entry11.Text);
        b = Convert.ToInt32(entry13.Text);
        c = a - b;
        entry15.Text = c.ToString();
    }

    protected void OnButton9Clicked(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(entry11.Text);
        b = Convert.ToInt32(entry13.Text);
        c = a * b;
        entry15.Text = c.ToString();
    }

    protected void OnButton11Clicked(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(entry11.Text);
        b = Convert.ToInt32(entry13.Text);
        if(a == 0 || b == 0)
        {
            entry15.Text = "Invalid Input!";
        } else
        {

            c = a / b;
            entry15.Text = c.ToString();
        }
    }

    protected void OnButton13Clicked(object sender, EventArgs e)
    {
        entry11.Text = entry13.Text = entry15.Text = "";
    }
}
