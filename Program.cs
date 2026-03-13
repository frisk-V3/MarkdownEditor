using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace MyMarkdownEditor;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        var form = new Form
        {
            Text = "TS Markdown Editor",
            Width = 1200,
            Height = 800,
            WindowState = FormWindowState.Normal
        };

        var webView = new WebView2 { Dock = DockStyle.Fill };
        form.Controls.Add(webView);

        form.Load += async (s, e) =>
        {
            await webView.EnsureCoreWebView2Async();
            // EXEと同じ場所にある wwwroot/index.html を読み込む
            string indexPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot", "index.html");
            webView.CoreWebView2.Navigate(new Uri(indexPath).AbsoluteUri);
        };

        Application.Run(form);
    }
}
